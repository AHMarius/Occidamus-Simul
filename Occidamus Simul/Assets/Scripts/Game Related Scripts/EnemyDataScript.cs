using System;
using UnityEngine;
using UnityEngine.Serialization;

public class EnemyDataScript : MonoBehaviour
{
    [Header("Main:")]
    [SerializeField]
    private string enemyName;

    [SerializeField]
    private string enemyClass; //taken randomly from a file with all the properties

    [Header("Enemy:")]
    public int enemyHealth;
    public int enemyArmor;
    public int enemyMovementSpeed;
    public int enemyAttackSpeed;
    public int enemyDamage;
    public int enemyLevel;
    public float enemyAttackRange;

    [FormerlySerializedAs("_enemyCharacter")]
    [Header("Extra")]
    [SerializeField]
    private EnemyCharacter enemyCharacter;

    private void Start()
    {
        GetComponent<SpriteRenderer>().sprite = enemyCharacter.enemySprite;
        enemyName = enemyCharacter.enemyName;
        enemyClass = enemyCharacter.enemyClass;
        enemyHealth = enemyCharacter.enemyHealth;
        enemyArmor = enemyCharacter.enemyArmor;
        enemyMovementSpeed = enemyCharacter.enemyMovementSpeed;
        enemyAttackSpeed = enemyCharacter.enemyAttackSpeed;
        enemyDamage = enemyCharacter.enemyDamage;
        enemyAttackRange = enemyCharacter.enemyAttackRange;
    }
}
