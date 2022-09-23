namespace NourNumberSystem.Moodle
{
    /// <summary>Class that represent the binary number system</summary> 

    public class BinarySystem : Base
    {
        public BinarySystem(string value)
        {        /// <summary>
                 /// Initializes a new instance of the Metigator.NumberSystem.Models.BinarySystem class to the value indicated
                 ///     by a specified string parameter
                 /// </summary> 
                 /// <param name="value">
                 /// string that hold the value of the Binary system Instance
                 /// </param>  
            Value = value;
            value.Guard("01", NumberBase.BINARY);
        }
    }

}

