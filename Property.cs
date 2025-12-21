abstract class Property
{
    protected string price;
    public string Price
    {
        get { return price; }
        set
        {
            if (value != "0")
            {
                price = value;
            }
        }
    }

    protected string owner;
    public string Owner
    {
        get { return owner; }
        set { owner = value; }
    }

    protected string phoneNumber;
    public string PhoneNumber
    {
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }

    protected Property()
    {
    }

    public abstract string GetInfo();
}