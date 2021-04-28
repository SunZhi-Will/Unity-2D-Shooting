using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHp;
    public int hp;
    public AudioSource audioSource;
    public GameObject blood;
    public EnemyMovement enemyMovement;
    
	// Start is called before the first frame update
	void Start ()
    {
		enemyMovement = gameObject.GetComponent<EnemyMovement>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public void AddDamage(int dmg)
    {
        hp -= dmg;
        try
        {
            enemyMovement.SettleDown(0.5f,0.1f);
        }
        catch (System.Exception e)
        {
            
            
        }
        
        if(hp <= 0)
        {
            Instantiate(blood, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
        audioSource.Play();
        
    }
}
