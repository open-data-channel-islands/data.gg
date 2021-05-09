using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGg.Core.Types
{
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
    }
}
