using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Debug.Log("Collided");
            SceneManager.LoadScene("Level 1");
        }

    }
}
