using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]
public class EnemyCharacter : ScriptableObject
{
    public Sprite enemySprite;
    public string enemyName;
    public string enemyClass;
    public int enemyHealth;
    public int enemyArmor;
    public int enemyMovementSpeed;
    public int enemyDamage;
    public int enemyAttackSpeed;
    public float enemyAttackRange;
}
