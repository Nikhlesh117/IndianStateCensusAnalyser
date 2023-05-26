using IndianStateCensusAnalyser;
namespace TestStateCensusAnalyser
{
    public class Tests
    {
        public void LoadDataFromCSV_ShouldReturnNumberOfRecords()
        {
            // Arrange
            string filePath = "D:\\c#\\257\\IndianStatesCensusAnalyserProblem\\IndianStatesCensusAnalyserProblem\\StateCensus.csv";
            StateCensusAnalyser analyser = new StateCensusAnalyser(filePath);
            int expectedNumberOfRecords = 5;

            // Act
            int actualNumberOfRecords = analyser.LoadDataFromCSV();

            // Assert
            Assert.AreEqual(expectedNumberOfRecords, actualNumberOfRecords);
        }
        //--------Tc-1.2-------//
        public void LoadDataFromCSV_ShouldThrowException_WhenIncorrectFileIsProvided()
        {
            // Arrange
            string filePath = "D:\\c#\\257\\IndianStatesCensusAnalyserProblem\\IndianStatesCensusAnalyserProblem\\StateCensus.csv";
            StateCensusAnalyser analyser = new StateCensusAnalyser(filePath);



            analyser.LoadDataFromCSV();
        }
    }
}