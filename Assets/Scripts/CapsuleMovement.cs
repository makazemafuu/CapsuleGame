using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    Vector3 direction = new Vector3(1, 0, 0);
    Vector3 direction2 = new Vector3(-1, 0, 0);
    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime);
        Input.GetAxis("Horizontal");
    }

    // Start is called before the first frame update
    void Start()
    {

    }

}
