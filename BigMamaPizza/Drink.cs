
public class Drink
{
    #region Enum
    public enum DrinkType { Beer, Soda, Coffee };
    public enum DrinkSize { Small, Medium, Large };
    public enum SodaBrand { None, Fanta, CocaCola, Sprite };

    #endregion

    #region Instance fields

    private DrinkType _drinkType;
    private DrinkSize _drinkSize;
    private SodaBrand _sodaBrand;
    
    #endregion


    #region Constructor

    public Drink(DrinkType drinkType, DrinkSize drinkSize)
    {
        _drinkType = drinkType;
        _drinkSize = drinkSize;
    }

    //Create nullable 
    public Drink(DrinkType drinkType, DrinkSize drinkSize, SodaBrand sodaBrand)
    {
        _drinkType = drinkType;
        _drinkSize = drinkSize;
        _sodaBrand = sodaBrand;
    }


    //Do not work, should return one text if you order soda, and another text if you dont order soda
    public override string ToString()
    {
        if (_sodaBrand != SodaBrand.None)
        {
            return "You have ordered a " + _drinkSize + " " + _sodaBrand;
        }
        else
        {
            return "You have ordered a " + _drinkSize + " " + _drinkType;
        }
       
    }

    #endregion

    #region Properties

    public double DrinkPrice
    {
        get
        {
            double drinkPrice = 0;
            if (_drinkSize == DrinkSize.Small)
            {
                drinkPrice = 30;
            }
            else if (_drinkSize == DrinkSize.Medium)
            {
                drinkPrice = 40;
            }
            else if (_drinkSize == DrinkSize.Large)
            {
                drinkPrice = 50;
            }
            return drinkPrice;
        }
    }

    #endregion
}