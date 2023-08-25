using System;

namespace IkaKysely
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Syötä ikäsi: ");
                int ikä = int.Parse(Console.ReadLine());

                // Luodaan viesti käyttäen string interpolation -ominaisuutta
                string viesti = $"{ikä} – näytät ikäistäsi nuoremmalta";

                // Tulostetaan viesti konsoliin
                Console.WriteLine(viesti);
            }
            catch (FormatException)
            {
                // Jos syöte ei ole kelvollinen kokonaisluku, tulostetaan virheviesti
                Console.WriteLine("Virheellinen syöte. Syötä kokonaisluku ikäsi.");
            }
        }
    }
}
