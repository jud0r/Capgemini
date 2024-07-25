
namespace Capgemini.Employee_Type_Salary
{
    public enum EmployeeType
    {
        Engineer = 0,
        Salesman = 1,
        Maneger = 2
    }
    public interface IEmployee
    {
        EmployeeType Type { get; }
        decimal Salary { get; set; }
        decimal GetPayAmount();
    }
    public class Engineer : IEmployee
    {
        public EmployeeType Type => EmployeeType.Engineer;
        public decimal Salary { get; set; }

        public decimal GetPayAmount()
        {
            return Salary;
        }
    }
    public class Salesman : IEmployee
    {
        public EmployeeType Type => EmployeeType.Salesman;
        public decimal Salary { get; set; }
        public decimal Commission { get; set; }

        public decimal GetPayAmount()
        {
            return Salary + Commission;
        }
    }
    public class Maneger : IEmployee
    {
        public EmployeeType Type => EmployeeType.Maneger;
        public decimal Salary { get; set; }
        public decimal Commission { get; set; }
        public decimal Bonus { get; set; }

        public decimal GetPayAmount()
        {
            return Salary + Commission + Bonus;
        }
    }
}
