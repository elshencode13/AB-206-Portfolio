#region Notes

//Tapşırıq 25:
//Yaratmış olduğunuz massivdəki elementləri əks sıralama ilə yeni massivə əlavə edib nəticəni çap edən proqramı yazın.

//Tapşırıq 26:
//Massivdə konkret ədədin olub-olmadığını yoxlayan və indexini çap edən proqramı yazın.(yoxdursa -1)

//Tapşırıq 27:
//Massivdə təkrarlanan elementləri tapıb, nəticəni çap edən proqramı yazın.(bütün təkrarlanan ədədlər)

//Tapşırıq 28:
//Massivdəki ikinci ən böyük elementi tapan və nəticəni çap edən proqramı yazın.

//Tapşırıq 29:
//Verilmiş N rəqəmli ədədin rəqəmləri cəmini tapan və nəticəni çap edən proqramı yazın.

//Tapşırıq 30:
//Verilmiş N rəqəmli ədədin rəqəmlərinin sayını tapan və nəticəni çap edən proqramı yazın.

//Tapşırıq 31:
//Verilmiş N rəqəmli ədədin sadə və ya mürəkkəb olduğunu tapan və nəticəni çap edən proqramı yazın.

//Tapşırıq 32:
//Verilmiş N rəqəmli ədədin Palindrome olub-olmamasını yoxlayan və nəticəni çap edən proqramı yazın.




