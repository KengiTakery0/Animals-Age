using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject _savesPanel;
    [SerializeField] GameObject _mainPanel;
    [SerializeField] GameObject _settingsPanel;

    public void OnLoadGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void OnBackToMain()
    {
        _savesPanel.SetActive(false);
        _mainPanel.SetActive(true);
    }

    public void OnPlayButtonClick()
    {
        _savesPanel.SetActive(true);
        _mainPanel.SetActive(false);
    }

    public void OnExitButtonClick()
    {
        Application.Quit();
    } 

    public void OnSettingsButtonClick()
    {
        _mainPanel.SetActive(false);
        _settingsPanel.SetActive(true);
    }
}
