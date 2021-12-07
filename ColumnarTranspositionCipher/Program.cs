using System;

namespace ColumnarTranspositionCipher
{
    class Program
    {
        static string Encrypt (string input, int key)
        {
            string encryptedMsg = "";

            double rows = input.Length / key;
            rows = (int)Math.Ceiling(rows);



            char[,] charArray = new char[key, (int)rows];

            int inputCount = 0;

            for (int columns = 0; columns < key; columns++)
            {
                for (int row = 0; row < rows; row++)
                {
                    charArray[columns, row] = input[inputCount];
                    inputCount++;
                    encryptedMsg += charArray[columns, row];
                }
            }

            return encryptedMsg;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Give me a string");
            //string input = Console.ReadLine();

            string input = "Common sense is not so common."; 

            int key = 8;

            Console.WriteLine(Encrypt(input, key));
        }
    }
}
