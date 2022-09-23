using NourNumberSystem.Moodle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NourNumberSystem
{

    public static class NumberSystemExtensions
    {
        /// <summary>
        /// Guard to validate ser input 
        /// </summary>
        /// <param name="allowedCharacter">
        /// The Allowed Character set as a string value
        /// </param>
        /// <param name="numberBase">
        /// This parameter helps identifying which number system input violate the rule
        /// </param>
        /// <param name="source">
        /// the string to validate
        /// </param>
        /// <exception cref="System.InvalidOperationException">
        /// Thrown when <paramref name="source" >
        /// has at least one character that does not exist in the characters of
        /// </paramref>
        /// </exception>
        public static void Guard(this string source,string allowedCharacter,NumberBase numberBase)
        {
            foreach (var ch in source)
            {
                if (!allowedCharacter.Contains(ch))
                    throw new InvalidOperationException($"{source} is invalid {numberBase} format");

            }
        }

        /// <summary>
        /// Extension Method to convert <typeparamref name="T"/><paramref name="source"/> to <paramref name="toBase"/> 
        /// </summary> 
        /// <param name="source">
        /// Number system Instance to convert
        /// </param>
        /// <param name="toBase">
        /// enum value that represent the number system
        /// </param> 
        /// <returns>A string value as a result of conversion</returns>
        public static string To<T>(this T source,NumberBase toBase) where T : Base
        {
            NumberBase frombase;
            switch (source)
            {
                case BinarySystem:frombase=NumberBase.BINARY; break;
                case OctalSystem:frombase=NumberBase.Octal; break;
                case DecimalSystem:frombase=NumberBase.Decimal; break;
                case Hexadecimal:frombase= NumberBase.Hexadecimal; break;
                default:
                    frombase=NumberBase.Decimal;break;
            }
            return Convert.ToString(Convert.ToInt32(source.Value, (int)frombase), (int)toBase);
        }
    }
}
