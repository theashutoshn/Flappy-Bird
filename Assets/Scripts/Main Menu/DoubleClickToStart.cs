using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoubleClickToStart : MonoBehaviour
{
    private float lastClickTime = 0f;
    private const float doubleClickTime = 0.2f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time - lastClickTime < doubleClickTime)
            {
                Vector2 MousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

                if (IsClickWithArea (MousePosition))
                {
                    StartGame();
                }
                
            }
            lastClickTime = Time.time;
        }

    }

    private bool IsClickWithArea (Vector2 MousePosition)
    {
        return true;
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
