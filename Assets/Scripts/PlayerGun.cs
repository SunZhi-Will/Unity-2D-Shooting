using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public GameObject[] bullet;
    public int bulletInt;
    public Transform shootPoint;
    public AudioSource audioSource;
    private bool attackTime = false;

    

	// Start is called before the first frame update
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetMouseButton(0) && bulletInt == 1){
            if(!attackTime){
                attackTime = true;
                StartCoroutine(WaitAndPrint(0.1f));
            }
            
            //audioSource.Play();
        }else if(Input.GetMouseButtonDown(0))
        {
            //print("我開槍了");
            Instantiate(bullet[bulletInt], shootPoint.position, shootPoint.rotation);
            //audioSource.Play();
        }
        
	}
    public void SetBullet(int _gunInt){
        bulletInt = _gunInt;
    }
    private IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Instantiate(bullet[bulletInt], shootPoint.position, shootPoint.rotation);
        attackTime = false;
    }
}
