using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class WASDRB2d_NEW : MonoBehaviour
{
    //variables
    public Rigidbody2D rb;

    public float movespeed;

    private Vector2 _movedirection;

    public InputActionReference move;

   

    // Update is called once per frame
    void Update()
    {
        _movedirection = move.action.ReadValue<Vector2>();
    }


    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(x: _movedirection.x * movespeed, y: _movedirection.y * movespeed);
    }
}
