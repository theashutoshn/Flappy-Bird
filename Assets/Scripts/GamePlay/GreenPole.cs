using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPole : MonoBehaviour
{
    private float _greePoleSpeed = 2f;

    private Bird _bird;

    private bool _scoreIncreamented = false;

    private GameManager _gameManager;
    //[SerializeField]
    //private GameObject _coinPrefab;

    //[SerializeField]
    //private Transform _coinSpawnLoc;

    void Start()
    {
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _bird = GameObject.Find("Bird").GetComponent<Bird>();
        if(_bird == null)
        {
            Debug.Log("Bird is not found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * _greePoleSpeed * Time.deltaTime);
        //Instantiate(_coinPrefab, _coinSpawnLoc.transform.position, Quaternion.identity);

        if(transform.position.x < -2.02 && !_scoreIncreamented)
        {
            _bird.Score(1);
            _scoreIncreamented = true;
        }
        
        if(transform.position.x < -5.4f)
        {
            Destroy(this.gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Bird"))
        {
            Destroy(other.gameObject);
            _gameManager.GameOver();
        }
        
    }
}
