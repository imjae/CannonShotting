using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMove : MonoBehaviour
{
    public Transform bulletTransfotm;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("ºÒ¸®³ª?");
        bulletTransfotm.position = new Vector3(0f, 5.6f, -44f);
    }

    // Update is called once per frame
    void Update()
    {
        float xCoor = Input.GetAxis("Horizontal");
        Vector3 moveVector = new Vector3(xCoor/10, 0, 0);

        transform.Translate(moveVector);
        bulletTransfotm.Translate(moveVector);
    }
}
