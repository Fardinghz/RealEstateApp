class Villa : Property
{
    public int LandMetrage {get; set;}
    public int BuildingMetrage {get; set;}
    public int BuildYear {get; set;}
    public int RoomNumber {get; set;}
    public string Address {get; set;}
    public bool Parking {get; set;}

    public Villa(int price , string owner , int phoneNumber , int LandMetrage , int BuildingMetrage , int BuildYear , int RoomNumber ,
    string Address , bool Parking)
    : base(price , owner , phoneNumber)
    {
        this.LandMetrage = LandMetrage;
        this.BuildingMetrage = BuildingMetrage;
        this.BuildYear =BuildYear;
        this.RoomNumber = RoomNumber;
        this.Address =Address;
        this.Parking = Parking;
    }

    public override string Getinfo()
    {
            return $"Villa | Price: {price}, Owner: {owner}, Phone: {phoneNumber}, " +
               $"Land: {LandMetrage}, Building: {BuildingMetrage}, Year: {BuildYear}, " +
               $"Rooms: {RoomNumber}, Address: {Address}, Parking: {Parking}";
    }
}