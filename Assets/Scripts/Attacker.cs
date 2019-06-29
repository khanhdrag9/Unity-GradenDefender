using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField] float speedMove = 1f;
    float currentSpeed = 0;
    
    void Start()
    {
    }

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * currentSpeed);
    }

    void Move()
    {
        currentSpeed = speedMove;
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
