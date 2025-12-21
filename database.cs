// فایل: Database.cs  ← فقط کلاس دیتابیس، بدون Main
using System;
using MySqlConnector;

public static class Database
{
    private static readonly string ConnectionString = 
        "Server=localhost;" +
        "Database=realestate;" +
        "User=root;" +
        "Password=93627475;";  // رمز خودت

    public static void TestConnection()
    {
        try
        {
            using var connection = new MySqlConnection(ConnectionString);
            connection.Open();

            Console.WriteLine("اتصال به دیتابیس realestate با موفقیت برقرار شد!");
            Console.WriteLine("از کلاس جداگانه Database فراخوانی شد.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("خطا در اتصال:");
            Console.WriteLine(ex.Message);
        }
    }
}