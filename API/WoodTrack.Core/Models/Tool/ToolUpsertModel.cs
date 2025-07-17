namespace WoodTrack.Core.Models;

public class ToolUpsertModel : BaseUpsertModel
{
    public string Code { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public decimal Dimension { get; set; }
    public DateTime ChargerdDate { get; set; }
    public int ToolCategoryId { get; set; }
    public int CahrgedByUserId { get; set; }
}
