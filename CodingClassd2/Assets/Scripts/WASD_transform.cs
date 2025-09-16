using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class WASD_transform : MonoBehaviour
{
    //variables
    public float speed;

    private Vector2 position;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        position = transform.position;

        position.x += speed * Time.deltaTime;

        position.y += speed * Time.deltaTime;

        transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 is where we are located
        position = transform.position;

        //press W to go up
        if (Input.GetKey(KeyCode.W)) ;
        {
            position.y += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S)) ;
        {
            position.y -= speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            position.x += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            position.x -= speed * Time.deltaTime;
        }

        transform.position = position;
    }
}
