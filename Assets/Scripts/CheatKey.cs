using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatKey : MonoBehaviour
{

    private GameObject spawner;

    private void Start()
    {
        spawner = GameObject.Find("EnemySpawnManager");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            DestroyMonsters();
        }
    }

    private void DestroyMonsters()
    {
        int childCount = spawner.transform.childCount;

        for (int i = 0; i < childCount; i++)
        {
            GameObject monster = spawner.transform.GetChild(i).gameObject;
            monster.GetComponent<Health>().takeDamage(5000, false);
        }
    }
}
