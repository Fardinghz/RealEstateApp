class Villa : Property
{
    public int LandMetrage { get; set; }
    public int BuildingMetrage { get; set; }
    public int BuildYear { get; set; }
    public int RoomNumber { get; set; }
    public string Address { get; set; }
    public bool Parking { get; set; }

    public Villa(string price, string owner, string phoneNumber,
                 int landMetrage, int buildingMetrage, int buildYear,
                 int roomNumber, string address, bool parking)
    {
        this.Price = price;      
        this.Owner = owner;
        this.PhoneNumber = phoneNumber;

        LandMetrage = landMetrage;
        BuildingMetrage = buildingMetrage;
        BuildYear = buildYear;
        RoomNumber = roomNumber;
        Address = address;
        Parking = parking;
    }

    public override string GetInfo()
    {
        return $"نوع: ویلا\n" +
               $"قیمت: {Price} میلیون تومان\n" +
               $"مالک: {Owner}\n" +
               $"تلفن: {PhoneNumber}\n" +
               $"متراژ زمین: {LandMetrage} متر\n" +
               $"متراژ بنا: {BuildingMetrage} متر\n" +
               $"سال ساخت: {BuildYear}\n" +
               $"تعداد اتاق: {RoomNumber}\n" +
               $"آدرس: {Address}\n" +
               $"پارکینگ: {(Parking ? "دارد" : "ندارد")}";
    }
}