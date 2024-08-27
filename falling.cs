using UnityEngine;
using System.Collections;

public class falling : MonoBehaviour
{
    //public Rigidbody platform;
    bool playerEntered = false;
    float timeStood = 0f;

    void OnCollisionEnter()
    {
        playerEntered = true;
    }
    void Update()
    {

        if (playerEntered)
        {
            timeStood += Time.deltaTime;
            if (timeStood > 5) 
                GetComponent<Rigidbody>().useGravity = true;
        }
    }

    
}