var rectangle1 = new Rectangle(5, 10);


Console.WriteLine("Rectangle width is: " + rectangle1.Width);
Console.WriteLine("Rectangle height is: " + rectangle1.Height);

Console.ReadKey();

class Rectangle
{
	public int Width;
	public int Height;

	public Rectangle(int width, int height)
	{
		Width = width;
		Height = height;
	}
}

