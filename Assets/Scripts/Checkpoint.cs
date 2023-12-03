using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Checkpoint : MonoBehaviour
{

    public GameObject NextCheckPoint;

    void Start()
    {
        NextCheckPoint.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") {
            NextCheckPoint.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}