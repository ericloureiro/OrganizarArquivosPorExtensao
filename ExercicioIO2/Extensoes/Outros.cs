using System;
using System.IO;

namespace SoftwareParaOrganizacao.Extensoes
{
    public class Outros
    {
        public static string CaminhoFinal { get; set; }
        public static String DiretorioFinal(string targetPath)
        {
            return CaminhoFinal = Path.Combine($"{targetPath}\\Outros\\");
        }
    }
}