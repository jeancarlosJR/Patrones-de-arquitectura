using MyLibrary;

namespace MyLibrary
{
    public abstract class Employec
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int GetInt()
        {
            return 5;
        }
        public virtual  decimal CalculateMonthlyPaymode()
        {
            return 12000;
        }

        public int GetPaymentDays()
        {
            return 30;
        }
    }

    public class Secretary : Employec
    {
        public override decimal CalculateMonthlyPaymode() => 15000;
    }

    public class Manager : Employec
    {
        public override decimal CalculateMonthlyPaymode()
        {
            return 30000;
        }
    }
}

public class Developer : Employec
{
    public int GetpaymentDays()
    {
        return 30; 
    }
}