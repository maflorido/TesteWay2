using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace TesteWave.Domain
{    
    public class ConexaoServico
    {
        private static string IpAddress = ConfigurationSettings.AppSettings["ip"];
        private static ServicoFuncoes servicoFuncoesNumeroSerie;

        public ConexaoServico(ServicoFuncoes servicoFuncoes)
        {
            
        }

        public static void Conectar()
        {
            ConexaoServico.servicoFuncoesNumeroSerie = new FuncaoNumeroSerie();
            //try
            //{
            //    TcpClient client = new TcpClient();
            //    client.Connect(IpAddress, 4000);
            //}
            //catch(Exception ex)
            //{
            //    throw new Exception("Erro ao conectar no servidor." + ex.Message);
            //}

            servicoFuncoesNumeroSerie.Executar();
        }
    }
}
