namespace WoodTrack.BLL;

public class ToolsService : BaseService<Tool, int, ToolModel, ToolUpsertModel, ToolSearchObject>, IToolsService
{
    public ToolsService(IMapper mapper, DatabaseContext databaseContext) : base(mapper, databaseContext)
    {
        //
    }

    public override async Task<ToolModel?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        var entity = await DbSet
            .Include(x => x.ToolCategory)
            .Where(x => x.Id == id)
            .FirstOrDefaultAsync(cancellationToken);

        return Mapper.Map<ToolModel>(entity);
    }

    public override async Task<PagedList<ToolModel>> GetPagedAsync(ToolSearchObject searchObject, CancellationToken cancellationToken = default)
    {
        var pagedList = await DbSet
            .Include(p => p.ToolCategory)
            .Where(c =>
                (
                    string.IsNullOrEmpty(searchObject.SearchFilter)
                    || c.Name.ToLower().Contains(searchObject.SearchFilter.ToLower())
                    || (!string.IsNullOrEmpty(c.Description) && c.Description.ToLower().Contains(searchObject.SearchFilter.ToLower()))
                )
                && (searchObject.CategoryId == 0 || searchObject.CategoryId == c.ToolCategoryId)
                && !c.IsDeleted
            )
            .ToPagedListAsync(searchObject);
        return Mapper.Map<PagedList<ToolModel>>(pagedList);
    }

    public Task<int> Count(CancellationToken cancellationToken = default)
    {
        return DbSet.Where(x => !x.IsDeleted).CountAsync(cancellationToken);
    }
}
