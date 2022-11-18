using UnityEngine;

public class PlayerDataScript : MonoBehaviour
{
    [Header("Main")]
    [SerializeField]
    private string playerName; //this will be taken from the main menu

    [SerializeField]
    private string playerClass; //this will be taken from the main menu

    [Header("Player:")]
    public int playerHealth;
    public int playerArmor;
    public int playerMovementSpeed;
    public int playerAttackSpeed;
    public int playerDamage;
    public int playerLevel;
    public float playerAttackRange;
    public int playerScore;

    [Header("Statistics:")]
    public int monstersKilled = 0;

    public int damageDealt = 0;

    public int totalScore = 0;

    [Header("Time played (in seconds):")]
    public int timePlayed = 0;

    [Header("Extra:")]
    [SerializeField]
    private PlayerCharacter character;

    //-------------------------------

    private void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = character.characterSprite;
        playerClass = character.characterClass;
        playerHealth = character.characterHealth;
        playerArmor = character.characterArmor;
        playerMovementSpeed = character.characterMovementSpeed;
        playerDamage = character.characterDamage;
        playerAttackSpeed = character.characterAttackSpeed;
        playerAttackRange = character.characterAttackRange;
        playerLevel = 0;
        playerScore = 0;
    }
}
