using System;

namespace MyEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 obj = new class1();
            obj.Employee();
            obj.EmpDailyWages();
            obj.EmpPartTime();
            obj.WagesSwitch();
            obj.WagesMonth();
            obj.totalWorkingHrMonth();
        }
    }
}
