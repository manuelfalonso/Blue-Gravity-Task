using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    [SerializeField]
    private bool _dontDestroyOnLoad = false;

    private static T instance;
    public static T Instance
    {
        get { return instance; }
    }

    protected virtual void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = (T)this;
            // The GameObject will persist across multiple scenes.
            if (_dontDestroyOnLoad)
                DontDestroyOnLoad(gameObject);
        }
    }

    protected virtual void OnDestroy()
    {
        if (instance == this)
        {
            instance = null;
        }
    }
}
