//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Scripts/Player/InputSystem/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""ControllActions"",
            ""id"": ""c27c3124-2ea9-4425-8386-e056602339b9"",
            ""actions"": [
                {
                    ""name"": ""CameraMoveUpDown"",
                    ""type"": ""PassThrough"",
                    ""id"": ""af9a0c0b-a915-44d1-9a40-31a0b0483a03"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CameraRotate"",
                    ""type"": ""Button"",
                    ""id"": ""13f8138e-af96-4d02-869c-4cd53dfe7687"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CameraMoveLeftRight"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5b758b1c-74a0-43ea-a662-45a3092d9947"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CameraScale"",
                    ""type"": ""PassThrough"",
                    ""id"": ""310102ef-2106-4910-a142-47585700291c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Move"",
                    ""id"": ""c2933495-8616-479b-a7a5-7a290902894d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMoveUpDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""41db8baa-debb-4220-abc6-9884e6e265d0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""CameraMoveUpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0252f9c0-6875-4c27-95d6-71523642b74e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""CameraMoveUpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""UDMove"",
                    ""id"": ""15d2b70f-6943-462a-aca0-b5e637dac61a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMoveUpDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""333b6563-3c76-42c4-ae43-aea40177ac6d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""CameraMoveUpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1e0449a8-5702-4c92-aff0-5ffc02d6b9f9"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""CameraMoveUpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bc037763-b4b8-4cf8-85f3-123e0be72ccf"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""CameraRotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""ADMove"",
                    ""id"": ""401da7b1-7ef5-4a1c-aed4-f97120575344"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMoveLeftRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c5c21810-37d9-4c61-8acb-2d54bfc24291"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""CameraMoveLeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f222ebe1-7ad4-4486-8121-47934f087fe4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""CameraMoveLeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftRightMove"",
                    ""id"": ""88befde5-3488-4ffc-a3ed-65430c418a79"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraMoveLeftRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""fcf08d41-587d-4018-93e6-16f03ef2b6aa"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""CameraMoveLeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3c1dd6d7-a23a-4218-bc93-8601664aa149"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""CameraMoveLeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ScrollScale"",
                    ""id"": ""93874f74-c580-4e3b-b60b-5e892d48fbfa"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraScale"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""08dc17b0-dca3-4248-94c6-61a07009200a"",
                    ""path"": ""<Mouse>/scroll/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""CameraScale"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""595eb23f-6c3e-4b4d-af0f-5ee00237e611"",
                    ""path"": ""<Mouse>/scroll/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Player"",
                    ""action"": ""CameraScale"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Player"",
            ""bindingGroup"": ""Player"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // ControllActions
        m_ControllActions = asset.FindActionMap("ControllActions", throwIfNotFound: true);
        m_ControllActions_CameraMoveUpDown = m_ControllActions.FindAction("CameraMoveUpDown", throwIfNotFound: true);
        m_ControllActions_CameraRotate = m_ControllActions.FindAction("CameraRotate", throwIfNotFound: true);
        m_ControllActions_CameraMoveLeftRight = m_ControllActions.FindAction("CameraMoveLeftRight", throwIfNotFound: true);
        m_ControllActions_CameraScale = m_ControllActions.FindAction("CameraScale", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // ControllActions
    private readonly InputActionMap m_ControllActions;
    private List<IControllActionsActions> m_ControllActionsActionsCallbackInterfaces = new List<IControllActionsActions>();
    private readonly InputAction m_ControllActions_CameraMoveUpDown;
    private readonly InputAction m_ControllActions_CameraRotate;
    private readonly InputAction m_ControllActions_CameraMoveLeftRight;
    private readonly InputAction m_ControllActions_CameraScale;
    public struct ControllActionsActions
    {
        private @PlayerInput m_Wrapper;
        public ControllActionsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @CameraMoveUpDown => m_Wrapper.m_ControllActions_CameraMoveUpDown;
        public InputAction @CameraRotate => m_Wrapper.m_ControllActions_CameraRotate;
        public InputAction @CameraMoveLeftRight => m_Wrapper.m_ControllActions_CameraMoveLeftRight;
        public InputAction @CameraScale => m_Wrapper.m_ControllActions_CameraScale;
        public InputActionMap Get() { return m_Wrapper.m_ControllActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControllActionsActions set) { return set.Get(); }
        public void AddCallbacks(IControllActionsActions instance)
        {
            if (instance == null || m_Wrapper.m_ControllActionsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ControllActionsActionsCallbackInterfaces.Add(instance);
            @CameraMoveUpDown.started += instance.OnCameraMoveUpDown;
            @CameraMoveUpDown.performed += instance.OnCameraMoveUpDown;
            @CameraMoveUpDown.canceled += instance.OnCameraMoveUpDown;
            @CameraRotate.started += instance.OnCameraRotate;
            @CameraRotate.performed += instance.OnCameraRotate;
            @CameraRotate.canceled += instance.OnCameraRotate;
            @CameraMoveLeftRight.started += instance.OnCameraMoveLeftRight;
            @CameraMoveLeftRight.performed += instance.OnCameraMoveLeftRight;
            @CameraMoveLeftRight.canceled += instance.OnCameraMoveLeftRight;
            @CameraScale.started += instance.OnCameraScale;
            @CameraScale.performed += instance.OnCameraScale;
            @CameraScale.canceled += instance.OnCameraScale;
        }

        private void UnregisterCallbacks(IControllActionsActions instance)
        {
            @CameraMoveUpDown.started -= instance.OnCameraMoveUpDown;
            @CameraMoveUpDown.performed -= instance.OnCameraMoveUpDown;
            @CameraMoveUpDown.canceled -= instance.OnCameraMoveUpDown;
            @CameraRotate.started -= instance.OnCameraRotate;
            @CameraRotate.performed -= instance.OnCameraRotate;
            @CameraRotate.canceled -= instance.OnCameraRotate;
            @CameraMoveLeftRight.started -= instance.OnCameraMoveLeftRight;
            @CameraMoveLeftRight.performed -= instance.OnCameraMoveLeftRight;
            @CameraMoveLeftRight.canceled -= instance.OnCameraMoveLeftRight;
            @CameraScale.started -= instance.OnCameraScale;
            @CameraScale.performed -= instance.OnCameraScale;
            @CameraScale.canceled -= instance.OnCameraScale;
        }

        public void RemoveCallbacks(IControllActionsActions instance)
        {
            if (m_Wrapper.m_ControllActionsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IControllActionsActions instance)
        {
            foreach (var item in m_Wrapper.m_ControllActionsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ControllActionsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ControllActionsActions @ControllActions => new ControllActionsActions(this);
    private int m_PlayerSchemeIndex = -1;
    public InputControlScheme PlayerScheme
    {
        get
        {
            if (m_PlayerSchemeIndex == -1) m_PlayerSchemeIndex = asset.FindControlSchemeIndex("Player");
            return asset.controlSchemes[m_PlayerSchemeIndex];
        }
    }
    public interface IControllActionsActions
    {
        void OnCameraMoveUpDown(InputAction.CallbackContext context);
        void OnCameraRotate(InputAction.CallbackContext context);
        void OnCameraMoveLeftRight(InputAction.CallbackContext context);
        void OnCameraScale(InputAction.CallbackContext context);
    }
}
