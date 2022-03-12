using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class class1
    {
        int Full_Time = 1;
        int Part_Time = 2;
        int maxRateInMonth = 100;
        int Emp_Rate_Per_Hr = 20;
        int numOfWorkingDays = 20;
        int total_WorkingDay = 20;
        int empHrs = 0;
        int empWage = 0;
        int totalEmpHr = 0;
        int totalSalary = 0;

    Random obj = new Random();
        

    public void Employee()
        {
            int empCheck = obj.Next(0, 2);
            if (empCheck == Full_Time)
            {
                Console.WriteLine("Employee is Present in Office");
            }
            else
            {
                Console.WriteLine("Employee is Absent from the Office");
            }
        }
        
    public void EmpDailyWages()
        {
            int empCheck = obj.Next(0, 2);
            if (empCheck == Full_Time)
            {
                empHrs = 8;
                Console.WriteLine("Employee worked full day");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is Absent");
            }
            empWage = empHrs * Emp_Rate_Per_Hr;
            Console.WriteLine("Employee salary is= " + empWage);
        }

    public void EmpPartTime()
        {
            int randomCheck = obj.Next(0, 3);
            if (randomCheck == Full_Time)
            {
                empHrs = 8;
                Console.WriteLine("Employee Worked Full Day");
            }
            else if (randomCheck == Part_Time)
            {
                empHrs = 4;
                Console.WriteLine("Employee Worked Half Day");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee Is Absent");
            }
                empWage = empHrs * Emp_Rate_Per_Hr;
                Console.WriteLine("Employee's Salary is= " + empWage);
        }
    public void WagesSwitch()
        {
            int randomCheck = obj.Next(0, 3);
            switch (randomCheck)
            {
            case 1:

                empHrs = 8;
                Console.WriteLine("Employee is working full day");
                break;

            case 2:

                empHrs = 4;
                Console.WriteLine("Employee is working Half day");
                break;

            case 0:


                empHrs = 0;
                Console.WriteLine("Employee is absent");
                break;

            }
            empWage = empHrs * Emp_Rate_Per_Hr;
            Console.WriteLine("Employee one day salary is= " + empWage);
        }
    public void WagesMonth()
        {
            for (int day = 1; day <= total_WorkingDay; day++)
            {
                int randomCheck = obj.Next(0, 3);
                switch (randomCheck)
                {
                    case 1:

                        empHrs = 8;
                        break;

                    case 2:

                        empHrs = 4;
                        break;

                    case 0:

                        empHrs = 0;
                        break;

                }
                empWage = empHrs * Emp_Rate_Per_Hr;
                totalSalary = (totalSalary + empWage);


            }
            Console.WriteLine("Employee total salary for a month is= "+totalSalary);

    }
    public void totalWorkingHrMonth()
        {
        while (total_EmpHr < maxRateInMonth && total_WorkingDay < numOfWorkingDays)
        {
            total_WorkingDay++;
            int randomCheck = obj.Next(0, 3);
            switch (randomCheck)
            {
                case 1:
                    {
                        empHrs = 8;
                        break;
                    }
                case 2:
                    {
                        empHrs = 4;
                        break;
                    }
                case 0:
                    {
                        empHrs = 0;
                        break;
                    }

            }
            total_EmpHr = (total_EmpHr + empHrs);


        }
        int total_Salary = (total_EmpHr * Emp_Rate_Per_Hr);
        Console.WriteLine("Employee total salary is= "+total_Salary);
        Console.WriteLine("Employee total Hours Worked= "+total_EmpHr);
        Console.WriteLine("Employee total working Days is= "+total_WorkingDay);
    }
}
