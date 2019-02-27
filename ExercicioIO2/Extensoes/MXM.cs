using System;
using System.IO;

namespace SoftwareParaOrganizacao.Extensoes
{
    public class MXM
    {
        public static string CaminhoFinal { get; set; }
        public static String DiretorioFinal(string targetPath)
        {
            return CaminhoFinal = Path.Combine($"{targetPath}\\MXM\\");
        }
        public static String[] Extensoes = new String[] { ".mxm" };
    }
}