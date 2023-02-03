using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        string returnedDate = Console.ReadLine();
        string dueDate=Console.ReadLine();
       int[] dueDatelist=todoDate(dueDate);
        int[] returnedDateList = todoDate(returnedDate);
        Console.WriteLine(calculateLateDate(dueDatelist, returnedDateList));
    }
  static  int[] todoDate(string a)
    {
        string[] dateParts = a.Split(' ');
        int day = int.Parse(dateParts[0]);
        int month = int.Parse(dateParts[1]);
        int year = int.Parse(dateParts[2]);
        int[] date= new int[3];
        date[0] = day;
        date[1] = month;
        date[2] = year;
        return date;
    }
  static  int calculateLateDate(int[] dueDate, int[] returnDate)
    {
        if (dueDate[2] < returnDate[2])
        {
            return 10000;
        }
        if(dueDate[2] ==returnDate[2])
        {
            if (dueDate[1] < returnDate[1])
            {
                return (returnDate[1] - dueDate[1]) * 500;
            }
            if(dueDate[1] == returnDate[1])
            {
                if (dueDate[0] < returnDate[0])
                {
                    return (returnDate[0] - dueDate[0]) * 15;
                }
            }
           
        }
              return 0;   
    }
}