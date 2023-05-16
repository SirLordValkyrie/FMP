using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{
    [SerializeField] private GameObject camera;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == camera)
        {
            Debug.Log("Collided");
            SceneManager.LoadScene("Level 1");
        }

    }
}
