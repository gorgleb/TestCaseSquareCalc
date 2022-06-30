using TestCaseSquareCalc;

namespace Tests;

public class CircleTests
{	
    [SetUp]
    public void Setup()
    {
    }

	[Test]
	public void GetSquareTest()
	{
		var radius = 5;
		var circle = new Circle(radius);
		var expectedValue = Math.PI * Math.Pow(radius, 2);

		var square = circle.SquareGetter();

		Assert.AreEqual(expectedValue, square);
	}
    [Test]
	public void LessThanMinimumRadiusTest()
    {
		Assert.Catch<ArgumentException>(() => new Circle(Constants.MinRadius - 1e7));
	}
	[Test]
	public void NegativeRadiusTest()
	{
		Assert.Catch<ArgumentException>(() => new Circle(-1));
	}
	public void ZeroRadiusTest()
	{
		Assert.Catch<ArgumentException>(() => new Circle(0));
	}
	
}