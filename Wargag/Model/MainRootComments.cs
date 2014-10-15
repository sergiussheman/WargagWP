using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wargag.Model
{
    public class CommentObject
    {
        public string comment { get; set; }
        public int account_id { get; set; }
        public int created_at { get; set; }
        public int comment_id { get; set; }
        public int content_id { get; set; }
        public string nickname { get; set; }
        public string time_created { get; set; }
    }

    public class MainRootComments
    {
        public string status { get; set; }
        public int count { get; set; }
        public List<CommentObject> data { get; set; }
    }
}
