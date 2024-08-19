namespace WhatsNewCSharp8
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string? EmployeeJob { get; set; }

        public Employee(int id, string name)
        {
            EmployeeId = id;
            EmployeeName = name;   
            EmployeeJob = null;
        }

        public Employee(int id, string name, string job)
        {
            EmployeeId = id;
            EmployeeName = name;
            EmployeeJob = job;
        }
    }
}
