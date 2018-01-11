using Renamer.Services;

namespace Renamer.Factories
{
    public static class RenameServiceFactory
    {
        public static IRenamingService GetRenamingService(string sourceDirectory, string pattern, string transform)
        {
            IRenamingService renamingService;

            if (pattern.Contains(SpatialService.KeySymbol))
            {
                renamingService = new SpatialService(sourceDirectory, pattern, transform);
            }
            else
            {
                renamingService = new LiteralService(sourceDirectory, pattern, transform);
            }

            return renamingService;
        }
    }
}