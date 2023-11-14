using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPole : MonoBehaviour
{
    private float _redPoleSpeed = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * _redPoleSpeed * Time.deltaTime);

        if (transform.position.x < -3.4f)
        {
            Destroy(this.gameObject);
        }
    }

    
}
