namespace MWG.AK.Inventory.BLL.Core
{
    public interface IAggregate<TId>
    {
        TId Id { get; }
    }
}
