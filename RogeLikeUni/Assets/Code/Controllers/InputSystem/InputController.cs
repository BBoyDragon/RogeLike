using UnityEngine.InputSystem;

namespace Code.Controllers.InputSystem
{
    public class InputController
    {
        private InputActionMap currentControlScheme;
        void SetControlScheme(InputActionAsset controlScheme)
        {
            currentControlScheme?.Disable();
            currentControlScheme = controlScheme.FindActionMap("Player");
            currentControlScheme.Enable();
        }
    }
}