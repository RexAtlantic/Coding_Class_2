using UnityEngine;

public class WASDRB2d : MonoBehaviour
{
    //variables
    public Rigidbody2D rb;
    public float forceamount = 1f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //attach the rigidbody2d from this object to the script as rb
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Make the sqaure move up if W is pressed
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up * forceamount);
        }

        //Make Square move left if A is pressed
        if (Input.GetKey(KeyCode.A))
        { 
            rb.AddForce(Vector2.left * forceamount);
        }

        //Make Square move down if S is pressed
        if (Input.GetKey(KeyCode.S))
        { 
            rb.AddForce(Vector2.down * forceamount);
        }

        //Make Square move right if D is pressed
        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * forceamount);
        }

    }
}
