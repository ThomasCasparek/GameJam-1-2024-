using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetHP : MonoBehaviour
{
    public EnemyRPG enemy;
    private void Awake()
    {
        enemy.enemyHP = enemy.enemyMaxHP;
    }
}
