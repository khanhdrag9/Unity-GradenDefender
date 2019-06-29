using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.transform.parent)
        {
            var attacker = collider.gameObject.transform.parent.GetComponent<Attacker>() as Attacker;
            if (attacker)
            {
                attacker.Die();
            }
        }

    }
}
