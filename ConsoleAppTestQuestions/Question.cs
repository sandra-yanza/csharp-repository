using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign5
{

    // Class "Question" is the base class.
    abstract class Question
    {
        public string QuestionText { get; set; }
        public abstract bool IsCorrect(string userSelection);
    }
}
