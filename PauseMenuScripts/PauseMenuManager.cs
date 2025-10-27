using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MenuManager
{
    //public static PauseMenuManager menuInstance;


    [SerializeField] GameObject _pauseMenu;
    bool _timePaused = false;
    bool _paused = false;

    public void ToggleTime()
    {
        Debug.Log("ToggleTime activated");
        float timeScale = !_timePaused ? 0.0f : 1.0f;
        _timePaused = !_timePaused;
        Time.timeScale = timeScale;
    }

    public void PauseToggle()
    {
        ToggleTime();
        _paused = !_paused;
        _pauseMenu.SetActive(_paused);
    }

    public void ContinueGame(){ _pauseMenu.SetActive(false); }

    public void RestartGame() { SceneManager.LoadScene(SceneManager.GetActiveScene().name); }
}
