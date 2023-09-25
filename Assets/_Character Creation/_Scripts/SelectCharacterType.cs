using UnityEngine;
using UnityEngine.UI;

public class SelectCharacterType : MonoBehaviour
{
    [Header (" Scriptable Scripts ")]
    [SerializeField] CharacterInformation characterInformation;
    [SerializeField] PlayerPerfTags playerPrefTags;

    [Header(" Elements ")]
    [SerializeField] GameObject maleCharacter;
    [SerializeField] GameObject femaleCharacter;

    [Header(" User Interface ")]
    [SerializeField] private GameObject genderSelectionCanvas;
    [SerializeField] private GameObject bodyTypeCanvas;

    [Space]
    [SerializeField] Toggle maleToggle;
    [SerializeField] Toggle femaleToggle;

    public void _ChooseMale()
    {
        if (maleToggle.isOn) 
        {
            characterInformation.characterType = CharacterInformation.CharacterType.Male;
        }
    }

    public void _ChooseFemale()
    {
        if (femaleToggle.isOn)
        {
            characterInformation.characterType = CharacterInformation.CharacterType.Female;
        }
    }

    public void _ConfirmButton()
    {
        int _type = (int)characterInformation.characterType;
        PlayerPrefs.SetInt(playerPrefTags.CharacterType, _type);

        if (_type == 0)
        {
            Debug.Log("Male");
            maleCharacter.SetActive(true);
        }
        else if (_type == 1)
        {
            Debug.Log("Female");
            femaleCharacter.SetActive(true);
        }

        genderSelectionCanvas.SetActive(false);
        bodyTypeCanvas.SetActive(true);
    }
}
