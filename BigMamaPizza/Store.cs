public class Store
{
    #region Method
    public static void Start()
    {
        Pizza PizzaOne = new Pizza(Pizza.PizzaType.Vesuvio, Pizza.PizzaTopping.Ham);
        Pizza PizzaTwo = new Pizza(Pizza.PizzaType.Calzone, Pizza.PizzaTopping.Mushrooms);
        Pizza PizzaThree = new Pizza(Pizza.PizzaType.Margherita, Pizza.PizzaTopping.Cheese);

        Customer Silas = new Customer("Silas", "sila0575@edu.zealand.dk","Boyesgade",3,1622);
        Customer André = new Customer("André", "andr1234@edu.zealand.dk", "Vesterbro", 5, 1824);
        Customer Ozan = new Customer("Ozan", "ozan5678@edu.zealand.dk", "Roskilde", 7, 4000);

        Order OrderOne = new Order(PizzaOne, Silas, Order.WhereToEat.Delivery);
        Order OrderTwo = new Order(PizzaTwo, André, Order.WhereToEat.PickUp);
        Order OrderThree = new Order(PizzaThree, Ozan, Order.WhereToEat.Delivery);


        Console.WriteLine(Silas);
        Console.WriteLine(PizzaOne);
        Console.WriteLine(OrderOne);
        Console.WriteLine($"Moms: " + OrderOne.CalcMoms);
        Console.WriteLine($"Netto: " + OrderOne.CalcNetto);
        Console.WriteLine($"Total: " + OrderOne.CalcTotalPrice());

        Console.WriteLine("---------------------------------------");

        Console.WriteLine(André);
        Console.WriteLine(PizzaTwo);
        Console.WriteLine(OrderTwo);
        Console.WriteLine($"Moms: " + OrderTwo.CalcMoms);
        Console.WriteLine($"Netto: " + OrderTwo.CalcNetto);
        Console.WriteLine($"Total: " + OrderTwo.CalcTotalPrice());

        Console.WriteLine("---------------------------------------");

        Console.WriteLine(Ozan);
        Console.WriteLine(PizzaThree);
        Console.WriteLine(OrderThree);
        Console.WriteLine($"Moms: " + OrderThree.CalcMoms);
        Console.WriteLine($"Netto: " + OrderThree.CalcNetto);
        Console.WriteLine($"Total: " + OrderThree.CalcTotalPrice());
    }


    #endregion
}