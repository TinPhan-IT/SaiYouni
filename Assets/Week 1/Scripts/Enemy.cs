using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    // 5 Enemies variables

    //variables 1 
    protected int maxEnemyHealth = 100;

    //variables 2
    protected int enemyHealth = 100;

    //variables 3 
    protected string enemyName;

    //variables 4 
    protected bool isDead = false;

    //variables 5 
    protected GameObject enemy;

    // 5 Enemies methods

    //Method 1
    protected virtual string GetEnemyName()
    {
        return enemyName;
    }

    //Method 2
    protected virtual void SetEnemyName(string name)
    {
        name = enemyName;
    }

    //Method 3
    public void TakeDamage(int damage)
    {
        enemyHealth -= damage;
        if (enemyHealth <= 0)
        {
            enemyHealth = 0;
            isDead = true;
        }
    }

    //Method 4
    public void HealEnemy(int healAmount)
    {
        if(isDead) return;
        enemyHealth += healAmount;
        if(enemyHealth > maxEnemyHealth) enemyHealth = maxEnemyHealth;
    }

    //Method 5
    public virtual bool CheckDead()
    {
        return isDead;
    }
}