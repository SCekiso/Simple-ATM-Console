Standard Bank ATM Simulation

Project Overview
This C# Console Application simulates a real-world ATM experience for Standard Bank clients. 
It provides a secure interface for users to access their accounts, check balances and perform basic financial transactions like deposits and withdrawals.

Key Features
User Authentication: Requires a valid card number and a 4-digit PIN to gain access.
Account Management: Uses a cardHolder class to manage personal data, including names, card details and balances.

Transaction Services:
Deposit: Add funds to your account with instant balance updates.
Withdrawal: Remove funds with a built-in "Insufficient Funds" safety check.
Balance Inquiry: View current holdings at any time.
Error Handling: Robust try-catch blocks ensure the program doesn't crash if a user enters invalid text or symbols.

Technical Highlights
Encapsulation: All sensitive data (card numbers, pins) is managed through getter and setter methods to maintain data integrity.
LINQ Integration: Uses FirstOrDefault to quickly search the database for a matching cardholder.
Dynamic Lists: Managed using List<cardHolder> to simulate a bank's database of active clients.

How to Use
Login: Enter one of the registered card numbers (e.g., 24681012).
PIN Entry: Enter the matching 4-digit PIN (e.g., 1234).
Menu Navigation: Select from the 4 menu options to manage your money.
Exit: Choose option 4 to safely log out and close the session.

Technical Stack
Language: C#
Framework: .NET Console
IDE: Visual Studio 2022

Observations on your Code:
Logic Separation: You did a great job defining the cardHolder class at the top. This makes it very easy to add more users or add new features (like savings vs. checkings accounts) later.

The "Hamilton Rustoff" Data: It looks like you've created a whole family of accounts! Having pre-set data in your List is perfect for testing your logic without needing a real database.

Safety First: Your withdrawal logic (currentUser.getBalance() < withdraw) is vital. It prevents "negative balances," which is exactly what a real bank would do.

Please be mindful of the following:❗❗❗❗
Since this project involves PIN numbers and Card numbers (even though they are fake for this project), 
that this is a SIMULATION and not for use with real sensitive data! This is not a real STANDARD BANK project!
