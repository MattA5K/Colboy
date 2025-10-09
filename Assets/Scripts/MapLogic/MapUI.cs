using UnityEngine;
using UnityEngine.SceneManagement;

public class MapUI : MonoBehaviour
{
    public static MapUI Instance;
    [SerializeField] private GameObject mapPanel;

    private void Awake()
    {
        Instance = this;
        mapPanel.SetActive(false);
    }

    public void OpenMap()
    {
        mapPanel.SetActive(true);
        Time.timeScale = 0f; //Pause game while map is open
    }

    public void CloseMap()
    {
        mapPanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void SelectLocation(string sceneName)
    {
        CloseMap();
        SceneManager.LoadScene(sceneName);
    }
}
