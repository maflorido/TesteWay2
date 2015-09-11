using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteWaveMarcello.Infra.Extensions
{
    public static class EnumExtension
    {
        public static string GetDescription(this Enum enumeration)
        {
            Type enumType = enumeration.GetType();

            string desc = Enum.GetName(enumType, enumeration);
            var field = enumType.GetField(enumeration.ToString());

            if (field != null)
            {
                DescriptionAttribute[] descAtts = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (descAtts.Length != 0)
                    desc = descAtts[0].Description;
            }

            return desc;
        }
    }
}
