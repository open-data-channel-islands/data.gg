using System.Collections.Generic;
using System.Linq;
using DataGg.Core.Attributes;

namespace DataGg.Core.Types;

public class ChartingData
{
    public IEnumerable<object> OrderedItems { get; set; }
    public ChartSeriesColumn[] Columns { get; set; }

    public ChartSeriesColumn[] ColumnsFiltered(string groupName)
    {
        return Columns
            .Where(x => x.GroupName == groupName || string.IsNullOrEmpty(groupName))
            .ToArray();
    }
    public ChartSeriesColumn GroupingColumn { get; set; }
}