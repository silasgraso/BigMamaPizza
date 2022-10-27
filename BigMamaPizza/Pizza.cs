//dictonary

public class Pizza
{
    #region Enum
    public enum PizzaType { Margherita, Vesuvio, Cappricciosa, Calzone };
    public enum PizzaTopping { Cheese, Ham, Mushrooms };
    #endregion

    #region Instance fields

    private PizzaType _pizzaType;
    private PizzaTopping _pizzaTopping;
 
    #endregion

    #region Constructor

    public Pizza(PizzaType pizzaType, PizzaTopping pizzaTopping)
    {
        _pizzaType = pizzaType;
        _pizzaTopping = pizzaTopping;
    }

    public override string ToString()
    {
        return "You have ordered a " + _pizzaType + " with " + _pizzaTopping + " the price is " + PizzaPrice + "+" + ToppingPrice;
    }

    #endregion

    #region Properties

    public double PizzaPrice
    {
        get 
        {
            double PizzaPrice = 0;
            if (_pizzaType == PizzaType.Margherita)
            {
                PizzaPrice = 69;
            }
            else if (_pizzaType == PizzaType.Vesuvio)
            {
                PizzaPrice = 75;
            }
            else if (_pizzaType == PizzaType.Cappricciosa || _pizzaType == PizzaType.Calzone)
            {
                PizzaPrice = 80;
            }
            return PizzaPrice;
        }
        
    }

    public double ToppingPrice
    {
        get
        {
            double ToppingPrice = 0;
            if (_pizzaTopping == PizzaTopping.Cheese)
            {
                ToppingPrice = 8;
            }
            else if (_pizzaTopping == PizzaTopping.Ham)
            {
                ToppingPrice = 10;
            }
            else if (_pizzaTopping == PizzaTopping.Mushrooms)
            {
                ToppingPrice = 12;
            }
            return ToppingPrice;
        }

    }

    #endregion
}