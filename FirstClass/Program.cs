var rectangle1 = new Rectangle(5, 10);
var rectangle2 = new Rectangle();

Console.WriteLine("Rectangle width is: " + rectangle1.Width);
Console.WriteLine("Rectangle height is: " + rectangle1.Height);
Console.WriteLine("Rectangle width is: " + rectangle2.Width);
Console.WriteLine("Rectangle height is: " + rectangle2.Height);

Console.ReadKey();

class Rectangle
{
	public int Width = 2;
	public int Height = 1;

	public Rectangle(int width, int height)
	{
		Width = width;
		Height = height;
	}
}

