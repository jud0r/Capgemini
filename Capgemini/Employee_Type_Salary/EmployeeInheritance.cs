
namespace Capgemini.Employee_Type_Salary
{
    public abstract class EmployeeInheritance
    {
        protected EmployeeInheritance(decimal salary)
        {
            Salary = salary;
        }
        public virtual EmployeeType Type { get; }
        public decimal Salary { get; set; }
        public virtual decimal GetPayAmount()
        {
            return Salary;
        }
    }
    public class EngineerInheritance : EmployeeInheritance
    {
        public EngineerInheritance(decimal salary) : base(salary) { }
        public override EmployeeType Type => EmployeeType.Engineer;
    }
    public class SalesmanInheritance : EmployeeInheritance
    {
        public SalesmanInheritance(decimal salary, decimal commission) : base(salary)
        {
            Commission = commission;
        }
        public decimal Commission { get; set; }
        public override EmployeeType Type => EmployeeType.Salesman;
        public override decimal GetPayAmount()
        {
            return Salary + Commission;
        }
    }
    public class ManegerInheritance : EmployeeInheritance
    {
        public ManegerInheritance(decimal salary, decimal commission, decimal bonus) : base(salary)
        {
            Commission = commission;
            Bonus = bonus;
        }

        public decimal Commission { get; set; }
        public decimal Bonus { get; set; }
        public override EmployeeType Type => EmployeeType.Maneger;
        public override decimal GetPayAmount()
        {
            return Salary + Commission + Bonus;
        }
    }
}
