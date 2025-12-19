class Apartment : Property
{
    public int Metrage {get; set;}
    public int buildYear {get; set;}
    public int tabaghe {get; set;}
    public string buildingName {get; set;}
    public string address {get; set;}
    public int roomNumber {get; set;}
    public bool parking {get; set;}
    public bool anbary {get; set;}
    public bool asansor {get; set;}

    public Apartment(int price, string owner, int phoneNumber,int metrage , int buildYear, int tabaghe, string buildingName , 
    string address , int roomNumber , bool parking , bool anbary , bool asansor) 
    : base(price, owner, phoneNumber)
    {
        this.Metrage= metrage;
        this.buildYear = buildYear;
        this.tabaghe =tabaghe;
        this.buildingName = buildingName;
        this.address = address;
        this.roomNumber = roomNumber;
        this.parking = parking;
        this.anbary = anbary;
        this.asansor =asansor;



    }
        public override string Getinfo()
    {
        throw new NotImplementedException();
    }

}