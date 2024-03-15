
namespace BaseLibrary.Entities
{
    public class Employee : BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? CivilId { get; set; }
        public string? FileNumber { get; set; }
        public string? Fullname { get; set; }
        public string? JobName { get; set; }
        public string? Address { get; set;}
        public string? TelephoneNumber { get; set; }
        public string? Photo { get; set; }
        public string? Other { get; set;}

        //relationship: many to one
        public GeneralDepartament? GeneralDepartament { get; set; }
        public int DepartamentId { get; set; }
        public Branch? Branch { get; set; }
        public int BranchId { get; set; }
        public Town? Town { get; set; }
        public int TownId { get; set; }
    }
}
