using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiPlayHp : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayHealth playHealth;
    public Image gHp;
    public Image hp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hp.fillAmount = (float)playHealth.hp/(float)playHealth.maxHp;
        gHp.fillAmount -= (gHp.fillAmount - hp.fillAmount) * Time.deltaTime;
    }
}
