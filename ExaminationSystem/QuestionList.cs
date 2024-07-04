using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public class QuestionList : List<BaseQuestion>
    {
        List<BaseQuestion> questions = new List<BaseQuestion>();
        private string _fileName;
        public QuestionList(string name)
        {
            _fileName = name;
        }
        public new void Add(BaseQuestion question)
        {
            base.Add(question);
            using (StreamWriter writer = new StreamWriter(Path.Combine("E:\\Exams",_fileName),true))
            {
                writer.WriteLine(question.ToString());
            }
        }
    }

}
