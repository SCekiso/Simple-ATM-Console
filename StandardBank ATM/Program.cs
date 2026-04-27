using System;
using System.Collections.Generic;
using System.Linq;

//Defining the card holder class
public class cardHolder
{
    string cardNumber;
    int cardPin;
    string cardHolderName;
    string cardHolderlastName;
    double balance;

    //Initializing the card holder class/constructor and parsed all the variables i created into the constructor
    public cardHolder(string cardNumber, int cardPin, string cardHolderName, string lastName, double balance)
    {
        this.cardNumber = cardNumber;
        this.cardPin = cardPin;
        this.cardHolderName = cardHolderName;
        this.cardHolderlastName = lastName;
        this.balance = balance;
    }
    //Created a method to get the card number of the card holder
    public string getCardNumber()
    {
        return cardNumber;
    }
    //Created a method to get the card pin of the card holder
    public int getCardPin()
    {
        return cardPin;
    }
    //Created a method to get the card holder name of the card holder
    public string getCardHolderName()
    {
        return cardHolderName;
    }
    //Created a method to get the last name of the card holder
    public string getLastName()
    {
        return cardHolderlastName;
    }
    //Created a method to get the balance of the card holder
    public double getBalance()
    {
        return balance;
    }

    //Created a method to set the card number of the card holder
    public void setcardNumber(string cardNumber)
    {
        this.cardNumber = cardNumber;
    }

    //Created a method to set the card pin of the card holder
    public void setcardPin(int cardPin)
    {
        this.cardPin = cardPin;
    }
    //Created a method to set the card holder name of the card holder
    public void setcardHolderName(string cardHolderName)
    {
        this.cardHolderName = cardHolderName;
    }

    //Created a method to set the last name of the card holder
    public void setlastName(string lastName)
    {
        this.cardHolderlastName = lastName;
    }

    //Created a method to set the balance of the card holder
    public void setbalance(double balance)
    {
        this.balance = balance;
    }

    //Created a main method to run the actual ATM
    public static void Main(string[] args)
    {//This function is for printing the options for the user to select from
        void printOptions()
        {
          
            Console.WriteLine("You can choose any service you want from the following options");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        //This function is for handling deposits from the user
        void deposit(cardHolder currentUser)
        {
            Console.WriteLine("How much money do you want to deposit?");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.setbalance(currentUser.getBalance() + deposit);
            Console.WriteLine("You have successfully deposited " + deposit + " and your new balance is " + currentUser.getBalance());
        }

        void withdraw(cardHolder currentUser)
        {
            Console.WriteLine("How much money do you want to withdraw?");
            double withdraw = Double.Parse(Console.ReadLine());
            //this is check if the user has enough money to make a withdrawal
            if (currentUser.getBalance() < withdraw)
            {
                Console.WriteLine("You have insufficient funds to make this withdrawal");
            }
            else
            {//this is to set the new balance of the user after making a withdrawal
                currentUser.setbalance(currentUser.getBalance() - withdraw);
                Console.WriteLine("You have successfully withdrawn your cash!");
            }
        }
        //This function is for showing the balance of the user
        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Your current balance is " + currentUser.getBalance());
        }

        //This is to create a list of card holders to store the card holder information in
        List<cardHolder> cardHolders = new List<cardHolder>();
        cardHolders.Add(new cardHolder("24681012", 1234, "Hamilton", "Rustoff", 10000.20));
        cardHolders.Add(new cardHolder("14161820", 5678, "Anna", "Rustoff", 20000.21));
        cardHolders.Add(new cardHolder("22242628", 9012, "Millicent", "Rustoff", 30000.22));
        cardHolders.Add(new cardHolder("30323436", 3456, "Melba", "Rustoff", 40000.23));
        cardHolders.Add(new cardHolder("38404244", 7890, "Lorraine", "Rustoff", 50000.24));
        cardHolders.Add(new cardHolder("46504852", 1234, "Michelle", "Rustoff", 60000.25));

        //This is to ask the user to enter their card number and pin to access their account
          Console.WriteLine("Welcome to our Standard Bank ATM!");
        Console.WriteLine("What is your credit card number?");
        //this Variable stores the card number entered by the user
        string debitcardNumber = "";
        cardHolder currentUser = null;//a variable for the logged in user or the user that is currently using the ATM
        //This will loop until a recognized card is entered
        while (true)
        {
            try
            {
                
                debitcardNumber = Console.ReadLine();
                //This is to check if the card number entered by the user matches any of the card numbers in the list of card holders
                currentUser = cardHolders.FirstOrDefault(a => a.getCardNumber() == debitcardNumber);
                if (currentUser != null)
                {
                    break;// Exits the loop
                }
                else
                {
                    Console.WriteLine("Your card is not recognized. Try again.");
                }
            }
            catch
            {
                Console.WriteLine("Your card is not recognized. Try again.");
            }
        }
        Console.WriteLine("What is your pin number?");
        int debitcardPin = 0;//this variable stores the pin number entered by the user
        while (true)//This will loop until a correct pin is entered
        {
            try
            {
                debitcardPin = int.Parse(Console.ReadLine());
                if (currentUser.getCardPin() == debitcardPin)
                {
                    break;// Exits the loop
                }
                else
                {
                    Console.WriteLine("Your pin is incorrect. Try again.");
                }
            }
            catch
            {
                Console.WriteLine("Your pin is incorrect. Try again.");
            }
        }
        //This will print a welcome message to the user after they have successfully logged in
        Console.WriteLine("Welcome " + currentUser.getCardHolderName() + " " + currentUser.getLastName() + "!");

        int option = 0;//this variable stores the option selected by the user from the menu
        do
        {
            printOptions();//This will print the options for the user to select from
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch { }
            //This is to handle the options selected by the user and call the appropriate function based on the option selected
            if (option == 1) { deposit(currentUser); }
            else if (option == 2) { withdraw(currentUser); }
            else if (option == 3) { balance(currentUser); }
            else if (option == 4) { break; }
            else { option = 0; }
        }
        while (option != 4);//This will loop until the user selects the option to exit
        Console.WriteLine("Thank you! See you next time.");
    }
}


