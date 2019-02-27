using System;
using System.IO;

namespace SoftwareParaOrganizacao.Extensoes
{
    public class Imagem
    {
        public static string CaminhoFinal { get; set; }
        public static String DiretorioFinal(string targetPath)
        {
            return CaminhoFinal = Path.Combine($"{targetPath}\\Imagem\\");
        }
        public static String[] Extensoes = new String[] { ".jpg", ".png" };
    }
}
