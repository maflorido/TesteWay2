using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using TesteWave.Domain;

namespace TesteWaveMarcello
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurarDependencias();

            ConexaoServico.Conectar();
            Console.ReadKey();
        }

        private static void ConfigurarDependencias()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<ServicoFuncoes>().AsSelf();
        }
    }
}
