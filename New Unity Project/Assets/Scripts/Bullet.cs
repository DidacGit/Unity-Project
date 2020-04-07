using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float liveTime = 4f;
    private void OnTriggerEnter(Collider other)
    {
        //Intentamos almacenar el componente Enemy en una variable (Esto dará null si el componente es un FirstAidKit o Ammunition
        Enemy enemy = other.GetComponentInParent<Enemy>();
        //Si no es null
        if (enemy != null)
        {
            enemy.kill(); // life = life - enemy.crashDamage;
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        if (liveTime < 0)
            Destroy(gameObject);
        liveTime -= Time.deltaTime;
    }
}
