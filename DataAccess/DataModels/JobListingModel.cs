namespace DataAccess.DataModels;

public class JobListingModel
{
    public int Id { get; set; }

    public string Company { get; set; }

    public string Logo { get; set; }

    public bool IsNew { get; set; }

    public bool IsFeatured { get; set; }

    public string Position { get; set; }

    public string Role { get; set; }

    public string Level { get; set; }

    public string PostedAt { get; set; }

    public string ContractType { get; set; }

    public string Location { get; set; }

    public List<LanguageModel> Languages { get; set; } = [];

    public List<ToolModel> Tools { get; set; } = [];
}
