using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*summary
 作者:90732120
 玩家子彈
 summary*/
public class Bullet : MonoBehaviour

{
    public float speed;
    public float destroyTime;
    public int damage;
	// Starl is called before the first frame update
	void Start ()
    {
        Destroy(this.gameObject, destroyTime);
	}
	
	// Update is called once per frame
	void Update ()
    {
        this.gameObject.transform.position += speed * this.transform.right * Time.deltaTime;
	}
    public void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.gameObject.tag.Equals("Enemy"))
        {
            other.gameObject.GetComponent<EnemyHealth>().AddDamage(damage);
            Destroy(this.gameObject);
        }else if(other.gameObject.tag.Equals("Wall")){
            try
            {
                other.gameObject.GetComponent<PlayHealth>().AddDamage(damage);
            }
            catch (System.Exception e)
            {
            }
            Destroy(this.gameObject);
        }
        
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
       
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
