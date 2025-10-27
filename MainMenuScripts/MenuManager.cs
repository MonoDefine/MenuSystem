using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static MenuManager menuInstance;


    [SerializeField] GameObject[] _menuPanels;

    public void Awake()
    {
        if (menuInstance == null)
            menuInstance = this;
        else
            Debug.LogError("More than 1 Menu Manager in scene");
    }

    // Play Game
    public void PlayGame()
    {
        SceneManager.LoadScene((int)GameScenes.LevelSelect);
    }

    // Open panel, disable other panels to stop conflicts
    public void OpenPanel(int panelIndex)
    {
        foreach (GameObject panel in _menuPanels)
        {
            panel.gameObject.SetActive(false);
        }
        _menuPanels[panelIndex].SetActive(true);
    }

    // Exit Game, duh
    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit;
#endif
    }

    // I will instead handle closing through the individual menu objects
    /*
    public void ClosePanel()
    {
        this.gameObject.SetActive(false);
    }*/

}
