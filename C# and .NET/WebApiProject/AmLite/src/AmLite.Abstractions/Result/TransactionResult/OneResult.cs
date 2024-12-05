namespace AmLite.Abstractions.Result.TransactionResult
{
    using AmLite.Abstractions.Result.TransactionResult.Interfaces;
    using System.Diagnostics.CodeAnalysis;
    //
    // Summary:
    //     Represents a result from a transaction that should contains a single result.
    //
    //
    // Type parameters:
    //   TResource:
    //     The type of the resource contained within the result.
    [ExcludeFromCodeCoverage]
    public class OneResult<TResource> : Result, IOneResult<TResource>, IResult
    {
        //
        // Summary:
        //     Gets or sets the resource that is the result of the transaction when executed
        //     successfully.
        public TResource? Resource { get; set; }

        public bool HasResource => Resource != null;
    }
}