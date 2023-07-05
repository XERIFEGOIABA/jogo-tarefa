using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{
    public string nomeCena;
    public GameObject menuPanel;

   
    void Start()
    {
        menuPanel.SetActive(true);

    }

    
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(nomeCena);
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
