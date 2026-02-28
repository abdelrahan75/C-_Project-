namespace Project_C_
{
    

    enum ans_of_one_choose
    {
        frist =1,
        second =2,
        thrid = 4,
        four = 8,
    }

    internal class Program
    {
       
        static void Main(string[] args)
        {
            var subject = new Subject("C# Programming", "CS301");

            var q1 = new True_OR_False_qusetion("OOP", "Is C# object-oriented?", 5);
            q1.SetCorrectAnswer(true);

            var q2 = new Choose_One_Question("Types", "Which is a value type?", 10);
            q2.AnswerList.Add(new Answer("string", false));
            q2.AnswerList.Add(new Answer("int", true));
            q2.AnswerList.Add(new Answer("object", false));

            var q3 = new Choose_all_Qusetion("OOP Pillars", "Select all OOP pillars:", 15);
            q3.AnswerList.Add(new Answer("Encapsulation", true));
            q3.AnswerList.Add(new Answer("Compilation", false));
            q3.AnswerList.Add(new Answer("Inheritance", true));

            var practiceExam = new PracticeExam(subject, TimeSpan.FromMinutes(30));
            practiceExam.AddQuestion(q1, q1.AnswerList[0]);
            practiceExam.AddQuestion(q2, q2.AnswerList[1]);
            practiceExam.AddQuestion(q3, q3.AnswerList[0]);

            var finalExam = new FinalExam(subject, TimeSpan.FromMinutes(90));
            finalExam.AddQuestion(q1, q1.AnswerList[0]);
            finalExam.AddQuestion(q2, q2.AnswerList[1]);
            finalExam.AddQuestion(q3, q3.AnswerList[0]);

            Console.WriteLine("1. Practice Exam\n2. Final Exam\nChoice: ");
            Exam selected = Console.ReadLine() == "1" ? practiceExam : finalExam;
            selected.ShowExam();
        }
    }
}
