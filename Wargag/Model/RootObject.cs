using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Windows.UI;

namespace Wargag.Model
{

    public class RootObject
    {
        public string status { get; set; }
        public int count { get; set; }
        public List<Datum> data { get; set; }
    }

    public class Datum
    {
        public int rating { get; set; }
        public int content_id { get; set; }
        public string description { get; set; }
        public string media_url { get; set; }
        public int created_at { get; set; }
        public object subject { get; set; }
        public int tag_id { get; set; }
        public string wargag_url { get; set; }
        public string nickname { get; set; }
        public int? category_id { get; set; }
        public string type { get; set; }
        public int? account_id { get; set; }
        public string time_created { get; set; }
        public Brush BackgroundColor { get; set; }
    }
}