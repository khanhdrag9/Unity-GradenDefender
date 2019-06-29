using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject gun = null;
    [SerializeField] Projectile projectile = null;

    public void Attack()
    {
        var obj = Instantiate(projectile, gun.transform.position, Quaternion.identity) as Projectile;
        obj.SetDirect(Vector2.right);
    }
}
