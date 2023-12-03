using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevels : MonoBehaviour
{
    public void loadLevel1(){
        SceneManager.LoadScene("Circuit1");
        Time.timeScale = 1f;
    }

    public void loadLevel2(){
        SceneManager.LoadScene("Circuit2");
        Time.timeScale = 1f;
    }

    public void  goBackToMenu(){
        SceneManager.LoadScene("MainMenu");
    }
}
