using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTrigger : MonoBehaviour
{
    [SerializeField] FloorSpeed floor;

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "Capsule")
        {
            Debug.Log("La capsule touche un monstre");
            floor.stop();
        }
    }
}
