namespace AmLite.Abstractions.Result.TransactionResult.Interfaces
{
    //
    // Summary:
    //     Defines the properties and methods required to implement a result from a transaction
    //     containing a single resource.
    //
    // Type parameters:
    //   TResource:
    //     The type of the resource contained within the result.
    public interface IOneResult<out TResource> : IResult
    {
        //
        // Summary:
        //     Gets the resource retrieved, created, or updated by the transaction.
        TResource Resource { get; }

        //
        // Summary:
        //     Gets a value indicating whether or not a result is available.
        bool HasResource { get; }
    }
}
