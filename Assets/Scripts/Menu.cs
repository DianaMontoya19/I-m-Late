using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
 
    public void Multiplayer()
    {
        Time.timeScale = 1f;
        //  Friend.SetActive(true);
        SceneManager.LoadScene("Backup");
    }
}
