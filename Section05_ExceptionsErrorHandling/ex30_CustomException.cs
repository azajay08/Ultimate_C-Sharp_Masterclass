using System;

namespace Coding.Exercise
{
	public class InvalidTransactionException : Exception
	{
		public TransactionData TransactionData { get; }
		
		public InvalidTransactionException()
		{
		}
		
		public InvalidTransactionException(string message) : base (message)
		{
		}
		
		public InvalidTransactionException(string message, Exception innerEcxeption) : base(message, innerEcxeption)
		{
		}
		
		public InvalidTransactionException(string message, TransactionData transactionData) : base(message)
		{
			TransactionData = transactionData;
		}
		
		public InvalidTransactionException(string message, TransactionData transactionData, Exception innerEcxeption) : base(message, innerEcxeption)
		{
			TransactionData = transactionData;
		}
		
	}

	public class TransactionData
	{
		public string Sender { get; init; }
		public string Receiver { get; init; }
		public decimal Amount { get; init; }
	}
}
