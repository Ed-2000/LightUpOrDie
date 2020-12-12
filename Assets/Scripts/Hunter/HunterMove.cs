using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HunterMove : MonoBehaviour
{
    [SerializeField] private Transform[] _transforms;

    private Transform _target;
    private NavMeshAgent _agent;

    private void Start()
    {
        _target = _transforms[Random.Range(0, _transforms.Length)];
        _agent = GetComponent < NavMeshAgent>();

        _agent.SetDestination(_target.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject otherGO = other.gameObject;

        //if (otherGO.GetComponent<>())
        //{
        //    _target = _transforms[Random.Range(0, _transforms.Length)];
        //}
    }
}
