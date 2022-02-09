using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 displacement;
    [SerializeField] Vector3 velocity;

    void Update()
    {
        Moving();
    }

    public void Moving()
    {
        displacement = velocity * Time.deltaTime;
        transform.position = transform.position + displacement;
    }
}
