using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleOnTrigger : MonoBehaviour
{
    [SerializeField] FloorSpeed floor;

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "Capsule")
        {
            Debug.Log("La capsule trigger le FinishLine");
            //col.gameObject.transform.GetComponent<FloorSpeed>();
            floor.stop();
        }
    }
}
