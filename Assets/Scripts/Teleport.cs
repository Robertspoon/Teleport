using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        //targetPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.T))
        {

           Vector3 deltaPosition = targetPosition - gameObject.transform.position;
            
           gameObject.GetComponent<CharacterController>().Move(deltaPosition);
           gameObject.GetComponent<CharacterController>().SimpleMove(Vector3.zero);


            //gameObject.SetActive(false);//hack, not reccomended
            // gameObject.transform.position = Vector3.zero;        
            //  gameObject.SetActive(true);

        }

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
