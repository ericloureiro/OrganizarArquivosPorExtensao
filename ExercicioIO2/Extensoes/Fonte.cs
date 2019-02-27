using System;
using System.IO;

namespace SoftwareParaOrganizacao.Extensoes
{
    public class Fonte
    {
        public static string CaminhoFinal { get; set; }
        public static String DiretorioFinal(string targetPath)
        {
            return CaminhoFinal = Path.Combine($"{targetPath}\\Fonte\\");
        }
        public static String[] Extensoes = new String[] { ".cs", ".js" };
    }
}
