using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Security.Cryptography;
using System.Security.Claims;


namespace Task1
{
    class Filter
    {
        string checkCorr;
        string replaceData;

        Filter(string checkCorr, string replaceData)
        {
            this.checkCorr = checkCorr;
            this.replaceData = replaceData;
        }

        string CheckCorrectInputData(string inputData)
        {            
            checkCorr = @"^(\d*?(\d)\s+\S+\s+)\2\s+";
            
            Regex regexp = new Regex(checkCorr);

            if (!regexp.IsMatch(inputData))
                return inputData;
            else
            {
                return new Regex(checkCorr).Replace(inputData, "$1"); 
            }                       
        }        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputAddress = "140002 ЛЮБЕРЦЫ 2 ОКТЯБРЬСКИЙ ПР 123/4-115";            
        }
    }
}
