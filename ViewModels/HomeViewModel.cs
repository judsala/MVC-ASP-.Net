using LanchesMVC.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace LanchesMVC.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}
