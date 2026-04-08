using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    [SerializeField] private string backToLevel1;
    [SerializeField] private string backToMainMenu;
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void restartGame()
    {
        SceneManager.LoadScene(backToLevel1);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(backToMainMenu);
    }
}
