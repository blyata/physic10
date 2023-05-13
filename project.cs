using System.Diagnostics.Metrics;

Console.Write("Did You Read User Manual ? (y,n) : ");
string UM = Console.ReadLine();
Console.WriteLine();
if (UM == "y")
{
    Console.Write("Select Your APP (1-15) : ");
    int APP = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (APP == 1)
    {
        Console.WriteLine("Bordar Jabejaeei (2x) (m/s) ");
        Console.WriteLine();
        Console.Write("Enter x1 (m) : ");
        int x1 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter t1 (s) : ");
        int t1 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter x2 (m) : ");
        int x2 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter t2 (s) : ");
        int t2 = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int delx;
        int delt;
        int v_;

        delx = (x2 - x1);
        if (x2 > x1)
        {
            delx = (x2 + x1);
        }
        delt = (t2 - t1);
        v_ = (delx / delt);

        Console.Write("Delta x is : " + delx + "m");
        Console.WriteLine();
        Console.Write("Delta t is : " + delt + "s");
        Console.WriteLine();
        Console.Write("Average Speed (Sorate Motevaset) is : " + v_ + "m/s");
        Console.WriteLine();
    }
    else if (APP == 2)
    {
        Console.WriteLine("Average Speed / Time Passed");
        Console.WriteLine();
        Console.Write("Enter Average Speed (Sorate Motevaset) : ");
        int v__2 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter Time Passed : ");
        int delt_2 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int delx_2 = (v__2 * delt_2);
        Console.WriteLine("Passed Distance : " + delx_2);
    }
    else if (APP == 3)
    {
        Console.WriteLine("Average Speed / Distance Passed");
        Console.WriteLine();
        Console.Write("Enter Average Speed (Sorate Motevaset) : ");
        int v__3 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter Distance Passed : ");
        int delx_3 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int delt_3 = (v__3 / delx_3);
        if (v__3 < delx_3)
        {
            delt_3 = (delx_3 / v__3);
        }
        Console.WriteLine("Passed Times : " + delt_3);

    }
    else if (APP == 4)
    {
        Console.WriteLine("Times Passed / Distance Passed");
        Console.WriteLine();
        Console.Write("Enter Distance Passed : ");
        int delx_4 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter Times Passed : ");
        int delt_4 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int v__4 = (delx_4 / delt_4);
        Console.WriteLine("Average Speed (Sorate Motevaset) : " + v__4);


    }
    else if (APP == 5)
    {
        Console.WriteLine("Convert m and s to km and h");
        Console.WriteLine();
        Console.Write("Enter m : ");
        int m5 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter s : ");
        int s5 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        double km5 = ((float)m5 / 1000);
        double h5 = ((float)s5 / 3600);
        Console.WriteLine("m is : " + (float)km5 + "km");
        Console.WriteLine("s is : " + (float)h5 + "h");
    }
    else if (APP == 6)
    {
        Console.WriteLine("Convert km and h to m and s");
        Console.WriteLine();
        Console.Write("Enter km : ");
        int km_6 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter h : ");
        int h_6 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        double m_6 = ((float)km_6 * 1000);
        double s_6 = ((float)h_6 * 3600);
        Console.WriteLine("km is : " + (float)m_6 + "m");
        Console.WriteLine("h is : " + (float)s_6 + "s");

    }
    else if (APP == 7)
    {
        Console.WriteLine("Convert m/s to km/h");
        Console.WriteLine();
        Console.Write("Enter m/s : ");
        int m_s7 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int km_h7 = ((m_s7 * 3600) / 1000);
        Console.WriteLine("Output is : " + km_h7 + "km/h");
    }    
    else if (APP == 8)
    {
        Console.WriteLine("Convert km/h to m/s");
        Console.WriteLine();
        Console.Write("Enter km/h : ");
        int km_h8 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int m_s8 = ((km_h8 * 1000) / 3600);
        Console.WriteLine("Output is : " + m_s8 + "m/s");
        Console.ReadKey();

    }
    else if (APP == 9)
    {
        Console.WriteLine("Instataneous Speed (Sorate Lahze-e)");
        Console.WriteLine();
        Console.Write("Enter x0 (m) : ");
        int x0_9 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter v (m/s) : ");
        int v_9 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Moadele Makan-Zaman : x=" + v_9 + "t" + "+" + x0_9);
        Console.WriteLine();
        Console.Write("Enter t (s) : ");
        int t_9 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int x1_9 = (v_9 * t_9 + x0_9);
        Console.WriteLine("x1 is : " + x1_9 + "m");

    }
    else if (APP == 10)
    {
        Console.WriteLine("Average Acceleration (Shetabe Motevaset)");
        Console.WriteLine();
        Console.Write("Enter v0 : ");
        int v0_10 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter Delta t : ");
        int delt_10 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter v1 : ");
        int v1_10 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int delv_10 = (v1_10 - v0_10);
        int a__10 = (delv_10 / delt_10);
        Console.WriteLine("Delta v is : " + delv_10 + "m/s");
        Console.WriteLine();
        Console.WriteLine("Average Acceleration : " + a__10 + " m/s2");

    }
    else if (APP == 11)
    {
        Console.WriteLine("Fixed acceleration (Shetab Saabet)");
        Console.WriteLine();
        Console.Write("Enter your v0 : ");
        int v0_11 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter a (m/s2) : ");
        int a_11 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Moadele Sorat-Zaman is : " + "V=" + a_11 + "t+" + v0_11);
        Console.WriteLine();
        Console.Write("Enter t : ");
        int t_11 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int v1_11 = (a_11 * t_11) + v0_11;
        Console.WriteLine("v1 is  : " + v1_11);
    }
    else if (APP == 12)
    {
        Console.WriteLine("Mass in Other Planets");
        Console.WriteLine();
        Console.Write("Enter Mass (Vazn) (kg) : ");
        int w_12 = int.Parse(Console.ReadLine());
        int ww_12 = w_12 * 10;
        Console.WriteLine();
        Console.WriteLine("  choose your desired planet in the solar system\t " +
            "  for example :\n " +
            " \n" +
            " , 1.MERIKH\a\n , 2.ZOHAL\a\n , 3.MAH\a\n , 4.MOSHTARI\a\n , 5.ATAROD\a\n , 6.ZOHRE\a\n , 7.ORANOS\a\n , 8.NEPTON\a\n , 9.PLUTO\a\n , 10.SUN\a\n");

        Console.Write("Your Choice : ");
        int planet_12 = int.Parse(Console.ReadLine());
        Console.WriteLine();

        int merikh_12 = 4;
        int zohal_12 = 11;
        int mah_12 = 2;
        int moshtari_12 = 25;
        int atarod_12 = 4;
        int zohre_12 = 9;
        int oranos_12 = 9;
        int nepton_12 = 11;
        int pluto_12 = 1;
        int sun_12 = 270;

        if (planet_12 == 1)
        {
            Console.WriteLine("Your Mass in Merikh is : " + (ww_12 / merikh_12) + "kg");
        }
        else if (planet_12 == 2)
        {
            Console.WriteLine("Your Mass in Zohal is : " + (ww_12 / zohal_12) + "kg");
        }
        else if (planet_12 == 3)
        {
            Console.WriteLine("Your Mass in Mah is : " + (ww_12 / mah_12) + "kg");
        }
        else if (planet_12 == 4)
        {
            Console.WriteLine("Your Mass in Moshtari is : " + (ww_12 / moshtari_12) + "kg");
        }
        else if (planet_12 == 5)
        {
            Console.WriteLine("Your Mass in Atarod is : " + (ww_12 / atarod_12) + "kg");
        }
        else if (planet_12 == 6)
        {
            Console.WriteLine("Your Mass in Zohre is : " + (ww_12 / zohre_12) + "kg");
        }
        else if (planet_12 == 7)
        {
            Console.WriteLine("Your Mass in Oranos is  : " + (ww_12 / oranos_12) + "kg");
        }
        else if (planet_12 == 8)
        {
            Console.WriteLine("Your Mass in Nepton is : " + (ww_12 / nepton_12) + "kg");
        }
        else if (planet_12 == 9)
        {
            Console.WriteLine("Your Mass in Pluto is : " + (ww_12 / pluto_12) + "kg");
        }
        else if (pluto_12 == 10)
        {
            Console.WriteLine("Your Mass in Sun is :" + (ww_12 / sun_12) + "kg");
        }
    }
    else if (APP == 13)
    {
        Console.WriteLine("Covert m.g to N (Niroye Amodi Tekyegah)");
        Console.WriteLine();
        Console.Write("Enter m (kg) : ");
        int m_13 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter g : ");
        int g_13 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int N_13 = m_13 * g_13;
        Console.WriteLine("N is : " + N_13 + "N");
    }
    else if (APP == 14)
    {
        Console.WriteLine("Static friction (Estekak Istaei)");
        Console.WriteLine();
        Console.Write("Enter m (kg) : ");
        int m_14 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter g : ");
        int g_14 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter Us (Zarib Estekak Istaei) : ");
        float Us_14 = float.Parse(Console.ReadLine());
        Console.WriteLine();
        int N_14 = m_14 * g_14;
        float fsmax_14 = N_14 * Us_14;
        Console.WriteLine("Fsmax is : " + fsmax_14 + "N");
    }    
    else if (APP == 15)
    {
        Console.WriteLine("Kinetic friction (Estekak Jonbeshi)");
        Console.WriteLine();
        Console.Write("Enter F (N) : ");
        int F_15 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter m (kg) : ");
        int m_15 = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter g : ");
        float g_15 = float.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter Uk (Zarib Estekak Jonbeshi) : ");
        float Uk_15 = float.Parse(Console.ReadLine());
        Console.WriteLine();
        float N_15 = (m_15 * g_15);
        float fk_15 = (Uk_15 * N_15);
        float a_15 = (F_15 - fk_15) / m_15;
        Console.WriteLine("a is : " + a_15 + " m/s2");
    }
    else if (APP <= 16)
    {
        Console.WriteLine("Wrong Choice");
        System.Environment.Exit(0);
    }
}
if (UM == "n")
{
    Console.WriteLine("Please Open User Manual PDF Document and Try Again");
    System.Environment.Exit(0);
}
Console.ReadKey();
