using System;

namespace BinaryToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable section
            string binaryInput;
            int Converter;

            //convert and input section
            Console.Write("Binary Ra Vared Konid : ");
            binaryInput = Console.ReadLine();
            Converter = Convert.ToInt32(binaryInput, 2);

            //output section
            Console.WriteLine(Converter);


            Console.ReadKey();
        }
    }
}
