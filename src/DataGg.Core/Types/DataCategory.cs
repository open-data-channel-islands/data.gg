namespace DataGg.Core.Types;

public class DataCategory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Image { get; set; }
    public string Desc { get; set; }
    public string Stub { get; set; }
    public bool ComingSoon { get; set; }
    public bool ShowOnSite { get; set; }
}

public class DataCategoryDto : DataCategory {

    public DataSetDto[] DataSets { get; set; }
}