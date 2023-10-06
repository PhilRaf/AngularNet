namespace angularnet.Interface
{
    public interface IPricing
    {
        Task<decimal?> FetchPriceAsync(int id);
    }
}
