using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCri : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //print("HI");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(3f*Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 5f*Input.GetAxis("Vertical") * Time.deltaTime);
    }
}
