using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyhealth : MonoBehaviour
{
    public int Health= 50;

    private Animator anim;
    void Start()
    {
        
    }
    
    void Update()
    {
        Death();
    }



    void Death()
    {
        if (Health<=0)
        {
            Destroy(gameObject);
        }
    }
}
