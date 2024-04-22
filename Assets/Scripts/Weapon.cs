using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damage=10;
    private BoxCollider2D triggerBox2;

    public void Start()
    {
        triggerBox2 = GetComponent<BoxCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        var enemy = other.gameObject.GetComponent<Enemyhealth>();
        if (enemy!=null)
        {
            enemy.Health-= damage;
        }
    }

    public void EnableTriggerBox()
    {
        triggerBox2.enabled = true;
    }

    public void disableTriggerBox()
    {
        triggerBox2.enabled = false;
    }
}
