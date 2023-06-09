using UnityEngine.InputSystem;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] private Transform _camera;

    [Header("Params")]
    [Space(1)]

    [Header("Camera")]
    [SerializeField] float _scrollSpeed;
    [SerializeField] float _moveSpeed;
    [SerializeField] float _scaleSpeed;

    [Header("ControlValues")]
    [SerializeField] private float _maxCameraRotationY; 
    [SerializeField] private float _minCameraRotationY; 
    [SerializeField] private float _maxCameraSize; 
    [SerializeField] private float _minCameraSize; 


    float moveHorizontal;
    float moveVertical;
    float scaleValue;

    private Camera camera;
    private PlayerInput playerInput;

    private bool isRotated = false;


    private void Awake()
    {
        playerInput = new PlayerInput();

        camera = _camera.GetComponent<Camera>();

        playerInput.ControllActions.CameraMoveUpDown.performed += ctx => moveVertical = ctx.ReadValue<float>();
        playerInput.ControllActions.CameraMoveLeftRight.performed += ctx => moveHorizontal = ctx.ReadValue<float>();
        playerInput.ControllActions.CameraScale.performed += ctx => scaleValue = ctx.ReadValue<float>();
        playerInput.ControllActions.CameraRotate.performed += ctx => Rotate();
       
    }

    private void Start()
    {
        camera.orthographicSize = _minCameraSize;
        _camera.transform.rotation =new Quaternion(0, _minCameraRotationY,0,0);
    }
    private void FixedUpdate()
    {
        MoveLeftRight(moveHorizontal * Time.deltaTime * _moveSpeed);
        MoveUpDown(moveVertical * Time.deltaTime * _scrollSpeed);
        ChangeViewSize(scaleValue * Time.deltaTime * _scaleSpeed);
    }

    #region VIEW_MOVE

    private void ChangeViewSize(float value)
    {

        if (camera.orthographicSize < _minCameraSize) camera.orthographicSize = _minCameraSize;
        if (camera.orthographicSize >= _maxCameraSize) camera.orthographicSize = _maxCameraSize;
       camera.orthographicSize += value;
    }
    private void MoveUpDown(float value)
    {
        _camera.transform.position = new Vector3(_camera.position.x, _camera.position.y + value, _camera.position.z);
    }
    private void Rotate()
    {
     
        if (!isRotated)
        {
            _camera.transform.position = new Vector3(_camera.position.x, _camera.position.y, 10);
            _camera.transform.transform.rotation = new Quaternion(0, _maxCameraRotationY, 0, 0);
            isRotated = true;
        }
        else if (isRotated)
        {
            _camera.transform.position = new Vector3(_camera.position.x, _camera.position.y, -10);
            _camera.transform.transform.rotation = new Quaternion(0, _minCameraRotationY, 0, 0);
            isRotated = false;
        }
    }
    private void MoveLeftRight(float value)
    { 
        if (isRotated) _camera.transform.position = new Vector3( _camera.position.x - value, _camera.position.y, _camera.position.z);
        else if (!isRotated) _camera.transform.position = new Vector3(_camera.position.x + value, _camera.position.y, _camera.position.z);
    }
    #endregion

    #region ENABLE/DISABLE
    private void OnEnable()
    {
        playerInput.Enable();
    }
    private void OnDisable()
    {
        playerInput.Disable();
    }
    #endregion
}
