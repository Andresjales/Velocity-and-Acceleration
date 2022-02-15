using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 displacement;
    [SerializeField] Vector3 velocity;
    [SerializeField]float xBorder, yBorder;

    void Update()
    {
        Moving();
        CheckCollisions();
    }

    public void Moving()
    {
        displacement = velocity * Time.deltaTime;
        transform.position = transform.position + displacement;
    }

    private void CheckCollisions()
    {
        if(transform.position.x >= xBorder || transform.position.x <= -xBorder)
        {
            velocity.x = velocity.x * -1;
        }
        else if(transform.position.y >= yBorder || transform.position.y <= -yBorder)
        {
            velocity.y = velocity.y * -1;
        }
    }
}
