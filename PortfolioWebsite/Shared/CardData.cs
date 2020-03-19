using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioWebsite.Shared
{
    public class CardData
    {
        public string Title { get; set; }
        public string Preview { get; set; }
        public string Body { get; set; }
        public string[] Tags { get; set; }
        public Dictionary<string, string> URL { get; set; }
    }
}