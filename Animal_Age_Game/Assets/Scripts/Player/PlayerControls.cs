using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] private GameObject _camera;

    [SerializeField] float _scrollSpeed;
    [SerializeField] float _moveSpeed;

    float moveHorizontal;
    float moveVertical;

    private PlayerInput playerInput;
    private bool isRotated = false;


    private void Awake()
    {
        playerInput = new PlayerInput();

        playerInput.ControllActions.CameraMoveUpDown.performed += ctx => moveVertical = ctx.ReadValue<float>();
        playerInput.ControllActions.CameraMoveLeftRight.performed += ctx => moveHorizontal = ctx.ReadValue<float>();
        playerInput.ControllActions.CameraRotate.performed += ctx => Rotate();
    }
    private void FixedUpdate()
    {
        MoveLeftRight(moveHorizontal * Time.deltaTime * _moveSpeed);
        MoveUpDown(moveVertical * Time.deltaTime * _scrollSpeed);
    }

    #region VIEW_MOVE
    private void MoveUpDown(float value)
    {
        _camera.transform.position += new Vector3(0, value, 0);
    }
    private void Rotate()
    {

        if (!isRotated)
        {
            _camera.transform.position = new Vector3(0, 0, 10);
            _camera.transform.transform.rotation = new Quaternion(0, 180, 0, 0);
            isRotated = true;
        }
        else if (isRotated)
        {
            _camera.transform.position = new Vector3(0, 0, -10);
            _camera.transform.transform.rotation = new Quaternion(0, 0, 0, 0);
            isRotated = false;
        }
    }

    private void MoveLeftRight(float value)
    {
        if (isRotated) _camera.transform.position += new Vector3(-value, 0, 0);
        else if (!isRotated) _camera.transform.position += new Vector3(value, 0, 0);
    }
    #endregion

    private void OnEnable()
    {
        playerInput.Enable();
    }
    private void OnDisable()
    {
        playerInput.Disable();
    }
}
