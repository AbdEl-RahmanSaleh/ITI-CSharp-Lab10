using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public abstract class BaseQuestion
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public string Marks { get; set; }
        public AnswerList Options { get; set; }
        public Answer RightAnswer { get; set; }

        
        public BaseQuestion(string _Header, string _Body, string _Marks,AnswerList _Options,Answer _RightAnswer )
        {   
            Header = _Header;
            Body = _Body;
            Marks = _Marks;
            Options = _Options;
            RightAnswer = _RightAnswer;
        }


        public void ShowQuestion()
        {
            Console.WriteLine($"{Header}\t\tMarks : {Marks} \n{Body} ?");

            for (int i = 0; i < Options.Count; i++)
                Console.WriteLine($"{i + 1}.{Options[i].AnswerText}");
        }

        public override string ToString()
        {
            return $"{Header}:-\t\tMarks: {Marks} \n{Body} ?\n RightAnswer : {RightAnswer.AnswerText}";
        }

        public override bool Equals(object obj)
        {
            BaseQuestion q = obj as BaseQuestion;

            if (q == null || GetType() != q.GetType())
            {
                return false;
            }
            return Header == q.Header && Body ==q.Body;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }


}
