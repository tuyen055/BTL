namespace NEWAPP.morder
{
    public class Employee
    {
        public string EmployeeID{ get; set; }
        public string  Fullname { get; set; }
        public int Age { get; set; }
        public void Nhapdulieu()
            {
                System.Console.Write("EmployeeID= ");
                EmployeeID = Console.ReadLine();
                System.Console.Write("Fullname = ");
                Fullname = Console.ReadLine();
                System.Console.Write("Age = ");
                Age = Convert.ToInt16(Console.ReadLine());
            }
    public void Hienthi()
    {
        System.Console.WriteLine(EmployeeID + "-" + Fullname + "-" + Age );
    }
    }
}