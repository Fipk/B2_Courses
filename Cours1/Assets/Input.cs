using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal"); // -1, 1 dans l'axee x
        float vertical = Input.GetAxis("Vertical"); // -1 , 1 dans l'axe Y

        Vector2 movement = new Vector2(horizontal, vertical);
        transform.Translate(movement * Time.deltaTime * speed);

        //GameObject.Find("Mon Cube").transform.Translate(movement * Time.deltaTime * speed);

        // GameObject.Find("Mon Cube").GetComponent<Toto>().Display();
        // GameObject.Find("Mon Cube");
    }
}
