using System;
using UnityEngine;

public class PlayerParameters : MonoBehaviour
{
    private static float _speed = 4.5f;

    public static float Speed { get => _speed; private set => _speed = value; }
}
