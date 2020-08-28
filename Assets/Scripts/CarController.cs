using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] float horizontalSpeed = 10.0f;
    [SerializeField] float minX;
    [SerializeField] float maxX;

    // Update is called once per frame
    void Update()
    {
        HorizontalMovement();
    }

    private void HorizontalMovement() 
    {
        float xOffset = Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime;
        float newXPos = transform.position.x + xOffset;
        float newXPosClamped = Mathf.Clamp(newXPos,minX, maxX);

        transform.position = new Vector3(newXPosClamped, transform.position.y, transform.position.z);
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "OtherCar") {
            Destroy(gameObject);
        }
    }
}
