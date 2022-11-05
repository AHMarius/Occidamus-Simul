using UnityEngine;

public class EnemyDataScript : MonoBehaviour
{
    [Header("Main:")]
    [SerializeField]
    private string enemyName;

    [SerializeField]
    private string enemyClass; //taken randomly from a file with all the properties

    [Header("Enemy:")]
    public float enemyHealth;

    public float enemyArmor;

    public float enemyMovementSpeed;

    public float enemyAttackSpeed;

    public float enemyDamage;

    public float enemyLevel;

    public float enemyAttackRange;
}
