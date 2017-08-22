using System.ComponentModel;

namespace DataHippo.Services.Entities
{
    public class Page
    {
        public string Next { get; set; }
        public string Previous { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
    }
}
