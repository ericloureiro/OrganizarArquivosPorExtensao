using System;
using System.IO;

namespace SoftwareParaOrganizacao.Extensoes
{
    public class Musica
    {
        public static string CaminhoFinal { get; set; }
        public static String DiretorioFinal(string targetPath)
        {
            return CaminhoFinal = Path.Combine($"{targetPath}\\Musica\\");
        }
        public static String[] Extensoes = new String[] { ".mp3", ".wav" };
    }
}
