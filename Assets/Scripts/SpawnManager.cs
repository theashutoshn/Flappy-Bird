using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _greenPolePrefab;

    [SerializeField]
    private GameObject _redPolePrefab;

    [SerializeField]
    private GameObject _diamondPrefab;

    
    void Start()
    {
       
        StartCoroutine(GreenPoleSpawner());
        //StartCoroutine(RedRoleSpawner());
        //StartCoroutine(DiamondSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GreenPoleSpawner()
    {
        while(true)
        {
            Vector3 posToSpawn =  new Vector3(3.4f, Random.Range(0.3f, 4.2f), 0f);
            Instantiate(_greenPolePrefab, posToSpawn, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }

    //IEnumerator RedRoleSpawner()
    //{
    //    while(true)
    //    {
    //        Vector3 posToSpawn = new Vector3(3.4f, Random.Range(3.53f, 5.5f), 0f);
    //        Instantiate(_redPolePrefab, posToSpawn, Quaternion.Euler(0, 0, 180));
    //        yield return new WaitForSeconds(1f);
    //    }
    //}

    //IEnumerator DiamondSpawner()
    //{
    //    while (true)
    //    {
    //        Vector3 posToSpawn = new Vector3(3.4f, Random.Range(0.3f, 1.5f), 0f);
    //        Instantiate(_diamondPrefab, posToSpawn, Quaternion.identity);
    //        yield return new WaitForSeconds(5f);
    //    }
    //}
    
}
