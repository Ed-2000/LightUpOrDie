using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowwormMove : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private float _speed = 5.5f;

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, _target.position, _speed * Time.deltaTime);
    }
}