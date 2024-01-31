using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
 
    public void Play()
    {
        Time.timeScale = 1f;
        //  Friend.SetActive(true);
        SceneManager.LoadScene("Backup");
    }
    public void Credits()
    {
        Time.timeScale = 1f;
        //  Friend.SetActive(true);
        SceneManager.LoadScene("Creditos");
    }
    public void Back()
    {
        Time.timeScale = 1f;
        //  Friend.SetActive(true);
        SceneManager.LoadScene("menu");
    }
}
