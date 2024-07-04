using ExaminationSystem;
using System.Collections;

namespace Lab10.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Delegate Lab
            //Book b1 = new Book("1", "Hello world", ["Ahmed", "Mohammed"], DateTime.Now, 500);
            //Book b2 = new Book("2", "Hello world", ["Ahmed", "Mohammed"], DateTime.Now, 500);
            //Book b3 = new Book("3", "Hello world", ["Ahmed", "Mohammed"], DateTime.Now, 500);
            //Book b4 = new Book("4", "Hello world", ["Ahmed", "Mohammed"], DateTime.Now, 500);
            //Book b5 = new Book("5", "Hello world", ["Ahmed", "Mohammed"], DateTime.Now, 500);

            //Console.WriteLine(b1);

            //List<Book> bookList = new List<Book>()
            //{
            //    b1,b2,b3,b4,b5

            //};
            //BookFunctionDel fPtr = delegate (Book b)
            //{
            //    return b.ISBN;
            //};
            //LibraryEngine.ProcessBooks(bookList, fPtr);

            //BookFunctionDel fPtr2 = b => b.PublicationDate.ToString();
            //LibraryEngine.ProcessBooks(bookList, fPtr2);


            //Func<Book, string> fPtr3 = BookFunctions.GetTitle;
            //LibraryEngine.ProcessBooks(bookList, fPtr3);


            #endregion

            #region Exam example
            AnswerList trueOrFalse = new AnswerList();
            Answer True = new Answer(1, "True");
            Answer False = new Answer(2, "False");
            trueOrFalse.Add(True);
            trueOrFalse.Add(False);


            AnswerList q1Answers = new AnswerList();
            Answer q1a1 = new Answer(1, "Yes");
            Answer q1a2 = new Answer(2, "No");
            Answer q1a3 = new Answer(3, "Maybe");
            q1Answers.Add(q1a1);
            q1Answers.Add(q1a2);
            q1Answers.Add(q1a3);

            AnswerList q2Answers = new AnswerList();
            Answer q2a1 = new Answer(1, "+");
            Answer q2a2 = new Answer(2, "-");
            Answer q2a3 = new Answer(3, "*");
            Answer AllOfTheAbove = new Answer(4, "All Of The Above");
            q2Answers.Add(q2a1);
            q2Answers.Add(q2a2);
            q2Answers.Add(q2a3);
            q2Answers.Add(AllOfTheAbove);

            QuestionList QL = new QuestionList("CS Practical Exam");

            ChooseOneQuestion q1 = new ChooseOneQuestion("Is C# is OOP language", "5", q1Answers, q1a1);
            TFQuestion q2 = new TFQuestion("Is C is OOP language", "5", trueOrFalse, False);
            ChooseAllQuestion q3 = new ChooseAllQuestion("which of the following is binary operator", "5", q2Answers, AllOfTheAbove);
            QL.Add(q1);
            QL.Add(q2);
            QL.Add(q3);


            Subject sub1 = new Subject("CS");
            PracticalExam practicalExamCS = new PracticalExam(TimeSpan.FromMinutes(30), sub1, 3);
            practicalExamCS.QuestionAnswerDictionary.Add(q1, q1a1);
            practicalExamCS.QuestionAnswerDictionary.Add(q2, False);
            practicalExamCS.QuestionAnswerDictionary.Add(q3, AllOfTheAbove);
            Console.WriteLine(practicalExamCS);
            practicalExamCS.ShowExam();

            QuestionList QL2 = new QuestionList("SE Final Exam")
            {
                q1,
                q2,
                q3
            };

            Subject sub2 = new Subject("Software Engineering");
            FinalExam finalExamSE = new FinalExam(TimeSpan.FromMinutes(30), sub2, 3);
            finalExamSE.QuestionAnswerDictionary.Add(q1, q1a1);
            finalExamSE.QuestionAnswerDictionary.Add(q2, False);
            finalExamSE.QuestionAnswerDictionary.Add(q3, AllOfTheAbove);
            Console.WriteLine(finalExamSE);
            finalExamSE.ShowExam();


            #endregion

        }
    }
}
