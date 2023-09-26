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

    private void Start()
    {
        int gender = PlayerPrefs.GetInt(playerPrefTags.userGender, 0);
        int bodyType = PlayerPrefs.GetInt(playerPrefTags.userBodyType, 1);

        if (gender == 0 )
            Debug.Log("User selected male");
        else
            Debug.Log("User selected female");

        if (bodyType == 0)
            Debug.Log("User selected thin body type");
        else if (bodyType == 1)
            Debug.Log("User selected regular body type");
        else if (bodyType == 2)
            Debug.Log("User selected fat body type");
    }

    public void _ChooseMale()
    {
        if (maleToggle.isOn) 
        {
            characterInformation.userGender = CharacterInformation.UserGender.Male;
        }
    }

    public void _ChooseFemale()
    {
        if (femaleToggle.isOn)
        {
            characterInformation.userGender = CharacterInformation.UserGender.Female;
        }
    }

    public void _ConfirmButton()
    {
        int _type = (int)characterInformation.userGender;
        PlayerPrefs.SetInt(playerPrefTags.userGender, _type);

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
