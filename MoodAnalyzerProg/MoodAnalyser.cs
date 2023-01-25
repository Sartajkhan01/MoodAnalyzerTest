using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProg
{
    public class MoodAnalyser
    {
        public string message;
        /// <summary>
        /// Default Constructor
        /// </summary>
        public MoodAnalyser()
        {

        }
        /// <summary>
        /// Parameterised Constructor
        /// </summary>
        public MoodAnalyser(string message)
        {
            this.message = message.ToUpper();
        }
        public string AnalyseMoodWithoutConstructor(string message)
        {
            if (message.ToLower().Contains("sad"))
                return "SAD";

            else return "HAPPY";

        }
        public string AnalyseMood()
        {
            if (message.ToLower().Contains("sad"))
                return "SAD";

            else return "HAPPY";
        }

    }
}
