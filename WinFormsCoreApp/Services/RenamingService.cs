using Renamer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Renamer.Services
{
    public abstract class RenamingService : IRenamingService
    {
        protected readonly string SourceDirectory;
        protected readonly string Pattern;
        protected readonly string Transform;

        protected readonly List<TransformResult> Results = new List<TransformResult>();

        protected RenamingService(string sourceDirectory, string pattern, string transform)
        {
            SourceDirectory = Directory.Exists(sourceDirectory) ? sourceDirectory : throw new InvalidOperationException("Directory doesn't exist.");
            Pattern = pattern.ToLower();
            Transform = transform;
        }

        public List<TransformResult> Rename()
        {
            var files = Directory.GetFiles(SourceDirectory);

            files.Where(f => FileMatchPredicate(Path.GetFileName(f)))
                .ToList()
                .ForEach(RenameFile);

            return Results;
        }

        protected abstract bool FileMatchPredicate(string fileName);

        protected abstract string ReplaceFileName(string oldFullPath);

        private void RenameFile(string oldFullPath)
        {
            var replacedFileName = ReplaceFileName(oldFullPath);

            var newFullPath = Path.Combine(Path.GetDirectoryName(oldFullPath) ??
                             throw new InvalidOperationException(nameof(Path.GetDirectoryName)), replacedFileName);

            File.Move(oldFullPath, newFullPath);

            Results.Add(new TransformResult(oldFullPath, newFullPath));
        }
    }
}