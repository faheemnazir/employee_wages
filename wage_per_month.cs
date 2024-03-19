namespace employeesWage;

public class wage_per_month
{
    public void wage_monthly()
    {
        int total_wage = 0, daily_wage = 0, employee_hours = 0;
        chech_if_present check = new chech_if_present();
        Console.WriteLine("enter the wage per hour");
        int wage_per_hour = int.Parse(Console.ReadLine());
        Console.WriteLine("enter the total no of working days a month");
        int total_no_days_a_month = int.Parse(Console.ReadLine());
        if (check.checknumber != 1)
            
        {
            employee_hours = 8;
            daily_wage = wage_per_hour * employee_hours;
        }
        else
        {
            Console.WriteLine("employee is absent");
            
        }

        total_wage = daily_wage * total_no_days_a_month;
        Console.WriteLine("the total monthly wage is "+total_wage);
    }
}