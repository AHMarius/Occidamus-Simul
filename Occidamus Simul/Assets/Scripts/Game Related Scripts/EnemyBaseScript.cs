using UnityEngine;

public class EnemyBaseScript : MonoBehaviour
{
    private EnemyDataScript _enemyData;

    private void Start()
    {
        _enemyData = GetComponent<EnemyDataScript>();
    }

    public void TakeDamage(float damage, PlayerDataScript player)
    {
        //Animations
        _enemyData.enemyHealth -= damage;
        if (_enemyData.enemyHealth <= 0)
        {
            Die();
            player.monstersKilled++;
        }
        print($"Enemy took {damage}");
    }

    private void Die()
    {
        //Animations
        Destroy(this.gameObject);
    }
}
