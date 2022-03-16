using UnityEngine;


[CreateAssetMenu]
public class SwordsConfig : ScriptableObject
{
    [SerializeField] private string[] sword;
    public string[] Sword => sword;

    public GameObject GetRandomSword()
    {
        var swordName = sword[Random.Range(0, sword.Length)];
        return LoadObject(swordName);
    }

    private GameObject LoadObject(string swordName)
    {
        return Resources.Load<GameObject>($"Characters/Swords/{swordName}");
    }

#if UNITY_EDITOR
    private void Reset()
    {
        var objects = Resources.LoadAll<GameObject>("Characters/Swords");
        sword = new string[objects.Length];
        for (int i = 0; i < sword.Length; i++)
        {
            sword[i] = objects[i].name;
        }
    }
#endif
}