using UnityEngine;

[CreateAssetMenu(fileName = "New Character", menuName = "Character")]
public class PlayerCharacter : ScriptableObject
{
    public Sprite characterSprite;
    public string characterName;
    public string characterClass;
    public int characterHealth;
    public int characterArmor;
    public int characterMovementSpeed;
    public int characterDamage;
    public int characterAttackSpeed;
    public float characterAttackRange;
}
