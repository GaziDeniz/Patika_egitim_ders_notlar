using System;
namespace arayuzler
{
    class Program
    {
        static void Main(string[] args)
        {
            SmsLogger smslog=new SmsLogger();
            smslog.WriteLog();

            FileLogger filelog =new FileLogger();
            filelog.WriteLog();

            DatabaseLogger databaselog=new DatabaseLogger();
            databaselog.WriteLog();

            //Buraya kadar oluşturduğumuz sınıflar(sms database file) ilogger ile buşekilde kullanılıyor

            //Bunun farklı bir şekilde kullanımı şu şekkilde olur;
            //-->LogManager isminde baska bir cs dosyası oluşturarak...

            LogManager logman=new LogManager(new SmsLogger());
            logman.WriteLog();
        }
    }
}