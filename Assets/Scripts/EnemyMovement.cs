using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float speed = 3;
    public float setSpeed = 3;
    public Rigidbody2D rig;
    public GameObject player;
    // Start is called before the first frame update
	void Start ()
    {
        rig = this.gameObject.GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        speed = setSpeed;
	}
	
	// Update is called once per frame
	void Update ()
    {
        rig.velocity = speed * this.transform.right;
        try
        {
            this.transform.rotation = Quaternion.Euler(0,0,
                Mathf.Atan2(player.transform.position.y - transform.position.y,
                player.transform.position.x - transform.position.x) * Mathf.Rad2Deg);
        }
        catch (System.Exception e)
        {
            
            
        }
        

	}
    public void SettleDown(float _speed, float _time){
        speed = _speed;
        StartCoroutine(WaitAndPrint(_time));
    }
    private IEnumerator WaitAndPrint(float waitTime)
    {
        
        yield return new WaitForSeconds(waitTime);
        speed = setSpeed;
        
    }
}
