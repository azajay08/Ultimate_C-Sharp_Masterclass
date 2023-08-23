using Moq;
using NUnit.Framework;
using UnitTestPractice;
namespace UnitTestPracticeTests;

[TestFixture]

public class PersonalDataReaderTests
{
	[Test]
	public void Read_ShallProduceResultWithDataOfPersonReadFromDataBase()
	{
		var databaseConnectionMock = new Mock<IDatabaseConnection>();
		databaseConnectionMock
			.Setup(mock => mock.GetById(5))
			.Returns(new Person(5, "John", "Smith"));

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

		var personalDataReader = new PersonalDataReader(
			databaseConnectionMock.Object);

		string result = personalDataReader.Read(5);

		//databaseConnectionMock.Reset();
		// This would reset the mock so we can assign it again, but it would
		// make the test too complicated

		Assert.AreEqual("(Id: 5) John Smith", result);
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

		//databaseConnectionMock.Verify(mock => mock.Write(
		//	personToBeSaved.Id, personToBeSaved));

		// Checking if if the Write method is only called once..
		// can also check Never 
		databaseConnectionMock.Verify(mock => mock.Write(
			personToBeSaved.Id, personToBeSaved),
			Times.Once());
	}
}

