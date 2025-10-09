using UnityEngine;

public class LocationButton : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public void OnClick()
    {
        MapUI.Instance.SelectLocation(sceneName);
    }
}
