using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCounter : MonoBehaviour
{
    public Rigidbody2D [] bulletsCounterSprite;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Shoot.isBulletFiredNow)
        {
            Destroy(bulletsCounterSprite[Shoot.numOfBulletsFired-1].gameObject);
            Shoot.isBulletFiredNow = false;

        }
    }
    public  void DestroyBulletCounterSprite(int indexOfBullet)
    {
    }


   
}
