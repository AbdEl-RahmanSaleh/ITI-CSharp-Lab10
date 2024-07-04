using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class ChooseOneQuestion : BaseQuestion
    {

        public ChooseOneQuestion(string _Body, string _Marks, AnswerList _Options,Answer _RightAnswer)
                                : base("Choose the Correct Answer", _Body, _Marks, _Options, _RightAnswer)
        {
        }
       
    }
}
