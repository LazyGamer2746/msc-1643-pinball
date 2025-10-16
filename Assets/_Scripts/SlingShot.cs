using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingShot : MonoBehaviour
{
    public float bumpForce = 1.0f;
    public int points = 150;
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponentInChildren<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("PlayerBall"))
        {
            audioSource.Play();
            Rigidbody rb = collision.rigidbody;
            rb.AddForce(transform.forward * bumpForce, ForceMode.Impulse);
            ScoreManager.AddScore(points);
        }
    }
}
