


Student s1 = new Student();
s1.SetName("Bob");
s1.SetID(1);
s1.SetScore(38);

Student s2 = new Student();
s2.SetName("Eve");
s2.SetID(2);
s2.SetScore(105);

Student[] students=new Student[]{s1,s2};

Console.WriteLine("--- Before Modification ---");
s1.PrintInfo();
s2.PrintInfo();

ExamBoard.ScoresModifier(students);
Console.WriteLine("---After Modification---");
s1.PrintInfo();
s2.PrintInfo();




Console.WriteLine("Grading Application");
public class GradeCalculator
{
    public static bool IsValidScore(int score)
    {
        if (score <= 100)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static string GetGrade(int score)
    {
        if (score >= 70)
        {
            return"Distinction";
        }
        else if (score >= 40)
        {
            return"Pass";
        }
        else
        {
            return"Fail";
        }
    }
}



public class ExamBoard
{
    public static void ScoresModifier(Student[] students)
    {
        foreach(Student s in students)
        {
            if(s.Score<=35 && s.Score <= 39)
            {
                s.Score=40;
            }
            else if (s.Score >= 100)
            {
                s.Score=100;
            }
            else
            {
             s.Score = s.Score;   
            }
        }
    }
}












