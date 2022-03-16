using UnityEngine;


public class SwordsController : MonoBehaviour
{
    private SwordsConfig config;
    

    public SwordsController()
    {
        config = Resources.Load<SwordsConfig>("Characters/Configs/SwordsConfig");
    }

    public GameObject GetRandomSword()
    {
        var asset = config.GetRandomSword();
        var obj = Instantiate(asset, Vector3.zero, Quaternion.identity);
        return obj;
    }
}