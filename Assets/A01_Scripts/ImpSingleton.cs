using UnityEngine;

public abstract class ImpSingleton<T> : ImpMonoBehaviour where T : ImpMonoBehaviour
{
    static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            { 
                Debug.LogError($"No instance: {typeof(T)}.");
            }
            return _instance;
        }
    }

    protected override void Awake()
    {
        base.Awake();
        
        if (_instance != null && _instance != this)
        {
            Debug.LogError($"Duplicate singleton : {typeof(T)} on {gameObject.name}.");
            return;
        }

        _instance = (T)(ImpMonoBehaviour)this;
    }
}
