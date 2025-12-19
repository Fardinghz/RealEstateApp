abstract class Property
{
    protected int price ;
    public int Price
    {
        get {return price ;}
        set
        {
            if (value >= 0)
            {
                price = value ;
            }
        }
    }

    protected string owner {get; set;}

    protected int phoneNumber {get; set;}

    public Property(int price , string owner , int phoneNumber)
    {
        this.price = price; 
        this.owner = owner;
        this.phoneNumber = phoneNumber;
    }

    public abstract string Getinfo();
}