using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{

    TargetManager targetManager;
    public float speed = 10f;
    private void Awake()
    {
        targetManager = FindObjectOfType<TargetManager>();
    }
    private void OnEnable()
    {
        gameObject.transform.position = targetManager.target.transform.position + new Vector3(0, 2, -2);
        gameObject.transform.rotation = Quaternion.Euler(0, targetManager.cameraTranform.eulerAngles.y, transform.rotation.z);
    }

    private void Update()
    {

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
