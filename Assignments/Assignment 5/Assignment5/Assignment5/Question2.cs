using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class LoanProcess
    {
        int LoanNumber;
        string CustomerName;
        internal int LoanAmount;
        float EMI_Amount;
        internal int AccountBalance;
        string Err;
        internal LoanProcess(int LoanNumber, string CustomerName, int LoanAmount, int AccountBalance)
        {
            this.LoanNumber = LoanNumber;
            this.LoanAmount = LoanAmount;
            this.CustomerName = CustomerName;
            this.AccountBalance = AccountBalance;
        }
        internal float Calculate_EMI(int LoanAmount, float ROI, int time)
        {
            float r = (ROI / (12 * 100));
            int t = time * 12;
            EMI_Amount = (LoanAmount * r * (float)Math.Pow(1 + r, t)) / (float)(Math.Pow(1 + r, t) - 1);
            return EMI_Amount;
        }
        public void CheckBalance(int AccountBalance, float EMI_Amount)
        {
            try
            {
                if (AccountBalance < EMI_Amount)
                {
                    throw new Exception("Not Sufficient Balance to Repay the Loan");
                }
                else
                {
                    Console.Write("Your EMI Amount is Deducted");
                }
                
            }
            catch (Exception e)
            {
                Err = e.Message;
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (Err != null)
                {
                    Console.WriteLine("Please add more funds in your account");
                }
                else
                {
                    Console.WriteLine("Thanks for Paying the EMI");
                }
                
            }
        }
    }
    class Question2
    {
        static void Main()
        {
            
            LoanProcess loanProcess = new LoanProcess(421356,"Arulselvan",300000,15000);
            float EMI = loanProcess.Calculate_EMI(loanProcess.LoanAmount,13,3);
            loanProcess.CheckBalance(loanProcess.AccountBalance, EMI);
            Console.Read();

        }
    }
}
