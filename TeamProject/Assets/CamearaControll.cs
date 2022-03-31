using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamearaControll : MonoBehaviour
{
    public float speed;
    Vector3 forward = new Vector3(0, 0, 1);
    Vector3 rotate = new Vector3(0, 5, 0);
    

    private void Update()
    {
        float v = Input.GetAxis("Vertical") * Time.deltaTime;
        float h = Input.GetAxis("Horizontal") * Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.up * speed*Time.deltaTime);
        }
        transform.Translate(forward * v * speed);
        transform.Rotate(rotate * h * speed);
    }
}
