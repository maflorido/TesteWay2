using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteWave.Domain.Enums
{
    internal enum EnumFuncoes
    {
        [Description("0x01")]
        LerNumeroSerie = 1,
        [Description("0x02")]
        LerStatus = 2,
        [Description("0x03")]
        DefinirIndiceRegistro = 3,
        [Description("0x04")]
        LerDataHora = 4,
        [Description("0x05")]
        LerValorEnergia = 5
    }
}
