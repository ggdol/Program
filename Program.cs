// using System;
// namespace Program
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {



//         }
//     }

//     public class CreateAccount : BankAccount
//     {
//         string userName { get; set; }
//         string accountNumber { get; set; }
//         string password { get; set; }

//     }

//     public class BankAccount : Transactions
//     {
//         decimal balance = 0M;
//         protected private void Deposite(decimal amount)
//         {
//             balance += amount;

//             saveRecord($"Account Depositte By: {amount}");

//         }


//         protected private void Withdrawn(decimal amount)
//         {
//             if (balance > 0)
//             {
//                 balance -= amount;
//                 saveRecord($"Account Withdrawn By: {amount}");
//             }
//             else
//             {

//                 saveRecord($"The Balance Below Zero!, The Balance is: {balance}");
//                 throw new Exception($"The Balance Below Zero!, The Balance is: {balance}");
//             }
//         }

//         public string Statement()
//         {

//             return $"The Account Balance Is: {balance}";
//         }
//     }


//     public abstract class Transactions
//     {

//         protected private List<string> recordList = new List<string>();


//         protected private void saveRecord(string rec)
//         {
//             recordList.Add(rec);
//         }
//     }
// }

