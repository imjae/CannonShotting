using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    float power;
    public GameObject rotaterTranform;

    GameObject cannon;
    // Start is called before the first frame update
    void Start()
    {

        GameObject tower = FindObjectOfType<Shoot>().gameObject;
        GameObject rotater = tower.transform.Find("rotater").gameObject;
        GameObject cannon = rotater.transform.Find("cannon").gameObject;

        float rotateX = cannon.transform.rotation.x;
        float rotateY = cannon.transform.rotation.y;
        float rotateZ = cannon.transform.rotation.z;

        Debug.Log(cannon.transform.rotation);

        Vector3 v = new Vector3(rotateX, rotateY, rotateZ);

        Debug.Log(v);

        power = FindObjectOfType<Shoot>().powerGauge;
        Rigidbody bulletRigidbody = GetComponent<Rigidbody>();

        Vector3 direction = transform.up;
        var quaternion = Quaternion.Euler(52, 0, 0);

        Vector3 newDirection = quaternion * direction;
        if (bulletRigidbody != null)
            bulletRigidbody.AddForce(newDirection * power);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
