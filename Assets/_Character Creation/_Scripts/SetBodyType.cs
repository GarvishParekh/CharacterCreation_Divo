using UnityEngine;
using UnityEngine.UI;

public class SetBodyType : MonoBehaviour
{
    [SerializeField] private CharacterInformation characterInfo;

    [Header (" Male Skin Renderer")]
    [SerializeField] private SkinnedMeshRenderer maleBodyMeshRenderer;

    [Space]
    [SerializeField] private SkinnedMeshRenderer[] maleTShirtMeshRenderer;
    [SerializeField] private SkinnedMeshRenderer[] maleTrouserMeshRenderer;
    
    [Header (" Female Skin Renderer")]
    [SerializeField] private SkinnedMeshRenderer femaleBodyMeshRenderer;

    [Space]
    [SerializeField] private SkinnedMeshRenderer[] femaleTShirtMeshRenderer;
    [SerializeField] private SkinnedMeshRenderer[] femaleTrouserMeshRenderer;

    [Header(" User Interface ")]
    [SerializeField] private Image thinImage;
    [SerializeField] private Image regularImage;
    [SerializeField] private Image fatImage;

    public void ChangeAppearanceUI()
    {
        if (characterInfo.characterType == CharacterInformation.CharacterType.Male)
        {
            thinImage.sprite = characterInfo.maleThinSprite;
            regularImage.sprite = characterInfo.maleRegularSprite;
            fatImage.sprite = characterInfo.maleFatSprite;
        }
        else
        {
            thinImage.sprite = characterInfo.femaleThinSprite;
            regularImage.sprite = characterInfo.femaleRegularSprite;
            fatImage.sprite = characterInfo.femaleFatSprite;
        }
    }
}
