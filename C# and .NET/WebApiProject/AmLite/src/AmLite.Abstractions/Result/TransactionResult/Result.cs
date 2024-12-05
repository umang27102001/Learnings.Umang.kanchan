namespace AmLite.Abstractions.Result.TransactionResult
{
    using AmLite.Abstractions.Result.TransactionResult.Interfaces;
    using System.Diagnostics.CodeAnalysis;

    //
    // Summary:
    //     Represents a result from a transaction.
    [ExcludeFromCodeCoverage]
    public class Result : IResult
    {
        //
        // Summary:
        //     Gets or sets a value indicating whether or not an error has occurred.
        public bool IsError { get; set; }

        //
        // Summary:
        //     Gets or sets a message indicating why an error has occurred.
        public string? ErrorMessage { get; set; }

        //
        // Summary:
        //     Gets or sets a value indicating whether or not the result is recoverable.
        public bool IsRecoverable { get; set; }

        //
        // Summary:
        //     Gets or sets the number of attempts that were executed.
        public int Attempts { get; set; }

        //
        // Summary:
        //     Gets or sets the number of documents that were modified by the repository operation.
        public long Modified { get; set; }

        //
        // Summary:
        //     Gets or sets a value indicating whether or not the storage provider acknowledged
        //     the request.
        public bool Acknowledged { get; set; }
    }
}