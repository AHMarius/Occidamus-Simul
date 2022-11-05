using System;
using UnityEngine;

public class PlayerCombatScript : MonoBehaviour
{
    public LayerMask enemyLayers;
    private PlayerDataScript _playerData;
    private Collider2D[] _hitEnemies;

    public void Attack(Transform attackPoint, float attackRange, float playerDamage)
    {
        //To do:
        //Play animation
        try
        {
            _hitEnemies = Physics2D.OverlapCircleAll(
                attackPoint.position,
                attackRange,
                enemyLayers
            );
            foreach (var enemy in _hitEnemies)
            {
                enemy.GetComponent<EnemyBaseScript>().TakeDamage(playerDamage, _playerData);
            }
        }
        catch (Exception e)
        {
            print("Error: " + e);
        }
    }
}
