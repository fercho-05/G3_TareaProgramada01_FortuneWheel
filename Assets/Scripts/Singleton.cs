using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour
    where T : MonoBehaviour
{
    static Singleton<T> _instance;

    protected static object _lock = new object();  //Se puede heredar y ver por el padre y por el hijo, no fuere de esto

    protected virtual void Awake() //Virtual = se puede sobreescribir
    {
        bool destroyMe = true;

        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    destroyMe = false;
                    _instance = this;

                    DontDestroyOnLoad(gameObject);
                }
            }
        }

        if (destroyMe)
        {
            Destroy(gameObject);
            return;
        }
    }

    public static T Instance
    {
        get
        {
            return _instance as T;
        }
    }

}
