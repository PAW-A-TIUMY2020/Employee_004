namespace Employee.Models
{
    public interface IEmployees
    {
        string EmpCode { get; set; }
        int EmployeeId { get; set; }
        string FullName { get; set; }
        string OfficeLocation { get; set; }
        string Position { get; set; }
    }
}