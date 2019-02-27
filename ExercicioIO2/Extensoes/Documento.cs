using System;
using System.IO;

namespace SoftwareParaOrganizacao.Extensoes
{
    public class Documento
    {
        public static string CaminhoFinal { get; set; }
        public static String DiretorioFinal(string targetPath)
        {
            return CaminhoFinal = Path.Combine($"{targetPath}\\Documento\\");
        }
        public static String[] Extensoes = new String[] { ".doc", ".docx", ".pdf", ".xls", ".xlsx", ".txt" };
    }
}
