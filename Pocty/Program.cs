using System;
using System.IO;
using System.Linq;

namespace Pocty
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input = @"C:/Users/LIBOR-PC/Desktop/Kasiopea/Pocty/A-lehky.txt";
            string Output = @"C:/Users/LIBOR-PC/Desktop/Kasiopea/Pocty/Vystup.txt";
            string[] AllInput = File.ReadAllLines(Input);
            int NumberOfInputs = Convert.ToInt32(AllInput[0]);
            string[] OutputArray = new string[NumberOfInputs];
            int InputArraysCount = -1;
            int[] InputArray;
            for (int i = 0; i < NumberOfInputs; i++)
            {
                bool value = true;
                InputArraysCount += 2;
                InputArray = AllInput[InputArraysCount + 1].Split(" ").Select(x => int.Parse(x)).ToArray();
                for (int j = 0; j < InputArray.Length; j++)
                {
                    if (InputArray[j] != 0)
                    {
                        if (InputArray[j] != j + 1)
                        {
                            value = false;
                        }
                    }
                }
                if (value == true)
                {
                    OutputArray[i] = "ANO";
                }
                else
                {
                    OutputArray[i] = "NE";
                }
            }
            System.IO.File.WriteAllLines(Output, OutputArray);
        }
    }
}
