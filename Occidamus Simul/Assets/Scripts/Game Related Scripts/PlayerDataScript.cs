using UnityEngine;

public class PlayerDataScript : MonoBehaviour
{
    [Header("Main")]
    [SerializeField]
    private string playerName; //this will be taken from the main menu

    [SerializeField]
    private string playerClass; //this will be taken from the main menu

    [Header("Player:")]
    public float playerHealth;

    public float playerArmor;

    public float playerMovementSpeed;

    public float playerAttackSpeed;

    public float playerDamage;

    public float playerLevel;

    public float playerAttackRange;

    public int playerScore;

    [Header("Statistics:")]
    public int monstersKilled;

    public int damageDealt;

    public int totalScore;

    [Header("Time played (in seconds):")]
    public int timePlayed;
}
