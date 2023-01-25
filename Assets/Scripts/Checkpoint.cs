using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public Vector3 spawnPosition;
    public GameObject checkPoint;
    public GameObject checkPoint2;
    

    
    void Start()
    {
        spawnPosition = gameObject.transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Killbox"))
        {
            Vector3 deltaPosition = spawnPosition - transform.position;

            gameObject.GetComponent<CharacterController>().Move(deltaPosition);
            gameObject.GetComponent<CharacterController>().SimpleMove(Vector3.zero);
        }

        if (other.gameObject.CompareTag("Checkpoint"))
        {
            spawnPosition = checkPoint.transform.position;
            Destroy(checkPoint);
        }

       

    }
}
