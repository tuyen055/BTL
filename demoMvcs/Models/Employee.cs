namespace demoMvcs.Models
{
    [Table("Employee")]
    public class Employee : Person
    {
        public string EmployeeID { get; set; }
        public int Age { get; set; }
    }

}

