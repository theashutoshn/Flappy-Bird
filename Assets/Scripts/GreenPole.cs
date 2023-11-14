using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPole : MonoBehaviour
{
    private float _greePoleSpeed = 2f;

    //[SerializeField]
    //private GameObject _coinPrefab;

    //[SerializeField]
    //private Transform _coinSpawnLoc;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * _greePoleSpeed * Time.deltaTime);
        //Instantiate(_coinPrefab, _coinSpawnLoc.transform.position, Quaternion.identity);

        if(transform.position.x < -3.4f)
        {
            Destroy(this.gameObject);
        }
    }
}
