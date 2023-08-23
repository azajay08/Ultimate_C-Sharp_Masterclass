using Moq;
using NUnit.Framework;
using UnitTestPractice;
namespace UnitTestPracticeTests;

[TestFixture]

public class PersonalDataReaderTests
{
	private PersonalDataReader _cut; // Class Under Test
	private Mock<IDatabaseConnection> _databaseConnectionMock;

	[SetUp] // This acts sort of like a constructor
	public void Setup()
	{
		_databaseConnectionMock = new Mock<IDatabaseConnection>();
		_cut = new PersonalDataReader(
			_databaseConnectionMock.Object);
	}

	[Test]
	public void Read_ShallProduceResultWithDataOfPersonReadFromDataBase()
	{
		_databaseConnectionMock
			.Setup(mock => mock.GetById(5))
			.Returns(new Person(5, "John", "Smith"));

		string result = _cut.Read(5);

		Assert.AreEqual("(Id: 5) John Smith", result);

		//var databaseConnectionMock = new Mock<IDatabaseConnection>();
		//databaseConnectionMock
		//	.Setup(mock => mock.GetById(5))
		//	.Returns(new Person(5, "John", "Smith"));
		//var personalDataReader = new PersonalDataReader(
		//	databaseConnectionMock.Object);

		//string result = personalDataReader.Read(5);
		//Assert.AreEqual("(Id: 5) John Smith", result);

		//databaseConnectionMock
		//	.Setup(mock => mock.GetById(It.IsAny<int>()))
		//	.Returns(new Person(5, "John", "Smith"));
		// The It.IsAny can be used to make it so any int can be used and it
		// will still return the value we want. NOT IS

		//databaseConnectionMock
		//	.Setup(mock => mock.GetById(It.IsAny<int>()))
		//	.Throws(new Exception("Some Message"));
		// We can use the Throw method to throw an exception instead of
		// return a value

		//var personalDataReader = new PersonalDataReader(
		//	databaseConnectionMock.Object);

		//databaseConnectionMock.Reset();
		// This would reset the mock so we can assign it again, but it would
		// make the test too complicated
	}

	// Testing a method that is a void
	[Test]
	public void Save_ShallCallTheWriteMethod_WithCorrectArguments()
	{
		var databaseConnectionMock = new Mock<IDatabaseConnection>();
		var persoanlDataReader = new PersonalDataReader(
			databaseConnectionMock.Object);
		var personToBeSaved = new Person(10, "Jane", "Miller");
		persoanlDataReader.Save(personToBeSaved);

		databaseConnectionMock.Verify(mock => mock.Write(
			personToBeSaved.Id, personToBeSaved));

		// Checking if if the Write method is only called once..
		// can also check Never(), Exactly(n), AtLeast(n), AtMost(n), Between(n, n) 
		//databaseConnectionMock.Verify(mock => mock.Write(
		//	personToBeSaved.Id, personToBeSaved),
		//	Times.Once());

		// If we want to just check if the Write method has been called and the
		// arguments don't matter, we can it with the IsAny method..
		//databaseConnectionMock.Verify(mock => mock.Write(
		//	It.IsAny<int>(), It.IsAny<Person>()));
	}
}

