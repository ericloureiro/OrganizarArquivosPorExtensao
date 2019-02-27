using System;
using System.IO;

namespace SoftwareParaOrganizacao.Servicos
{
    class CriarDiretorio
    {
        public static void CriaDiretorio(String diretorio)
        {
            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
            }
        }
    }
}
