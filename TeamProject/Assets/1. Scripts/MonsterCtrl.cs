using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCtrl : MonoBehaviour
{
    public Transform target;

    public float speed;

    private void Start()
    {
        speed = Random.Range(50f, 100f);
        target = FindObjectOfType<TargetManager>().target;
    }

    void RotateEnemy()
    {
        Vector3 dir = target.position - transform.position;

        transform.localRotation =
            Quaternion.Slerp(transform.localRotation,
            Quaternion.LookRotation(dir), 5 * Time.fixedDeltaTime);
    }
    void MoveEnemy()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
    }

    private void FixedUpdate()
    {
        RotateEnemy();
        MoveEnemy();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            Destroy(gameObject);
        }
    }

}
