using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private Button startGameButton;
    // Start is called before the first frame update
    void Start()
    {
        startGameButton = GameObject.Find("Start Game Button").GetComponent<Button>();
        startGameButton.onClick.AddListener(LoadGame);
    }

    private void LoadGame()
    {
        SceneManager.LoadScene(1);
    }

}
