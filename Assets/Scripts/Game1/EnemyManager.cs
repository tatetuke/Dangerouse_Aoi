using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class EnemyManager : SceneChanger
{
    public Wave[] waves;
    public int wave;
    public float time;
    public int EnemyCnt => waves[wave].patterns.Count + FindObjectsOfType<GameEnemy>().Length;
 

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        CreateEnemy();
        if (EnemyCnt == 0)
        {
            if (waves.Length-1 == wave)
            {
                GameOverScene();
            }
            wave++;
            time = 0;
        }
        
    }

    public void CreateEnemy()
    {
        foreach (var pattern in waves[wave].patterns)
        {
            if (pattern.time <= time)
            {
                var enemy = Instantiate(pattern.enemy, new Vector3(-1000, -1000), Quaternion.identity);
                enemy.route = pattern.route;
            }
        }
       
        waves[wave].patterns.RemoveAll(pattern => pattern.time <= time);
    }
}

[Serializable]
public class Wave
{
    public List<EnemyPattern> patterns;
}

[Serializable]
public class EnemyPattern
{
    public float time;
    public GameEnemy enemy;
    public Route route;
}
