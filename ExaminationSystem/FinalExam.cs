using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class FinalExam : Exam
    {

        public FinalExam(TimeSpan duration, Subject subject,int numberOfQuestion)
            : base("Final Exam",subject, duration, numberOfQuestion)
        {
        }

        public override void ShowExam()
        {
            foreach (var question in QuestionAnswerDictionary.Keys)
            {
                question.ShowQuestion();
                Console.Write("Answer : ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }
    }
}
