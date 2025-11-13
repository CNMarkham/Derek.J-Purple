using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pellet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.CompareTag("Pacman"));
        {
           
            Eat();
        }
    }

    protected virtual void Eat()
    {
        Debug.Log("hi");
        this.gameObject.SetActive(false);
    }
}