using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    public abstract class Exam : ICloneable, IComparable<Exam>
    {
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
        public int NumberOfQuestions { get; set; }

        public Dictionary<BaseQuestion, Answer> QuestionAnswerDictionary { get; set; }

        public Subject AssociatedSubject { get; set; }
        protected Exam(string _title,Subject subject, TimeSpan _duration,int _numberOfTheQuestion)
        {
            Title = _title;
            Duration = _duration;
            AssociatedSubject = subject;
            NumberOfQuestions = _numberOfTheQuestion;
            QuestionAnswerDictionary = new Dictionary<BaseQuestion, Answer>();
        }
        public abstract void ShowExam();

        public override string ToString()
        {
            return $"{AssociatedSubject} {Title} Exam , Duration: {Duration} , {NumberOfQuestions} Questions";
        }
        public override bool Equals(object obj)
        {
            Exam e = obj as Exam;

            if (e == null || GetType() !=e.GetType())
            {
                return false ;
            }
            return Title == e.Title && Duration == e.Duration;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Exam? other)
        {
            return Duration.CompareTo(other.Duration);
        }
    }
}
