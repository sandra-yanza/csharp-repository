using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign5
{

    // Class "TFQuestion" is the class for the True/False answers.
    class TFQuestion : Question
    {
        public bool CorrectAnsw { get; set; }

        public TFQuestion(string text, bool correctAnsw)
        {
            QuestionText = text;
            CorrectAnsw = correctAnsw;
        }

        public override bool IsCorrect(string userSelection)
        {
            bool userSelect;
            if (bool.TryParse(userSelection, out userSelect))
            {
                return userSelect == CorrectAnsw;
            }
            return false;
        }
    }

}
