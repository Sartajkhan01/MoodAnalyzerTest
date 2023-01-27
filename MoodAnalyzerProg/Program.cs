namespace MoodAnalyzerProg
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Mood Analyser Reflection Problems");
            MoodAnalysis moodAnalysis = new MoodAnalysis("I am in Happy Mood");
            Console.WriteLine("Mood is: " + moodAnalysis.AnalyseMood());

            Console.ReadLine();

        }
    }
}