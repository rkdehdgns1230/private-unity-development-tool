using UnityEngine;

public class Managers : MonoBehaviour
{
    public static Managers Instance
    {
        get
        {
            Init();
            return _instance;
        }
    }

    private static Managers _instance;

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    static void Init()
    {
        if(_instance == null)
        {
            GameObject go = GameObject.Find("@Managers") ?? new GameObject("@Managers");
            _instance = go.GetComponent<Managers>() ?? go.AddComponent<Managers>();
            DontDestroyOnLoad(go);
        }
    }
}
