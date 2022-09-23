namespace NourNumberSystem.Moodle
{
    /// <summary>Class that represent the decimal number system</summary> 

    public class DecimalSystem : Base
    {

        public DecimalSystem(string value)
        {
            /// <summary>
            /// Initializes a new instance of the Metigator.NumberSystem.Models.DecimalSystem class to the value indicated
            ///     by a specified string parameter
            /// </summary> 
            /// <param name="value">
            /// string that hold the value of the Decimal system Instance
            /// </param>  
            Value = value;
            value.Guard("0123456789", NumberBase.Decimal);
        }
    }

}

