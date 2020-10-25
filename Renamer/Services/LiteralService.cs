using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Renamer.Services
{
    public class LiteralService : RenamingService
    {
        public LiteralService(string sourceDirectory, string pattern, string transform) : base(sourceDirectory, pattern, transform)
        {
        }

        protected override bool FileMatchPredicate(string fileName)
        {
            return fileName.ToLower().Contains(Pattern);
        }

        protected override string ReplaceFileName(string oldFullPath)
        {
            var filename = Path.GetFileName(oldFullPath);

            return Regex.Replace(filename ?? throw new InvalidOperationException(nameof(Path.GetFileName)), Pattern, Transform, RegexOptions.IgnoreCase);
        }
    }
}