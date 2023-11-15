using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    private float _baseSpeed = 2f;
    [SerializeField]
    public GameObject _basePrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * _baseSpeed * Time.deltaTime);

        if(Mathf.Abs(transform.position.x + 4.8f) < 0.1f)
        {
            
            Vector3 posToSpawn = new Vector3(6.61f, transform.position.y, 0);
            Instantiate(_basePrefab, posToSpawn, Quaternion.identity);
        }

        //if (transform.position.x < -5.52f)
        //{
        //    Destroy(this.gameObject);
        //}
    }
}
