using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float engineThurst = 10000f;
    public float pitchSpeed = 30f;
    public float rollSpeed = 45f;
    public float yawSpeed = 25f;

    Rigidbody rigid;

    float thrust=1f;
    float pitch;
    float roll;
    float yaw;

    public float speed;
    float height;
    public GameObject bullet;
    public Transform cameraTranform;
    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();




    }

    private void Update()
    {
        pitch = 0f;
        roll = 0f;
        yaw = 0f;
        if (Input.GetKey(KeyCode.Q))
        {
            yaw = -1f;
        }
        if (Input.GetKey(KeyCode.E))
        {
            yaw = 1f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            roll = 1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            roll = -1f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            pitch = 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pitch = -1f;
        }

        Shoot();

        height = transform.position.y -1f;

    }

    void Shoot()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            //bullet.transform.position = gameObject.transform.position + new Vector3(0, 2, -2);
            //bullet.transform.rotation = Quaternion.Euler(0, cameraTranform.eulerAngles.y, 0);

        }
    }


    private void FixedUpdate()
    {
        transform.RotateAround(transform.position, transform.up, yaw * Time.fixedDeltaTime * yawSpeed); //zÃà
        transform.RotateAround(transform.position, transform.forward, roll * Time.fixedDeltaTime * rollSpeed); //yÃà
        transform.RotateAround(transform.position, transform.right, pitch * Time.fixedDeltaTime * pitchSpeed); //xÃà

        //if(transform.position.y >1000 
        //    || transform.position.y<-1000 
        //    || transform.position.x>1000 
        //    || transform.position.x<-1000
        //    || transform.position.z>1000
        //    || transform.position.z<-1000)

        //{
        //    transform.position = new Vector3(0, 0, 0);
        //}

        //rigid.AddForce((thrust * engineThurst) * transform.forward);
    }
}
