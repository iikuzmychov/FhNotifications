using System;

namespace FreelancehuntApiClient
{
    public class FhFeedObject
    {
        public string Message { get; set; }
        public bool IsNew { get; set; }
        public DateTime CreatedAt { get; set; }
        public FhDataObject OwnerDataObject { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is FhFeedObject)
            {
                var otherFeedObject = obj as FhFeedObject;

                if (Message == otherFeedObject.Message && CreatedAt == otherFeedObject.CreatedAt)
                    return true;
            }

            return false;
        }
    }
}
