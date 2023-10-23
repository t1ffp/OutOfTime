using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public GameObject endScreen;
    public GameObject startScreen;

    private void Start()
    {
        Time.timeScale = 0f;
        startScreen.SetActive(true);
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            startScreen.SetActive(false);
            Time.timeScale = 1.0f;
        }
    }
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
           endScreen.SetActive(true);
            Time.timeScale = 0f;
        }

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
