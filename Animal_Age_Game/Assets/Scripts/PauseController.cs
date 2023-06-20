using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    public void OnContinue()
    {
        Time.timeScale = 1;
        this.gameObject.SetActive(false);
    }
    public void OnSettings()
    {
        //открытие наcтроек
    }
    public void OnExitToMainMenu()
    {
        //Сохранение
        SceneManager.LoadScene("MainMenu");
    }
    public void OnExit()
    {
        //Сохранение
        Application.Quit();
    }
}
