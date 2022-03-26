using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSpeed : MonoBehaviour
{

    [SerializeField] private float speed;

    private float timeSpan = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
    timeSpan += Time.deltaTime * 2;
    Debug.Log(transform.forward * (speed / 10) * timeSpan);
    transform.position -= transform.forward * (speed / 10) * timeSpan;
    }
}
