using UnityEngine;
using UnityEngine.UI;

public class ItemDataFetcher : MonoBehaviour
{
    [Header (" Scriptable Elements ")]
    [SerializeField] private CharacterInformation characterInformation;
    [SerializeField] private ItemImages itemImageScriptable;
    [SerializeField] private PlayerPerfTags playerPrefTag;

    [SerializeField] private enum ItemTtype
    {
        TShirt,
        Trousers,
        Hair,
        FacialHair,
        Hat,
        Footwear,
        Sunglasses,
    }

    [SerializeField]
    private enum CharacterGender
    {
        Male,
        Female
    }
    [Header(" Elements ")]
    [SerializeField] private CharacterGender characterGender;
    [SerializeField] private ItemTtype itemType;
    [SerializeField] private Image itemImage;

    [Header(" Settings ")]
    [SerializeField] private int itemIndex;

    private void Start()
    {
        switch (itemType)
        {
            case ItemTtype.TShirt:
                FetchMaleTShirts();
                break;
            case ItemTtype.Trousers:
                FetchMaleTrousers();
                break;
            case ItemTtype.Hair:
                FetchMaleHair();
                break;
            case ItemTtype.FacialHair:
                FetchMaleFacialHair();
                break;
            case ItemTtype.Hat:
                FetchMaleHat();
                break;
            case ItemTtype.Footwear:
                FetchMaleFootwear();
                break;
            case ItemTtype.Sunglasses:
                FetchMaleSunglasses();
                break;

            default: 
                break; 
        }
    }

    #region Male Fetcher
    private void FetchMaleTShirts() => itemImage.sprite = itemImageScriptable.maleSprites.tShirtSprites[itemIndex];
    private void FetchMaleTrousers() => itemImage.sprite = itemImageScriptable.maleSprites.trouserSprites[itemIndex];
    private void FetchMaleHair() => itemImage.sprite = itemImageScriptable.maleSprites.hairSprites[itemIndex];
    private void FetchMaleFacialHair() => itemImage.sprite = itemImageScriptable.maleSprites.facialHairSprites[itemIndex];
    private void FetchMaleHat() => itemImage.sprite = itemImageScriptable.maleSprites.hatSprite[itemIndex];
    private void FetchMaleFootwear() => itemImage.sprite = itemImageScriptable.maleSprites.footwearSprite[itemIndex];
    private void FetchMaleSunglasses() => itemImage.sprite = itemImageScriptable.maleSprites.sunglassesSprite[itemIndex]; 
    #endregion
}
