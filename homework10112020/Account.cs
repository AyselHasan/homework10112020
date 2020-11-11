using System;
using System.Collections.Generic;
using System.Text;

namespace homework10112020
{
    class Account
    {
        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        private static int _TotalNo;
        private int _No;
        public int NO
        {
            get { return _No; }
            set { _No = value; }
        }
        public Account(string UserName, string Password)
        {
            _UserName = UserName;
            _Password = Password;
            _TotalNo++;
            _No = _TotalNo;
        }

        public bool IsUserNameValid()
        {
            char[] array = UserName.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (char.IsLetter(array[i]) == true || char.IsDigit(array[i]) == true)
                {
                    return true;
                }
            }
            return false;
        }


        public bool IsPasswordValid()
        {
            char[] array1 = Password.ToCharArray();

            if (Password.Length > 8 && Password.Length < 25)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (char.IsSymbol(array1[j]) == true && char.IsDigit(array1[j]) == true && char.IsUpper(array1[j]) == true)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public void setPassword()
        {
            if (IsPasswordValid() == true && IsUserNameValid() == true)
            {
                Console.WriteLine("Account yaradildi.");
            }
            else if (IsPasswordValid() == false)
            {
                Console.WriteLine("Sifrenin uzunlugu 8-25 simvol arasi, icinde en az bir symbol, 1 boyuk herf ve en az bir digit istifade olunmalidir.");
            }
            else if (IsUserNameValid() == false)
            {
                Console.WriteLine("Username yanlizca digit ve herflerden ibaret ola biler.");
            }
        }

    }
}
