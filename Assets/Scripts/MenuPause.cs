using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public GameObject pauseMenu;

    public void ResumeGame()
    {
        Time.timeScale = 1f; // Reanuda el tiempo del juego
        pauseMenu.SetActive(false); // Oculta el menú de pausa
    }

    public void MenuInicial(string nombre)
    {
        SceneManager.LoadScene(nombre);
        Time.timeScale = 1f;
    }

    public void Salir()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
