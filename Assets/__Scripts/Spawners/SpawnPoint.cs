using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This class is to identify that this is the "SpawnPoint"
public class SpawnPoint : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, 0.25f);
    }
}
