using BankSystemFinalEx.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankSystemFinalEx
{
    internal class Account
    {
        public string FirstName;
        public string LastName;
        public string Id;
        public string Password;
        private bool AllowEdit;
        private DateTime CreationTime;
        public long Balance { get { return balance; } }

        private long balance;

        public static void validateName(string name)
        {
            if (!name.All(Char.IsLetter)
                || name.Length > 14
                || name.Length < 2)
            {
                throw new InvalidAccountDetail("First and last names must only have letters and be 2 to 14 letters long");
            }
        }

        public static void validateId(string id)
        {
            // TODO check that no other user has this ID - עשינו להוריד
            if (!id.All(Char.IsDigit)
                || id.Length != 9)
            {
                throw new InvalidAccountDetail("ID must be 9 digits long number");
            }
        }
        
        public static void validatePassword(string password)
        {
            if (!password.All(Char.IsLetterOrDigit)
                || 4 > password.Length
                || 12 < password.Length)
            {
                throw new InvalidAccountDetail("password must consist of letters and digits");
            }
        }

        public Account(string fname, string lname, string id, string password) 
        { 
            FirstName = fname;
            LastName = lname;
            Id = id;
            Password = password;
            AllowEdit = false;
            CreationTime = DateTime.Now;
            balance = 0;

            validateName(FirstName);
            validateName(LastName);
            validateId(Id);
            validatePassword(Password);
        }

        public Account(IEnumerable<string> fileLines)
        {
            FirstName = fileLines.ElementAt(0);
            LastName = fileLines.ElementAt(1);
            Password = fileLines.ElementAt(2);
            Id = fileLines.ElementAt(3);
            CreationTime = DateTime.Parse(fileLines.ElementAt(4));
            balance = long.Parse(fileLines.ElementAt(5));
        }

        public static Account FromId(string id)
        {
            validateId(id);

            if (!exists(id))
            {
                throw new UnableToLoadAccount("Account with id " + id + " does not exist!");
            }

            var userDetails = File.ReadLines(Program.usersPath + "\\" + id); // Load account file to "array"
            return new Account(userDetails);                                  //  Parse array into Account object (not really creating new account)
        }

        public static bool exists(string id)
        {
            return File.Exists(Program.usersPath + "\\" + id);
        }

        public bool exists()
        {
            return exists(Id);
        }

        public void update()
        {
            string userFilePath = Program.usersPath + "\\" + Id;

            using (var sw = File.CreateText(userFilePath))
            {
                sw.AutoFlush = true;
                sw.WriteLine(FirstName);
                sw.WriteLine(LastName);
                sw.WriteLine(Password);
                sw.WriteLine(Id);
                sw.WriteLine(CreationTime);
                sw.WriteLine(Balance);
            }
        }

        public void create()
        {
            string userFilePath = Program.usersPath + "\\" + Id;

            if (File.Exists(userFilePath))
            {
                throw new UserAlreadyExists(Id);
            }

            using (var sw = File.CreateText(userFilePath))
            {
                sw.AutoFlush = true;
                sw.WriteLine(FirstName);
                sw.WriteLine(LastName);
                sw.WriteLine(Password);
                sw.WriteLine(Id);
                sw.WriteLine(CreationTime);
                sw.WriteLine(Balance);
            }
        }

        public void deposit(uint amount)
        {
            if (balance + amount < balance) // overflow
            {
                throw new AccountOperationFail("Cant add this amount since it overflows");
            }

            balance += amount;
            update();
        }

        public void withdraw(uint amount)
        {
            if (Balance < amount)
            {
                throw new AccountOperationFail("You dont have enough funds to withdraw this amount :(");
            }

            balance -= amount;
            update();
        }

        public void send(uint amount, string otherAccountId)
        {
            if (!exists(otherAccountId))
            {
                throw new UserNotExist(otherAccountId);
            }

            if (Balance < amount)
            {
                throw new AccountOperationFail("You dont have enough funds to send this amount :(");
            }

            balance -= amount;
            update();
        }
    }
}
