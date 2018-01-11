using System;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Windows.Forms;
using Renamer.Factories;

namespace Renamer
{
    public partial class Form1 : Form
    {
        private static string DialogTitle => "Renamer";
        private static string ErrorDialogTitle => "Error";
        private static string NoMatchesMessage => "Found no matches to rename.";

        public Form1()
        {
            InitializeComponent();

            sourceTextBox.KeyDown += SourceTextBoxOnKeyDown;

            sourceTextBox.MouseDoubleClick += TextBoxOnMouseDoubleClick;
            patternTextBox.MouseDoubleClick += TextBoxOnMouseDoubleClick;
            transformTextBox.MouseDoubleClick += TextBoxOnMouseDoubleClick;

            startButton.Click += StartButtonOnClick;

            var sourceTextBoxObservable = Observable.FromEventPattern<EventHandler, EventArgs>(h => sourceTextBox.TextChanged += h, h => sourceTextBox.TextChanged -= h)
                .Select(GetText);
            var patternTextBoxObservable = Observable.FromEventPattern<EventHandler, EventArgs>(h => patternTextBox.TextChanged += h, h => patternTextBox.TextChanged -= h)
                .Select(GetText);

            Observable.CombineLatest(sourceTextBoxObservable, patternTextBoxObservable)
                .Subscribe(allTexts => startButton.Enabled = allTexts.All(t => !string.IsNullOrEmpty(t)));
        }

        private static string GetText(EventPattern<EventArgs> eventPattern)
        {
            return ((TextBox) eventPattern.Sender).Text;
        }

        private static void TextBoxOnMouseDoubleClick(object sender, MouseEventArgs mouseEventArgs)
        {
            if (sender is TextBox textbox)
            {
                textbox.SelectAll();
            }
        }

        private void SourceTextBoxOnKeyDown(object sender, KeyEventArgs keyEventArgs)
        {
            if (keyEventArgs.KeyData != Keys.Enter) return;

            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                sourceTextBox.Text = folderBrowserDialog.SelectedPath;
                patternTextBox.Focus();
            }
        }

        private void StartButtonOnClick(object sender, EventArgs eventArgs)
        {
            try
            {
                var renamingService = RenameServiceFactory.GetRenamingService(sourceTextBox.Text, patternTextBox.Text, transformTextBox.Text);
                var results = renamingService.Rename();

                if (results.Any())
                {
                    var message = results.Aggregate("", (o, n) => o + $"Changed {n.OldPath} to {n.NewPath}.\n");
                    MessageBox.Show(message, DialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(NoMatchesMessage, DialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, ErrorDialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
