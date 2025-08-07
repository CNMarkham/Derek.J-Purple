using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) // "If the up arrow key is pressed..."
        {
            transform.Translate(Vector2.up * Time.deltaTime * speed); // "move up to the speed of Vector2.up * Time.deltaTime * speed"
        }

        if (Input.GetKey(KeyCode.DownArrow)) // "If the down arrow key is pressed..."
        {
            transform.Translate(Vector2.down * Time.deltaTime * speed); // "move down to the speed of Vector2.down * Time.deltaTime * speed"
        }
    }
}