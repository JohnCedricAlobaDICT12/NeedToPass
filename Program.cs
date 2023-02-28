﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTimeKeeping_Final_Project
{
    internal class Program
    {
        static void Greeting_Head() {
            Console.WriteLine(" ");
            Console.WriteLine("||================================||");
            Console.WriteLine("|| REG. HOURS:   8:00 AM-5:00 PM  ||");
            Console.WriteLine("||================================||");
        }
        static void Greeting_Body() {
            Console.WriteLine("||================================||");
            Console.WriteLine("|| MORE THAN 30 MINUTES IS LATE   ||");
            Console.WriteLine("|| WITH MINUS 1 HOUR BREAK        ||");
            Console.WriteLine("|| COMPANY HOURS  8:00 AM-5:00 PM ||");
            Console.WriteLine("||================================||");
        }
        static void Greeting_Function()
        {
            Console.WriteLine("||================================||");
            Console.WriteLine("||  Good Moring, You're On Time   ||");
            Console.WriteLine("||================================||");
        }// GOODS
        static void Late_Function(string AM, int hr1, int mn1)
        {
            if (AM == "AM")
            {
                if (hr1 > 8)
                {
                    if (mn1 >= 1 )
                    {
                        // ************ CONSTANT VALUE ************
                        int inhrs = hr1 * 60;
                        int in_hrs = inhrs + mn1;
                        //----------------Total Late----------------
                        int BreakSubLate = in_hrs - 60;
                        int Total_Late = BreakSubLate - 450;
                        int L_H = Math.Abs(Total_Late / 60);
                        int L_M = Math.Abs(Total_Late % 60);
                        Console.WriteLine("||===============================||");
                        Console.WriteLine("||      LATE     ||       " + "{0}:{1:D2}", L_H, L_M);
                        Console.WriteLine("||===============================||");
                    }
                }
                // 12 AM Condtion
                else if (hr1 == 12 && AM == "AM")
                {
                    Greeting_Function();
                }
                else { Greeting_Function(); }
            }
            else
            {
                // ************ CONSTANT VALUE ************
                int inhrs = hr1 * 60;
                int in_hrs = inhrs + mn1;
                //----------------Total Late----------------
                int BreakSubLate = in_hrs - 60;
                int Total_Late = BreakSubLate - 450;
                int L_H = Math.Abs(Total_Late / 60);
                int L_M = Math.Abs(Total_Late % 60);
                Console.WriteLine("||===============================||");
                Console.WriteLine("||      LATE     ||       " + "{0}:{1:D2}", L_H, L_M);
                Console.WriteLine("||===============================||");
            }
        }// GOODS
        static void TotalQuata(int hr1, int hr2, int mn1, int mn2) 
        {
            int ui1 = hr1*60;
            int uii = hr2 + 12;
            int ui2 = uii * 60;
            int m1 = ui1 + mn1;
            int m2 = ui2 + mn2 - 60;
            int tt = m2 - m1;
            int ch = Math.Abs(tt/60);
            int cm = Math.Abs(tt%60);
            Console.WriteLine("||********************************||");
            Console.WriteLine("||      PERIOD   ||     " + "{0}:{1:D2}", ch, cm);
            Console.WriteLine("||********************************||");
        }// GOODS
        static void TotalOvertime(int hr1, int hr2, int mn2) 
        {
            int MTU1 = hr2 + 12;
            if (MTU1 > 17) 
            {
                int cv = 1020;
                int ui2 = MTU1 *60;
                int a_m = ui2 + mn2;
                int tt = a_m-cv;
                int ch = Math.Abs(tt/60);
                int cm = Math.Abs(tt%60);
                Console.WriteLine("||===============================||");
                Console.WriteLine("||     OVERTIME  ||       " + "{0}:{1:D2}", ch, cm);
                Console.WriteLine("||===============================||");
            } else if (MTU1 < 17)
            {
                Console.WriteLine("||================================||");
                Console.WriteLine("|| EARLY!, NO OVERTIME HAVE FUN!! ||");
                Console.WriteLine("||================================||");
            }
        } // GOODS
        static void TotalUndertime(string AM, int hr1,int hr2,int mn1, int mn2 )
        {
            int newval = hr2 + 12;
            int ui1 = hr1 * 60;
            int uii = newval;
            int ui2 = uii * 60;
            int m1 = ui1 + mn1;
            int m2 = ui2 + mn2 - 60;
            int tt = m2 - m1;
            if (tt < 480)
            {
                int cv = 1020;
                int ui22 = newval * 60;
                int a_m = ui22 + mn2;
                int ttt = a_m - cv;
                int ch = Math.Abs(ttt / 60);
                int cm = Math.Abs(ttt % 60);
                Console.WriteLine("||********************************||");
                Console.WriteLine("||   UNDERTIME   ||     " + "{0}:{1:D2}", ch, cm);
                Console.WriteLine("||********************************||");
            }
            else
            {
                if (tt > 480)
                {
                    Console.WriteLine("||===============================||");
                    Console.WriteLine("||  You Don't Have UnderTime     ||");
                    Console.WriteLine("||===============================||");
                }
            }
        }
        static void Main(string[] args)
        {
            Greeting_Body();
            Console.WriteLine("||           USER TIME IN         ||");
            Console.WriteLine("||================================||");
            Console.Write("||     START TIME: ");
                int H1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("||     MINUTES: ");
                int M1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("||     AM or PM: ");
                string T1 = Console.ReadLine();
            Console.WriteLine("||     TIME STARTED: "+H1+":"+M1+" "+T1);
            // Tate Time
            Late_Function(T1, H1, M1);
            Console.WriteLine("||================================||");
            Console.WriteLine("||          USER TIME OUT         ||");
            Console.WriteLine("||================================||");
            Console.Write("||     END TIME: ");
                int H2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("||     MINNUTES: ");
                int M2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("||     AM or PM: ");
                string T2 = Console.ReadLine();
            Console.WriteLine("||     TIME Ended: " + H2 + ":" + M2 + " "+T2);

            if (T1 == "AM") 
            {
                switch (H1)
                {
                    case 1:
                        // Regular Time
                        Greeting_Head();
                        // Total Hours
                        TotalQuata(H1,H2,M1,M2);
                        // Overtime
                        TotalOvertime(H1,H2,M2);
                        // Undertime
                        TotalUndertime(T1,H1,H2,M1,M2);
                        break;
                    case 2:
                        // Regular Time
                        Greeting_Head();
                        // Total Hours
                        TotalQuata(H1, H2, M1, M2);
                        // Overtime
                        TotalOvertime(H1, H2, M2);
                        // Undertime;
                        TotalUndertime(T1, H1, H2, M1, M2);
                        break;
                    case 3:
                        // Regular Time
                        Greeting_Head();
                        // Total Hours
                        TotalQuata(H1, H2, M1, M2);
                        // Overtime
                        TotalOvertime(H1, H2, M2);
                        // Undertime
                        TotalUndertime(T1, H1, H2, M1, M2);
                        break;
                    case 4:
                        // Regular Time
                        Greeting_Head();
                        // Total Hours
                        TotalQuata(H1, H2, M1, M2);
                        // Overtime
                        TotalOvertime(H1, H2, M2);
                        // Undertime
                        TotalUndertime(T1, H1, H2, M1, M2);
                        break;
                    case 5:
                        // Regular Time
                        Greeting_Head();
                        // Total Hours
                        TotalQuata(H1, H2, M1, M2);
                        // Overtime
                        TotalOvertime(H1, H2, M2);
                        // Undertime
                        TotalUndertime(T1, H1, H2, M1, M2);
                        break;
                    case 6:
                        // Regular Time
                        Greeting_Head();
                        // Total Hours
                        TotalQuata(H1, H2, M1, M2);
                        // Overtime
                        TotalOvertime(H1, H2, M2);
                        // Undertime
                        TotalUndertime(T1, H1, H2, M1, M2);
                        break;
                    case 7:
                        // Regular Time
                        Greeting_Head();
                        // Total Hours
                        TotalQuata(H1, H2, M1, M2);
                        // Overtime
                        TotalOvertime(H1, H2, M2);
                        // Undertime
                        TotalUndertime(T1, H1, H2, M1, M2);
                        break;
                    case 8:
                        // Regular Time
                        Greeting_Head();
                        // Total Hours
                        TotalQuata(H1, H2, M1, M2);
                        // Overtime
                        TotalOvertime(H1, H2, M2);
                        // Undertime
                        TotalUndertime(T1, H1, H2, M1, M2);
                        break;
                    case 9:
                        // Regular Time
                        Greeting_Head();
                        // Total Hours
                        TotalQuata(H1, H2, M1, M2);
                        // Overtime
                        TotalOvertime(H1, H2, M2);
                        // Undertime
                        TotalUndertime(T1, H1, H2, M1, M2);
                        break;
                    case 10:
                        // Regular Time
                        Greeting_Head();
                        // Total Hours
                        TotalQuata(H1, H2, M1, M2);
                        // Overtime
                        TotalOvertime(H1, H2, M2);
                        // Undertime
                        TotalUndertime(T1, H1, H2, M1, M2);
                        break;
                    case 11:
                        // Regular Time
                        Greeting_Head();
                        // Total Hours
                        TotalQuata(H1, H2, M1, M2);
                        // Overtime
                        TotalOvertime(H1, H2, M2);
                        // Undertime
                        TotalUndertime(T1, H1, H2, M1, M2);
                        break;
                    case 12:
                        // Regular Time
                        Greeting_Head();
                        // Total Hours
                        TotalQuata(H1, H2, M1, M2);
                        // Overtime
                        TotalOvertime(H1, H2, M2);
                        // Undertime
                        TotalUndertime(T1, H1, H2, M1, M2);
                        break;
                }
            }
            Console.ReadKey();
           
        }
    }
}
