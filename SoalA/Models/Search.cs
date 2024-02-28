using System.ComponentModel.DataAnnotations;

namespace SoalA.Models
{
    public class Search
    {
        public string Keyword { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
