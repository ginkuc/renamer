using Renamer.Models;
using System.Collections.Generic;

namespace Renamer.Services
{
    public interface IRenamingService
    {
        List<TransformResult> Rename();
    }
}