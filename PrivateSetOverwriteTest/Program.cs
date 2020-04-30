using System;

namespace PrivateSetOverwriteTest
{
    public class Data
    {
        public string ValueA { get; set; }
        public string ValueB { get; private set; }

        public Data(string vA, string vB)
        {
            this.ValueA = vA;
            this.ValueB = vB;
        }

        public override string ToString() => $"{this.ValueA} {this.ValueB}";

    }
    class Program
    {
        static void Main(string[] args)
        {
            var objA = new Data("Hello", "World!");
            Console.WriteLine(objA);
            //Hello World!

            // set is private. Not allowed
            //objA.ValueB = "Germany!"; // CS0272

            // Get the type
            var type = objA.GetType();
            //var type = typeof(Data); // alternative

            // Get the property and set the value
            var prop = type.GetProperty("ValueB");
            prop.SetValue(objA, "Germany");

            Console.WriteLine(objA);
            //Hello Germany
        }
    }
}
