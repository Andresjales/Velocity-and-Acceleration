using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    Vector3 displacement;
    [SerializeField] Vector3 velocity;
    [SerializeField] Vector3 acceleration;
    [SerializeField] Transform planet;

    void Update()
    {
        Moving();
    }

    public void Moving()
    {
        Vector3 direction = planet.position - transform.position;
        acceleration = direction;

        velocity += acceleration * Time.deltaTime;

        displacement = velocity * Time.deltaTime;
        transform.position = transform.position + displacement;

        acceleration.Draw(transform.position, Color.green);
        velocity.Draw(transform.position, Color.red);
        direction.Draw(Color.blue);
    }
}
