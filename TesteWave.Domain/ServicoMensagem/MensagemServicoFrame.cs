using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using TesteWave.Domain.Enums;
using TesteWaveMarcello.Infra.Extensions;
using System.Linq;
using System.Collections;

namespace TesteWave.Domain.ServicoMensagem
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
    internal class MensagemServicoFrame
    {
        private string dados = string.Empty;

        public byte Header { get; } = 0x7D;

        public byte ComprimentoMensagem
        {
            get
            {
                return (byte)Encoding.ASCII.GetByteCount(DadosString);
            }
        }

        public EnumFuncoes CodigoFuncao { get; set; }

        public byte[] Dados { get; set; }

        public string DadosString
        {
            get
            {
                if (string.IsNullOrEmpty(this.dados))
                    dados = Encoding.ASCII.GetString(this.Dados);

                return this.dados;
            }
        }

        public string CheckSum
        {
            get
            {
                Dados = new byte[] { 0x41, 0x42, 0x43, 0x44, 0x45, 0x46, 0x47 };

                string teste = "ABCDEFG";
                var bla = Encoding.ASCII.GetBytes(teste);

                return Encoding.ASCII.GetString(Dados);
            }
        }

    }
}
