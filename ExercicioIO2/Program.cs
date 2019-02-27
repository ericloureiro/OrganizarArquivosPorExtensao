using System;
using System.Collections.Generic;
using System.IO;
using SoftwareParaOrganizacao.Extensoes;
using SoftwareParaOrganizacao.Servicos;

namespace SoftwareParaOrganizacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o DIRETÓRIO fonte: ");
            string sourcePath = Console.ReadLine();

            if (!Directory.Exists(sourcePath))
            {
                Console.WriteLine("Diretório não existe! Finalizando programa.");
                Environment.Exit(0);
            }

            Console.WriteLine("Insira o DIRETÓRIO final: ");
            string targetPath = Console.ReadLine();

            CriarDiretorio.CriaDiretorio(targetPath);
            {
                List<string> diretorios = new List<String>()
            {
                    Documento.DiretorioFinal(targetPath),
                    Imagem.DiretorioFinal(targetPath),
                    Video.DiretorioFinal(targetPath),
                    Musica.DiretorioFinal(targetPath),
                    Fonte.DiretorioFinal(targetPath),
                    MXM.DiretorioFinal(targetPath),
                    Outros.DiretorioFinal(targetPath),
            };
                diretorios.ForEach(d => CriarDiretorio.CriaDiretorio(d));

                var arquivos = Directory.EnumerateFiles(sourcePath, "*.*", SearchOption.AllDirectories);

                foreach (string s in arquivos)
                {
                    if (VerificarExtensoes.VerificarExtensaoArquivo(Documento.Extensoes, s))
                    {
                        CopiarColar.CopiarColarArquivo(s, Documento.CaminhoFinal);
                    }
                    else if (VerificarExtensoes.VerificarExtensaoArquivo(Imagem.Extensoes, s))
                    {
                        CopiarColar.CopiarColarArquivo(s, Imagem.CaminhoFinal);
                    }
                    else if (VerificarExtensoes.VerificarExtensaoArquivo(Video.Extensoes, s))
                    {
                        CopiarColar.CopiarColarArquivo(s, Video.CaminhoFinal);
                    }
                    else if (VerificarExtensoes.VerificarExtensaoArquivo(Musica.Extensoes, s))
                    {
                        CopiarColar.CopiarColarArquivo(s, Musica.CaminhoFinal);
                    }
                    else if (VerificarExtensoes.VerificarExtensaoArquivo(Fonte.Extensoes, s))
                    {
                        CopiarColar.CopiarColarArquivo(s, Fonte.CaminhoFinal);
                    }
                    else if (VerificarExtensoes.VerificarExtensaoArquivo(MXM.Extensoes, s))
                    {
                        CopiarColar.CopiarColarArquivo(s, MXM.CaminhoFinal);
                    }
                    else
                    {
                        CopiarColar.CopiarColarArquivo(s, Outros.CaminhoFinal);
                    }
                }
            }
        }
    }
}
