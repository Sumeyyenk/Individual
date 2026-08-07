public class Student
{
    public string Name {get; set;}
    public int ID;
    public int Score;
    public void SetName(string name)
    {
        Name= name;
    }
    public void SetID(int id)
    {
        ID=id;
    }
    public void SetScore(int score)
    {
        Score=score;
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Student {ID}: {Name} - Score:{Score}");
    }
}