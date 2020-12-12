using UnityEngine;

public class PlayerParameters : MonoBehaviour
{
    private static float _speed = 3.5f;
    private static float _rotateSpeed = 0.1f;
    private static int _numberOfMatches = 0;

    public static float Speed { get => _speed; private set => _speed = value; }
    public static int NumberOfMatches { get => _numberOfMatches; set => _numberOfMatches = value; }
    public static float RotateSpeed { get => _rotateSpeed; set => _rotateSpeed = value; }
}