using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSwitching : MonoBehaviour
{
    // Start is called before the first frame update
    public Image image;
    public SpriteRenderer spriteRenderer;
    public Sprite[] Gun;
    public Sprite[] weaponGun;
    public int gunInt = 0;
    public PlayerGun playerGun;
    void Start()
    {
        playerGun = gameObject.GetComponent<PlayerGun>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            gunInt++;
            if(gunInt == Gun.Length){
                gunInt = 0;
            }
            spriteRenderer.sprite = Gun[gunInt];
            image.sprite = weaponGun[gunInt];
            playerGun.SetBullet(gunInt);
        }
    }
}
