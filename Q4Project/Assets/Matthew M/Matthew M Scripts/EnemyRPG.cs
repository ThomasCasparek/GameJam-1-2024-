using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRPG : MonoBehaviour
{
    public string EnemyName;
    public int enemyHP;
    public int enemyMaxHP;
    public int enemydamage;
    public int enemyEXP;

    public bool TakeDamage(int damage)
    {
        enemyHP -= damage;

        if (enemyHP <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
