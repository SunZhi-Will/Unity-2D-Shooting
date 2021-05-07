using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playTran;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            transform.position = new Vector3(playTran.position.x,playTran.position.y,-10);
        }
        catch (System.Exception e)
        {
            
            
        }
        
        
    }
}
