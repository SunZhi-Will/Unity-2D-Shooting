using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySkill : MonoBehaviour
{
    public GameObject bullet;
    public Transform shootPoint;
    private bool attackTime = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && !attackTime)
        {
            Destroy(Instantiate(bullet, shootPoint.position, shootPoint.rotation), 20f);
            attackTime = true;
            StartCoroutine(WaitAndPrint(5f));
        }
    }
    private IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        attackTime = false;
    }
}
