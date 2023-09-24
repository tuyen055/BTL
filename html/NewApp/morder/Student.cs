namespace newApp.models{
    public class Student{
        public string StudentID { get; set; }
        public string FullName { get; set; }
        public void Nhap(){
            System.Console.Write("StudentID: ");
            StudentID = Console.ReadLine();
            System.Console.Write("FullName: ");
            FullName = Console.ReadLine();

        }
        public void Xuat(){
            System.Console.Write(StudentID + "-" + FullName);
        }


    }

}
