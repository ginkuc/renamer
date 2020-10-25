using System;
using System.IO;

namespace Renamer.Services
{
    public class SpatialService : RenamingService
    {
        public const string KeySymbol = "#";

        public SpatialService(string sourceDirectory, string pattern, string transform) : base(sourceDirectory, pattern, transform)
        {
        }

        protected override bool FileMatchPredicate(string fileName)
        {
            return true;
        }

        protected override string ReplaceFileName(string oldFullPath)
        {
            var filename = Path.GetFileName(oldFullPath);

            if(string.IsNullOrEmpty(filename)) throw new InvalidOperationException(nameof(Path.GetFileName));

            var positionsToRemove = Pattern.Length;

            var replacedFileName = $"{Transform}{filename.Substring(positionsToRemove)}";

            return replacedFileName;
        }
    }
}