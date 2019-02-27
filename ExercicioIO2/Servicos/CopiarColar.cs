using System.IO;

namespace SoftwareParaOrganizacao.Servicos
{
    class CopiarColar
    {
        public static void CopiarColarArquivo(string arquivoOrigem, string diretorioDestino)
        {
            string nomeArquivo = Path.GetFileName(arquivoOrigem);
            string diretorioFinal = Path.Combine(diretorioDestino + nomeArquivo);
            File.Copy(arquivoOrigem, diretorioFinal);
        }
    }
}
