using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayLibrary
{
    public class SystemB
    {
        public void UserUpdate()
        {
            var instance = DataStorage.GetInstance();

            instance.AddUserId(10);
        }
    }
}
