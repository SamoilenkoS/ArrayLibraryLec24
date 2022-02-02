using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ArrayLibrary
{
    public class DataStorage
    {
        private Dictionary<int, List<int>> _usersData;
        private static DataStorage Instance;

        private DataStorage()
        {
            _usersData = new Dictionary<int, List<int>>();
        }

        public static DataStorage GetInstance()
        {
            if(Instance == null)
            {
                Instance = new DataStorage();
            }

            return Instance;
        }

        public void AddUserId(int id)
        {
            _usersData.TryAdd(id, new List<int>());
        }

        public void AddUserData(int value)
        {
            foreach (var item in _usersData)
            {
                item.Value.Add(value);
            }
        }

        public void DebugData()
        {
            foreach (var item in _usersData)
            {
                Debug.Write(item.Key + " ");
                foreach (var i in item.Value)
                {
                    Debug.Write(i + " ");
                }
            }
        }
    }
}
