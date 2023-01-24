using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Vector3 targetPosition;
    public GameObject killbox;
    

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            targetPosition = gameObject.transform.position;
        }
    }
}
