
using System;

public class Order
{
    #region Enum
    public enum WhereToEat { PickUp, Delivery };
    #endregion

    #region Instance field

    private Pizza _pizza;
    private Customer _customer;
    private WhereToEat _whereToEat;

    #endregion

    #region Constructor
    public Order(Pizza pizza, Customer customer, WhereToEat whereToEat)
    {
        _pizza = pizza;
        _customer = customer;
        _whereToEat = whereToEat;
    }

    #endregion

    #region Property
    public double DeliveryPrice
    {
        get
        {
            double DeliveryPrice = 0;
            if (_whereToEat == WhereToEat.Delivery)
            {
                DeliveryPrice = 40;
            }
            return DeliveryPrice;
        }

    }

    public double CalcMoms
    {
        get
        {
            double CalcMoms = 0;
            CalcMoms = this.CalcTotalPrice();
            CalcMoms = CalcMoms * 0.2;
            return Math.Round(CalcMoms,2);
        }
    }

    public double CalcNetto
    {
        get
        {
            double CalcNetto = 0;
            CalcNetto = CalcTotalPrice();
            CalcNetto = CalcNetto * 0.8;
            return Math.Round(CalcNetto,2);
        }
    }
    #endregion

    #region Methods

    public override string ToString()
    {
        return "You have ordered your food as " + _whereToEat + " +" + DeliveryPrice;
    }
    public double CalcTotalPrice()
    {
        double CalcTotalPrice = 0;

        CalcTotalPrice  = _pizza.PizzaPrice + _pizza.ToppingPrice + DeliveryPrice; 

        return CalcTotalPrice;
        //return "Total price " + CalcTotalPrice + "Netto price " + CalcNetto + "Moms price " + CalcMoms;
    }

    #endregion

}