using UnityEngine;

public class CharacterGenerator : MonoBehaviour
{
    private GameObject characterObj;
    private Character character;

    public void CreateBaseCharacter(string type)
    {
        var baseCharacter = Resources.Load<GameObject>($"Characters/{type}");
        if (characterObj != null) Destroy(characterObj);
        characterObj = Instantiate(baseCharacter, Vector3.zero, Quaternion.identity);
        character = characterObj.GetComponent<Character>();
    }

    public void ChangeCharacterColor()
    {
        character.ChangeClothes();
    }

    public void ChangeCharacterHairColor()
    {
        character.ChangeHair();
    }

    public void ChangeCharacterSword()
    {
        SwordsController swordsController = new SwordsController();
        character.ChangeSword(swordsController.GetRandomSword());
    }
    
}