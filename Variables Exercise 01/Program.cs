using System.Collections.Generic;
using System;

namespace Variables_Exercise_01
{
    class Program
    {
        public struct PointA // A Value Type Container with a parameterized constructor
        {
            private double X;
            private double Y;

            public PointA(double x, double y) 
            {
                X = x;
                Y = y;
            }
        }
        public struct PointB // A Value Type Container with default constructor
        {
            public double X { get; set; }
            public double Y { get; set; }
        } 

        public enum MyEnum { Sun, Mon, Tue, Wed, Thu, Fri, Sat }; // A Value Type Collection

        public enum Cards { Spades, Clubs, Diamonds, Hearts };

        static void Main(string[] args)
        {
            var myList = new List<object>();

            // - Complete all of the TODO's for this exercise
            // - Once finished save, commit, and then push to GitHub!

            #region List of C# Value Types https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types
            //  DATATYPES         |       Size         |                     VALUES                          |
            sbyte _sbyte;               // 8 bit	                      -128 to 127
            byte _byte;                 // 8 bit	                         0 to 255
            short _short;               // 16 bit	                   -32,768 to 32,767
            ushort _ushort;             // 16 bit	                         0 to 65,535
            int _int;                   // 32 bit	            -2,147,483,648 to 2,147,483,647
            uint _uint;                 // 32 bit	                         0 to 4,294,967,295
            long _long;                 // 64 bit	-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong _ulong;               // 64 bit	                         0 to 18,446,744,073,709,551,615

            // Floating point types https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
            float _float;
            double _double;
            decimal _decimal;

            char _char;                 // 16 bit	                         0 to 65535
            bool _bool;                 // ~1 bit	                      True or false
            #endregion

            // TODO: Declare 5 constansts
            const int num13 = 13;
            const bool skyBlue = true;
            const double pi = 3.14159265;
            const char initName = 'R';
            const long bigNumbeeeer = 9217302312541450514;

            // TODO: Declare 2 variables of each type from the list above (1 pair for each) 
            // Make sure to use C# naming convention best practices (camelCase, PascalCase, etc...)

            sbyte minSByte;
            sbyte maxSByte;
            byte minByte;
            byte maxByte;
            short minShort;
            short maxShort;
            ushort minUShort;
            ushort maxUShort;
            int minInt;
            int maxInt;
            uint minUInt;
            uint maxUInt;
            long minLong;
            long maxLong;
            ulong minULong;
            ulong maxULong;
            float minFloat;
            float maxFloat;
            double minDouble;
            double maxDouble;
            decimal minDecimal;
            decimal maxDecimal;
            char minChar;
            char maxChar;
            bool minBool;
            bool maxBool;

            // TODO: Initialize 1 of the variables with that datatypes minimum value
            minSByte = sbyte.MinValue;
            minByte = byte.MinValue;
            minShort = short.MinValue;
            minUShort = ushort.MinValue;
            minInt = int.MinValue;
            minUInt = uint.MinValue;
            minLong = long.MinValue;
            minULong = ulong.MinValue;
            minFloat = float.MinValue;
            minDouble = double.MinValue;
            minDecimal = decimal.MinValue;
            minChar = char.MinValue;
            minBool = false;

            // TODO: Initialize the other variable with that datatypes maximum value
            maxSByte = sbyte.MaxValue;
            maxByte = byte.MaxValue;
            maxShort = short.MaxValue;
            maxUShort = ushort.MaxValue;
            maxInt = int.MaxValue;
            maxUInt = uint.MaxValue;
            maxLong = long.MaxValue;
            maxULong = ulong.MaxValue;
            maxFloat = float.MaxValue;
            maxDouble = double.MaxValue;
            maxDecimal = decimal.MaxValue;
            maxChar = char.MaxValue;
            maxBool = true;

            // TODO: Write out each of the variables to the Console 
            Console.WriteLine($"The MINIMUM values of each type are: \n");
            Console.WriteLine($"sbyte = {minSByte}\n");
            Console.WriteLine($"byte = {minByte}\n");
            Console.WriteLine($"short = {minShort}\n");
            Console.WriteLine($"int = {minInt}\n");
            Console.WriteLine($"uint = {minUInt}\n");
            Console.WriteLine($"long = {minLong}\n");
            Console.WriteLine($"ulong = {minULong}\n");
            Console.WriteLine($"float = {minFloat}\n");
            Console.WriteLine($"double = {minDouble}\n");
            Console.WriteLine($"decimal = {minDecimal}\n");
            Console.WriteLine($"char = {minChar}\n");
            Console.WriteLine($"bool = {minBool}\n \n");

            Console.WriteLine($"The MAXIMUM values of each type are: \n");
            Console.WriteLine($"sbyte = {maxSByte}\n");
            Console.WriteLine($"byte = {maxByte}\n");
            Console.WriteLine($"short = {maxShort}\n");
            Console.WriteLine($"int = {maxInt}\n");
            Console.WriteLine($"uint = {maxUInt}\n");
            Console.WriteLine($"long = {maxLong}\n");
            Console.WriteLine($"ulong = {maxULong}\n");
            Console.WriteLine($"float = {maxFloat}\n");
            Console.WriteLine($"double = {maxDouble}\n");
            Console.WriteLine($"decimal = {maxDecimal}\n");
            Console.WriteLine($"char = {maxChar}\n");
            Console.WriteLine($"bool = {maxBool}\n");


            // **BONUS**
            // TODO: Create your own enum and initialize it with constants of your choosing
            // TODO: Declare it and then iterate through it writing out to the console
            // TODO: Instantiate a struct and initialize all of it's members

        }

    }
}
