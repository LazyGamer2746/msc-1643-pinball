using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class DeathZone : MonoBehaviour
{

    private GameManager manager;

    private void Start()
    {
        manager = FindObjectOfType<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("PlayerBall"))
        {
            Destroy(other.gameObject);


            manager.EndBall();

        }
    }
}
