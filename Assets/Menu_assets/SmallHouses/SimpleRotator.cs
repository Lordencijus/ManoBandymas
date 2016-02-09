using UnityEngine;
using System.Collections;

public class SimpleRotator : MonoBehaviour
{

    public float speed = 1f;

	void Update ()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
