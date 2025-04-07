using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy : MonoBehaviour
{
    public List<Enemy> enemyList;
    //----------------------Edit below here --------------------
    public Enemy FindEnemyWithSmallestHealth()
    {
        Enemy smallestHealthEnemy = enemyList[0];
        foreach (Enemy enemy in enemyList)
        {
            if (enemy.CheckDead()) continue;
            if(enemy.enemyHealth < smallestHealthEnemy.enemyHealth)
            {
                smallestHealthEnemy = enemy;
            }
        }
        return smallestHealthEnemy;
    }

    public Enemy FindEnemyWithLargestHealth()
    {
        Enemy largestHealthEnemy = enemyList[0];
        foreach (Enemy enemy in enemyList)
        {
            if (enemy.CheckDead()) continue;
            if (enemy.enemyHealth > largestHealthEnemy.enemyHealth)
            {
                largestHealthEnemy = enemy;
            }
        }
        return largestHealthEnemy;
    }

    //----------------------Edit above here --------------------
}
