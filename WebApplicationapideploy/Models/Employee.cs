namespace WebApplicationapideploy.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Department { get; set; }
        public DateTime HireDate { get; set; }
    }
}
