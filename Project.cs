class Accounts
{
    public int[] index;
    public string  C_name = "", C_add = "";
    public double Balance = 0;
    public int Age , Acc_no;
    public Accounts() { }
    public Accounts(int Acc_no, string C_name, int Age, string C_add, double Balance)
    {
        //int[] index,
        //this.index = index;
        this.Acc_no = Acc_no;
        this.C_name = C_name;
        this.C_add = C_add;
        this.Balance = Balance;
    }

    public int Create_Acc()
    {
        string str = " ";
        System.Console.Write("Enter The Account Number:");
        Acc_no = System.Convert.ToInt32(System.Console.ReadLine());
        if (Acc_no == null)
        {
            System.Console.WriteLine("you must enter the accno");
            if (int.TryParse(str, out Acc_no))
            {
                System.Console.WriteLine("enter the integer");
            }
        }
        System.Console.Write("Enter The Customer Name:");
        C_name = System.Console.ReadLine();
        if (C_name == null)
        {
            System.Console.WriteLine("enter the name please:");

        }
        System.Console.Write("Age:");
        Age = int.Parse(System.Console.ReadLine());
        if (Age <= 0)
        {
            System.Console.WriteLine("Enter the age");
        }


       System.Console.Write("Enter The Address:");
        C_add = System.Console.ReadLine();
        if (C_add == null)
        {
            System.Console.WriteLine("enter the address");
        }


        System.Console.Write("Deposite amount:");
        Balance = double.Parse(System.Console.ReadLine());
        if (Balance <= 0)
        {
            System.Console.WriteLine("enter the amount");
        }
	return 1;

    }

public void Acc_Availability(int Acc_num)
{
    if (Acc_no.Equals(Acc_num))
    {
        	System.Console.WriteLine("-----------------------------****************-----------------------------");
        System.Console.WriteLine("Account Number:" + Acc_no);
        System.Console.WriteLine("Name:" + C_name);
        System.Console.WriteLine("Age:" + Age);
        System.Console.WriteLine("Address:" + C_add);
        System.Console.WriteLine("Balance:" + Balance + "rs");
        	System.Console.WriteLine("-----------------------------****************-----------------------------");
    }
    else
    {
        System.Console.WriteLine("Account does not exist!");
    }
}
public void Deposite(int Acc_num)
{


    if (Acc_no.Equals(Acc_num))
    {
        System.Console.Write("Enter the amount:");
        int Amount = int.Parse(System.Console.ReadLine());
            if (Amount <= 0)
            {
                System.Console.WriteLine("amount must be greater than 0");
            }


    		else
                this.Balance = Balance + Amount;

        System.Console.WriteLine("-----------------------------****************-----------------------------");
        System.Console.WriteLine("Balance is:" + Balance + "rs");
        System.Console.WriteLine("-----------------------------****************-----------------------------");
    }
    else
    {
        System.Console.WriteLine("Account does not exist!");
    }

            
 }
        public void Withdraw(int Acc_num)
{
    if (Acc_no.Equals(Acc_num))
    {
        System.Console.Write("Enter the amount:");
        int Amount = int.Parse(System.Console.ReadLine());
        if (Balance == 0)
        {
            System.Console.WriteLine("Insufficient balance");

        }
        else if (Amount > Balance)
        {
            System.Console.WriteLine("Insufficient balance");
        }
        else
        {
            Balance = Balance - Amount;
            System.Console.WriteLine("Balance: rs" + Balance);
        }
    }
    else
    {
        System.Console.WriteLine("Account does not exist!");
    }
}
public void Balenquiry()
{
    System.Console.WriteLine("Your balance is: rs" + Balance);
}

    }
    class Program
{
    public static void Main(string[] args)
    {
        //char ch;
        int result;
        int  Acc_num ; string ch;
        //double depositeamount;
        //double withdrawamount;

        Accounts Acc = new Accounts();
        //try
        //{


        for (; ; )
        {
            System.Console.WriteLine("----------------------------------------------------------------------");
            System.Console.WriteLine("1.New Acoount\n2.Enquiry\n3.Deposit\n4.Withdraw\n5.Exit\n");
            System.Console.WriteLine("enter your choice");
            ch = System.Console.ReadLine();

            switch (ch)
            {
                case "1":

                    result = Acc.Create_Acc();
                    if (result == 1)
                    {
                        System.Console.WriteLine("Account number \"{0}\" Created Successfuly", Acc.Acc_no);
                    }
                    else
                    {
                        System.Console.WriteLine("Account could not be created! Try again.");
                    }

                    break;

                case "2":

                    System.Console.Write("Enter the Account Number:");
                    Acc_num = System.Convert.ToInt32(System.Console.ReadLine());
                    Acc.Acc_Availability(Acc_num);
                    break;

                case "3":

                    System.Console.Write("Enter the Account Number:");
                    Acc_num = System.Convert.ToInt32(System.Console.ReadLine());
                    Acc.Deposite(Acc_num);
                    break;

                case "4":

                    System.Console.Write("Enter The Customer Account Number:  ");
                    Acc_num = System.Convert.ToInt32(System.Console.ReadLine());
                    Acc.Withdraw(Acc_num);
                    break;

                case "5":

                    System.Environment.Exit(0);
                    break;

                default:

                    System.Console.WriteLine("invalid choice!");
                    break;
            }
        }
    }


}



