using UnityEngine;
using UnityEngine.SceneManagement;

public class AreYouSurePanel : MonoBehaviour
{
    public void ExitGame() { SceneManager.LoadScene((int)GameScenes.MainMenu); }

}
