using System.Buffers;

class Land : Property
{
    public int metrage {get; set;}
    public bool mojavez {get; set;}
    public string address {get; set;}

    public Land(int price , string owner , int phoneNumber , int metrage , bool mojavez , string address) 
    :  base(price, owner, phoneNumber)
    {
        this.metrage = metrage ;
        this.mojavez = mojavez ;
        this.address = address ;
    }
        public override string Getinfo()
    {
        throw new NotImplementedException();
    }
}