namespace ASS_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pricepersmallroom = 25;
            int priceperlargeroom = 35;
            double salestaxrate = 0.06;

            Console.WriteLine("enter nuber of small carbets:");
            int SmallRooms = int.Parse(Console.ReadLine());

            Console.WriteLine("enter nmuber of large carbets:");
            int LargeRooms = int.Parse(Console.ReadLine());

            int smallroomcost = pricepersmallroom * SmallRooms;
            int largeroomcost = priceperlargeroom * LargeRooms;
            int total = smallroomcost + largeroomcost;
            double salestax = total * salestaxrate;
            double estimate = total + salestax;

            Console.WriteLine($"Number of small carpets: {SmallRooms}");
            Console.WriteLine($"Number of large carpets: {LargeRooms}");
            Console.WriteLine($"Price per small room: ${pricepersmallroom}");
            Console.WriteLine($"Price per large room: ${priceperlargeroom}");
            Console.WriteLine($"Cost : ${total}");
            Console.WriteLine($"Tax: ${salestax}\n");
            Console.WriteLine($"Total estimate: ${estimate}"); 
            Console.WriteLine("This estimate is valid for 30 days");


        }
    }
}
