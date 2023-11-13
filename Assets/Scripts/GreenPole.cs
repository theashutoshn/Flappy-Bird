using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPole : MonoBehaviour
{
    private float _greePoleSpeed = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * _greePoleSpeed * Time.deltaTime);
    }
}
