using System;
using UnityEngine;

public class PlayerCombatScript : MonoBehaviour
{
    public LayerMask enemyLayers;
    private PlayerDataScript _playerData;
    private Collider2D[] _hitEnemies;

    private void Start()
    {
        _playerData = this.GetComponent<PlayerDataScript>();
    }

    public void Attack(Transform attackPoint, float attackRange, int playerDamage)
    {
        //To do:
        //Play animation
        // try
        // {
        _hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        foreach (var enemy in _hitEnemies)
        {
            if (enemy.TryGetComponent(out EnemyBaseScript ebs))
                ebs.TakeDamage(playerDamage, _playerData);
        }
        // }
        /*catch (Exception e)
        {
            print("Error: " + e);
            foreach (var enemy in _hitEnemies)
                print(enemy + "" + enemy.GetComponent<EnemyDataScript>().enemyHealth);
        }*/
    }
}
