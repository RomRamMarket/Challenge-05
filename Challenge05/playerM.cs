using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class playerM : MonoBehaviour
{
    public float speed = 4; // Velocidad normal
    public float sprintSpeed = 15; // Velocidad de sprint
    private float currentSpeed; // Velocidad actual
    private Vector2 movementValue; 
    private bool sprint = false; // Indica si hay sprint al presionar shift + key (A,S,D,W,Up arrow, Down arrow, Left arrow, Right arrow)

    // esto si se presiona solo (A, D, <-, ->)
    public void OnHorizontalMovement(InputValue value)
    {
        movementValue = value.Get<Vector2>();
        print("Velocidad Normal:( esto funciona");
        currentSpeed = speed; //volver a la speed original 
    }

    // esto pasa cuando se presiona Shift + A
    public void OnFastHorizontalMovement(InputValue value)
    {
        currentSpeed = sprintSpeed;  // Cambiar a velocidad rápida
        print("Shift + A: velocidad rápida:) y esto tambien");
    }

    void Update()
    {
        // Mover horizontalmente depende del currentSpeed (depende de si hay sprint o no)
        transform.Translate(Time.deltaTime * movementValue.x * currentSpeed, 0, 0);
    }
}