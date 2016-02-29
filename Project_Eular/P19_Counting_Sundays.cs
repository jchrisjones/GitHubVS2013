using System;
using System.Collections.Generic;
using System.IO;


namespace Project_Eular
{
    class P19_Counting_Sundays
    {
        public P19_Counting_Sundays()
        {
            Console.WriteLine(sundays());
            Console.WriteLine();
            Console.WriteLine(sundays2());
        }

        enum MonthOfYear
        {
            January = 31,
            Febuary = 28,
            March = 31,
            April = 30,
            May = 31,
            June = 30,
            July = 31,
            August = 31,
            September = 30,
            October = 31,
            November = 30,
            December = 31
        };

        public static int sundays()
        {

            int totalDaysOfCentury = 1;
            int daysInThatMonth = 0;
            int monthOfSundays = 0;
            int temp = monthOfSundays;
            for (int i = 1901; i <= 2000; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (totalDaysOfCentury % 7 == 0)
                        monthOfSundays++; 
                    switch (j)
                    {

                        case 0:
                            daysInThatMonth = (int)MonthOfYear.January;                                            
                            totalDaysOfCentury += daysInThatMonth;
                            break;                            
                        case 1:
                            daysInThatMonth = (int)MonthOfYear.Febuary;
                            if ((i % 4 == 0 && !(i % 100 == 0)) || i % 400 == 0)
                            {
                                daysInThatMonth += 1;                                
                            }                            
                            totalDaysOfCentury += daysInThatMonth;
                            
                            break;
                        case 2:
                            daysInThatMonth = (int)MonthOfYear.March;
                                         
                            totalDaysOfCentury += daysInThatMonth;
                            break;       
                        case 3:
                            daysInThatMonth = (int)MonthOfYear.April;
                                           
                            totalDaysOfCentury += daysInThatMonth;
                            break;       
                        case 4:
                            daysInThatMonth = (int)MonthOfYear.May;
                                          
                            totalDaysOfCentury += daysInThatMonth;
                            break;       
                        case 5:
                            daysInThatMonth = (int)MonthOfYear.June;
                                         
                            totalDaysOfCentury += daysInThatMonth;
                            break;       
                        case 6:
                            daysInThatMonth = (int)MonthOfYear.July;
                                           
                            totalDaysOfCentury += daysInThatMonth;
                            break;       
                        case 7:
                            daysInThatMonth = (int)MonthOfYear.August;
                                             
                            totalDaysOfCentury += daysInThatMonth;
                            break;       
                        case 8:
                           daysInThatMonth = (int)MonthOfYear.September;
                                          
                            totalDaysOfCentury += daysInThatMonth;
                            break;       
                        case 9:
                            daysInThatMonth = (int)MonthOfYear.October;
                           
                  
                            totalDaysOfCentury += daysInThatMonth;
                            break;       
                        case 10:
                           daysInThatMonth = (int)MonthOfYear.November;
                                              
                            totalDaysOfCentury += daysInThatMonth;
                            break;       
                        case 11:
                            daysInThatMonth = (int)MonthOfYear.December;
                                             
                            totalDaysOfCentury += daysInThatMonth;
                            break;       
                    }
                    if(temp < monthOfSundays)
                    {
                        Console.WriteLine(new DateTime(i, j + 1, 1).DayOfWeek + " " + new DateTime(i, j+1, 1));
                    }
                }
            }

            Console.WriteLine(totalDaysOfCentury);
            return monthOfSundays;
        }

        public static int sundays2()
        {
            int sundays = 0;
            DateTime currentMonth = new DateTime(1901, 1, 1);
            DateTime oneMonthTooFar = new DateTime(2001, 1, 1);
            int days = (oneMonthTooFar - currentMonth).Days;
            Console.WriteLine("Days: {0}", days);
            while(currentMonth < oneMonthTooFar)
            {
                
                if (currentMonth.DayOfWeek == DayOfWeek.Sunday)
                    sundays++;
                currentMonth = currentMonth.AddMonths(1);

            }
            return sundays;
        }
    }

}