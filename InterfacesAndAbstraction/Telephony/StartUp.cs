using System;
using System.Linq;
using System.Threading.Channels;
using Telephony.Models;
using Telephony.Models.Interfaces;

namespace Telephony;

public class StartUp
{
    public static void Main()
    {
        var phones = ReadInput();
        var urls = ReadInput();

        foreach ( var phone in phones )
        {
            if(IsValidPhoneNumber(phone))
            {
                ICaller phoneI;
                if(phone.Length == 7) 
                {
                    phoneI = new StationaryPhone();
                    phoneI.Call(phone);

                }
                else
                {
                    phoneI = new SmartPhone();
                    phoneI.Call(phone);
                }
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }

        foreach ( var url in urls )
        {
            if (IsUrlValid(url))
            { 
                SmartPhone smartPhone = new SmartPhone();
                smartPhone.Browse($"{url}!");
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }
        }
    }

    private static bool IsUrlValid(string url)
    {
        return !url.Any(char.IsDigit);
    }

    private static bool IsValidPhoneNumber(string phone)
    {
        return phone.All(char.IsDigit);  
    }

    private static string[] ReadInput()
    {
        return Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    }
}
