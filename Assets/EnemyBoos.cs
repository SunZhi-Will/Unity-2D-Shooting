using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBoos : MonoBehaviour
{
    // Start is called before the first frame update
    public EnemyMovement enemyMovement;
    public float generatorTime = 10;
    public float generatorTimer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(generatorTimer <= 0)
        {
            enemyMovement.SettleDown(5,2);
            generatorTimer = generatorTime;
        }
        generatorTimer -= Time.deltaTime;
        
    }
}
