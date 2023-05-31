using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private PlayerInput playerInput;

    private void Awake()
    {
        playerInput = new PlayerInput();
    }

    public void CameraMoveUpDown(Transform cameraPos)
    {
        float scroll = playerInput.ControllActions.CameraMove.ReadValue<float>();
        if (scroll > 0) cameraPos.position += new Vector3(0, 1, 0);
        else if (scroll < 0) cameraPos.position -= new Vector3(0, 1, 0);
    }
    public void CameraRotate()
    {
        
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }
    private void OnDisable()
    {
        playerInput.Disable();
    }
}
