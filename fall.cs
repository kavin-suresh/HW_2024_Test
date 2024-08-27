using System.Collections;
using UnityEngine;

public class fall : MonoBehaviour
{
    bool isFalling = false;
    float downSpeed = 0;
    void onTriggerEnter(Collider collider)
    {
        if(collider.gameObject.name == "player")
        {
            isFalling = true;
            Destroy(gameObject, 10);
        }
    }
    void Update()
    {
        if(isFalling)
        {
            downSpeed += Time.deltaTime;
            transform.position = new Vector3(transform.position.x, transform.position.y - downSpeed, transform.position.z);
        }
    }
}
