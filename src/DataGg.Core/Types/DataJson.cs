using System;

namespace DataGg.Core.Types;

public class DataJson
{
    public int Id { get; set; }
    public int DataSetId { get; set; }
    public DateTime Stamp { get; set; }
    public string Json { get; set; }
    public bool Draft { get; set; }
}