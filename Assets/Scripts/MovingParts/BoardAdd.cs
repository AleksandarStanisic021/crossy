using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardAdd : MonoBehaviour
{
   
    private void onCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            coll.transform.parent = transform;
        }
    }

    private void onColliderExit(Collider other)
    {
        other.transform.parent = null;
    }
}
