// GENERATED AUTOMATICALLY FROM 'Assets/scripts/Playercontrolls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Playercontrolls : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @Playercontrolls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Playercontrolls"",
    ""maps"": [
        {
            ""name"": ""actionmap"",
            ""id"": ""18b155ae-8161-4175-9e17-30a3cf822f85"",
            ""actions"": [
                {
                    ""name"": ""click"",
                    ""type"": ""Button"",
                    ""id"": ""e90d9775-b6dd-4b4e-b5b0-f2d3d6b059a1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""move"",
                    ""type"": ""Button"",
                    ""id"": ""03b6a799-a0e1-4aae-93ed-0822936d0e44"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""rotate"",
                    ""type"": ""Button"",
                    ""id"": ""2cd33a8e-3fb5-4a75-bb09-9e35339414f2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""menu"",
                    ""type"": ""Button"",
                    ""id"": ""d7d05aae-cc82-442a-b22f-fe8ff8184715"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""restart"",
                    ""type"": ""Button"",
                    ""id"": ""e4dea02b-7fd9-44fc-a55d-0c21b32cd9b6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0e1be5de-1838-45bc-a709-efb7047eaf5b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8d685d2-4793-4d27-b51b-e3e51cab1a29"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85248633-eac4-4c24-82d2-e70a82e60b73"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c8ca069-cd63-4f9c-b0ed-f234d654e68c"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a9fe623-5f65-4d4f-acc1-15a33e168a64"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // actionmap
        m_actionmap = asset.FindActionMap("actionmap", throwIfNotFound: true);
        m_actionmap_click = m_actionmap.FindAction("click", throwIfNotFound: true);
        m_actionmap_move = m_actionmap.FindAction("move", throwIfNotFound: true);
        m_actionmap_rotate = m_actionmap.FindAction("rotate", throwIfNotFound: true);
        m_actionmap_menu = m_actionmap.FindAction("menu", throwIfNotFound: true);
        m_actionmap_restart = m_actionmap.FindAction("restart", throwIfNotFound: true);
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

    // actionmap
    private readonly InputActionMap m_actionmap;
    private IActionmapActions m_ActionmapActionsCallbackInterface;
    private readonly InputAction m_actionmap_click;
    private readonly InputAction m_actionmap_move;
    private readonly InputAction m_actionmap_rotate;
    private readonly InputAction m_actionmap_menu;
    private readonly InputAction m_actionmap_restart;
    public struct ActionmapActions
    {
        private @Playercontrolls m_Wrapper;
        public ActionmapActions(@Playercontrolls wrapper) { m_Wrapper = wrapper; }
        public InputAction @click => m_Wrapper.m_actionmap_click;
        public InputAction @move => m_Wrapper.m_actionmap_move;
        public InputAction @rotate => m_Wrapper.m_actionmap_rotate;
        public InputAction @menu => m_Wrapper.m_actionmap_menu;
        public InputAction @restart => m_Wrapper.m_actionmap_restart;
        public InputActionMap Get() { return m_Wrapper.m_actionmap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionmapActions set) { return set.Get(); }
        public void SetCallbacks(IActionmapActions instance)
        {
            if (m_Wrapper.m_ActionmapActionsCallbackInterface != null)
            {
                @click.started -= m_Wrapper.m_ActionmapActionsCallbackInterface.OnClick;
                @click.performed -= m_Wrapper.m_ActionmapActionsCallbackInterface.OnClick;
                @click.canceled -= m_Wrapper.m_ActionmapActionsCallbackInterface.OnClick;
                @move.started -= m_Wrapper.m_ActionmapActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_ActionmapActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_ActionmapActionsCallbackInterface.OnMove;
                @rotate.started -= m_Wrapper.m_ActionmapActionsCallbackInterface.OnRotate;
                @rotate.performed -= m_Wrapper.m_ActionmapActionsCallbackInterface.OnRotate;
                @rotate.canceled -= m_Wrapper.m_ActionmapActionsCallbackInterface.OnRotate;
                @menu.started -= m_Wrapper.m_ActionmapActionsCallbackInterface.OnMenu;
                @menu.performed -= m_Wrapper.m_ActionmapActionsCallbackInterface.OnMenu;
                @menu.canceled -= m_Wrapper.m_ActionmapActionsCallbackInterface.OnMenu;
                @restart.started -= m_Wrapper.m_ActionmapActionsCallbackInterface.OnRestart;
                @restart.performed -= m_Wrapper.m_ActionmapActionsCallbackInterface.OnRestart;
                @restart.canceled -= m_Wrapper.m_ActionmapActionsCallbackInterface.OnRestart;
            }
            m_Wrapper.m_ActionmapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @click.started += instance.OnClick;
                @click.performed += instance.OnClick;
                @click.canceled += instance.OnClick;
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @rotate.started += instance.OnRotate;
                @rotate.performed += instance.OnRotate;
                @rotate.canceled += instance.OnRotate;
                @menu.started += instance.OnMenu;
                @menu.performed += instance.OnMenu;
                @menu.canceled += instance.OnMenu;
                @restart.started += instance.OnRestart;
                @restart.performed += instance.OnRestart;
                @restart.canceled += instance.OnRestart;
            }
        }
    }
    public ActionmapActions @actionmap => new ActionmapActions(this);
    public interface IActionmapActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
    }
}
