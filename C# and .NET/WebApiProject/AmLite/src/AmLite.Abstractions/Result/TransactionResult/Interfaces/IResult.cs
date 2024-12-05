namespace AmLite.Abstractions.Result.TransactionResult.Interfaces
{
    //
    // Summary:
    //     Defines the properties and methods required to implement a result for a transaction.
    public interface IResult
    {
        //
        // Summary:
        //     Gets a value indicating whether or not an error has occurred while processing
        //     the transaction.
        bool IsError { get; }

        //
        // Summary:
        //     Gets the message describing the error that has occurred while processing the
        //     transaction.
        string ErrorMessage { get; }

        //
        // Summary:
        //     Gets a value indicating whether or not the transaction is recoverable.
        bool IsRecoverable { get; }

        //
        // Summary:
        //     Gets the number of attempts that were executed.
        int Attempts { get; }

        //
        // Summary:
        //     Gets the number of resources that were modified by the transaction.
        long Modified { get; }

        //
        // Summary:
        //     Gets a value indicating whether or not the transaction was acknowledged.
        bool Acknowledged { get; }
    }
}
