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

    public Image[] digitImages;
    public Sprite[] numberSprite;
     
    void Start()
    {
        _bird = GetComponent<Bird>();
        UpdateScore(0);
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
        //scoreText.text = birdScore.ToString();

        string scoreString = birdScore.ToString().PadLeft(digitImages.Length, '0');
       for (int i = 0; i < digitImages.Length; i++)
        {
            int digit = int.Parse(scoreString[i].ToString());
            digitImages[i].sprite = numberSprite[digit];
        }
       

    }

    


}
