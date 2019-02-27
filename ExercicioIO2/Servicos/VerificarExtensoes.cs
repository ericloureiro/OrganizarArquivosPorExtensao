using System;
using System.IO;
using System.Linq;

namespace SoftwareParaOrganizacao.Servicos
{
    class VerificarExtensoes
    {
        public static Boolean VerificarExtensaoArquivo(String[] extensoes, string diretorio)
        {
            return extensoes.Any(e => e == Path.GetExtension(diretorio));
        }
    }
}
