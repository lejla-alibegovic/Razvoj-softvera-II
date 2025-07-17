namespace WoodTrack.Core.Models.Service;

public class ToolServiceUpsertModel : BaseUpsertModel
{
    public decimal NewDimension { get; set; }
    public DateTime DeadlineFinishedAt { get; set; }
    public string Description { get; set; } = default!;
    public int ToolId { get; set; }
    public int CahrgedByUserId { get; set; }
}
