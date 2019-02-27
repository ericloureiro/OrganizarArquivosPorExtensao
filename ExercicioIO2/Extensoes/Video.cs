using System;
using System.IO;

namespace SoftwareParaOrganizacao.Extensoes
{
    public class Video
    {
        public static string CaminhoFinal { get; set; }
        public static String DiretorioFinal(string targetPath)
        {
            return CaminhoFinal = Path.Combine($"{targetPath}\\Outros\\");
        }
        public static String[] Extensoes = new String[] { ".mp4", ".avi" };
    }
}
