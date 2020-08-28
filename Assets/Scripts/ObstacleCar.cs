using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCar : MonoBehaviour
{
    [SerializeField] float speed = -4f;

    void Update()
    {
        transform.Translate(new Vector3(0,1,0) * speed * Time.deltaTime);
    }
}
