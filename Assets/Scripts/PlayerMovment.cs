using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovment : MonoBehaviour
{
        Vector2 MoveVector;
        public float Speed = 1f;

    public void InputPLayer(InputAction.CallbackContext _context)
    {
        MoveVector = _context.ReadValue<Vector2>();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movment = new Vector3(MoveVector.x, 0, MoveVector.y);
        movment.Normalize();
        transform.Translate(movment * Time.deltaTime * Speed);
    }
}
