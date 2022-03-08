using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace DataGg.Core.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public class ChartSeriesColumn : Attribute
{
    public string DisplayName { get; set; }
    public string PropertyName  { get; set; }
    public Type BackingType { get; set; }
    public PropertyInfo PropertyInfo { get; set; }
    public bool UsedForGrouping { get; set; } = false;
    public CalcMethod CalcMethod { get; set; } = CalcMethod.None;
    public string Format { get; set; } = string.Empty;
    public string GroupName { get; set; }
    
    public static IEnumerable<ChartSeriesColumn> GetColumnsForGeneric(Type type) 
    {
        var cols = new List<ChartSeriesColumn>();

        var propertyInfos = type.GetProperties().OrderBy(p => p.Name).ToArray();
        for (var i = 0; i < propertyInfos.Length; i++)
        {
            var p = propertyInfos[i];

            var attrs = (ChartSeriesColumn[])p.GetCustomAttributes(typeof(ChartSeriesColumn), true);

            if (attrs.Length > 0)
            {
                var attr = attrs[0];
                attr.PropertyName = p.Name;
                attr.BackingType = p.PropertyType;
                attr.PropertyInfo = p;

                if (string.IsNullOrEmpty(attr.DisplayName))
                {
                    attr.DisplayName = GetDisplayNameFromPropertyName(attr.PropertyName);
                }



                cols.Add(attr);
            }
        }

        //cols = cols.OrderBy(c => c.Ordinal).ToList();

        if (!cols.Any())
        {
            throw new ApplicationException(
                "You have not added Chart Series Columns");
        }

        return cols;
    }
    
    private static string GetDisplayNameFromPropertyName(string propertyName)
    {
        return Regex.Replace(propertyName, "([A-Z]+)(?=([A-Z]|$))", "$1 ");
    }
    
}

public enum CalcMethod
{
    None,
    PercentChange
}