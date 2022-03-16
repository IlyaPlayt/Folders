using UnityEngine;


public class Character : MonoBehaviour
{
    [SerializeField] private GameObject hair;
    [SerializeField] private GameObject clothes;
    [SerializeField] private GameObject swordPoint;
    [SerializeField] private GameObject sword;
    private Color[] colors;

    public void ChangeClothes()
    {
        var renderer = clothes.GetComponent<SkinnedMeshRenderer>();
        renderer.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1);
    }

    public void ChangeHair()
    {
        var renderer = hair.GetComponent<SkinnedMeshRenderer>();
        renderer.material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1);
    }

    public void ChangeSword(GameObject newSword)
    {
        if(sword!=null) Destroy(sword);
        sword = newSword;
        sword.transform.SetParent(swordPoint.transform);
        sword.transform.position=swordPoint.transform.position;

    }
    
}