using UnityEngine;
using System.Collections;

public class Rotor : MonoBehaviour
{
    public float Speed = 25;
    void Update()
    {
        transform.Rotate(0f, Speed * Time.deltaTime, 0f);
    }
}
