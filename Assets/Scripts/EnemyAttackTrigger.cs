using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackTrigger : MonoBehaviour
{
    

    //Update is called once per frame
    private bool attackTime = false;
    public int damage;
    EnemyMovement em;
    void Start ()
    {
        em = this.gameObject.GetComponent<EnemyMovement>();
	}

    public void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.tag.Equals("Player") && !attackTime)
        {
            other.gameObject.GetComponent<PlayHealth>().AddDamage(damage);
            attackTime = true;
            em.SettleDown(0,1);
            StartCoroutine(WaitAndPrint(0.5f));
        }else if(other.gameObject.tag.Equals("Wall")  && !attackTime){
            try
            {
                other.gameObject.GetComponent<PlayHealth>().AddDamage(damage);
                attackTime = true;
                StartCoroutine(WaitAndPrint(0.5f));
            }
            catch (System.Exception e)
            {
            }
        }
    }
    private IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        attackTime = false;
        
    }
}
