using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliteObj : MonoBehaviour {


    void OnTriggerExit(Collider other)
    {
        // Destroy everything that leaves the trigger
        DestroyObject(other.gameObject);
    }

}
