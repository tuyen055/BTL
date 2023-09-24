namespace NEWAPP.morder
{
    public class Fruit
    {
        public string name{ get; set; }
        public string  color{ get; set; }
        public int price { get; set; }
        public void Nhapdulieu()
            {
                System.Console.Write("name= ");
                name = Console.ReadLine();
                System.Console.Write("color = ");
               color = Console.ReadLine();
                System.Console.Write("price = ");
                price = Convert.ToInt16(Console.ReadLine());
            }
    public void Hienthi()
    {
        System.Console.WriteLine(name + "-" + color + "-" +price);
    }
    }
}