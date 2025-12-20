class Land : Property
{
    public int Metrage { get; set; }         
    public bool Mojavez { get; set; }            
    public string Address { get; set; }

    public Land(int price, string owner, string phoneNumber,
                int metrage, bool mojavez, string address)
    {
        this.Price = price;             
        this.Owner = owner;
        this.PhoneNumber = phoneNumber;

        Metrage = metrage;
        Mojavez = mojavez;
        Address = address;
    }

    public override string GetInfo()
    {
        return $"نوع: زمین\n" +
               $"قیمت: {Price} میلیون تومان\n" +
               $"مالک: {Owner}\n" +
               $"تلفن: {PhoneNumber}\n" +
               $"متراژ: {Metrage} متر مربع\n" +
               $"مجوز ساخت: {(Mojavez ? "دارد" : "ندارد")}\n" +
               $"آدرس: {Address}";
    }
}