namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        int new_id1 = 220;
        int new_id2 = 221;

        //Creates 2 instances of customer and provides values for each attribute
        Customer c1 = new Customer(110, "Alice", 28);
        Customer c2 = new Customer(111, "Bob", 30);

        c1.PrintCusInfo();
        c2.PrintCusInfo();

        //Sets each of the two customer's id's to the variable values listed at the top of Main
        c1.ChangeID(new_id1);
        c2.ChangeID(new_id2);

        c1.PrintCusInfo();
        c2.PrintCusInfo();

        //Calls c1's CompareAge with c2 as input parameter
        c1.CompareAge(c2);
    }
}

//Customer class
class Customer
{
    //Customer Attributes
    private int cus_id;
    public string cus_name;
    public int cus_age;

    //Customer Methods
    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }
    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer: {cus_id}, name: {cus_name}, age:{cus_age}");
    }
    public void CompareAge(Customer objCustomer)
    {
        if(this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older");
        } else {
            Console.WriteLine($"{objCustomer.cus_name} is older");
        }
    }

    //Initial Values
    public Customer(int id, string name, int age)
    {
        cus_id = id;
        cus_name = name;
        cus_age = age;
    }
}

