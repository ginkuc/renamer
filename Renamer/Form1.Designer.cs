using Renamer.Properties;

namespace Renamer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.patternTextBox = new System.Windows.Forms.TextBox();
            this.transformTextBox = new System.Windows.Forms.TextBox();
            this.patternLabel = new System.Windows.Forms.Label();
            this.transformLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.titleLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(31, 39);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(345, 20);
            this.sourceTextBox.TabIndex = 10;
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(28, 9);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(44, 13);
            this.sourceLabel.TabIndex = 0;
            this.sourceLabel.Text = "Source:";
            // 
            // patternTextBox
            // 
            this.patternTextBox.Location = new System.Drawing.Point(31, 98);
            this.patternTextBox.Name = "patternTextBox";
            this.patternTextBox.Size = new System.Drawing.Size(135, 20);
            this.patternTextBox.TabIndex = 20;
            // 
            // transformTextBox
            // 
            this.transformTextBox.Location = new System.Drawing.Point(226, 98);
            this.transformTextBox.Name = "transformTextBox";
            this.transformTextBox.Size = new System.Drawing.Size(150, 20);
            this.transformTextBox.TabIndex = 30;
            // 
            // patternLabel
            // 
            this.patternLabel.AutoSize = true;
            this.patternLabel.Location = new System.Drawing.Point(28, 71);
            this.patternLabel.Name = "patternLabel";
            this.patternLabel.Size = new System.Drawing.Size(44, 13);
            this.patternLabel.TabIndex = 0;
            this.patternLabel.Text = "Pattern:";
            // 
            // transformLabel
            // 
            this.transformLabel.AutoSize = true;
            this.transformLabel.Location = new System.Drawing.Point(223, 71);
            this.transformLabel.Name = "transformLabel";
            this.transformLabel.Size = new System.Drawing.Size(57, 13);
            this.transformLabel.TabIndex = 0;
            this.transformLabel.Text = "Transform:";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 129);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(214, 45);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "File renamer";
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(258, 148);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(117, 23);
            this.startButton.TabIndex = 40;
            this.startButton.Text = "Go";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 180);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.transformLabel);
            this.Controls.Add(this.patternLabel);
            this.Controls.Add(this.transformTextBox);
            this.Controls.Add(this.patternTextBox);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.sourceTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = Resources.Icon;
            this.Name = "Form1";
            this.Text = "File Renamer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.TextBox patternTextBox;
        private System.Windows.Forms.TextBox transformTextBox;
        private System.Windows.Forms.Label patternLabel;
        private System.Windows.Forms.Label transformLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startButton;
    }
}

