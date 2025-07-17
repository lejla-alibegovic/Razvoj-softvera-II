namespace WoodTrack.Core.Models;

public class ToolModel : BaseModel
{
    public string Code { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public decimal Dimension { get; set; }
    public DateTime ChargerdDate { get; set; }
    public int ToolCategoryId { get; set; }
    public ToolCategoryModel ToolCategory { get; set; } = default!;
    public int CahrgedByUserId { get; set; }
    public UserModel ChargedByUser { get; set; } = default!;
}
