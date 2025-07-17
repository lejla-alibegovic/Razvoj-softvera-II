namespace WoodTrack.BLL;

public interface IReportsService
{
    Task<byte[]> GenerateClientsReport(UsersSearchObject searchObject);
    Task<byte[]> GenerateOrdersReport(OrderSearchObject searchObject);
}
