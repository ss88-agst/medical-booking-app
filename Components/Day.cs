using Microsoft.Extensions.Primitives;

namespace BlazorApp3.Components
{
    public class Day
    {
        public int DayID { get; set; }
        public DateTime Date { get; set; } = new DateTime(1900, 1, 1);
    }
}
