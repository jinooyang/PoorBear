using FusionExamples.Utility;
using UnityEngine;

public class ManagerContainer : MonoBehaviour
{
    
    public static ManagerContainer Instance => Singleton<ManagerContainer>.Instance;

    void Start()
    {
        // DontDestroyOnLoad(gameObject);
    }

}
