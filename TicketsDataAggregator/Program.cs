
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

const string TicketsFolder = "Tickets";

try
{
	var ticketsAggregator = new TicketsAggregator(
		TicketsFolder);

	ticketsAggregator.Run();
}
catch (Exception ex)
{
	Console.WriteLine("An exception occurred. " +
		"Exception message: " + ex.Message);
}

Console.WriteLine("Press any key to close.");
Console.ReadKey();


public class TicketsAggregator
{
	private readonly string _ticketsFolder;

	public TicketsAggregator(
		string ticketsFolder)
	{
		_ticketsFolder = ticketsFolder;
	}

	public void Run()
	{
		using (PdfDocument document = PdfDocument.Open(_ticketsFolder + "/Tickets1.pdf"))
		{

			// Page number starts from 1, not 0.
			Page page = document.GetPage(1);
			string text = page.Text;
		}

	}
}
