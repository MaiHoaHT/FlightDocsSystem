using DocumentsService.Models;
using FlightService.Models;

namespace FlightDocsSystemAPI.Model
{
    public class FlightViewAPI
    {
        public int APIID { get; set; }
        public int FlightID { get; set; }
        public Flight Flight { get; set; }
        public int DocumentID { get; set; }
        public Document Document { get; set; }
        public string EndpointURL { get; set; }
        public string RequestPayload { get; set; }
        public string ResponsePayload { get; set; }
        public string Status { get; set; }
    }
}
