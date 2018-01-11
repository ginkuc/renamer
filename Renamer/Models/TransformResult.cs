namespace Renamer.Models
{
    public class TransformResult
    {
        public string OldPath { get; set; }
        public string NewPath { get; set; }

        public TransformResult(string oldPath, string newPath)
        {
            OldPath = oldPath;
            NewPath = newPath;
        }
    }
}