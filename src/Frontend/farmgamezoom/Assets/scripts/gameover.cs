using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    public float temporestante = 5f;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if  (temporestante > 0)
        {
            temporestante -= Time.deltaTime;
            
        }
        else
        {
            GameOver();
        }

    }
    void GameOver()
    {
        SceneManager.LoadScene(2);
    }
}
