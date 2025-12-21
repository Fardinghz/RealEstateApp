class Apartment : Property
{
    public int Metrage { get; set; }
    public int BuildYear { get; set; }       
    public int Tabaghe { get; set; }         
    public string BuildingName { get; set; }
    public string Address { get; set; }
    public int RoomNumber { get; set; }
    public bool Parking { get; set; }
    public bool Anbary { get; set; }          
    public bool Asansor { get; set; }         

    public Apartment(string price, string owner, string phoneNumber,
                     int metrage, int buildYear, int tabaghe, string buildingName,
                     string address, int roomNumber, bool parking, bool anbary, bool asansor)
    {
        this.Price = price;         
        this.Owner = owner;
        this.PhoneNumber = phoneNumber;

        Metrage = metrage;
        BuildYear = buildYear;
        Tabaghe = tabaghe;
        BuildingName = buildingName;
        Address = address;
        RoomNumber = roomNumber;
        Parking = parking;
        Anbary = anbary;
        Asansor = asansor;
    }

    public override string GetInfo()
    {
        return $"نوع: آپارتمان\n" +
               $"قیمت: {Price} میلیون تومان\n" +
               $"مالک: {Owner}\n" +
               $"تلفن: {PhoneNumber}\n" +
               $"متراژ: {Metrage} متر\n" +
               $"سال ساخت: {BuildYear}\n" +
               $"طبقه: {Tabaghe}\n" +
               $"نام ساختمان: {BuildingName}\n" +
               $"آدرس: {Address}\n" +
               $"تعداد اتاق: {RoomNumber}\n" +
               $"پارکینگ: {(Parking ? "دارد" : "ندارد")}\n" +
               $"انباری: {(Anbary ? "دارد" : "ندارد")}\n" +
               $"آسانسور: {(Asansor ? "دارد" : "دارد")}";
    }
}