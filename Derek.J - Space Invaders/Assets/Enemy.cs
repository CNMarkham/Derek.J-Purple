using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator animator;
    public float speed;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        direction = Vector2.right;
    }

    void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed);
    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        animator.SetTrigger("death");
        Destroy(collision.gameObject);
    }

}
