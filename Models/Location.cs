using System;

namespace RazorTute.Models
{
    public class Location
    {
        public int ID { get; set; }
        public string Name { get; set; }
	public DateTime captureDate { get; set; }
	public string resources { get; set; }
	public decimal distance { get; set; }
    }
}
