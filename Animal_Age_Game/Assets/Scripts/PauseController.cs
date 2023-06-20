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
        //�������� ��c�����
    }
    public void OnExitToMainMenu()
    {
        //����������
        SceneManager.LoadScene("MainMenu");
    }
    public void OnExit()
    {
        //����������
        Application.Quit();
    }
}
