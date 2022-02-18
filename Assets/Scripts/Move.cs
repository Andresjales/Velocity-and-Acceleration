using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 displacement;
    [SerializeField] Vector3 velocity;
    [SerializeField] float xBorder, yBorder;
    [SerializeField] Vector3 acceleration;

    void Update()
    {
        Moving();
        CheckCollisions();
    }

    public void Moving()
    {
        velocity += acceleration * Time.deltaTime;
        displacement = velocity * Time.deltaTime;
        transform.position = transform.position + displacement;

        acceleration.Draw(transform.position, Color.green);
        velocity.Draw(transform.position, Color.red);
        transform.position.Draw(Color.blue);
    }

    private void CheckCollisions()
    {
        if(transform.position.x >= xBorder || transform.position.x <= -xBorder)
        {
            if(transform.position.x >= xBorder)
            {
                transform.position = new Vector3(xBorder, transform.position.y, 0);
            }
            else if(transform.position.x <= -xBorder)
            {
                transform.position = new Vector3(-xBorder, transform.position.y, 0);
            }

            velocity.x = velocity.x * -1;
        }
        else if(transform.position.y >= yBorder || transform.position.y <= -yBorder)
        {
            if (transform.position.y >= yBorder)
            {
                transform.position = new Vector3(transform.position.x, yBorder, 0);
            }
            else if (transform.position.y <= -yBorder)
            {
                transform.position = new Vector3(transform.position.x, -yBorder, 0);
            }

            velocity.y = velocity.y * -1;
        }
    }
}
