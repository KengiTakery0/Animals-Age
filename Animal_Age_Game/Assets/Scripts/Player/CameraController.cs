
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject _camera;
    [SerializeField] PlayerControls _playerControls;

    private void Update()
    {
        _playerControls.CameraMoveUpDown(_camera.transform);
    }


}
