using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class InputHandler : MonoBehaviour
{
    #region Variables

    private Camera _mainCamera;
    public AudioSource doorSound; // Reference to the AudioSource component for the door sound

    #endregion

    private void Awake()
    {
        _mainCamera = Camera.main;
    }

    private void Start()
    {
        // Assuming you have an AudioSource component attached to the same GameObject
        doorSound = GetComponent<AudioSource>();
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        if (!rayHit.collider) return;

        var Nameclick = rayHit.collider.gameObject.name;
        var NameTag = rayHit.collider.gameObject.tag;
        Debug.Log(Nameclick);
        Debug.Log(NameTag);

        if (NameTag == "Door")
        {
            // Play the door sound effect
            if (doorSound != null)
            {
                doorSound.Play();
            }
        }
        else if (Nameclick == "Radio")
        {
            SceneManager.LoadSceneAsync(3);
        }
    }
}