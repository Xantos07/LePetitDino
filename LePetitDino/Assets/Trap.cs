using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    void Update()
    {
        transform.Translate(new Vector3(-1,0,0) * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
