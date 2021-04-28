using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemy;
    public Transform generatorPoint;
    //Start is called before the first frame update
    public float generatorTime = 5;
    public float generatorTimer;
    void Start()
    {
        generatorTimer = generatorTime;
    }
	
	// Update is called once per frame
	void Update ()
    {
        generatorTimer -= Time.deltaTime;
        if(generatorTimer <= 0)
        {
            Instantiate(enemy, generatorPoint.position, generatorPoint.rotation);
            generatorTimer = generatorTime;
        }
	}
}
