using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;


public class InputHandler : MonoBehaviour
{
    #region Variables

    private Camera _mainCamera;

    #endregion

    private void Awake()
    {
        _mainCamera = Camera.main;
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        if (!rayHit.collider) return;

        var Nameclick = rayHit.collider.gameObject.name;
        rayHit.collider.gameObject.SetActive(false);
        Debug.Log(Nameclick);
        var Find = GameObject.Find("DialogueBox1");
        var myGameObject = GameObject.Find("DialogueBox1");
        Debug.Log(Find.name);
    }
}