namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
}

[TestClass]
public class Subtraction
{
	[TestMethod]

	public void Subtract_Valid_Smith()
	{
        Assert.AreEqual(3, Program.Subtract("5", "2"));
        Assert.AreEqual(0, Program.Subtract("3", "3"));
        Assert.AreEqual(-2, Program.Subtract("5", "7"));
    }
}

[TestClass]
public class Multiplication
{
	[TestMethod]

	public void Multiply_Valid_Smith()
	{
        Assert.AreEqual(15, Program.Multiply("5", "3"));
        Assert.AreEqual(0, Program.Multiply("3", "0"));
        Assert.AreEqual(-5, Program.Multiply("5", "-1"));
    }
}

[TestClass]
public class Power
{ 
	
	[TestMethod]
	public void Power_Valid_Smith()
	{
        Assert.AreEqual(16, Program.Power("2", "4"));
        Assert.AreEqual(1, Program.Power("100", "0"));
        Assert.AreEqual(17, Program.Power("4", "2"));
    }
}
