using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Bryann Alfaro
 * Clase que controla el menu de pausa
 * Referencia: Clase impartida
 */
public class Pause : MonoBehaviour


{
    public GameObject pauseMenu;
    public GameObject player;
    public GameObject gun;
    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            TogglePause();
        }
    }

    public void TogglePause()
    {

        if (pauseMenu)
        {

            if (player) player.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled=isPaused;
            if (gun) gun.GetComponent<Gun>().enabled = isPaused;

            pauseMenu.SetActive(pauseMenu.activeSelf);
            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0.0f : 1.0f;

            if (player) player.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = !isPaused;
            if (gun) gun.GetComponent<Gun>().enabled = !isPaused;

            if (isPaused)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            
                
        }

    }

}

