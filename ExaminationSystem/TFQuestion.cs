using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class TFQuestion : BaseQuestion
    {

       
        public TFQuestion(string _Body,string _Marks, AnswerList _Options,Answer _RightAnswer)
                              : base("Choose the Correct Answer", _Body, _Marks,_Options , _RightAnswer)
        {
          
        }

    }
}
