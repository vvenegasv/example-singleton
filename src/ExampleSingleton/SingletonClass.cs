using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSingleton
{
    public class SingletonClass
    {
        private static volatile SingletonClass _instance;
        private static object _syncRoot = new Object();
        private readonly string _key;

        private SingletonClass()
        {
            _key = Guid.NewGuid().ToString();
        }

        public static SingletonClass Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                            _instance = new SingletonClass();
                    }
                }
                return _instance;
            }
        }

        public string GetKey()
        {
            return _instance._key;
        }
    }
}
