using System;
using System.Collections.Generic;
using System.Text;

namespace ATM_Lab
{
    class ATM
    {
        private string username;
        private string password;
        private int balance;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }


        public ATM()
        {

        }

        public ATM(string _username, string _password, int _balance)
        {
            username = _username;
            password = _password;
            balance = _balance;
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        //public static void GetUsername(string message)
        //{
        //    string username = GetUserInput(message);
        //}

        //public static void GetUserPassword(string message)
        //{
        //    string password = GetUserInput(message);
        //}

        public static void AddUserInputToList(List<string> stringList, string message)
        {
            string input = GetUserInput(message);
            stringList.Add(input);
            //stringList.Add(GetUserInput(message)); IS THE 2 LINES ABOVE   
        }

        public static void ListOutList(List<string> list1)
        {
            foreach (string word in list1)
            {
                Console.WriteLine(word);
            }
        }
    }
}
