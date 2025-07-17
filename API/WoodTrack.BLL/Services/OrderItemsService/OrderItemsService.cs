namespace WoodTrack.BLL;

public class OrderItemsService : BaseService<OrderItem, int, OrderItemModel, OrderItemUpsertModel, BaseSearchObject>, IOrderItemsService
{
    public OrderItemsService(IMapper mapper, DatabaseContext databaseContext) : base(mapper, databaseContext)
    {

    }
}
