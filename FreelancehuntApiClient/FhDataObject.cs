using Newtonsoft.Json.Linq;

namespace FreelancehuntApiClient
{
    public class FhDataObject
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public JObject Attributes { get; set; }
        public FhResponse OwnerResponse { get; set; }
    }
}
