using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killbox : MonoBehaviour
{
    public GameObject checkPoint;
    public Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        //targetPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Vector3 deltaPosition = targetPosition - other.transform.position;

            other.gameObject.GetComponent<CharacterController>().Move(deltaPosition);
            other.gameObject.GetComponent<CharacterController>().SimpleMove(Vector3.zero);
        }
    }
}
