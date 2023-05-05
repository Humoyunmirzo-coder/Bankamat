using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.NewFolder
{
    public class Bankomat 
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public Bankomat()
        {
            Id = 0;
            Address = "Tashkent";

        }
        public int password = 1122;
        public int Balans = 1000000;
        public void Methods()
        {

            Console.Write(" Enter Your Adres ");
            Console.WriteLine();
        }

        public void Enterpin()
        {
            Console.Write("   Enter Your Password: ");
            int password = int.Parse(Console.ReadLine());
            if (password == 1122)
            {
                SelectLanguage();
            }
            else
            {
                Console.WriteLine($" Your passwort eror ! \n Try again  :  "); Enterpin();
            }
        }
        public void Adress()
        {
            Console.Write("  Enter Your Adres:  ");
            int add = int.Parse(Console.ReadLine());
            if (add == 3211)
            {
                Enterpin();
            }
            else { Console.WriteLine(" Mistak  your adrees: "); Adress(); }
        }
        public void SelectLanguage()
        {
            Console.WriteLine(" Choose  a Language ! ");
            Console.WriteLine(" ____________");
            Console.WriteLine("|   1. UZB   |\n|   2. RUS   |\n|   3. ENG   |");
            Console.WriteLine(" ____________");
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                switch (number)
                {
                    case 1:
                        SelectOperation(); break;
                }
            }
            else { Console.WriteLine(" The operation did not lenguage ! \n Please else langauge choose! "); SelectLanguage(); }
        }
        public void SelectOperation()
        {

            Console.WriteLine("   1. Pul yechish\n   2. Balans tekshirish\n   3. Parol o'zgartirish\n   4. Valuta almashtirish \n   5. Tolovlar    ");
            int namber = int.Parse(Console.ReadLine());
            if (namber != 1 && namber != 2 && namber != 3 && namber != 4 && namber != 5)
            {
                Console.WriteLine(" Xato Raqam Kiritildi Iltimos Boshqattan Urinib Korin! ");
                SelectOperation();
            }
            switch (namber)
            {
                case 1:
                    Console.WriteLine($"  1.  50 000 sum  ");
                    Console.WriteLine($"  2. 100 000 sum ");
                    Console.WriteLine($"  3. 150 000 sum ");
                    Console.WriteLine($"  4. 200 000 sum ");
                    Console.WriteLine($"  5. 250 000 sum");
                    Console.WriteLine($"  6. 300 000 sum");
                    Console.WriteLine($"  7. 400 000 sum ");
                    Console.WriteLine($"  8. 500 000 sum");
                    Console.WriteLine($"  9. Boshqa summa kiritish  ");
                    Console.WriteLine($"  0. Orqaga qaytish  ");
                    int sum = int.Parse(Console.ReadLine());
                    switch (sum)
                    {
                        case 0:
                            SelectOperation();
                            break;
                        case 1:
                            Console.WriteLine("  Kartanggizdan  50 000 sum \n  Iltimos karta va pulni oling! "); break;
                        case 2:
                            Console.WriteLine("  Kartanggizdan  100 000 sum \n  Iltimos karta va pulni oling! "); break;
                        case 3:
                            Console.WriteLine("  Kartanggizdan  150 000 sum \n  Iltimos karta va pulni oling! "); break;
                        case 4:
                            Console.WriteLine("  Kartanggizdan  200 000 sum \n  Iltimos karta va pulni oling! "); break;
                        case 5:
                            Console.WriteLine("  Kartanggizdan  250 000 sum \n  Iltimos karta va pulni oling! "); break;
                        case 6:
                            Console.WriteLine("  Kartanggizdan  300 000 sum \n  Iltimos karta va pulni oling! "); break;
                        case 7:
                            Console.WriteLine("  Kartanggizdan  400 000 sum \n  Iltimos karta va pulni oling! "); break;
                        case 8:
                            Console.WriteLine("  Kartanggizdan  500 000 sum \n  Iltimos karta va pulni oling! "); break;
                        case 9:
                            Console.Write("  Boshqa Summa kiriting:   ");
                            int summab = int.Parse(Console.ReadLine());
                            Console.WriteLine($" Boshqa summa {summab} sum yechildi   \n Iltimos karta va pulni oling! \n  ");

                            break;
                    }
                    break;

                case 2:
                    Console.WriteLine($"Balansingizda  {Balans} summa bor! ");
                    Console.WriteLine(" 1. Orqaga qaytish:  \n  0. Kartani chiqarish:  ");
                    int son = int.Parse(Console.ReadLine());
                    if (son == 1) SelectOperation();
                    if (son == 0) break;
                    break;

                case 3:

                    Console.Write(" Xozirgi parol kiriting: ");
                    int pasword1 = int.Parse(Console.ReadLine());
                    if (password == pasword1)
                    {
                        Console.Write(" Yangi parol kiriting:   ");
                        int passvord = int.Parse(Console.ReadLine());
                        password = passvord;
                        Console.WriteLine(" Kod ozgartirildi! ");
                    }
                    else { Console.WriteLine(" Kod notogri  Iltimos boshqatan kiriting "); };
                    break;

                case 4:
                Abmen:
                    Console.WriteLine(" Valuta Almashtirish!   \n   Bugingi kurs USD = 1.140.000  ");
                    Console.WriteLine("   1. USD =>UZS   Almashtrish\n   2. UZS =>USD   Almashtirish\n   0. Orqaga qaytish ");
                    int number1 = int.Parse(Console.ReadLine());
                    if (number1 == 1)
                    {
                        Console.WriteLine(" $100 = 1140000 sumga   Almashtirildi! \n    Pul va Chekni Oling !  ");

                    }
                    if (number1 == 2)
                    {
                        Console.WriteLine(" 1140000 sum =  $100  ga Almashdi! \n Pul va Chekni Oling! ");
                    }
                    if (number1 == 0)
                    {
                        SelectOperation();
                    }
                    else
                    {
                        Console.WriteLine(" Xato raqam!  \n Iltimos qayta kiriting! ");
                        goto Abmen;
                    }
                    break;
                case 5:
                    Console.WriteLine(" Tolovlar! \n   1. Kamunal \n   2. Mobil \n   3. Talim");
                    int number2 = int.Parse(Console.ReadLine());
                    if (number2 == 1)
                    {
                        Console.WriteLine("   1. Elektir Energiya \n   2. Gaz \n   3. Ichimlik Suvi ");
                        int numbr = int.Parse(Console.ReadLine());
                        if (numbr == 1)
                        {
                        backto:
                            Console.Write(" Hudud  Shift Raqamini Kiriting: ");
                            int elektr = int.Parse(Console.ReadLine());
                            if (elektr > 99999 && elektr < 999999)
                            {
                                Console.WriteLine(" Summa kiriting:  ");
                                int summa = int.Parse(Console.ReadLine());
                                Console.WriteLine($" Hudud Shirift Raqamizga {summa} sum tolandi! ");
                                Console.WriteLine("   1. Orqaga\n   0. Dastirdan Chiqish ");
                                int num = int.Parse(Console.ReadLine());
                                /*     if (num == 1)
                                     { SelectOperation(); }*/
                                if (elektr! > 99999 && elektr! < 999999)
                                {
                                    Console.WriteLine(" Xato Raqam Kiritdinggiz Iltimos Qayta Urinib Ko'rin");
                                    goto backto;
                                }
                                else { break; }
                            }

                        }
                    }
                    if (number2 == 2)
                    {
                    refund:
                        Console.Write("   Hududizdagi Gaz Raqamini Kiriting:");
                        int gaz = int.Parse(Console.ReadLine());
                        if (gaz > 99999 && gaz < 999999)
                        {
                            Console.Write(" Tolanadigon Summa Kiriting: ");
                            int summa = int.Parse(Console.ReadLine());
                            Console.WriteLine($" Gaz hissob raqamizga {summa} Summa Qabul Qilindi!");
                            Console.WriteLine("   1. Orqaga\n   0. Dastirdan Chiqish ");
                            int num = int.Parse(Console.ReadLine());
                            /*   if (num == 1)
                               { SelectOperation(); }*/

                        }
                        else { break; }
                        if (gaz! > 99999 && gaz! < 999999)
                        {
                            Console.WriteLine(" Xato Raqam Kiritdinggiz Iltimos Qayta Urinib Ko'rin");
                            goto refund;
                        }
                    }
                    if (number2 == 3)
                    {
                    retreval:
                        Console.Write(" Suv Hisob Raqamini Kiriting: ");
                        int suv = int.Parse(Console.ReadLine());
                        if (suv > 9999 && suv < 99999)
                        {
                            Console.WriteLine("Summa Kiriting:  ");
                            int summa = int.Parse(Console.ReadLine());
                            Console.WriteLine($" Suv Hisob Raqamizga  {summa} Summa Qabul Qilindi ! ");
                            Console.WriteLine("   1. Orqaga\n   0. Dastirdan Chiqish ");
                            int num = int.Parse(Console.ReadLine());
                            /*  if (num == 1) SelectOperation();*/

                        }
                        else { break; }
                        if (suv! > 9999 && suv! < 99999)
                        {
                            Console.WriteLine(" Xato Raqam Kiritdinggiz Iltimos Qayta Urinib Ko'rin");
                            goto retreval;
                        }
                    }


                    break;




            }
        }



    }
}
