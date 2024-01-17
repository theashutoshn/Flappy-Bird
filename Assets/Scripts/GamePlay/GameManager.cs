using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _gameOver;

    [SerializeField]
    private GameObject _restartPanel;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        _gameOver.gameObject.SetActive(true);
        _restartPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        _gameOver.gameObject.SetActive(false);
        _restartPanel.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
}
