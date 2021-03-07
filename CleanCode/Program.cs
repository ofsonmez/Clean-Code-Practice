using System;
using System.Reflection.Metadata;

namespace CleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            #region BooleanComparisons

            // I wrote a code and I said that this code nice. So nice is true :)
            bool nice = true;
            
            // Don't
            if (nice == true)
            {
                nice = false;
            }
            
            // Do
            if (nice)
            {
                nice = true;
            }
            
            // This code contains 400 lines. So contain is 400 and nice is true.
            int contain = 400;
            
            // Don't
            if (contain == 400)
            {
                nice = true;
            }
            else
            {
                nice = false;
            }
            
            // Do
            nice = contain == 400;

            #endregion

            #region BePositive

            // Positive statements is better for understanding.
            int value = 5;
            
            if (value)

            #endregion

            #region TernaryIF

            // Use ternaryIf when if/else logic is simple.
            bool goPayment;
            bool loggedIn;

            // Don't
            if (loggedIn)
            {
                goPayment = true;
            }
            else
            {
                goPayment = false;
            }

            // Do
            goPayment = loggedIn ? true : false;

            #endregion

            #region StronglyType
            
            // Use StronglyType not StringlyType :)
            const string luckyNumber = "Seven";
            
            // Don't
            if (luckyNumber == "Seven")
                
            // Do
            if (luckyNumber == LuckyNumber.Seven)

            #endregion

            #region SpecifyVariable

            // Don't
            if (range < 20 && range > 0)
            
            // Do
            var range = new int[20];
            if (range < 20 && range > 0)

            #endregion

            #region SpecifyCondition

            // Don't
            if (isLoggedIn == true && user.Count > 0 && user is true)
                
            // Do
            bool yes = isLoggedIn == true && user.Count > 0 && user is true;
            if (yes)
                
            #endregion

            #region UseRightTools

            // Don't
            List<Contract> relatedContracts = new List<Contract>();
 
            foreach(var contract in contracts)
            {
                if(contract.IsActive && 
                   contract.Status == ContractStatus.Done && 
                   contract.RemainingPayment == 0)
                {
                    relatedContracts.Add(contract);
                }
            }
 
            return relatedContracts ;
            
            // Do
            return contracts.Where(c => c.IsActive && c.Status == ContractStatus.Done)
                .Where(c => c.RemainingPayment == 0);

            #endregion

            #region RuleOf7
            // We need to assign our variables JUST_IN_TIME
            
            // Don't
            int minUserNameLenght = 6; 
            int maxUserNameLenght = 20;
            bool isAlphaNumeric;
 
            if(userName.Length < minUserNameLength) 
                return false;  
            if(userName.Length > maxUserNameLength) 
                return false; 
            isAlphaNumeric = userName.All(Char.IsLetterOrDigit);
            
            // Do
                int minUserNameLenght = 6; 
            if(userName.Length < minUserNameLength) 
                return false;  
 
            int maxUserNameLenght = 20;
            if(userName.Length > maxUserNameLength) 
                return false; 
 
            bool isAlphaNumeric = userName.All(Char.IsLetterOrDigit);
            

            #endregion

            #region FailFast
            // If our code throw errors then handle them first

            // Don't
            public void SignIn(string userName, string password)
            {
                if(!string.IsNullOrWhiteSpace(userName))
                { 
                    // code
                    if(!string.IsNullOrWhiteSpace(password))
                    {
                        // SignIn
                    }
                    else 
                    {
                        throw ...
                    }
                }
                else 
                {
                    throw ...
                }
 
            }
            
            // Do
            public void Login(string userName, string password) 
            { 
                if(string.IsNullOrWhiteSpace(userName)) 
                    throw ...;
                if(string.IsNullOrWhiteSpace(password)) 
                    throw ...;
 
                // SignIn;
            }

            #endregion

        }
    }
}