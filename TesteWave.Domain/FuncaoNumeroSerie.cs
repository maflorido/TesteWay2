using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteWave.Domain.Enums;
using TesteWave.Domain.ServicoMensagem;

namespace TesteWave.Domain
{
    internal class FuncaoNumeroSerie : ServicoFuncoes
    {
        public override void Executar()
        {
            MensagemServicoFrame frame = new MensagemServicoFrame();

            
            frame.CodigoFuncao = EnumFuncoes.LerNumeroSerie;
            frame.Dados = null;
            var teste = frame.CheckSum;
            var aa = frame.ComprimentoMensagem;
        }
    }
}
