using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnner : MonoBehaviour
{
    [SerializeField] private GameObject trap;

    [SerializeField] private float timer = 4f;
    float index = 0f;
    
    private void Update()
    {
        index += Time.deltaTime;

        if (index >= timer)
        {
            Instantiate(trap, transform.position, Quaternion.identity);
            index = 0f;
        }
    }
}
