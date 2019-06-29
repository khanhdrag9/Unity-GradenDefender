using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] int damage = 20;
    Vector2 direct = Vector2.right;

    void Update()
    {
        transform.Translate(direct * Time.deltaTime * speed);
    }

    public void SetDirect(Vector2 direct)
    {
        this.direct = direct;
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.transform.parent)
        {
            var health = collider.gameObject.transform.parent.GetComponent<Health>();
            if(health)
            {
                health.Reduce(damage);
            }
        }
        Destroy(gameObject);
    }
}
