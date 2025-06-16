using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemFinalEx
{
    namespace Exceptions
    {

        public class InvalidAccountDetail : Exception
        {
            public InvalidAccountDetail(string reason) : base($"Invalid account detail, reason: {reason}") { }
        }

        public class UnableToLoadAccount : Exception 
        {
            public UnableToLoadAccount(string reason) : base($"Unable to load account, reason: {reason}") { }
        }

        public class UserAlreadyExists : Exception
        {
            public UserAlreadyExists(string userid) : base($"user with the same id ({userid}) already exists!") { }
        }

        public class AccountOperationFail : Exception
        {
            public AccountOperationFail(string reason) : base($"failed to perform operation, reason: {reason}") { }
        }

        public class UserNotExist : Exception
        {
            public UserNotExist(string userid) : base($"user with the same id ({userid}) doesnt exist!") { }
        }


    }
}
