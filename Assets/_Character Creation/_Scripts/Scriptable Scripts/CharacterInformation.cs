using UnityEngine;

[CreateAssetMenu(fileName = "Avatar Information", menuName = "Character/Information")]
public class CharacterInformation : ScriptableObject
{
    public enum CharacterType
    {
        Male,
        Female
    }
    public CharacterType characterType;

    [Header(" Body Type Sprites ")]
    public Sprite maleThinSprite;
    public Sprite maleRegularSprite;
    public Sprite maleFatSprite;

    [Space]
    public Sprite femaleThinSprite;
    public Sprite femaleRegularSprite;
    public Sprite femaleFatSprite;
}
