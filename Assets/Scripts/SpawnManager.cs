using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _greenPolePrefab;
    void Start()
    {
        StartCoroutine(GreenPoleSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GreenPoleSpawner()
    {
        while(true)
        {
            Vector3 posToSpawn =  new Vector3(3.4f, Random.Range(-4.41f, -2.18f), 0f);
            Instantiate(_greenPolePrefab, posToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
    }
}
