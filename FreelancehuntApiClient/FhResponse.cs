using System.Collections.Generic;
using System.Net.Http;

namespace FreelancehuntApiClient
{
    public class FhResponse
    {
        private List<FhDataObject> data;
        private FhErrorData error;

        public List<FhDataObject> Data
        {
            get => data;

            set
            {
                data = value;

                if (data != null)
                    data.ForEach(dataObject => dataObject.OwnerResponse = this);
            }
        }
        public FhErrorData Error
        {
            get => error;

            set
            {
                error = value;

                if (error != null)
                    error.OwnerResponse = this;
            }
        }
        public HttpResponseMessage Message { get; set; }
    }
}
