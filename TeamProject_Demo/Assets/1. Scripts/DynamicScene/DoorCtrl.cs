using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCtrl : MonoBehaviour
{
    public float floor;
    public GameObject elevator;
    Animator doorAnim;

    bool isOpen = false;

    private void Awake()
    {
        doorAnim = GetComponent<Animator>();
    }
    private void LateUpdate()
    {
        if (elevator.transform.position.y == floor)
        {
            doorAnim.SetBool("Open", true);
            isOpen = true;
        }
        else if (isOpen)
        {
            doorAnim.Play("DoorClose");
            doorAnim.SetBool("Open", false);
            isOpen = false;
        }
    }
}
