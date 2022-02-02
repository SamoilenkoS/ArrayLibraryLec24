using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayLibrary
{
    public class SystemA
    {
        public void DataUpdate()
        {
            var instance = DataStorage.GetInstance();

            instance.AddUserData(550);
        }
    }
}
