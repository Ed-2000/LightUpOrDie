using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private GameObject[] _rotatedObjects;

    private void Start()
    {

        for (int i = 0; i < _rotatedObjects.Length; i++)
        {
            if (_rotatedObjects[i].isStatic)
            {
                _rotatedObjects[i].isStatic = false;
            }

            _rotatedObjects[i].transform.Rotate(0, Random.Range(0, 360), 0);
            _rotatedObjects[i].isStatic = true;
        }
    }
}
