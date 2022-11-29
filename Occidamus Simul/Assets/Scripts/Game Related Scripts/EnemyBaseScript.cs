using UnityEngine;

public class EnemyBaseScript : MonoBehaviour
{
    private EnemyDataScript _enemyData;

    private void Start()
    {
        _enemyData = GetComponent<EnemyDataScript>();
    }

    public void TakeDamage(int damage, PlayerDataScript player)
    {
        //Animations
        if (_enemyData.enemyHealth > 0)
            _enemyData.enemyHealth -= damage;
        else if (_enemyData.enemyHealth <= 0)
        {
            player.monstersKilled++;
            Die();
        }
        print($"Enemy took {damage}");
    }

    private void Die()
    {
        //Animations
        print(this.name + "was killed");
        Destroy(this.gameObject);
    }
}
