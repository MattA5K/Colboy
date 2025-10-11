using UnityEngine;

public class Door : MonoBehaviour , IInteractable
{
    public bool IsInteractable; //temp
    [SerializeField] private GameObject MapManager;
    public void Interact()
    {
        MapUI.Instance.OpenMap();
    }

    public bool CanInteract()
    {
        return IsInteractable; //temp
    }

    public void OnPlayerEnter()
    {
        // Show a popup near bottom of screen
        /*
         * 
         * 
         * 
         * 
         *              E
         *          Open Door
         * 
        */

    }

    public void OnPlayerExit()
    {
        // Hide the prompt
    }
}
