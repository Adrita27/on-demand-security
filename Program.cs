using System;



namespace test
{
    class Program
    {
        static void Main(string[] args)
        {




            BUSHRA b1 = new BUSHRA();
            b1.SetName("ADRITA RAHMAN BUSHRA");
            b1.SetId("20-43367-1");
            b1.SetCgpa(3.76);
            b1.SetProgramme("Computer Science");
            b1.SetUniversity("AMERICAN INTERNATIONAL UNIVERSITY BANGLADESH");
            b1.display();




            BUSHRA b2 = new BUSHRA("ADRITA RAHMAN BUSHRA", "20-43367-1", 3.76,"AMERICAN INTERNATIONAL UNIVERSITY BANGLADESH" ,"Computer Science" );
            b2.display();
            BUSHRA b3 = new BUSHRA(b1);

            b3.display();
            Console.ReadLine();



        }
    }
}