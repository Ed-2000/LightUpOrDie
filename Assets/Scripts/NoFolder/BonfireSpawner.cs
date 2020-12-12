using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonfireSpawner : MonoBehaviour
{
    [SerializeField] private int _numberOfBonfires = 7;
    [SerializeField] private GameObject _parent;
    [SerializeField] private GameObject _bonfirePrefab;
    [SerializeField] private Transform[] _transforms;

    private List<int> _indexes;
    private List<GameObject> _bonfires;

    private void Start()
    {
        _indexes = new List<int>();
        _bonfires = new List<GameObject>();
        _indexes = SomeMath.CreateRandomUniqueIndexes(_numberOfBonfires, 0, _transforms.Length);

        for (int i = 0; i < _numberOfBonfires; i++)
        {
            GameObject newBonfire = Instantiate(_bonfirePrefab);
            newBonfire.transform.position = _transforms[_indexes[i]].position;
            newBonfire.transform.parent = _parent.transform;

            _bonfires.Add(newBonfire);
        }
    }
}