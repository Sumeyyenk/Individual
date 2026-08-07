namespace GradingApp.Tests;
[TestClass]
public class GradeTests
{
    [TestMethod]
    public void GetGrade_ScoreIs75_ReturnDistinction()
    {
        int score= 75;
        string expected="Distinction";
        string actual = GradeCalculator.GetGrade(score);
        Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void GetGrade_ScoreIs50_ReturnPass()
    {
        int score=50;
        string expected="Pass";
        string actual=GradeCalculator.GetGrade(score);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IsValidScore_ScoreIs20_ReturnTrue()
    {
        int score = 20;
        bool expected=true;
        bool actual = GradeCalculator.IsValidScore(score);
        Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void IsValidScore_ScoreIs120_ReturnFalse()
    {
        int score = 120;
        bool expected = false;
        bool actual = GradeCalculator.IsValidScore(score);
        Assert.AreEqual(expected, actual);
    }

}