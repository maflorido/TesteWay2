using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace TesteWaveMarcello.Domain
{
    private string EnderecoIp = ConfigurationSettings.AppSettings.Keys["ip"];
    public class ServicoConexao
    {
        public static void Conectar()
        {

        }
    }
}
