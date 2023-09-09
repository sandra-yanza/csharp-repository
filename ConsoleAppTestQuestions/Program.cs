using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign5
{


    // Class "Quiz",  used for the Question List.
    class Quiz
    {
        private List<Question> ListQuestions = new List<Question>();
        private int score = 0;

        public void AddQuestion(Question question)
        {
            ListQuestions.Add(question);
        }

        public void RunQuiz()
        {
            foreach (var question in ListQuestions)
            {
                Console.WriteLine(question.QuestionText);

                if (question is MCQuestion mcq)
                {
                    for (int i = 0; i < mcq.Choices.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {mcq.Choices[i]}");
                    }
                }
                else if (question is TFQuestion tfq)
                {
                    Console.WriteLine("true or false");
                }

                Console.Write("Enter answer: ");
                string userAnswer = Console.ReadLine();

                if (question.IsCorrect(userAnswer))
                {
                    Console.WriteLine("Correct answer!\n");
                    score++;
                }
                else
                {
                    Console.WriteLine("Wrong answer.\n");
                }
            }

            Console.WriteLine($"You finished the quiz. Your score is: {score}. Total questions: {ListQuestions.Count}.\n");
            Console.WriteLine("Thanks for your answers.\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = new Quiz();

            MCQuestion mcq1 = new MCQuestion("Who is the author of the phrase 'I think, therefore I am'?", new List<string> { "Galileo Galilei", "Plato", "Descartes" }, 3);
            quiz.AddQuestion(mcq1);
            MCQuestion mcq2 = new MCQuestion("What is the name of the longest river in the world?", new List<string> { "Nile", "Amazon", "Danube" }, 2);
            quiz.AddQuestion(mcq2);
            MCQuestion mcq3 = new MCQuestion("When did World War II end?", new List<string> { "1945", "1947", "1943" }, 1);
            quiz.AddQuestion(mcq3);
            MCQuestion mcq4 = new MCQuestion("What is the holy book of Muslims?", new List<string> { "The Bible", "The Talmud", "The Quran" }, 3);
            quiz.AddQuestion(mcq4);

            TFQuestion tfq1 = new TFQuestion("The black box of an airplane is black.", false);
            quiz.AddQuestion(tfq1);
            TFQuestion tfq2 = new TFQuestion("There are five different blood groups.", false);
            quiz.AddQuestion(tfq2);
            TFQuestion tfq3 = new TFQuestion("The small intestine is about three and a half times the length of your body.", true);
            quiz.AddQuestion(tfq3);

            quiz.RunQuiz();
            Console.ReadKey();
        }
    }
}
