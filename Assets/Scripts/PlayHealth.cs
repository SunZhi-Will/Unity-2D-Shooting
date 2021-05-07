using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayHealth : MonoBehaviour
{
    public int maxHp;
    public int hp;
    public GameObject blood;
    public GameObject uiGameOver;
    
	// Start is called before the first frame update
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    public void AddDamage(int dmg)
    {
        hp -= dmg;
        if(hp <= 0)
        {
            Instantiate(blood, transform.position, transform.rotation);
            try
            {
                uiGameOver.SetActive(true);
            }
            catch (System.Exception)
            {
                
                
            }
            
            Destroy(this.gameObject);
        }
        
    }
}
