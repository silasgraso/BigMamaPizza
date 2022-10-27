public class Customer
{
    #region Instance field

    private string _name;
    private string _email;
    private string _addressRoad;
    private int _addressRoadNumber;
    private int _zipCode;

    #endregion

    #region Constructor
    public Customer(string name, string email, string road,int roadNumber, int zipCode)
    {
        _name = name;
        _email = email;
        _addressRoad = road;
        _addressRoadNumber = roadNumber;
        _zipCode = zipCode;
    }
    #endregion
    public override string ToString()
    {
        return  "This is " + _name + 
                " with email " + _email + 
                " the person live at " + _addressRoad + 
                ", " + _addressRoadNumber + 
                ". " + _zipCode ;
    }

    #region Properties

    public string Name
    {
        get { return _name; }
    }

    public string Email
    {
        get { return _email; }
    }

    public int AddressRoadNumber
    {
        get { return _addressRoadNumber; }
    }

    public string AddressRoad
    {
        get { return _addressRoad; }
    }

    public int ZipCode
    {
        get { return _zipCode; }
    }

    #endregion

}