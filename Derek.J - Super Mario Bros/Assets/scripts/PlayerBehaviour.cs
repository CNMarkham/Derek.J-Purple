using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public SpriteRenderer smallRenderer;
    public SpriteRenderer bigRnederer;
    private Animator smallAnimator;
    public bool big;
    
    // Start is called before the first frame update
    private void Start()
    {
        smallAnimator = smallRenderer.gameObject.GetComponent<Animator>();
        big = false;
    }
    public void Hit()
    {
        if (big)
        {
            Shrink();
        }
        else
        {
            Death();
        }
    }
    private void Shrink()
    {

    }
    public void Grow()
    {

    }
    private void Death()
    {

    }
    private IEnumerator ChangeSize()
    {

    }
}
