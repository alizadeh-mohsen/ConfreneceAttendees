namespace ConfreneceAttendees.Data
{
    public class Attendee : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public string? CompanyName { get; set; }

        public ReferralSouerce? referralSouerce { get; set; }
        public int ReferralId { get; set; }

        public Gender? Gender { get; set; }
        public int GenderId { get; set; }

        public JobRole? jobRole { get; set; }
        public int JobId { get; set; }

    }
}
