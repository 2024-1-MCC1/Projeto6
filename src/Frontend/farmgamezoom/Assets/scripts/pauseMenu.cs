using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject voltar;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (voltar.activeSelf)
            {
                voltar.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                voltar.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

        public void ResumeGame()
    {
        voltar.SetActive(false);
        Time.timeScale = 1;
    }

    public void VoltarMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
