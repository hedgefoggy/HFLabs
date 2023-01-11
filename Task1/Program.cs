using System;
using System.Text.RegularExpressions;

namespace Task1
{
    class Filter
    {
        string checkCorrect;
        string replaceData;

        public Filter(string checkCorrect, string replaceData)
        {
            this.checkCorrect = checkCorrect;
            this.replaceData = replaceData;
        }

        public string CheckCorrectInputData(string inputData)
        {
            Regex regexp = new Regex(checkCorrect);     

            if (!regexp.IsMatch(inputData))
                return inputData;
            else
            {
                return regexp.Replace(inputData, replaceData); 
            }                       
        }        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputAddress = "140002 ЛЮБЕРЦЫ 2 ОКТЯБРЬСКИЙ ПР 123/4-115";
            string regexp = @"^(\d*?(\d)\s+\S+\s+)\2\s+";
            string replacement = "$1";

            Filter filter = new Filter(regexp, replacement);
            
            Console.WriteLine(filter.CheckCorrectInputData(inputAddress));

            Console.ReadLine();
        }
    }
}