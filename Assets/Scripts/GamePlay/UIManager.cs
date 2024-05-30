using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{

    private Bird _bird;
    public TextMeshProUGUI scoreText;

    [SerializeField]
    private Image _gameOver;

     
    void Start()
    {
        _bird = GetComponent<Bird>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        _gameOver.gameObject.SetActive(true);
        Time.timeScale = 1f;
        
    }

    public void UpdateScore(int birdScore)
    {
        scoreText.text = birdScore.ToString();
    }


}
