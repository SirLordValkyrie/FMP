using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    
    private void OnTriggerEnter ()
    {
        Destroy(gameObject);
    }

}