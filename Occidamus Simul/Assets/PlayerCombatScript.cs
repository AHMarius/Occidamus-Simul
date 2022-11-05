using System;
using UnityEngine;

public class PlayerCombatScript : MonoBehaviour
{
    public LayerMask enemyLayers;

    public void Attack(Transform attackPoint, float attackRange)
    {
        //To do:
        //Play animation
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(
            attackPoint.position,
            attackRange,
            enemyLayers
        );
        foreach (Collider2D enemy in hitEnemies)
        {
            //Damage the enemy
        }
    }
}
