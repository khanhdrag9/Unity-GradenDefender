using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int HP = 100;
    
    public void Reduce(int value)
    {
        HP -= value;
        if(HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
