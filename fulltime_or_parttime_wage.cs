using System.Runtime.Intrinsics.Arm;

namespace employeesWage;

public class fulltime_or_parttime_wage
{
    public void part_time_wage()
    {


        int full_time = 1;
        int part_time = 2;
        int employee_hours = 0;
        double total_wage = 0;
        Console.WriteLine("enter the wage per hour");
        int wage_per_hour = int.Parse(Console.ReadLine());
        Random rdm = new Random();
        int chech_if_present = rdm.Next(3);
        switch (chech_if_present)
        {
            case 1: employee_hours = 8;
                break;
            case 2: employee_hours = 4;
                break;
            default: break;
        }

        total_wage = employee_hours * wage_per_hour;
        if(full_time==chech_if_present)
            Console.WriteLine("the full time wage is "+total_wage);
        else if(part_time==chech_if_present)
            Console.WriteLine("the part time wage is "+total_wage);
    }
}