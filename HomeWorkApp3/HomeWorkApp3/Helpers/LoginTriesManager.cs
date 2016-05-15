using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWorkApp3.Helpers
{
    public class LoginTriesManager
    {
        string value = "numOfTries";

        public LoginTriesManager()
        {
            InitializeGlobalVariable();
        }

        public void AddUnsuccessfulTry()
        {
            var currentTries = (int)HttpContext.Current.Application[value];
            currentTries += 1;
            HttpContext.Current.Application[value] = currentTries;
        }

        public string GetStatusMessage()
        {
            var currentTries = GetCurrentTries();
            if (currentTries == 0)
            {
                return "";
            }
            else if (currentTries > 5)
            {
                return "Login is temporarily disabled. Please try after 30 minutes";
            } else
            {
                return $"Invalid username or password. (Number of tries: {currentTries})";
            }
        }

        public bool areMoreThan5Tries()
        {
            return GetCurrentTries() > 5 ? true : false;
        }

        int GetCurrentTries()
        {
            return (int)HttpContext.Current.Application[value];
        }

        public void ResetTriesToZero()
        {
            var currentTries = (int)HttpContext.Current.Application[value];
            currentTries = 0;
            HttpContext.Current.Application[value] = currentTries;
        }



        private void InitializeGlobalVariable()
        {
            if (HttpContext.Current.Application [value] == null)
            {
                HttpContext.Current.Application[value] = 0;
            }
        }
    }
}