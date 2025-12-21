class Program
{
    static void Main(string[] args)
    {
        Property first = new Villa("22000", "فردین", "09111234567", 200, 100, 1399, 2, "سنگر آزادی", true);

        Console.WriteLine("اطلاعات اولیه:");
        Console.WriteLine(first.GetInfo()); 


        if (first is Villa villa) 
        {
            villa.Parking = false;          
            villa.Price = "28000";              
            villa.Owner = "علی احمدی";        
            villa.Address = "خیابان آزادی";   
            villa.LandMetrage = 250;       
            villa.RoomNumber = 4;           
        }
        else
        {
            Console.WriteLine("این ملک ویلا نیست!");
        }

        Console.WriteLine("\nاطلاعات بعد از تغییرات:");
        Console.WriteLine(first.GetInfo());

        Console.WriteLine("\nبرای بستن برنامه اینتر بزن...");
        Console.ReadLine();
    }
}