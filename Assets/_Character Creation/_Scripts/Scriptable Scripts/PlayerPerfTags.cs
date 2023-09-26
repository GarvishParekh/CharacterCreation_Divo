using UnityEngine;


[CreateAssetMenu(fileName = "PlayerPref Information", menuName = "PlayerPref/Tags")]
public class PlayerPerfTags : ScriptableObject
{
    public string userGender;           // 0 male, 1 female
    public string userBodyType;         // 0 thin, 1 regular, 2 fat
    public string userBodyColor;        // 0 fair, 1 regular, 2 dark
}
