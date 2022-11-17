using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject Player;
    NavMeshAgent navMesh;

    void OnTriggerEnter(Collider other)
    {

        Player.transform.position = teleportTarget.transform.position;
    }
}
