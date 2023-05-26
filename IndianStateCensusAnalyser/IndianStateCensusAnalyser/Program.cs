using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Indian State Census Analyser Problem");

            string filePath = "D:\\c#\\257\\IndianStatesCensusAnalyserProblem\\IndianStatesCensusAnalyserProblem\\StaeCensus.csv";
            StateCensusAnalyser analyser = new StateCensusAnalyser(filePath);
            int numberOfRecords = analyser.LoadDataFromCSV();
            Console.WriteLine("Number of records in the file: " + numberOfRecords);
        }
    }
}
