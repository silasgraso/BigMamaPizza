
using System;

public class Order
{
    #region Enum
    // when ordering you have to choose where to eat
    public enum WhereToEat { PickUp, Delivery };
    #endregion

    #region Instance field

    private Pizza _pizza;
    private Customer _customer;
    private WhereToEat _whereToEat;

    #endregion

    #region Constructor
    // the order contaín the pizzaobject, costumer object and where to eat the pizza pickup or delivery
    public Order(Pizza pizza, Customer customer, WhereToEat whereToEat)
    {
        _pizza = pizza;
        _customer = customer;
        _whereToEat = whereToEat;
    }

    #endregion

    #region 
    //get price for delivery or pickup
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

    //Calculate moms price on the total order
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

    //Calculate netto price on the total order

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
    //print information about where to eat and the price
    public override string ToString()
    {
        return "You have ordered your food as " + _whereToEat + " +" + DeliveryPrice;
    }

    //Calculate price for total order

    public double CalcTotalPrice()
    {
        double CalcTotalPrice = 0;

        CalcTotalPrice  = _pizza.PizzaPrice + _pizza.ToppingPrice + DeliveryPrice; 

        return CalcTotalPrice;
    }

    #endregion

}