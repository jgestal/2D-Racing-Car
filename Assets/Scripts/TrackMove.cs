using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackMove : MonoBehaviour
{

    [SerializeField] float speed = 0.5f;
    Vector3 offset; 

    void Start() {

    }
    void Update() {
        offset = new Vector2(0, Time.time * speed);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }

}
