using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform _player;
    public Vector3 _offset;
    public float _smoth = 1f;
    public bool _rotationActive = true;
    public float _velroTation = 5.0f;

    public bool _lookAtPlayer = false;

    void Start()
    {
        _offset = transform.position - _player.position;
    }

    private void FixedUpdate()
    {
        if (_rotationActive)
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X")*_velroTation,Vector3.up);
            _offset = camTurnAngle * _offset;

        }
        Vector3 newpos = _player.position + _offset;
        transform.position = Vector3.Slerp(transform.position, newpos, _smoth);

        if (_lookAtPlayer || _rotationActive)
        {
            transform.LookAt(_player);

        }
    }
}