#endregion
#region Tapsiriq_1

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {

//        int Birinci_eded = 13;
//        int Ikinci_eded = 7;

//        Console.WriteLine(Birinci_eded + Ikinci_eded);
//    }
//}


#endregion
#region Tapsiriq_2
//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {

//        int eded = 4;
//        int hasil = eded * eded;
//        Console.WriteLine(hasil);
//    }
//} 


#endregion
#region Tapsiriq_3
//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        string name = "Elşen";
//        int age = 20;
//        Console.WriteLine("Salam,menim adim "+name+"dir "+"ve menim "+age+" yasim var.");


//    }
//}


#endregion
#region Tapsiriq_4
//using System.Runtime.ConstrainedExecution;

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int a = 10;
//        int b = 20;
//        int c;
//        c = a;
//        a = b;
//        Console.WriteLine("a dəyişəninin əvvəlki dəyəri "+c +", yer dəyişmədən sonra "+a+" - dir.");
//        b = c;
//        c = a;
//        Console.WriteLine("b dəyişəninin əvvəlki dəyəri " + c + ", yer dəyişmədən sonra " + b + " - dir.");

//        //a dəyişəninin əvvəlki dəyəri 10, yer dəyişmədən sonra 20 - dir.
//        //b dəyişəninin əvvəlki dəyəri 20, yer dəyişmədən sonra 10 - dur.
//    }
//}


#endregion
#region Tapsiriq_5
//using System.Runtime.ConstrainedExecution;

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Birinci ededi daxil edin:");
//        int birinci_eded = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Ikinci ededi daxil edin:");
//        int ikinci_eded = Convert.ToInt32(Console.ReadLine());
//        Console.Write("Ucuncu ededi daxil edin:");
//        int ucuncu_eded = Convert.ToInt32(Console.ReadLine());

//        int cemi = birinci_eded + ikinci_eded + ucuncu_eded;
//        int ededi_orta = cemi / 3;
//        Console.WriteLine(cemi);
//        Console.WriteLine(ededi_orta);
//    }
//}


#endregion
#region Tapsiriq_6

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Dordreqemli ededi daxil edin: ");
//        int eded =Convert.ToInt32(Console.ReadLine());
//        int cemi = 0;

//        while (eded>0)
//        {
//           int i = eded % 10;
//           cemi = cemi + i;
//           eded =  eded / 10;
//        }
//        Console.WriteLine(cemi);
//    }
//}


#endregion
#region Tapsiriq_7

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {

//        Console.Write("bir eded daxil edin: ");
//        int eded =Convert.ToInt32(Console.ReadLine());

//        if (eded % 2 == 0)
//        {
//            Console.WriteLine("Daxil edilen eded cutdur.");

//        }
//        else
//        {
//            Console.WriteLine("Daxil edilen eded tekdir.");
//        }

//    }
//}


#endregion
#region Tapsiriq_8

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {

//        Console.Write("Birinci ededi daxil edin: ");
//        int birinci =Convert.ToInt32(Console.ReadLine());
//        Console.Write("ikinci ededi daxil edin: ");
//        int ikinci = Convert.ToInt32(Console.ReadLine());

//        if (birinci>ikinci)
//        {
//            Console.WriteLine("Birinci eded ikinciden boyukdur.");
//        }
//        else if (ikinci>birinci)
//        {
//            Console.WriteLine("ikinci eded birinciden boyukdur.");
//        }
//        else
//        {
//            Console.WriteLine("Bu ededler beraberdir.");
//        }
//    }
//}


#endregion
#region Tapsiriq_9

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {

//        Console.Write("Ededi daxil edin: ");
//        int eded = Convert.ToInt32(Console.ReadLine());

//        if (eded > 0)
//        {
//            Console.WriteLine("Bu eded musbetdir.");
//        }
//        else if (eded < 0)
//        {
//            Console.WriteLine("Bu eded menfidir.");
//        }
//        else
//        {
//            Console.WriteLine("Bu eded sifirdir");
//        }
//    }
//}


#endregion
#region Tapsiriq_10

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {

//        Console.Write("Ededi daxil edin: ");
//        int eded = Convert.ToInt32(Console.ReadLine());


//        if (eded % 3 == 0 & eded % 5 == 0)
//        {
//            Console.WriteLine("Bu eded hem 3,hem de 5 bolunur.");
//        }
//        else
//        {
//            Console.WriteLine("Bu eded ne 3, ne de 5 bolunur.");
//        }
//    }
//}


#endregion
#region Tapsiriq_11

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {

//        Console.Write("Ededi daxil edin: ");
//        int eded = Convert.ToInt32(Console.ReadLine());


//        if (eded % 3 == 0 & eded % 2 == 0)
//        {
//            Console.WriteLine("Bu eded hem 3,hem de 2 bolunur.");
//        }
//        else if (eded % 3 == 0 || eded % 2 == 0)
//        {
//            Console.WriteLine("Bu eded 2-ye ve ya 3-e bolunur");
//        }
//        else
//        {
//            Console.WriteLine("Bu eded ne 2-ye,nede 3-e bolumur.");
//        }
//    }
//}


#endregion
#region Tapsiriq_12

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Ayin nomresini daxil edin:");
//        int ay =Convert.ToInt32(Console.ReadLine());

//        switch(ay){
//            case 1:
//                Console.WriteLine("Yanvar");
//                break;
//            case 2:
//                Console.WriteLine("Fevral");
//                break;
//            case 3:
//                Console.WriteLine("Mart");
//                break;
//            case 4:
//                Console.WriteLine("Aprel");
//                break;
//            case 5:
//                Console.WriteLine("May");
//                break;
//            case 6:
//                Console.WriteLine("Iyun");
//                break;
//            case 7:
//                Console.WriteLine("Iyul");
//                break;
//            case 8:
//                Console.WriteLine("Avqust");
//                break;
//            case 9:
//                Console.WriteLine("Sentyabr");
//                break;
//            case 10:
//                Console.WriteLine("Oktyabr");
//                break;
//            case 11:
//                Console.WriteLine("Noyabr");
//                break;
//            case 12:
//                Console.WriteLine("Dekabr");
//                break;
//            default:
//                Console.WriteLine("Ayin nomresini duzgun daxil etmemisiniz.");
//                break;
//        }

//    }
//}


#endregion
#region Tapsiriq_13

//using System;

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Imtahan balinizi daxil edin:");
//        int bal = Convert.ToInt32(Console.ReadLine());

//        if (bal < 51)
//        {
//            Console.WriteLine("F");
//        }
//        else if (bal < 61)
//        {
//            Console.WriteLine("E");
//        }
//        else if (bal < 71)
//        {
//            Console.WriteLine("D");
//        }
//        else if (bal < 81)
//        {
//            Console.WriteLine("C");
//        }
//        else if (bal < 91)
//        {
//            Console.WriteLine("B");
//        }
//        else if (bal <= 100)
//        {
//            Console.WriteLine("A");
//        }
//        else
//        {
//            Console.WriteLine("Balin qiymetini duzgun daxil edin.");
//        }

//    }
//}


#endregion
#region Tapsiriq_14

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Birinci ededi daxil edin:");
//        int birinci_eded = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Ikinci ededi daxil edin:");
//        int ikinci_eded = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Emeliyyati daxil edin:");
//        Char hesab = Convert.ToChar(Console.ReadLine());

//        if (hesab == '+')
//        {
//            Console.WriteLine(birinci_eded + ikinci_eded);
//        }
//        else if (hesab == '-')
//        {
//            Console.WriteLine(birinci_eded - ikinci_eded);
//        }
//        else if (hesab == '/')
//        {
//            Console.WriteLine(birinci_eded / ikinci_eded);
//        }
//        else if (hesab == '*')
//        {
//            Console.WriteLine(birinci_eded * ikinci_eded);
//        }
//        else
//        {
//            Console.WriteLine("Emeliyyati duzgun daxil edmemisiniz.");
//        }

//    }
//}


#endregion
#region Tapsiriq_15

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Meblegi daxil edin:");
//        int mebleg = Convert.ToInt32(Console.ReadLine());

//        if (mebleg < 50)
//        {

//            Console.WriteLine("Endirim yoxdur.");
//        }
//        else if (mebleg >= 50 & mebleg < 100) 
//        {
//            int endirim = mebleg - (mebleg / 5);
//            Console.WriteLine("Endirimli qiymet: Alinan mehsulun deyeri: "+mebleg+ " Odeyeceyiniz mebleg: "+ endirim+ " (5 % endirim)");

//        }
//        else if(mebleg >= 100)
//        {
//            int endirim = mebleg - (mebleg / 10);
//            Console.WriteLine("Endirimli qiymet: Alinan mehsulun deyeri: " + mebleg + " Odeyeceyiniz mebleg: " + endirim + " (10 % endirim)");
//        }
//    }
//}


#endregion
#region Tapsiriq_16

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Username: ");
//        string username = Console.ReadLine();
//        Console.Write("Password: ");
//        int password = Convert.ToInt32(Console.ReadLine());

//        if (username == "admin" & password == 2222)
//        {
//            Console.WriteLine("Login accepted!");
//        }
//        else
//        {
//            Console.WriteLine("Access denied!");
//        }


//    }

//}


#endregion
#region Tapsiriq_17

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Meblegi daxil edin: ");
//        double mebleg = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Valyutani daxil edin(USD ve ya AZN):");
//        string valyuta = (Console.ReadLine());

//        if (valyuta == "AZN")
//        {
//            mebleg /= 1.7;
//            Console.WriteLine(mebleg);
//        }
//        else if (valyuta == "USD")
//        {
//            mebleg *= 1.7;
//            Console.WriteLine(mebleg);
//        }
//        else
//        {
//            Console.WriteLine("Valyutani duzgun daxil edin");
//        }

//    }
//}


#endregion
#region Tapsiriq_18

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Cekinizi daxil edin(kg): ");
//        double ceki = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Boyunuzu daxil edin(metr ile): ");
//        int boy = Convert.ToInt32(Console.ReadLine());

//        if (boy < 160)
//        {
//            if (ceki < 18.5)
//            {
//                Console.WriteLine("Ceki azligi");
//            }
//            else if (ceki >= 18.5 & ceki < 24.9)
//            {
//                Console.WriteLine("Normal ceki");
//            }
//            else if( ceki >= 25 & ceki >= 29.9 )
//            {
//                Console.WriteLine("Artiq ceki");
//            }
//            else if(ceki >= 30)
//            {
//                Console.WriteLine("Piyleme");
//            }

//        }
//    }
//}


#endregion
#region Tapsiriq_19 

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Sifrenizi daxil edin: ");
//        int sifre = Convert.ToInt32(Console.ReadLine());
//        double balans =0.99;

//        if (sifre == 1234)
//        {
//            Console.Write("Xos gelmisiniz! \n 1-Balansi goster \n 2-Vesait elave et \n 3-Mexaric et  \nEmeliyyatinizin nomresini daxil edin: ");
//            int num = Convert.ToInt32(Console.ReadLine());

//            if (num == 1)
//            {
//                Console.WriteLine("Balans: "+ balans);
//            }
//            else if (num == 2)
//            {
//                Console.Write("Daxil edilecek mebleg: ");
//                int medaxil = Convert.ToInt32(Console.ReadLine());
//                if (medaxil <= 0)
//                {
//                    Console.WriteLine("Vesaiti duzgun daxil edin! ");
//                }
//                Console.WriteLine("Balans: " + medaxil + balans);
//            }
//            else if (num == 3)
//            {
//                Console.Write("Cixaris edilecek mebleg: ");
//                int mexaric = Convert.ToInt32(Console.ReadLine());
//                if(balans < mexaric)
//                {
//                    Console.WriteLine("Mexaric balansdan coxdur");
//                }
//                Console.WriteLine("Balans: "+( balans - mexaric));
//            }
//            else 
//            {
//                Console.WriteLine("Emeliyyatinizin nomresini duzgun daxil edin!");
//            }
//        }



//        //Tapşırıq 19:
//        //Aşağıdaki funksionallıqlara sahib olan ATM proqramı yazılsın.
//        //İstifadəçinin ilkin balansı müəyyən edilsin.
//        //İstifadəçi balansı yoxlaya bilsin, vəsait əlavə edə bilsin, pul çıxara bilsin.
//        //(məbləğ mənfi olmamalı, çıxarılan məbləğ balansdan çox olmamalıdır və s.yoxlamalar aparın).
//    }
//}


#endregion
#region Tapsiriq_20

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int[] array = { 1, 2, 3 };

//        foreach (int i in array)
//        {
//            Console.WriteLine(i);
//        }


//        //        Tapşırıq 20:
//        //Yaratmış olduğunuz massivin elementlərini ekrana çap edən proqram yazın.
//    }
//}


#endregion
#region Tapsiriq_21

//using System.Diagnostics.Metrics;

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int[] array = { 1, 2, 3, 4, 5, };
//        int cem = 0;

//        foreach (int i in array)
//        {
//           cem += i;
//        }

//        Console.WriteLine(cem);

////        Tapşırıq 21:
////Yaratmış olduğunuz massivin bütün elementlərin cəmini hesablayıb nəticəni çap edən proqramı yazın.
//    }
//}


#endregion
#region Tapsiriq_22 

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {

//        int[] array = { 1, 2, 3, 4, 5, };
//        int ededi_ortasi = 0;
//        int cem = 0;

//        for (int i = 0; i < array.Length; i++)
//        {

//            cem += array[i];
//        }
//        ededi_ortasi = cem / array.Length;

//        Console.WriteLine(ededi_ortasi);
//        //        Tapşırıq 22:
//        //Yaratmış olduğunuz integer massivdə olan elementlərin ortalamasını hesablayıb nəticəni çap edən proqramı yazın.

//    }
//}


#endregion
#region Tapsiriq_23

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int[] array = { 12, 13, 45, 47, 30 };
//        int maxvalue = int.MinValue;
//        int minvalue = int.MaxValue;
//        int maxvalueindex = 0;
//        int minvalueindex = 0;

//        for (int i = 0; i < array.Length; i++)
//        {
//            if (maxvalue < array[i])
//            {
//                maxvalue = array[i];
//                maxvalueindex = i;

//            }
//        }
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (minvalue > array[i])
//            {
//            minvalue = array[i];
//            minvalueindex = i;


//            }

//        }
//        Console.WriteLine("Massivin maximum elementi: "+maxvalue+" indexi: "+maxvalueindex);
//        Console.WriteLine("Massivin minimum elementi: " + minvalue + " indexi: " + minvalueindex);

//        //        Tapşırıq 23:
//        //Yaratmış olduğunuz integer massivdə olan ən böyük və ən kiçik elementləri index-i ilə birgə çap edən proqramı yazın.

//    }
//}


#endregion
#region Tapsiriq_24

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int[] array = { 1, 2, 3, 4, 5, };

//        for (int i = 0; i < array.Length; i++)
//        { 
//        if (array[i] % 2 == 0)
//            {
//                Console.WriteLine(array[i]);
//            }
//        }

//        //Tapşırıq 24:
//        //Yaratmış olduğunuz integer massivdə olan cüt ədədləri çap edən proqramı yazın.
//    }
//}


#endregion
#region Tapsiriq_25bitmeyib

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int[] array = { 1, 2, 3, 4, 5};

//        for (int i = 0; i < array.Length; i++)
//        {
//          int[] new array  array[i];
//        }

//        //Tapşırıq 25:
//        //Yaratmış olduğunuz massivdəki elementləri əks sıralama ilə yeni massivə əlavə edib nəticəni çap edən proqramı yazın.
//    }
//}


#endregion
#region Tapsiriq_26bitmeyib

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {

//        //Tapşırıq 26:
//        //Massivdə konkret ədədin olub-olmadığını
//        //yoxlayan və indexini çap edən proqramı yazın.(yoxdursa -1)
//    }
//}


#endregion
#region Tapsiriq_27bitmeyib

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {

//        int Birinci_eded = 13;
//        int Ikinci_eded = 7;

//        Console.WriteLine(Birinci_eded + Ikinci_eded);
//    }
//}


#endregion
#region Tapsiriq_28 biymeyib

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {

//        //Tapşırıq 28:
//Massivdəki ikinci ən böyük elementi tapan və nəticəni çap edən proqramı yazın.
//    }
//}


#endregion
#region Tapsiriq_29

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Ededi daxil edin: ");
//        int num =Convert.ToInt32(Console.ReadLine());
//        int cem = 0;

//        while (num > 0)
//        {
//            cem += num % 10;
//            num /= 10;
//        }
//        Console.WriteLine(cem);
//        //Tapşırıq 29:
//        //Verilmiş N rəqəmli ədədin rəqəmləri cəmini tapan və nəticəni çap edən proqramı yazın.
//    }
//}


#endregion
#region Tapsiriq_30

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {

//        Console.Write("Ededi daxil edin: ");
//        int num = Convert.ToInt32(Console.ReadLine());
//        int count = 0;

//        while (num > 0)
//        {

//            num /= 10;
//            count++;
//        }
//        Console.WriteLine(count);

//        //Tapşırıq 30:
//        //Verilmiş N rəqəmli ədədin rəqəmlərinin sayını tapan və nəticəni çap edən proqramı yazın.
//    }
//}


#endregion
#region Tapsiriq_31bitirmeliyik

//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Ededi daxil edin: ");
//        int num = Convert.ToInt32(Console.ReadLine());

//        if (num % num == 0 || num % 1 == 0 & num % 2 != 0 )
//        {
//            Console.WriteLine("Daxil edilen eded sade ededdir");
//        }
//        else
//        {
//            Console.WriteLine("Daxil edilen eded murekkeb ededdir");
//        }

//        //Tapşırıq 31:
//        //Verilmiş N rəqəmli ədədin sadə və ya mürəkkəb olduğunu tapan və nəticəni çap edən proqramı yazın.

//    }
//}


#endregion
#region Tapsiriq_33 ?


//namespace C__Basic_Project;

//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Ededi daxil edin: ");
//        int num = Convert.ToInt32(Console.ReadLine());
//        int a = 0;
//        int b = 1;
//        int c;
        
//        for (int i = 0; i < num; i++)
//        {
//            c = a + b;
//            a = b;
//            b = c;

//            Console.WriteLine(c);
//        }
        


            
        

//        //Tapşırıq 33:
//        //Fibonaçi ədədlərindən ilk N həddini tapan və çap edən proqramı yazın.

//    }
//}


#endregion