namespace Ink.Core.Domain
{
    public class CompanyUser
    {
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public bool? AllowTaking { get; set; } //given right to do take? maybe should allow date base upto when!
    }
}
