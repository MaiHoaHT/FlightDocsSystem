using System.ComponentModel.DataAnnotations;

namespace FlightDocsSystemAPI.Model
{
    public class Flight
    {
        [Required]
        public string FlightNo { get; set; }
        [Required]
        public DateTime DateBegin { get; set; }
        [Required]
        public string From { get; set; }
        [Required]
        public string To { get; set; }
    }
}
