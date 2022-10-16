using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecToBinary
{
    class Program
    {
		static int Octet1;
        static int Octet2;
        static int Octet3;
        static int Octet4;
        static string bit1 = "0";
        static string bit2 = "0";
        static string bit3 = "0";
        static string bit4 = "0";
        static string bit5 = "0";
        static string bit6 = "0";
        static string bit7 = "0";
        static string bit8 = "0";

        static void Main(string[] args)

        {
        Start:
            Console.WriteLine("What do you want to do?");
            string responce = Console.ReadLine();

            if (responce == "Decimal to Binary")
            {
                Console.Clear();
                Console.WriteLine("Enter the 4 Octets.");
                Octet1 = Int32.Parse(Console.ReadLine());
                Octet2 = Int32.Parse(Console.ReadLine());
                Octet3 = Int32.Parse(Console.ReadLine());
                Octet4 = Int32.Parse(Console.ReadLine());

                Console.WriteLine();
                if (Octet1 >= 0 && Octet1 <= 126)
                {
                    Console.WriteLine("Class A  N.H.H.H.");
                }
                if (Octet1 == 127)
                {
                    Console.WriteLine("This IP is a Loop Back.");
                }
                else if (Octet1 >= 128 && Octet1 <= 191)
                {
                    Console.WriteLine("Class B  N.N.H.H.");
                }
                else if (Octet1 >= 192 && Octet1 <= 223)
                {
                    Console.WriteLine("Class C  N.N.N.H.");
                    Console.WriteLine("Can use subnet masking.");
                }
                else
                {
                    Console.WriteLine("This console application does not know what Class this IP belongs too.");
                }

                // Octect 1 Calculation
                if (Octet1 >= 128)
                {
                    Octet1 = Octet1 - 128;
                    bit8 = "1";
                }
                if (Octet1 >= 64)
                {
                    Octet1 = Octet1 - 64;
                    bit7 = "1";
                }
                if (Octet1 >= 32)
                {
                    Octet1 = Octet1 - 32;
                    bit6 = "1";
                }
                if (Octet1 >= 16)
                {
                    Octet1 = Octet1 - 16;
                    bit5 = "1";
                }
                if (Octet1 >= 8)
                {
                    Octet1 = Octet1 - 8;
                    bit4 = "1";
                }
                if (Octet1 >= 4)
                {
                    Octet1 = Octet1 - 4;
                    bit3 = "1";
                }
                if (Octet1 >= 2)
                {
                    Octet1 = Octet1 - 2;
                    bit2 = "1";
                }
                if (Octet1 >= 1)
                {
                    Octet1 = Octet1 - 1;
                    bit1 = "1";
                }

                Console.WriteLine();

                Console.WriteLine(bit8 + bit7 + bit6 + bit5 + bit4 + bit3 + bit2 + bit1);

                //Octect 2 Calculation
                bit1 = "0";
                bit2 = "0";
                bit3 = "0";
                bit4 = "0";
                bit5 = "0";
                bit6 = "0";
                bit7 = "0";
                bit8 = "0";

                if (Octet2 >= 128)
                {
                    Octet2 = Octet2 - 128;
                    bit8 = "1";
                }
                if (Octet2 >= 64)
                {
                    Octet2 = Octet2 - 64;
                    bit7 = "1";
                }
                if (Octet2 >= 32)
                {
                    Octet2 = Octet2 - 32;
                    bit6 = "1";
                }
                if (Octet2 >= 16)
                {
                    Octet2 = Octet2 - 16;
                    bit5 = "1";
                }
                if (Octet2 >= 8)
                {
                    Octet2 = Octet2 - 8;
                    bit4 = "1";
                }
                if (Octet2 >= 4)
                {
                    Octet2 = Octet2 - 4;
                    bit3 = "1";
                }
                if (Octet2 >= 2)
                {
                    Octet2 = Octet2 - 2;
                    bit2 = "1";
                }
                if (Octet2 >= 1)
                {
                    Octet2 = Octet2 - 1;
                    bit1 = "1";
                }
                Console.WriteLine(bit8 + bit7 + bit6 + bit5 + bit4 + bit3 + bit2 + bit1);

                //Octet3
                bit1 = "0";
                bit2 = "0";
                bit3 = "0";
                bit4 = "0";
                bit5 = "0";
                bit6 = "0";
                bit7 = "0";
                bit8 = "0";

                if (Octet3 >= 128)
                {
                    Octet3 = Octet3 - 128;
                    bit8 = "1";
                }
                if (Octet3 >= 64)
                {
                    Octet3 = Octet3 - 64;
                    bit7 = "1";
                }
                if (Octet3 >= 32)
                {
                    Octet3 = Octet3 - 32;
                    bit6 = "1";
                }
                if (Octet3 >= 16)
                {
                    Octet3 = Octet3 - 16;
                    bit5 = "1";
                }
                if (Octet3 >= 8)
                {
                    Octet3 = Octet3 - 8;
                    bit4 = "1";
                }
                if (Octet3 >= 4)
                {
                    Octet3 = Octet3 - 4;
                    bit3 = "1";
                }
                if (Octet3 >= 2)
                {
                    Octet3 = Octet3 - 2;
                    bit2 = "1";
                }
                if (Octet3 >= 1)
                {
                    Octet3 = Octet3 - 1;
                    bit1 = "1";
                }
                Console.WriteLine(bit8 + bit7 + bit6 + bit5 + bit4 + bit3 + bit2 + bit1);


                //Octet4
                bit1 = "0";
                bit2 = "0";
                bit3 = "0";
                bit4 = "0";
                bit5 = "0";
                bit6 = "0";
                bit7 = "0";
                bit8 = "0";

                if (Octet4 >= 128)
                {
                    Octet4 = Octet4 - 128;
                    bit8 = "1";
                }
                if (Octet4 >= 64)
                {
                    Octet4 = Octet4 - 64;
                    bit7 = "1";
                }
                if (Octet4 >= 32)
                {
                    Octet4 = Octet4 - 32;
                    bit6 = "1";
                }
                if (Octet4 >= 16)
                {
                    Octet4 = Octet4 - 16;
                    bit5 = "1";
                }
                if (Octet4 >= 8)
                {
                    Octet4 = Octet4 - 8;
                    bit4 = "1";
                }
                if (Octet4 >= 4)
                {
                    Octet4 = Octet4 - 4;
                    bit3 = "1";
                }
                if (Octet4 >= 2)
                {
                    Octet4 = Octet4 - 2;
                    bit2 = "1";
                }
                if (Octet4 >= 1)
                {
                    Octet4 = Octet4 - 1;
                    bit1 = "1";
                }
                Console.WriteLine(bit8 + bit7 + bit6 + bit5 + bit4 + bit3 + bit2 + bit1);

            }

            else if (responce == "Binary to Decimal")
			{

                Console.Clear();
                Console.WriteLine("Enter each bit value.");
                Console.WriteLine();
				Console.WriteLine("First Octet");
				bit1 = Console.ReadLine();
				bit2 = Console.ReadLine();
				bit3 = Console.ReadLine();
				bit4 = Console.ReadLine();
				bit5 = Console.ReadLine();
				bit6 = Console.ReadLine();
				bit7 = Console.ReadLine();
				bit8 = Console.ReadLine();
				
				//Octect 1
				if (bit1 == "1")
				{
					Octet1 = (Octet1 + 128);
				}
				
				if (bit2 == "1")
				{
					Octet1 = (Octet1 + 64);
				}
				
				if (bit3 == "1")
				{
					Octet1 = (Octet1 +32);
				}
				
				if (bit4 == "1")
				{
					Octet1 = (Octet1 + 16);
				}
				
				if (bit5 == "1")
				{
					Octet1 = (Octet1 + 8);
				}
				
				if (bit6 == "1")
				{
					Octet1 = (Octet1 + 4);
				}
				
				if (bit7 == "1")
				{
					Octet1 = (Octet1 + 2);
				}
				
				if (bit8 == "1")
				{
					Octet1 = (Octet1 + 1);
				}

                Console.WriteLine("--------------------");
                Console.WriteLine();
				Console.WriteLine(Octet1);
				//////////////////////////////////////////////////////////////////////////////////
				//Octet2
				
				Console.WriteLine();
				Console.WriteLine("Second Octet");
				bit1 = Console.ReadLine();
				bit2 = Console.ReadLine();
				bit3 = Console.ReadLine();
				bit4 = Console.ReadLine();
				bit5 = Console.ReadLine();
				bit6 = Console.ReadLine();
				bit7 = Console.ReadLine();
				bit8 = Console.ReadLine();
				
				if (bit1 == "1")
				{
					Octet2 = (Octet2 + 128);
				}
				
				if (bit2 == "1")
				{
					Octet2 = (Octet2 + 64);
				}
				
				if (bit3 == "1")
				{
					Octet2 = (Octet2 +32);
				}
				
				if (bit4 == "1")
				{
					Octet2 = (Octet2 + 16);
				}
				
				if (bit5 == "1")
				{
					Octet2 = (Octet2 + 8);
				}
				
				if (bit6 == "1")
				{
					Octet2 = (Octet2 + 4);
				}
				
				if (bit7 == "1")
				{
					Octet2 = (Octet2 + 2);
				}
				
				if (bit8 == "1")
				{
					Octet2 = (Octet2 + 1);
				}
				
				Console.WriteLine(Octet2);
				
				//////////////////////////////////////////////////////////////////////////////////
				//Octet3
				
				Console.WriteLine();
				Console.WriteLine("Third Octet");
                bit1 = Console.ReadLine();
                bit2 = Console.ReadLine();
                bit3 = Console.ReadLine();
                bit4 = Console.ReadLine();
                bit5 = Console.ReadLine();
                bit6 = Console.ReadLine();
                bit7 = Console.ReadLine();
                bit8 = Console.ReadLine();

                if (bit1 == "1")
				{
					Octet3 = (Octet3 + 128);
				}
				
				if (bit2 == "1")
				{
					Octet3 = (Octet3 + 64);
				}
				
				if (bit3 == "1")
				{
					Octet3 = (Octet3 +32);
				}
				
				if (bit4 == "1")
				{
					Octet3 = (Octet3 + 16);
				}
				
				if (bit5 == "1")
				{
					Octet3 = (Octet3 + 8);
				}
				
				if (bit6 == "1")
				{
					Octet3 = (Octet3 + 4);
				}
				
				if (bit7 == "1")
				{
					Octet3 = (Octet3 + 2);
				}
				
				if (bit8 == "1")
				{
					Octet3 = (Octet3 + 1);
				}
				
				Console.WriteLine(Octet3);
				
				
			}
			
			else
            {
                Console.WriteLine("This application does not how to do that.");
            }

            Console.ReadKey();
            Console.Clear();
            goto Start;
            

        }
    }
}
