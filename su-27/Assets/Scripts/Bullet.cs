using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 2;
    public float speed = 20f;
    public Rigidbody2D rb;
   
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
       

    }
  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        HealthPoints hp = collision.GetComponent<HealthPoints>();
        if (hp != null)
        {
            hp.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
