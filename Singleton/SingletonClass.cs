using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton;

public sealed class SingletonClass
{
    private static SingletonClass? _instance;
    private static readonly object _lock = new object();
    public Guid InstanceId { get; private set; }
    private SingletonClass()
    {

    }

    public static SingletonClass GetInstance()
    {
        if (_instance is null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new SingletonClass();
                    _instance.InstanceId = Guid.NewGuid();
                }
            }
        }
        return _instance;
    }

    public void DoBusinessLogic()
    {
        // Do some cool stuff with you singleton instance.
    }
}
