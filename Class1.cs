using System;

namespace Employee_Attendance
{
    public class Class1
    {
        public byte attendance()
        {
            Random random = new Random();
            byte test = random.Next(0, 2);
            return test;
        }
    }
}