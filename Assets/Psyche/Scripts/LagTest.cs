using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LagTest : MonoBehaviour
{
    [SerializeField] private int StartIterations = 10000;
    [SerializeField] private int UpdateIterations = 5;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < StartIterations; i++)
        {
            Debug.Log(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < UpdateIterations; i++)
        {
            Debug.Log(gameObject);
        }
    }
}
