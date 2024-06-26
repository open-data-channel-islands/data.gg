﻿using System;
using System.Linq;

namespace DataGg.Core.Types;

public class DataSet
{
    public int Id { get; set; }
    public int DataCategoryId { get; set; }
    public string Name { get; set; }
    public string Desc { get; set; }
    public string Filename { get; set; }
    public string Stub { get; set; }
    public bool Live { get; set; }
    public string Source { get; set; }
    public DateTime? Stale { get; set; }
}

public class DataSetDto : DataSet
{
    public DataJson[] DataJsons { get; set; }

    public DataJson CurrentDataJson => DataJsons.OrderBy(dj => dj.Stamp).FirstOrDefault(dj => !dj.Draft);

}