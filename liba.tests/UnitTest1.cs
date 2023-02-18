namespace liba.tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Class1 class1= new Class1();
        int n = class1.add(1, 2);
        Assert.Equal(3, n);
    }
}