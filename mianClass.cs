namespace employeesWage;

public class mianClass
{
    public static void Main(string[] args)
    {
        chech_if_present cp = new chech_if_present();
        
        daily_Wage dailyWage = new daily_Wage();
        
        fulltime_or_parttime_wage fulltimeOrParttimeWage = new fulltime_or_parttime_wage();
        wage_per_month wagePerMonth = new wage_per_month();
       
        Console.WriteLine("1.chack if the employee is present \n 2.calculate daily wage\n 3.calculate full time and part time wage\n 4.calculate the monthly wage");
        Console.WriteLine("enter your choice");
        int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    cp.check();
                    break;
                    break;
                case 2:
                    dailyWage.dailyWageOfEmployee();
                    break;
                case 3:
                    fulltimeOrParttimeWage.part_time_wage();
                    break;
                case 4:
                    wagePerMonth.wage_monthly();
                    break;
                default:
                    Console.WriteLine("enter a vlaid choice");
                    break;
            }
        }


    
}