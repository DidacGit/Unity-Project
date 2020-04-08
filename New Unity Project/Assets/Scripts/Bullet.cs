using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float liveTime = 4f;

    public GameObject explosionEffect;
    private void OnTriggerEnter(Collider other)
    {
        //Intentamos almacenar el componente Enemy en una variable (Esto dará null si el componente es un FirstAidKit o Ammunition
        Enemy enemy = other.GetComponentInParent<Enemy>();
        //Si no es null
        if (enemy != null)
        {
            enemy.kill();
            //At the same time the enemy dies, it explodes
            Explode();
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (liveTime < 0)
            Destroy(gameObject);
        liveTime -= Time.deltaTime;
    }

    void Explode()
    {
        //Show explosion effect
        Instantiate(explosionEffect, transform.position, transform.rotation);
    }
}