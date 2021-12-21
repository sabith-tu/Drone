// GENERATED AUTOMATICALLY FROM 'Assets/DronGame/Input/DronInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @DronInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @DronInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DronInputs"",
    ""maps"": [
        {
            ""name"": ""Dron"",
            ""id"": ""ca403db8-5daa-492e-a6a6-0d3158010dbd"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""1e4b8e69-c576-4a53-ad78-e1bf9c503469"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UpDown"",
                    ""type"": ""Value"",
                    ""id"": ""d332254b-988c-45dc-8366-9dbce5cb2f43"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2cf8cef3-d55d-4d90-a8a9-90363129410e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keybord"",
                    ""id"": ""ff2f722a-73dc-4b3f-8cf9-6f0536ef75c5"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e20b9bc4-c766-4683-a9bf-44df96f54abd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""100bfafb-4307-4be9-a6ea-9725a75dd0f4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8a454d54-66b1-4ffe-b89c-df37078c4317"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2ff5b5d2-8608-460a-a014-69f407f9a495"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""77fd4f0c-3e20-4e7a-8218-a69ceed9cbdb"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0f558ea4-a79c-410a-92c2-165f3bef53ba"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""313b4274-b8b1-45ad-9c2d-70d4e841dc42"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""gamepad"",
                    ""id"": ""2e866f0f-93a3-499b-8fbe-6eaa4dfd3f72"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""dc256745-df4b-45fe-9821-11044afa8133"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""19921a50-d7e5-49ca-88c9-c442897d15d1"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Dron
        m_Dron = asset.FindActionMap("Dron", throwIfNotFound: true);
        m_Dron_Movement = m_Dron.FindAction("Movement", throwIfNotFound: true);
        m_Dron_UpDown = m_Dron.FindAction("UpDown", throwIfNotFound: true);
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

    // Dron
    private readonly InputActionMap m_Dron;
    private IDronActions m_DronActionsCallbackInterface;
    private readonly InputAction m_Dron_Movement;
    private readonly InputAction m_Dron_UpDown;
    public struct DronActions
    {
        private @DronInputs m_Wrapper;
        public DronActions(@DronInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Dron_Movement;
        public InputAction @UpDown => m_Wrapper.m_Dron_UpDown;
        public InputActionMap Get() { return m_Wrapper.m_Dron; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DronActions set) { return set.Get(); }
        public void SetCallbacks(IDronActions instance)
        {
            if (m_Wrapper.m_DronActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_DronActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_DronActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_DronActionsCallbackInterface.OnMovement;
                @UpDown.started -= m_Wrapper.m_DronActionsCallbackInterface.OnUpDown;
                @UpDown.performed -= m_Wrapper.m_DronActionsCallbackInterface.OnUpDown;
                @UpDown.canceled -= m_Wrapper.m_DronActionsCallbackInterface.OnUpDown;
            }
            m_Wrapper.m_DronActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @UpDown.started += instance.OnUpDown;
                @UpDown.performed += instance.OnUpDown;
                @UpDown.canceled += instance.OnUpDown;
            }
        }
    }
    public DronActions @Dron => new DronActions(this);
    public interface IDronActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnUpDown(InputAction.CallbackContext context);
    }
}
