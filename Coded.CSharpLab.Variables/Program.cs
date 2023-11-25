//Example1();
//Example2();
//Example3();
//Example4();


void Example1()
{
    string studentName = "";
    
    Console.Write("What's your name?: ");
    studentName = Console.ReadLine();

    Console.WriteLine($"Welcome {studentName} to the class!");
}

void Example2()
{
    string name = "Ahmad";
    decimal baseSalary = 2500.500M;
    string department = "Data Science and AI";
    DateOnly joinedAt = DateOnly.Parse("2023-01-01");
    bool coveredByinsurance = false;
    
    // The Modern way of declaring variables
    // var name = "Ahmad";
    // var baseSalary = 2500M;
    // var department = "Data Science and AI";
    // var joinedAt = DateOnly.Parse("2023-01-01");
    // var coveredByInsurance = false;
}

void Example3()
{
    // What not to do
    
    int s = 2000;
    int m = 12;

    int t = s * m;
   
    // What to do;
    int salary = 2000;
    int monthCount = 12;

    int totalSalaryPayment = salary * monthCount;
}

void Example4()
{
    decimal salary = 1000M;
    IncreaseSalary(salary);
    
    Console.WriteLine($"The new salary is {salary}");

    salary = IncreaseSalaryFix(salary);
    
    Console.WriteLine($"The new salary is {salary}");
    
    BankAccount customerAccount = new BankAccount();
    customerAccount.CurrentBalance = 1000M;
    
    IncreaseAmount(customerAccount);
    
    Console.WriteLine($"The new account balance is {customerAccount.CurrentBalance}");
}


void IncreaseSalary(decimal startingSalary)
{
    startingSalary += 5000M;
}

decimal IncreaseSalaryFix(decimal startingSalary)
{
    return startingSalary + 5000M;
}
void IncreaseAmount(BankAccount account)
{
    account.CurrentBalance += 5000;
}

public class BankAccount
{
    public string AccountNumber { get; set; }
    public decimal CurrentBalance { get; set; }
    public string CustomerName { get; set; }
}