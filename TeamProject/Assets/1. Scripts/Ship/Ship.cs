using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    public float forwardSpeed = 25f;
    public float leftRightSpeed = 7.5f;
    public float upSpeed = 5f;

    float actForwardSpeed;
    float actLeftRightSpeed;
    float actUpSpeed;

    float forwardAcc = 2.5f;
    float leftRightAcc = 2.0f;
    float upAcc = 2.0f;



    public float lookRateSpeed = 90.0f;
    Vector2 lookInput;
    Vector2 screenCenter;
    Vector2 mouseDistance;

    float rollInput;
    public float rollSpeed = 90.0f, roolAcc = 3.5f;



    public Transform gun;
    public GameObject bullet;
    private void Start()
    {
        screenCenter.x = Screen.width * 0.5f;
        screenCenter.y = Screen.height * 0.5f;

        Cursor.lockState = CursorLockMode.Confined;
    }
    private void Update()
    {
        Move();
        Shooting();
    }

    void Move()
    {
        lookInput.x = Input.mousePosition.x;
        lookInput.y = Input.mousePosition.y;

        mouseDistance.x = (lookInput.x - screenCenter.x) / screenCenter.x;
        mouseDistance.y = (lookInput.y - screenCenter.y) / screenCenter.y;

        mouseDistance = Vector2.ClampMagnitude(mouseDistance, 1f);

        rollInput = Mathf.Lerp(rollInput, Input.GetAxisRaw("Roll"), roolAcc * Time.deltaTime);
        transform.Rotate(-mouseDistance.y * lookRateSpeed * Time.deltaTime, mouseDistance.x * lookRateSpeed * Time.deltaTime, rollInput * rollSpeed * Time.deltaTime, Space.Self);

        actForwardSpeed = Mathf.Lerp(actForwardSpeed, Input.GetAxisRaw("Vertical") * forwardSpeed, forwardAcc * Time.deltaTime);
        actLeftRightSpeed = Mathf.Lerp(actLeftRightSpeed, Input.GetAxisRaw("Horizontal") * leftRightSpeed, leftRightAcc * Time.deltaTime);
        actUpSpeed = Mathf.Lerp(actUpSpeed, Input.GetAxisRaw("Hover") * upSpeed, upAcc * Time.deltaTime);

        transform.position += transform.forward * actForwardSpeed * Time.deltaTime;
        transform.position += (transform.right * actLeftRightSpeed * Time.deltaTime) + (transform.up * actUpSpeed * Time.deltaTime);
    }

    void Shooting()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject shoot = GameObject.Instantiate(bullet, gun.position, gun.rotation) as GameObject;
        }
    }


}
