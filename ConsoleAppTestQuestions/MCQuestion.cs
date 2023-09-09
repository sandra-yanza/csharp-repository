using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign5
{

    // Class "MCQuestion",  used for multiple choice questions.
    class MCQuestion : Question
    {
        public List<string> Choices { get; set; }
        public int CorrectAnswIndex { get; set; }

        public MCQuestion(string text, List<string> choices, int correctAnswIndex)
        {
            QuestionText = text;
            Choices = choices;
            CorrectAnswIndex = correctAnswIndex;
        }

        public override bool IsCorrect(string userSelection)
        {
            int userSelect;
            if (int.TryParse(userSelection, out userSelect))
            {
                return userSelect == CorrectAnswIndex;
            }
            return false;
        }
    }

}
