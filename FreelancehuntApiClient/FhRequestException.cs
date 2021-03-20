using System;

namespace FreelancehuntApiClient
{
    public class FhRequestException : Exception
    {
        public FhErrorData Error { get; set; }

        public FhRequestException(FhErrorData error)
        {
            Error = error ?? throw new ArgumentNullException(nameof(error));
        }
    }
}
