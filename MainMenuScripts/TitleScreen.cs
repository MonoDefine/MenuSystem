using UnityEngine;

public class TitleScreen : MonoBehaviour
{
    [SerializeField] GameObject _titleScreen;
    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            _titleScreen.SetActive(false);
        }
    }
}
