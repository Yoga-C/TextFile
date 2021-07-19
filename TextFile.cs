using System;
using static System.Console;
using System.IO;
using System.Linq;

namespace TextFile
{
    class TextFile
    {
        
        static void Main()
        {
            const string inFilename = @"D:\Pam Lemus_Documentos_D\Canada\Douglas College\1ST SEMESTER\1175 005_INTRODUCTION TO PROGRAMMING\Lab Excercise\Lab 8\Input.txt";
            try
            {
                string line;
                string[] tokens;
                double  avg = 0,
                        sum = 0,
                        values = 0;
                string  max="",
                        min = "";
                int linesCount,
                        lineNumber = 1;
                linesCount = File.ReadAllLines(inFilename).Length;
                StreamReader reader = new StreamReader(inFilename);
                
                while ((line = reader.ReadLine()) != null)
                {
                    tokens = line.Split(' ');
                    
                    
                    for (int i = 0; i < tokens.Length; i++)
                    {
                        values = Convert.ToDouble(tokens[i]);
                        sum += values;
                        avg = sum / tokens.Length;
                        max = tokens.Max();
                        min = tokens.Min();
                    }
                    WriteLine("\n{0}", line);
                    WriteLine("Number of values processed Line {0}: {1}", lineNumber, tokens.Length);
                    WriteLine("Average of values Line {0}: {1:F2}", lineNumber, avg);
                    WriteLine("Smallest value Line {0}: {1} ", lineNumber, min);
                    WriteLine("Largest value Line {0}: {1} ", lineNumber, max);
                    lineNumber++;
                }
                reader.Close();
            }
            catch (IOException e)
            {
                WriteLine(e.StackTrace);
            }
            ReadKey();
        }
    }
}
