using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public int crashDamage = 1;
    public bool damageOnDestroy = false;
    private void OnDestroy()
    {
        //Esto se ejecuta en el destructor
        if (damageOnDestroy)
        {
            //player -> applyDamage(crashDamage)
        }

    }

}
