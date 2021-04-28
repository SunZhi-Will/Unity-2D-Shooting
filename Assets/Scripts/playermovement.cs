using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rig;
    
    
    // Start is called before the first frame update
    void Start()
    {
        rig = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        ////print(xInput + "_" + yInput);
        ////this.gameObject.transform.position += 
        //new Vector3(xInput * speed*Time.deltaTime, yInput * speed * Time.deltaTime);
        rig.velocity = new Vector2(xInput * speed, yInput * speed);


        Vector3 mouseInputPosition = Input.mousePosition;
        //mouseInputPosition.z = 10;
        Vector3 mousePositiom = Camera.main.ScreenToWorldPoint(mouseInputPosition);
        

        this.transform.rotation = Quaternion.Euler(0,0,
            Mathf.Atan2(mousePositiom.y - transform.position.y,
            mousePositiom.x - transform.position.x) * Mathf.Rad2Deg);

    }
}
