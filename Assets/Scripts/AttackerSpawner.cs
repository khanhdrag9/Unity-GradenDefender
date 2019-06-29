using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] Attacker attacker = null;
    [SerializeField] float minTimeToSpawn = 3f;
    [SerializeField] float maxTimeToSpawn = 7f;
    bool isSpawn = true;

    void Start()
    {
        StartCoroutine(loopSpawn());
    }

    IEnumerator loopSpawn()
    {
        while(isSpawn)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(minTimeToSpawn, maxTimeToSpawn));
            spawnAttacker();
        }
    }

    void spawnAttacker()
    {
        var obj = Instantiate(attacker, transform.position, Quaternion.identity) as Attacker;
    }
}
