namespace NourNumberSystem.Moodle
{
    /// <summary>Class that represent the hexadecimal number system</summary> 

    public class Hexadecimal : Base
    {
        public Hexadecimal(string value)
        {
            /// <summary>
            /// Initializes a new instance of the Metigator.NumberSystem.Models.HexadecimalSystem class to the value indicated
            ///     by a specified string parameter
            /// </summary> 
            ///         /// <param name="value">
            /// string that hold the value of the Hexadecimal system Instance
            /// </param> 
            Value = value;
            value.Guard("0123456789ABCDEF", NumberBase.Hexadecimal);
        }
    }

}

