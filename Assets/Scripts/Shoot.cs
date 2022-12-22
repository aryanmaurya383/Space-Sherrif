using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public static int numOfBulletsFired;
    public static bool isBulletFiredNow;
    public static bool isBulletPresent;

    public AudioSource fireSoundEffect;
    // Start is called before the first frame update
    void Start()
    {
        isBulletFiredNow=false;
        isBulletPresent = false;
        numOfBulletsFired = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isBulletPresent&&Input.GetMouseButtonDown(0))
        { 
           
            ShootBullet();
             fireSoundEffect.Play();
            numOfBulletsFired++;
            isBulletFiredNow = true;
            isBulletPresent = true;
        }
    }
    public void ShootBullet()
    {
        
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
