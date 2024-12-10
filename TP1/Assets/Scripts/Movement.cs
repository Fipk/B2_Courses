using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 20f;
    // Update is called once per frame
    void Update()
    {

        // Movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2 (horizontal, vertical);

        transform.Translate(movement * Time.deltaTime * speed);

    }
}
