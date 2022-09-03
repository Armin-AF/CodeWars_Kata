namespace LeetCode.Test;
using LeetCode;

public class UnitTest1
{
    [Fact]
    public void Roman_To_Int_Give_3()
    { 
        Assert.Equal(3, Class1.RomanToInt("III"));
        
    }
    
    [Fact]
    public void Roman_To_Int_Give_1994()
    {
        Assert.Equal(1994, Class1.RomanToInt("MCMXCIV"));
    }

    [Fact]
    public void Longest_Prefix_Is_Fl()
    {
        Assert.Equal("fl", Class1.LongestCommonPrefix(new string[] { "flower", "flow", "flight" }));
    }
    
    [Fact]
    public void No_Common_Prefix()
    {
        Assert.Equal("", Class1.LongestCommonPrefix(new string[] { "dog", "racecar", "car" }));
    }
    
    [Fact]
    public void Bool_To_Word_Returned_1() {
        Assert.Equal("Yes", Class1.BoolToWord(true));
    }
    
    [Fact]
    public void Sum_Of_five_Numbers_Returned_6() {
        Assert.Equal(6, Class1.PositiveSum(new int[] { 1, 2, 3, -4, -5 }));
    }

    [Fact]
    public void Six_By_Sex(){
        Assert.Equal("SexSexSexSexSexSex", Class1.RepeatStr(6,"Sex"));
    }

    [Fact]
    public void world_Reverse_Is_dliow(){
        Assert.Equal("dlrow", Class1.Solution("world"));
    }
    
    [Fact]
    public void Test0()
    {
        Assert.Equal(6421, Class1.DescendingOrder(4612));
    }
    
    [Fact]
    public void Return_The_Shortest_Length()
    {
        Assert.Equal(2, Class1.FindShort("This is possible"));
    }
    
    [Fact]
    public void Next_Sqr_Of_16_Is_25()
    {
        Assert.Equal(25, Class1.FindNextSquare((16)));
    }
}