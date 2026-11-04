namespace Delegate
{
    internal class Program
        
    {
        public delegate void Kitchen(string name, int minute);
        static void Main(string[] args)
        {
            smartPot s = new smartPot();    
            chef c = new chef();
            s.OnDishReady += c.Takeoffstove;
            s.OnDishReady += (dish, min) => Console.WriteLine("צפצןף אזהרה");
            s.StartCooking("עוף", 5);
            s.OnDishReady -= c.Takeoffstove;
            s.StartCooking("עוף", 5);
        }
    }
}
