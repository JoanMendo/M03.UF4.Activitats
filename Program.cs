using System;
using System.Linq;

namespace Ex1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string textPath = @"D:\C#\input.txt";
            string sum = "";
            string currentLine;
            string[] nums1to9 = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int totalSum = 0;
            string[] allLines ;
            string[] lines =File.ReadAllLines(textPath);

                for (int i = 0; i < lines.Length; i++)
                {
                    currentLine = "";
                
                    for (int j = 0; j < lines[i].Length; j++)
                    {
                        if (Char.IsDigit(lines[i][j]))
                        {
                            sum += lines[i][j];
                            break;
                        }
                        else 
                        { 
                            currentLine += lines[i][j];
                            if (nums1to9.Contains(currentLine))
                            {
                                
                                for (int k = 0; k < nums1to9.Length; k++)
                                {
                                    if (nums1to9[k].Contains(currentLine))
                                    {
                                    sum += nums1to9[k];
                                    break;
                                    }
                                }
                            
                            }
                        }
                    }

                    currentLine = "";

                    for (int j = lines[i].Length - 1; j >= 0; j--)
                    {
                        if (Char.IsDigit(lines[i][j]))
                        {
                            sum += lines[i][j];
                            break;
                        }
                        else
                        {
                            currentLine = lines[i][j] + currentLine;
                            if (nums1to9.Contains(currentLine))
                            {

                                for (int k = 0; k < nums1to9.Length; k++)
                                {
                                    if (nums1to9[k].Contains(currentLine))
                                    {
                                        sum += nums1to9[k];
                                        break;
                                    }
                                }

                            }
                        }
                }
                        sum += " ";
                
                        
                    
                
                }
                allLines = sum.Split(' ');
                for (int i = 0; i < lines.Length; i++)
                {
                    totalSum += int.Parse(allLines[i]);
                }
                Console.WriteLine(totalSum);
            
        }
    }
}