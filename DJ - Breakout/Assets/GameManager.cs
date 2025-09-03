using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Brick1;
    public GameObject Brick2;
    public GameObject Brick3;

    public float xSpace;
    public float xOffset;
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < 9; x++)
        {
            Instantiate(Brick1, new Vector2(x * xSpace + xOffset, 3), Quaternion.identity);
            Instantiate(Brick2, new Vector2(x * xSpace + xOffset, 3.75f), Quaternion.identity);
            Instantiate(Brick3, new Vector2(x * xSpace + xOffset, 4.5f), Quaternion.identity);
        }
    }
}