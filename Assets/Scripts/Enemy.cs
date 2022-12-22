using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static int enemiesDied = 0;
    public AudioSource hitSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            
            Destroy(this.gameObject);
             hitSoundEffect.Play();

            enemiesDied++;
            ScoreCounter.scoreValue = ScoreCounter.scoreValue + 100 - Shoot.numOfBulletsFired * 10;
        }
    }
}
