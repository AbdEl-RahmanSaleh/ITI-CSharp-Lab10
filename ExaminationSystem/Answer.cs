using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class Answer
    {
        public string AnswerText { get; set; }
        public int RightAnswerIndex { get; set; }
        public Answer(int rightAnswerIndex, string answerText)
        {
            AnswerText = answerText;
            RightAnswerIndex = rightAnswerIndex;
        }
        public Answer()
        {

        }
    }
}
