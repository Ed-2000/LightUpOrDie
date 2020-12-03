using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Joystick _joystick;
    private CharacterController _chController;
    private float _gravityForce;
    private float _hor;
    private float _vert;

    private void Start()
    {
        _joystick = GameObject.Find("Joystick").GetComponent<Joystick>();
        _chController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        //движение
        _hor = _joystick.Horizontal() * PlayerParameters.Speed;
        _vert = _joystick.Vertical() * PlayerParameters.Speed;

        Vector3 moveVector = new Vector3(_hor, 0, _vert);

        if (Vector3.Angle(Vector3.forward, moveVector) > 1f || Vector3.Angle(Vector3.forward, moveVector) == 0f)
        {
            Vector3 direct = Vector3.RotateTowards(transform.forward, moveVector, PlayerParameters.Speed / 15f, 0f);
            transform.rotation = Quaternion.LookRotation(direct);
        }

        moveVector.y = _gravityForce;

        _chController.Move(moveVector * Time.deltaTime);

        //влияние гравитации
        if (!_chController.isGrounded) _gravityForce -= 20f * Time.deltaTime;
        else _gravityForce = -1f;
    }
}