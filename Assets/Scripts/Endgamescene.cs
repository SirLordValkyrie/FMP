using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endgamescene : MonoBehaviour
{
    [SerializeField] public GameObject Player;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            SceneManager.LoadScene("End");
        }

    }
}
