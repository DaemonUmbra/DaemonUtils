using UnityEngine;

/// <summary>
/// Funnels Unity Input Events into function calls for BindableControls
/// </summary>
public class InputWrapper : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        #region KeyDown

        if (Input.GetKeyDown(KeyCode.None))
        {
            BindableControls.BindingDown(KeyCode.None);
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            BindableControls.BindingDown(KeyCode.Backspace);
        }
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            BindableControls.BindingDown(KeyCode.Delete);
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            BindableControls.BindingDown(KeyCode.Tab);
        }
        if (Input.GetKeyDown(KeyCode.Clear))
        {
            BindableControls.BindingDown(KeyCode.Clear);
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            BindableControls.BindingDown(KeyCode.Return);
        }
        if (Input.GetKeyDown(KeyCode.Pause))
        {
            BindableControls.BindingDown(KeyCode.Pause);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            BindableControls.BindingDown(KeyCode.Escape);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BindableControls.BindingDown(KeyCode.Space);
        }
        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            BindableControls.BindingDown(KeyCode.Keypad0);
        }
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            BindableControls.BindingDown(KeyCode.Keypad1);
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            BindableControls.BindingDown(KeyCode.Keypad2);
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            BindableControls.BindingDown(KeyCode.Keypad3);
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            BindableControls.BindingDown(KeyCode.Keypad4);
        }
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            BindableControls.BindingDown(KeyCode.Keypad5);
        }
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            BindableControls.BindingDown(KeyCode.Keypad6);
        }
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            BindableControls.BindingDown(KeyCode.Keypad7);
        }
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            BindableControls.BindingDown(KeyCode.Keypad8);
        }
        if (Input.GetKeyDown(KeyCode.Keypad9))
        {
            BindableControls.BindingDown(KeyCode.Keypad9);
        }
        if (Input.GetKeyDown(KeyCode.KeypadPeriod))
        {
            BindableControls.BindingDown(KeyCode.KeypadPeriod);
        }
        if (Input.GetKeyDown(KeyCode.KeypadDivide))
        {
            BindableControls.BindingDown(KeyCode.KeypadDivide);
        }
        if (Input.GetKeyDown(KeyCode.KeypadMultiply))
        {
            BindableControls.BindingDown(KeyCode.KeypadMultiply);
        }
        if (Input.GetKeyDown(KeyCode.KeypadMinus))
        {
            BindableControls.BindingDown(KeyCode.KeypadMinus);
        }
        if (Input.GetKeyDown(KeyCode.KeypadPlus))
        {
            BindableControls.BindingDown(KeyCode.KeypadPlus);
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            BindableControls.BindingDown(KeyCode.KeypadEnter);
        }
        if (Input.GetKeyDown(KeyCode.KeypadEquals))
        {
            BindableControls.BindingDown(KeyCode.KeypadEquals);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            BindableControls.BindingDown(KeyCode.UpArrow);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            BindableControls.BindingDown(KeyCode.DownArrow);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            BindableControls.BindingDown(KeyCode.RightArrow);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            BindableControls.BindingDown(KeyCode.LeftArrow);
        }
        if (Input.GetKeyDown(KeyCode.Insert))
        {
            BindableControls.BindingDown(KeyCode.Insert);
        }
        if (Input.GetKeyDown(KeyCode.Home))
        {
            BindableControls.BindingDown(KeyCode.Home);
        }
        if (Input.GetKeyDown(KeyCode.End))
        {
            BindableControls.BindingDown(KeyCode.End);
        }
        if (Input.GetKeyDown(KeyCode.PageUp))
        {
            BindableControls.BindingDown(KeyCode.PageUp);
        }
        if (Input.GetKeyDown(KeyCode.PageDown))
        {
            BindableControls.BindingDown(KeyCode.PageDown);
        }
        if (Input.GetKeyDown(KeyCode.F1))
        {
            BindableControls.BindingDown(KeyCode.F1);
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            BindableControls.BindingDown(KeyCode.F2);
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            BindableControls.BindingDown(KeyCode.F3);
        }
        if (Input.GetKeyDown(KeyCode.F4))
        {
            BindableControls.BindingDown(KeyCode.F4);
        }
        if (Input.GetKeyDown(KeyCode.F5))
        {
            BindableControls.BindingDown(KeyCode.F5);
        }
        if (Input.GetKeyDown(KeyCode.F6))
        {
            BindableControls.BindingDown(KeyCode.F6);
        }
        if (Input.GetKeyDown(KeyCode.F7))
        {
            BindableControls.BindingDown(KeyCode.F7);
        }
        if (Input.GetKeyDown(KeyCode.F8))
        {
            BindableControls.BindingDown(KeyCode.F8);
        }
        if (Input.GetKeyDown(KeyCode.F9))
        {
            BindableControls.BindingDown(KeyCode.F9);
        }
        if (Input.GetKeyDown(KeyCode.F10))
        {
            BindableControls.BindingDown(KeyCode.F10);
        }
        if (Input.GetKeyDown(KeyCode.F11))
        {
            BindableControls.BindingDown(KeyCode.F11);
        }
        if (Input.GetKeyDown(KeyCode.F12))
        {
            BindableControls.BindingDown(KeyCode.F12);
        }
        if (Input.GetKeyDown(KeyCode.F13))
        {
            BindableControls.BindingDown(KeyCode.F13);
        }
        if (Input.GetKeyDown(KeyCode.F14))
        {
            BindableControls.BindingDown(KeyCode.F14);
        }
        if (Input.GetKeyDown(KeyCode.F15))
        {
            BindableControls.BindingDown(KeyCode.F15);
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            BindableControls.BindingDown(KeyCode.Alpha0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            BindableControls.BindingDown(KeyCode.Alpha1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            BindableControls.BindingDown(KeyCode.Alpha2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            BindableControls.BindingDown(KeyCode.Alpha3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            BindableControls.BindingDown(KeyCode.Alpha4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            BindableControls.BindingDown(KeyCode.Alpha5);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            BindableControls.BindingDown(KeyCode.Alpha6);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            BindableControls.BindingDown(KeyCode.Alpha7);
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            BindableControls.BindingDown(KeyCode.Alpha8);
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            BindableControls.BindingDown(KeyCode.Alpha9);
        }
        if (Input.GetKeyDown(KeyCode.Exclaim))
        {
            BindableControls.BindingDown(KeyCode.Exclaim);
        }
        if (Input.GetKeyDown(KeyCode.DoubleQuote))
        {
            BindableControls.BindingDown(KeyCode.DoubleQuote);
        }
        if (Input.GetKeyDown(KeyCode.Hash))
        {
            BindableControls.BindingDown(KeyCode.Hash);
        }
        if (Input.GetKeyDown(KeyCode.Dollar))
        {
            BindableControls.BindingDown(KeyCode.Dollar);
        }
        if (Input.GetKeyDown(KeyCode.Ampersand))
        {
            BindableControls.BindingDown(KeyCode.Ampersand);
        }
        if (Input.GetKeyDown(KeyCode.Quote))
        {
            BindableControls.BindingDown(KeyCode.Quote);
        }
        if (Input.GetKeyDown(KeyCode.LeftParen))
        {
            BindableControls.BindingDown(KeyCode.LeftParen);
        }
        if (Input.GetKeyDown(KeyCode.RightParen))
        {
            BindableControls.BindingDown(KeyCode.RightParen);
        }
        if (Input.GetKeyDown(KeyCode.Asterisk))
        {
            BindableControls.BindingDown(KeyCode.Asterisk);
        }
        if (Input.GetKeyDown(KeyCode.Plus))
        {
            BindableControls.BindingDown(KeyCode.Plus);
        }
        if (Input.GetKeyDown(KeyCode.Comma))
        {
            BindableControls.BindingDown(KeyCode.Comma);
        }
        if (Input.GetKeyDown(KeyCode.Minus))
        {
            BindableControls.BindingDown(KeyCode.Minus);
        }
        if (Input.GetKeyDown(KeyCode.Period))
        {
            BindableControls.BindingDown(KeyCode.Period);
        }
        if (Input.GetKeyDown(KeyCode.Slash))
        {
            BindableControls.BindingDown(KeyCode.Slash);
        }
        if (Input.GetKeyDown(KeyCode.Colon))
        {
            BindableControls.BindingDown(KeyCode.Colon);
        }
        if (Input.GetKeyDown(KeyCode.Semicolon))
        {
            BindableControls.BindingDown(KeyCode.Semicolon);
        }
        if (Input.GetKeyDown(KeyCode.Less))
        {
            BindableControls.BindingDown(KeyCode.Less);
        }
        if (Input.GetKeyDown(KeyCode.Equals))
        {
            BindableControls.BindingDown(KeyCode.Equals);
        }
        if (Input.GetKeyDown(KeyCode.Greater))
        {
            BindableControls.BindingDown(KeyCode.Greater);
        }
        if (Input.GetKeyDown(KeyCode.Question))
        {
            BindableControls.BindingDown(KeyCode.Question);
        }
        if (Input.GetKeyDown(KeyCode.At))
        {
            BindableControls.BindingDown(KeyCode.At);
        }
        if (Input.GetKeyDown(KeyCode.LeftBracket))
        {
            BindableControls.BindingDown(KeyCode.LeftBracket);
        }
        if (Input.GetKeyDown(KeyCode.Backslash))
        {
            BindableControls.BindingDown(KeyCode.Backslash);
        }
        if (Input.GetKeyDown(KeyCode.RightBracket))
        {
            BindableControls.BindingDown(KeyCode.RightBracket);
        }
        if (Input.GetKeyDown(KeyCode.Caret))
        {
            BindableControls.BindingDown(KeyCode.Caret);
        }
        if (Input.GetKeyDown(KeyCode.Underscore))
        {
            BindableControls.BindingDown(KeyCode.Underscore);
        }
        if (Input.GetKeyDown(KeyCode.BackQuote))
        {
            BindableControls.BindingDown(KeyCode.BackQuote);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            BindableControls.BindingDown(KeyCode.A);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            BindableControls.BindingDown(KeyCode.B);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            BindableControls.BindingDown(KeyCode.C);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            BindableControls.BindingDown(KeyCode.D);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            BindableControls.BindingDown(KeyCode.E);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            BindableControls.BindingDown(KeyCode.F);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            BindableControls.BindingDown(KeyCode.G);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            BindableControls.BindingDown(KeyCode.H);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            BindableControls.BindingDown(KeyCode.I);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            BindableControls.BindingDown(KeyCode.J);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            BindableControls.BindingDown(KeyCode.K);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            BindableControls.BindingDown(KeyCode.L);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            BindableControls.BindingDown(KeyCode.M);
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            BindableControls.BindingDown(KeyCode.N);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            BindableControls.BindingDown(KeyCode.O);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            BindableControls.BindingDown(KeyCode.P);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            BindableControls.BindingDown(KeyCode.Q);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            BindableControls.BindingDown(KeyCode.R);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            BindableControls.BindingDown(KeyCode.S);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            BindableControls.BindingDown(KeyCode.T);
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            BindableControls.BindingDown(KeyCode.U);
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            BindableControls.BindingDown(KeyCode.V);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            BindableControls.BindingDown(KeyCode.W);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            BindableControls.BindingDown(KeyCode.X);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            BindableControls.BindingDown(KeyCode.Y);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            BindableControls.BindingDown(KeyCode.Z);
        }
        if (Input.GetKeyDown(KeyCode.Numlock))
        {
            BindableControls.BindingDown(KeyCode.Numlock);
        }
        if (Input.GetKeyDown(KeyCode.CapsLock))
        {
            BindableControls.BindingDown(KeyCode.CapsLock);
        }
        if (Input.GetKeyDown(KeyCode.ScrollLock))
        {
            BindableControls.BindingDown(KeyCode.ScrollLock);
        }
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            BindableControls.BindingDown(KeyCode.RightShift);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            BindableControls.BindingDown(KeyCode.LeftShift);
        }
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            BindableControls.BindingDown(KeyCode.RightControl);
        }
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            BindableControls.BindingDown(KeyCode.LeftControl);
        }
        if (Input.GetKeyDown(KeyCode.RightAlt))
        {
            BindableControls.BindingDown(KeyCode.RightAlt);
        }
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            BindableControls.BindingDown(KeyCode.LeftAlt);
        }
        if (Input.GetKeyDown(KeyCode.LeftCommand))
        {
            BindableControls.BindingDown(KeyCode.LeftCommand);
        }
        if (Input.GetKeyDown(KeyCode.LeftWindows))
        {
            BindableControls.BindingDown(KeyCode.LeftWindows);
        }
        if (Input.GetKeyDown(KeyCode.RightCommand))
        {
            BindableControls.BindingDown(KeyCode.RightCommand);
        }
        if (Input.GetKeyDown(KeyCode.RightWindows))
        {
            BindableControls.BindingDown(KeyCode.RightWindows);
        }
        if (Input.GetKeyDown(KeyCode.AltGr))
        {
            BindableControls.BindingDown(KeyCode.AltGr);
        }
        if (Input.GetKeyDown(KeyCode.Help))
        {
            BindableControls.BindingDown(KeyCode.Help);
        }
        if (Input.GetKeyDown(KeyCode.Print))
        {
            BindableControls.BindingDown(KeyCode.Print);
        }
        if (Input.GetKeyDown(KeyCode.SysReq))
        {
            BindableControls.BindingDown(KeyCode.SysReq);
        }
        if (Input.GetKeyDown(KeyCode.Break))
        {
            BindableControls.BindingDown(KeyCode.Break);
        }
        if (Input.GetKeyDown(KeyCode.Menu))
        {
            BindableControls.BindingDown(KeyCode.Menu);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            BindableControls.BindingDown(KeyCode.Mouse0);
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            BindableControls.BindingDown(KeyCode.Mouse1);
        }
        if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            BindableControls.BindingDown(KeyCode.Mouse2);
        }
        if (Input.GetKeyDown(KeyCode.Mouse3))
        {
            BindableControls.BindingDown(KeyCode.Mouse3);
        }
        if (Input.GetKeyDown(KeyCode.Mouse4))
        {
            BindableControls.BindingDown(KeyCode.Mouse4);
        }
        if (Input.GetKeyDown(KeyCode.Mouse5))
        {
            BindableControls.BindingDown(KeyCode.Mouse5);
        }
        if (Input.GetKeyDown(KeyCode.Mouse6))
        {
            BindableControls.BindingDown(KeyCode.Mouse6);
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton0);
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton1);
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton2))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton2);
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton3))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton3);
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton4))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton4);
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton5))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton5);
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton6))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton6);
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton7))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton7);
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton8))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton8);
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton9))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton9);
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton10))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton10);
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton11))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton11);
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton12))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton12);
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton13))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton13);
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton14))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton14);
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton15))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton15);
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton16))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton16);
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton17))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton17);
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton18))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton18);
        }
        if (Input.GetKeyDown(KeyCode.JoystickButton19))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton19);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button0);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button1);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button2);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button3);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button4);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button5);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button6);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button7);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button8);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button9);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button10);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button11);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button12);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button13);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button14);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button15);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button16);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button17);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button18);
        }
        if (Input.GetKeyDown(KeyCode.Joystick1Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button19);
        }
        if (Input.GetKeyDown(KeyCode.Joystick2Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button0);
        }
        if (Input.GetKeyDown(KeyCode.Joystick2Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button1);
        }
        if (Input.GetKeyDown(KeyCode.Joystick2Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button2);
        }
        if (Input.GetKeyDown(KeyCode.Joystick2Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button3);
        }
        if (Input.GetKeyDown(KeyCode.Joystick2Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button4);
        }
        if (Input.GetKeyDown(KeyCode.Joystick2Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button5);
        }
        if (Input.GetKeyDown(KeyCode.Joystick2Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button6);
        }
        if (Input.GetKeyDown(KeyCode.Joystick2Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button7);
        }
        if (Input.GetKeyDown(KeyCode.Joystick2Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button8);
        }
        if (Input.GetKeyDown(KeyCode.Joystick2Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button9);
        }
        if (Input.GetKeyDown(KeyCode.Joystick2Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button10);
        }
        if (Input.GetKeyDown(KeyCode.Joystick2Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button11);
        }
        if (Input.GetKeyDown(KeyCode.Joystick2Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button12);
        }
        if (Input.GetKeyDown(KeyCode.Joystick2Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button13);
        }
        if (Input.GetKeyDown(KeyCode.Joystick2Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button14);
        }
        if (Input.GetKeyDown(KeyCode.Joystick2Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button15);
        }
        if (Input.GetKeyDown(KeyCode.Joystick2Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button16);
        }
        if (Input.GetKeyDown(KeyCode.Joystick2Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button17);
        }
        if (Input.GetKeyDown(KeyCode.Joystick2Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button18);
        }
        if (Input.GetKeyDown(KeyCode.Joystick2Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button19);
        }
        if (Input.GetKeyDown(KeyCode.Joystick3Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button0);
        }
        if (Input.GetKeyDown(KeyCode.Joystick3Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button1);
        }
        if (Input.GetKeyDown(KeyCode.Joystick3Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button2);
        }
        if (Input.GetKeyDown(KeyCode.Joystick3Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button3);
        }
        if (Input.GetKeyDown(KeyCode.Joystick3Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button4);
        }
        if (Input.GetKeyDown(KeyCode.Joystick3Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button5);
        }
        if (Input.GetKeyDown(KeyCode.Joystick3Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button6);
        }
        if (Input.GetKeyDown(KeyCode.Joystick3Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button7);
        }
        if (Input.GetKeyDown(KeyCode.Joystick3Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button8);
        }
        if (Input.GetKeyDown(KeyCode.Joystick3Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button9);
        }
        if (Input.GetKeyDown(KeyCode.Joystick3Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button10);
        }
        if (Input.GetKeyDown(KeyCode.Joystick3Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button11);
        }
        if (Input.GetKeyDown(KeyCode.Joystick3Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button12);
        }
        if (Input.GetKeyDown(KeyCode.Joystick3Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button13);
        }
        if (Input.GetKeyDown(KeyCode.Joystick3Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button14);
        }
        if (Input.GetKeyDown(KeyCode.Joystick3Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button15);
        }
        if (Input.GetKeyDown(KeyCode.Joystick3Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button16);
        }
        if (Input.GetKeyDown(KeyCode.Joystick3Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button17);
        }
        if (Input.GetKeyDown(KeyCode.Joystick3Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button18);
        }
        if (Input.GetKeyDown(KeyCode.Joystick3Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button19);
        }
        if (Input.GetKeyDown(KeyCode.Joystick4Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button0);
        }
        if (Input.GetKeyDown(KeyCode.Joystick4Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button1);
        }
        if (Input.GetKeyDown(KeyCode.Joystick4Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button2);
        }
        if (Input.GetKeyDown(KeyCode.Joystick4Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button3);
        }
        if (Input.GetKeyDown(KeyCode.Joystick4Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button4);
        }
        if (Input.GetKeyDown(KeyCode.Joystick4Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button5);
        }
        if (Input.GetKeyDown(KeyCode.Joystick4Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button6);
        }
        if (Input.GetKeyDown(KeyCode.Joystick4Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button7);
        }
        if (Input.GetKeyDown(KeyCode.Joystick4Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button8);
        }
        if (Input.GetKeyDown(KeyCode.Joystick4Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button9);
        }
        if (Input.GetKeyDown(KeyCode.Joystick4Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button10);
        }
        if (Input.GetKeyDown(KeyCode.Joystick4Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button11);
        }
        if (Input.GetKeyDown(KeyCode.Joystick4Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button12);
        }
        if (Input.GetKeyDown(KeyCode.Joystick4Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button13);
        }
        if (Input.GetKeyDown(KeyCode.Joystick4Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button14);
        }
        if (Input.GetKeyDown(KeyCode.Joystick4Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button15);
        }
        if (Input.GetKeyDown(KeyCode.Joystick4Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button16);
        }
        if (Input.GetKeyDown(KeyCode.Joystick4Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button17);
        }
        if (Input.GetKeyDown(KeyCode.Joystick4Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button18);
        }
        if (Input.GetKeyDown(KeyCode.Joystick4Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button19);
        }
        if (Input.GetKeyDown(KeyCode.Joystick5Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button0);
        }
        if (Input.GetKeyDown(KeyCode.Joystick5Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button1);
        }
        if (Input.GetKeyDown(KeyCode.Joystick5Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button2);
        }
        if (Input.GetKeyDown(KeyCode.Joystick5Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button3);
        }
        if (Input.GetKeyDown(KeyCode.Joystick5Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button4);
        }
        if (Input.GetKeyDown(KeyCode.Joystick5Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button5);
        }
        if (Input.GetKeyDown(KeyCode.Joystick5Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button6);
        }
        if (Input.GetKeyDown(KeyCode.Joystick5Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button7);
        }
        if (Input.GetKeyDown(KeyCode.Joystick5Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button8);
        }
        if (Input.GetKeyDown(KeyCode.Joystick5Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button9);
        }
        if (Input.GetKeyDown(KeyCode.Joystick5Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button10);
        }
        if (Input.GetKeyDown(KeyCode.Joystick5Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button11);
        }
        if (Input.GetKeyDown(KeyCode.Joystick5Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button12);
        }
        if (Input.GetKeyDown(KeyCode.Joystick5Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button13);
        }
        if (Input.GetKeyDown(KeyCode.Joystick5Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button14);
        }
        if (Input.GetKeyDown(KeyCode.Joystick5Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button15);
        }
        if (Input.GetKeyDown(KeyCode.Joystick5Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button16);
        }
        if (Input.GetKeyDown(KeyCode.Joystick5Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button17);
        }
        if (Input.GetKeyDown(KeyCode.Joystick5Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button18);
        }
        if (Input.GetKeyDown(KeyCode.Joystick5Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button19);
        }
        if (Input.GetKeyDown(KeyCode.Joystick6Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button0);
        }
        if (Input.GetKeyDown(KeyCode.Joystick6Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button1);
        }
        if (Input.GetKeyDown(KeyCode.Joystick6Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button2);
        }
        if (Input.GetKeyDown(KeyCode.Joystick6Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button3);
        }
        if (Input.GetKeyDown(KeyCode.Joystick6Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button4);
        }
        if (Input.GetKeyDown(KeyCode.Joystick6Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button5);
        }
        if (Input.GetKeyDown(KeyCode.Joystick6Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button6);
        }
        if (Input.GetKeyDown(KeyCode.Joystick6Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button7);
        }
        if (Input.GetKeyDown(KeyCode.Joystick6Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button8);
        }
        if (Input.GetKeyDown(KeyCode.Joystick6Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button9);
        }
        if (Input.GetKeyDown(KeyCode.Joystick6Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button10);
        }
        if (Input.GetKeyDown(KeyCode.Joystick6Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button11);
        }
        if (Input.GetKeyDown(KeyCode.Joystick6Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button12);
        }
        if (Input.GetKeyDown(KeyCode.Joystick6Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button13);
        }
        if (Input.GetKeyDown(KeyCode.Joystick6Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button14);
        }
        if (Input.GetKeyDown(KeyCode.Joystick6Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button15);
        }
        if (Input.GetKeyDown(KeyCode.Joystick6Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button16);
        }
        if (Input.GetKeyDown(KeyCode.Joystick6Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button17);
        }
        if (Input.GetKeyDown(KeyCode.Joystick6Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button18);
        }
        if (Input.GetKeyDown(KeyCode.Joystick6Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button19);
        }
        if (Input.GetKeyDown(KeyCode.Joystick7Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button0);
        }
        if (Input.GetKeyDown(KeyCode.Joystick7Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button1);
        }
        if (Input.GetKeyDown(KeyCode.Joystick7Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button2);
        }
        if (Input.GetKeyDown(KeyCode.Joystick7Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button3);
        }
        if (Input.GetKeyDown(KeyCode.Joystick7Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button4);
        }
        if (Input.GetKeyDown(KeyCode.Joystick7Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button5);
        }
        if (Input.GetKeyDown(KeyCode.Joystick7Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button6);
        }
        if (Input.GetKeyDown(KeyCode.Joystick7Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button7);
        }
        if (Input.GetKeyDown(KeyCode.Joystick7Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button8);
        }
        if (Input.GetKeyDown(KeyCode.Joystick7Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button9);
        }
        if (Input.GetKeyDown(KeyCode.Joystick7Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button10);
        }
        if (Input.GetKeyDown(KeyCode.Joystick7Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button11);
        }
        if (Input.GetKeyDown(KeyCode.Joystick7Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button12);
        }
        if (Input.GetKeyDown(KeyCode.Joystick7Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button13);
        }
        if (Input.GetKeyDown(KeyCode.Joystick7Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button14);
        }
        if (Input.GetKeyDown(KeyCode.Joystick7Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button15);
        }
        if (Input.GetKeyDown(KeyCode.Joystick7Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button16);
        }
        if (Input.GetKeyDown(KeyCode.Joystick7Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button17);
        }
        if (Input.GetKeyDown(KeyCode.Joystick7Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button18);
        }
        if (Input.GetKeyDown(KeyCode.Joystick7Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button19);
        }
        if (Input.GetKeyDown(KeyCode.Joystick8Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button0);
        }
        if (Input.GetKeyDown(KeyCode.Joystick8Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button1);
        }
        if (Input.GetKeyDown(KeyCode.Joystick8Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button2);
        }
        if (Input.GetKeyDown(KeyCode.Joystick8Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button3);
        }
        if (Input.GetKeyDown(KeyCode.Joystick8Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button4);
        }
        if (Input.GetKeyDown(KeyCode.Joystick8Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button5);
        }
        if (Input.GetKeyDown(KeyCode.Joystick8Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button6);
        }
        if (Input.GetKeyDown(KeyCode.Joystick8Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button7);
        }
        if (Input.GetKeyDown(KeyCode.Joystick8Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button8);
        }
        if (Input.GetKeyDown(KeyCode.Joystick8Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button9);
        }
        if (Input.GetKeyDown(KeyCode.Joystick8Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button10);
        }
        if (Input.GetKeyDown(KeyCode.Joystick8Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button11);
        }
        if (Input.GetKeyDown(KeyCode.Joystick8Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button12);
        }
        if (Input.GetKeyDown(KeyCode.Joystick8Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button13);
        }
        if (Input.GetKeyDown(KeyCode.Joystick8Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button14);
        }
        if (Input.GetKeyDown(KeyCode.Joystick8Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button15);
        }
        if (Input.GetKeyDown(KeyCode.Joystick8Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button16);
        }
        if (Input.GetKeyDown(KeyCode.Joystick8Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button17);
        }
        if (Input.GetKeyDown(KeyCode.Joystick8Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button18);
        }
        if (Input.GetKeyDown(KeyCode.Joystick8Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button19);
        }

        #endregion KeyDown

        #region Key

        if (Input.GetKey(KeyCode.None))
        {
            BindableControls.BindingDown(KeyCode.None);
        }
        if (Input.GetKey(KeyCode.Backspace))
        {
            BindableControls.BindingDown(KeyCode.Backspace);
        }
        if (Input.GetKey(KeyCode.Delete))
        {
            BindableControls.BindingDown(KeyCode.Delete);
        }
        if (Input.GetKey(KeyCode.Tab))
        {
            BindableControls.BindingDown(KeyCode.Tab);
        }
        if (Input.GetKey(KeyCode.Clear))
        {
            BindableControls.BindingDown(KeyCode.Clear);
        }
        if (Input.GetKey(KeyCode.Return))
        {
            BindableControls.BindingDown(KeyCode.Return);
        }
        if (Input.GetKey(KeyCode.Pause))
        {
            BindableControls.BindingDown(KeyCode.Pause);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            BindableControls.BindingDown(KeyCode.Escape);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            BindableControls.BindingDown(KeyCode.Space);
        }
        if (Input.GetKey(KeyCode.Keypad0))
        {
            BindableControls.BindingDown(KeyCode.Keypad0);
        }
        if (Input.GetKey(KeyCode.Keypad1))
        {
            BindableControls.BindingDown(KeyCode.Keypad1);
        }
        if (Input.GetKey(KeyCode.Keypad2))
        {
            BindableControls.BindingDown(KeyCode.Keypad2);
        }
        if (Input.GetKey(KeyCode.Keypad3))
        {
            BindableControls.BindingDown(KeyCode.Keypad3);
        }
        if (Input.GetKey(KeyCode.Keypad4))
        {
            BindableControls.BindingDown(KeyCode.Keypad4);
        }
        if (Input.GetKey(KeyCode.Keypad5))
        {
            BindableControls.BindingDown(KeyCode.Keypad5);
        }
        if (Input.GetKey(KeyCode.Keypad6))
        {
            BindableControls.BindingDown(KeyCode.Keypad6);
        }
        if (Input.GetKey(KeyCode.Keypad7))
        {
            BindableControls.BindingDown(KeyCode.Keypad7);
        }
        if (Input.GetKey(KeyCode.Keypad8))
        {
            BindableControls.BindingDown(KeyCode.Keypad8);
        }
        if (Input.GetKey(KeyCode.Keypad9))
        {
            BindableControls.BindingDown(KeyCode.Keypad9);
        }
        if (Input.GetKey(KeyCode.KeypadPeriod))
        {
            BindableControls.BindingDown(KeyCode.KeypadPeriod);
        }
        if (Input.GetKey(KeyCode.KeypadDivide))
        {
            BindableControls.BindingDown(KeyCode.KeypadDivide);
        }
        if (Input.GetKey(KeyCode.KeypadMultiply))
        {
            BindableControls.BindingDown(KeyCode.KeypadMultiply);
        }
        if (Input.GetKey(KeyCode.KeypadMinus))
        {
            BindableControls.BindingDown(KeyCode.KeypadMinus);
        }
        if (Input.GetKey(KeyCode.KeypadPlus))
        {
            BindableControls.BindingDown(KeyCode.KeypadPlus);
        }
        if (Input.GetKey(KeyCode.KeypadEnter))
        {
            BindableControls.BindingDown(KeyCode.KeypadEnter);
        }
        if (Input.GetKey(KeyCode.KeypadEquals))
        {
            BindableControls.BindingDown(KeyCode.KeypadEquals);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            BindableControls.BindingDown(KeyCode.UpArrow);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            BindableControls.BindingDown(KeyCode.DownArrow);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            BindableControls.BindingDown(KeyCode.RightArrow);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            BindableControls.BindingDown(KeyCode.LeftArrow);
        }
        if (Input.GetKey(KeyCode.Insert))
        {
            BindableControls.BindingDown(KeyCode.Insert);
        }
        if (Input.GetKey(KeyCode.Home))
        {
            BindableControls.BindingDown(KeyCode.Home);
        }
        if (Input.GetKey(KeyCode.End))
        {
            BindableControls.BindingDown(KeyCode.End);
        }
        if (Input.GetKey(KeyCode.PageUp))
        {
            BindableControls.BindingDown(KeyCode.PageUp);
        }
        if (Input.GetKey(KeyCode.PageDown))
        {
            BindableControls.BindingDown(KeyCode.PageDown);
        }
        if (Input.GetKey(KeyCode.F1))
        {
            BindableControls.BindingDown(KeyCode.F1);
        }
        if (Input.GetKey(KeyCode.F2))
        {
            BindableControls.BindingDown(KeyCode.F2);
        }
        if (Input.GetKey(KeyCode.F3))
        {
            BindableControls.BindingDown(KeyCode.F3);
        }
        if (Input.GetKey(KeyCode.F4))
        {
            BindableControls.BindingDown(KeyCode.F4);
        }
        if (Input.GetKey(KeyCode.F5))
        {
            BindableControls.BindingDown(KeyCode.F5);
        }
        if (Input.GetKey(KeyCode.F6))
        {
            BindableControls.BindingDown(KeyCode.F6);
        }
        if (Input.GetKey(KeyCode.F7))
        {
            BindableControls.BindingDown(KeyCode.F7);
        }
        if (Input.GetKey(KeyCode.F8))
        {
            BindableControls.BindingDown(KeyCode.F8);
        }
        if (Input.GetKey(KeyCode.F9))
        {
            BindableControls.BindingDown(KeyCode.F9);
        }
        if (Input.GetKey(KeyCode.F10))
        {
            BindableControls.BindingDown(KeyCode.F10);
        }
        if (Input.GetKey(KeyCode.F11))
        {
            BindableControls.BindingDown(KeyCode.F11);
        }
        if (Input.GetKey(KeyCode.F12))
        {
            BindableControls.BindingDown(KeyCode.F12);
        }
        if (Input.GetKey(KeyCode.F13))
        {
            BindableControls.BindingDown(KeyCode.F13);
        }
        if (Input.GetKey(KeyCode.F14))
        {
            BindableControls.BindingDown(KeyCode.F14);
        }
        if (Input.GetKey(KeyCode.F15))
        {
            BindableControls.BindingDown(KeyCode.F15);
        }
        if (Input.GetKey(KeyCode.Alpha0))
        {
            BindableControls.BindingDown(KeyCode.Alpha0);
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            BindableControls.BindingDown(KeyCode.Alpha1);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            BindableControls.BindingDown(KeyCode.Alpha2);
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            BindableControls.BindingDown(KeyCode.Alpha3);
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            BindableControls.BindingDown(KeyCode.Alpha4);
        }
        if (Input.GetKey(KeyCode.Alpha5))
        {
            BindableControls.BindingDown(KeyCode.Alpha5);
        }
        if (Input.GetKey(KeyCode.Alpha6))
        {
            BindableControls.BindingDown(KeyCode.Alpha6);
        }
        if (Input.GetKey(KeyCode.Alpha7))
        {
            BindableControls.BindingDown(KeyCode.Alpha7);
        }
        if (Input.GetKey(KeyCode.Alpha8))
        {
            BindableControls.BindingDown(KeyCode.Alpha8);
        }
        if (Input.GetKey(KeyCode.Alpha9))
        {
            BindableControls.BindingDown(KeyCode.Alpha9);
        }
        if (Input.GetKey(KeyCode.Exclaim))
        {
            BindableControls.BindingDown(KeyCode.Exclaim);
        }
        if (Input.GetKey(KeyCode.DoubleQuote))
        {
            BindableControls.BindingDown(KeyCode.DoubleQuote);
        }
        if (Input.GetKey(KeyCode.Hash))
        {
            BindableControls.BindingDown(KeyCode.Hash);
        }
        if (Input.GetKey(KeyCode.Dollar))
        {
            BindableControls.BindingDown(KeyCode.Dollar);
        }
        if (Input.GetKey(KeyCode.Ampersand))
        {
            BindableControls.BindingDown(KeyCode.Ampersand);
        }
        if (Input.GetKey(KeyCode.Quote))
        {
            BindableControls.BindingDown(KeyCode.Quote);
        }
        if (Input.GetKey(KeyCode.LeftParen))
        {
            BindableControls.BindingDown(KeyCode.LeftParen);
        }
        if (Input.GetKey(KeyCode.RightParen))
        {
            BindableControls.BindingDown(KeyCode.RightParen);
        }
        if (Input.GetKey(KeyCode.Asterisk))
        {
            BindableControls.BindingDown(KeyCode.Asterisk);
        }
        if (Input.GetKey(KeyCode.Plus))
        {
            BindableControls.BindingDown(KeyCode.Plus);
        }
        if (Input.GetKey(KeyCode.Comma))
        {
            BindableControls.BindingDown(KeyCode.Comma);
        }
        if (Input.GetKey(KeyCode.Minus))
        {
            BindableControls.BindingDown(KeyCode.Minus);
        }
        if (Input.GetKey(KeyCode.Period))
        {
            BindableControls.BindingDown(KeyCode.Period);
        }
        if (Input.GetKey(KeyCode.Slash))
        {
            BindableControls.BindingDown(KeyCode.Slash);
        }
        if (Input.GetKey(KeyCode.Colon))
        {
            BindableControls.BindingDown(KeyCode.Colon);
        }
        if (Input.GetKey(KeyCode.Semicolon))
        {
            BindableControls.BindingDown(KeyCode.Semicolon);
        }
        if (Input.GetKey(KeyCode.Less))
        {
            BindableControls.BindingDown(KeyCode.Less);
        }
        if (Input.GetKey(KeyCode.Equals))
        {
            BindableControls.BindingDown(KeyCode.Equals);
        }
        if (Input.GetKey(KeyCode.Greater))
        {
            BindableControls.BindingDown(KeyCode.Greater);
        }
        if (Input.GetKey(KeyCode.Question))
        {
            BindableControls.BindingDown(KeyCode.Question);
        }
        if (Input.GetKey(KeyCode.At))
        {
            BindableControls.BindingDown(KeyCode.At);
        }
        if (Input.GetKey(KeyCode.LeftBracket))
        {
            BindableControls.BindingDown(KeyCode.LeftBracket);
        }
        if (Input.GetKey(KeyCode.Backslash))
        {
            BindableControls.BindingDown(KeyCode.Backslash);
        }
        if (Input.GetKey(KeyCode.RightBracket))
        {
            BindableControls.BindingDown(KeyCode.RightBracket);
        }
        if (Input.GetKey(KeyCode.Caret))
        {
            BindableControls.BindingDown(KeyCode.Caret);
        }
        if (Input.GetKey(KeyCode.Underscore))
        {
            BindableControls.BindingDown(KeyCode.Underscore);
        }
        if (Input.GetKey(KeyCode.BackQuote))
        {
            BindableControls.BindingDown(KeyCode.BackQuote);
        }
        if (Input.GetKey(KeyCode.A))
        {
            BindableControls.BindingDown(KeyCode.A);
        }
        if (Input.GetKey(KeyCode.B))
        {
            BindableControls.BindingDown(KeyCode.B);
        }
        if (Input.GetKey(KeyCode.C))
        {
            BindableControls.BindingDown(KeyCode.C);
        }
        if (Input.GetKey(KeyCode.D))
        {
            BindableControls.BindingDown(KeyCode.D);
        }
        if (Input.GetKey(KeyCode.E))
        {
            BindableControls.BindingDown(KeyCode.E);
        }
        if (Input.GetKey(KeyCode.F))
        {
            BindableControls.BindingDown(KeyCode.F);
        }
        if (Input.GetKey(KeyCode.G))
        {
            BindableControls.BindingDown(KeyCode.G);
        }
        if (Input.GetKey(KeyCode.H))
        {
            BindableControls.BindingDown(KeyCode.H);
        }
        if (Input.GetKey(KeyCode.I))
        {
            BindableControls.BindingDown(KeyCode.I);
        }
        if (Input.GetKey(KeyCode.J))
        {
            BindableControls.BindingDown(KeyCode.J);
        }
        if (Input.GetKey(KeyCode.K))
        {
            BindableControls.BindingDown(KeyCode.K);
        }
        if (Input.GetKey(KeyCode.L))
        {
            BindableControls.BindingDown(KeyCode.L);
        }
        if (Input.GetKey(KeyCode.M))
        {
            BindableControls.BindingDown(KeyCode.M);
        }
        if (Input.GetKey(KeyCode.N))
        {
            BindableControls.BindingDown(KeyCode.N);
        }
        if (Input.GetKey(KeyCode.O))
        {
            BindableControls.BindingDown(KeyCode.O);
        }
        if (Input.GetKey(KeyCode.P))
        {
            BindableControls.BindingDown(KeyCode.P);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            BindableControls.BindingDown(KeyCode.Q);
        }
        if (Input.GetKey(KeyCode.R))
        {
            BindableControls.BindingDown(KeyCode.R);
        }
        if (Input.GetKey(KeyCode.S))
        {
            BindableControls.BindingDown(KeyCode.S);
        }
        if (Input.GetKey(KeyCode.T))
        {
            BindableControls.BindingDown(KeyCode.T);
        }
        if (Input.GetKey(KeyCode.U))
        {
            BindableControls.BindingDown(KeyCode.U);
        }
        if (Input.GetKey(KeyCode.V))
        {
            BindableControls.BindingDown(KeyCode.V);
        }
        if (Input.GetKey(KeyCode.W))
        {
            BindableControls.BindingDown(KeyCode.W);
        }
        if (Input.GetKey(KeyCode.X))
        {
            BindableControls.BindingDown(KeyCode.X);
        }
        if (Input.GetKey(KeyCode.Y))
        {
            BindableControls.BindingDown(KeyCode.Y);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            BindableControls.BindingDown(KeyCode.Z);
        }
        if (Input.GetKey(KeyCode.Numlock))
        {
            BindableControls.BindingDown(KeyCode.Numlock);
        }
        if (Input.GetKey(KeyCode.CapsLock))
        {
            BindableControls.BindingDown(KeyCode.CapsLock);
        }
        if (Input.GetKey(KeyCode.ScrollLock))
        {
            BindableControls.BindingDown(KeyCode.ScrollLock);
        }
        if (Input.GetKey(KeyCode.RightShift))
        {
            BindableControls.BindingDown(KeyCode.RightShift);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            BindableControls.BindingDown(KeyCode.LeftShift);
        }
        if (Input.GetKey(KeyCode.RightControl))
        {
            BindableControls.BindingDown(KeyCode.RightControl);
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            BindableControls.BindingDown(KeyCode.LeftControl);
        }
        if (Input.GetKey(KeyCode.RightAlt))
        {
            BindableControls.BindingDown(KeyCode.RightAlt);
        }
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            BindableControls.BindingDown(KeyCode.LeftAlt);
        }
        if (Input.GetKey(KeyCode.LeftCommand))
        {
            BindableControls.BindingDown(KeyCode.LeftCommand);
        }
        if (Input.GetKey(KeyCode.LeftWindows))
        {
            BindableControls.BindingDown(KeyCode.LeftWindows);
        }
        if (Input.GetKey(KeyCode.RightCommand))
        {
            BindableControls.BindingDown(KeyCode.RightCommand);
        }
        if (Input.GetKey(KeyCode.RightWindows))
        {
            BindableControls.BindingDown(KeyCode.RightWindows);
        }
        if (Input.GetKey(KeyCode.AltGr))
        {
            BindableControls.BindingDown(KeyCode.AltGr);
        }
        if (Input.GetKey(KeyCode.Help))
        {
            BindableControls.BindingDown(KeyCode.Help);
        }
        if (Input.GetKey(KeyCode.Print))
        {
            BindableControls.BindingDown(KeyCode.Print);
        }
        if (Input.GetKey(KeyCode.SysReq))
        {
            BindableControls.BindingDown(KeyCode.SysReq);
        }
        if (Input.GetKey(KeyCode.Break))
        {
            BindableControls.BindingDown(KeyCode.Break);
        }
        if (Input.GetKey(KeyCode.Menu))
        {
            BindableControls.BindingDown(KeyCode.Menu);
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            BindableControls.BindingDown(KeyCode.Mouse0);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            BindableControls.BindingDown(KeyCode.Mouse1);
        }
        if (Input.GetKey(KeyCode.Mouse2))
        {
            BindableControls.BindingDown(KeyCode.Mouse2);
        }
        if (Input.GetKey(KeyCode.Mouse3))
        {
            BindableControls.BindingDown(KeyCode.Mouse3);
        }
        if (Input.GetKey(KeyCode.Mouse4))
        {
            BindableControls.BindingDown(KeyCode.Mouse4);
        }
        if (Input.GetKey(KeyCode.Mouse5))
        {
            BindableControls.BindingDown(KeyCode.Mouse5);
        }
        if (Input.GetKey(KeyCode.Mouse6))
        {
            BindableControls.BindingDown(KeyCode.Mouse6);
        }
        if (Input.GetKey(KeyCode.JoystickButton0))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton0);
        }
        if (Input.GetKey(KeyCode.JoystickButton1))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton1);
        }
        if (Input.GetKey(KeyCode.JoystickButton2))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton2);
        }
        if (Input.GetKey(KeyCode.JoystickButton3))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton3);
        }
        if (Input.GetKey(KeyCode.JoystickButton4))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton4);
        }
        if (Input.GetKey(KeyCode.JoystickButton5))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton5);
        }
        if (Input.GetKey(KeyCode.JoystickButton6))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton6);
        }
        if (Input.GetKey(KeyCode.JoystickButton7))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton7);
        }
        if (Input.GetKey(KeyCode.JoystickButton8))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton8);
        }
        if (Input.GetKey(KeyCode.JoystickButton9))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton9);
        }
        if (Input.GetKey(KeyCode.JoystickButton10))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton10);
        }
        if (Input.GetKey(KeyCode.JoystickButton11))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton11);
        }
        if (Input.GetKey(KeyCode.JoystickButton12))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton12);
        }
        if (Input.GetKey(KeyCode.JoystickButton13))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton13);
        }
        if (Input.GetKey(KeyCode.JoystickButton14))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton14);
        }
        if (Input.GetKey(KeyCode.JoystickButton15))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton15);
        }
        if (Input.GetKey(KeyCode.JoystickButton16))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton16);
        }
        if (Input.GetKey(KeyCode.JoystickButton17))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton17);
        }
        if (Input.GetKey(KeyCode.JoystickButton18))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton18);
        }
        if (Input.GetKey(KeyCode.JoystickButton19))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton19);
        }
        if (Input.GetKey(KeyCode.Joystick1Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button0);
        }
        if (Input.GetKey(KeyCode.Joystick1Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button1);
        }
        if (Input.GetKey(KeyCode.Joystick1Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button2);
        }
        if (Input.GetKey(KeyCode.Joystick1Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button3);
        }
        if (Input.GetKey(KeyCode.Joystick1Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button4);
        }
        if (Input.GetKey(KeyCode.Joystick1Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button5);
        }
        if (Input.GetKey(KeyCode.Joystick1Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button6);
        }
        if (Input.GetKey(KeyCode.Joystick1Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button7);
        }
        if (Input.GetKey(KeyCode.Joystick1Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button8);
        }
        if (Input.GetKey(KeyCode.Joystick1Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button9);
        }
        if (Input.GetKey(KeyCode.Joystick1Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button10);
        }
        if (Input.GetKey(KeyCode.Joystick1Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button11);
        }
        if (Input.GetKey(KeyCode.Joystick1Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button12);
        }
        if (Input.GetKey(KeyCode.Joystick1Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button13);
        }
        if (Input.GetKey(KeyCode.Joystick1Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button14);
        }
        if (Input.GetKey(KeyCode.Joystick1Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button15);
        }
        if (Input.GetKey(KeyCode.Joystick1Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button16);
        }
        if (Input.GetKey(KeyCode.Joystick1Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button17);
        }
        if (Input.GetKey(KeyCode.Joystick1Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button18);
        }
        if (Input.GetKey(KeyCode.Joystick1Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button19);
        }
        if (Input.GetKey(KeyCode.Joystick2Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button0);
        }
        if (Input.GetKey(KeyCode.Joystick2Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button1);
        }
        if (Input.GetKey(KeyCode.Joystick2Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button2);
        }
        if (Input.GetKey(KeyCode.Joystick2Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button3);
        }
        if (Input.GetKey(KeyCode.Joystick2Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button4);
        }
        if (Input.GetKey(KeyCode.Joystick2Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button5);
        }
        if (Input.GetKey(KeyCode.Joystick2Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button6);
        }
        if (Input.GetKey(KeyCode.Joystick2Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button7);
        }
        if (Input.GetKey(KeyCode.Joystick2Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button8);
        }
        if (Input.GetKey(KeyCode.Joystick2Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button9);
        }
        if (Input.GetKey(KeyCode.Joystick2Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button10);
        }
        if (Input.GetKey(KeyCode.Joystick2Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button11);
        }
        if (Input.GetKey(KeyCode.Joystick2Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button12);
        }
        if (Input.GetKey(KeyCode.Joystick2Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button13);
        }
        if (Input.GetKey(KeyCode.Joystick2Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button14);
        }
        if (Input.GetKey(KeyCode.Joystick2Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button15);
        }
        if (Input.GetKey(KeyCode.Joystick2Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button16);
        }
        if (Input.GetKey(KeyCode.Joystick2Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button17);
        }
        if (Input.GetKey(KeyCode.Joystick2Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button18);
        }
        if (Input.GetKey(KeyCode.Joystick2Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button19);
        }
        if (Input.GetKey(KeyCode.Joystick3Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button0);
        }
        if (Input.GetKey(KeyCode.Joystick3Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button1);
        }
        if (Input.GetKey(KeyCode.Joystick3Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button2);
        }
        if (Input.GetKey(KeyCode.Joystick3Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button3);
        }
        if (Input.GetKey(KeyCode.Joystick3Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button4);
        }
        if (Input.GetKey(KeyCode.Joystick3Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button5);
        }
        if (Input.GetKey(KeyCode.Joystick3Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button6);
        }
        if (Input.GetKey(KeyCode.Joystick3Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button7);
        }
        if (Input.GetKey(KeyCode.Joystick3Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button8);
        }
        if (Input.GetKey(KeyCode.Joystick3Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button9);
        }
        if (Input.GetKey(KeyCode.Joystick3Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button10);
        }
        if (Input.GetKey(KeyCode.Joystick3Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button11);
        }
        if (Input.GetKey(KeyCode.Joystick3Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button12);
        }
        if (Input.GetKey(KeyCode.Joystick3Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button13);
        }
        if (Input.GetKey(KeyCode.Joystick3Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button14);
        }
        if (Input.GetKey(KeyCode.Joystick3Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button15);
        }
        if (Input.GetKey(KeyCode.Joystick3Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button16);
        }
        if (Input.GetKey(KeyCode.Joystick3Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button17);
        }
        if (Input.GetKey(KeyCode.Joystick3Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button18);
        }
        if (Input.GetKey(KeyCode.Joystick3Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button19);
        }
        if (Input.GetKey(KeyCode.Joystick4Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button0);
        }
        if (Input.GetKey(KeyCode.Joystick4Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button1);
        }
        if (Input.GetKey(KeyCode.Joystick4Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button2);
        }
        if (Input.GetKey(KeyCode.Joystick4Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button3);
        }
        if (Input.GetKey(KeyCode.Joystick4Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button4);
        }
        if (Input.GetKey(KeyCode.Joystick4Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button5);
        }
        if (Input.GetKey(KeyCode.Joystick4Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button6);
        }
        if (Input.GetKey(KeyCode.Joystick4Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button7);
        }
        if (Input.GetKey(KeyCode.Joystick4Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button8);
        }
        if (Input.GetKey(KeyCode.Joystick4Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button9);
        }
        if (Input.GetKey(KeyCode.Joystick4Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button10);
        }
        if (Input.GetKey(KeyCode.Joystick4Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button11);
        }
        if (Input.GetKey(KeyCode.Joystick4Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button12);
        }
        if (Input.GetKey(KeyCode.Joystick4Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button13);
        }
        if (Input.GetKey(KeyCode.Joystick4Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button14);
        }
        if (Input.GetKey(KeyCode.Joystick4Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button15);
        }
        if (Input.GetKey(KeyCode.Joystick4Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button16);
        }
        if (Input.GetKey(KeyCode.Joystick4Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button17);
        }
        if (Input.GetKey(KeyCode.Joystick4Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button18);
        }
        if (Input.GetKey(KeyCode.Joystick4Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button19);
        }
        if (Input.GetKey(KeyCode.Joystick5Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button0);
        }
        if (Input.GetKey(KeyCode.Joystick5Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button1);
        }
        if (Input.GetKey(KeyCode.Joystick5Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button2);
        }
        if (Input.GetKey(KeyCode.Joystick5Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button3);
        }
        if (Input.GetKey(KeyCode.Joystick5Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button4);
        }
        if (Input.GetKey(KeyCode.Joystick5Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button5);
        }
        if (Input.GetKey(KeyCode.Joystick5Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button6);
        }
        if (Input.GetKey(KeyCode.Joystick5Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button7);
        }
        if (Input.GetKey(KeyCode.Joystick5Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button8);
        }
        if (Input.GetKey(KeyCode.Joystick5Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button9);
        }
        if (Input.GetKey(KeyCode.Joystick5Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button10);
        }
        if (Input.GetKey(KeyCode.Joystick5Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button11);
        }
        if (Input.GetKey(KeyCode.Joystick5Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button12);
        }
        if (Input.GetKey(KeyCode.Joystick5Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button13);
        }
        if (Input.GetKey(KeyCode.Joystick5Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button14);
        }
        if (Input.GetKey(KeyCode.Joystick5Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button15);
        }
        if (Input.GetKey(KeyCode.Joystick5Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button16);
        }
        if (Input.GetKey(KeyCode.Joystick5Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button17);
        }
        if (Input.GetKey(KeyCode.Joystick5Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button18);
        }
        if (Input.GetKey(KeyCode.Joystick5Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button19);
        }
        if (Input.GetKey(KeyCode.Joystick6Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button0);
        }
        if (Input.GetKey(KeyCode.Joystick6Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button1);
        }
        if (Input.GetKey(KeyCode.Joystick6Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button2);
        }
        if (Input.GetKey(KeyCode.Joystick6Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button3);
        }
        if (Input.GetKey(KeyCode.Joystick6Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button4);
        }
        if (Input.GetKey(KeyCode.Joystick6Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button5);
        }
        if (Input.GetKey(KeyCode.Joystick6Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button6);
        }
        if (Input.GetKey(KeyCode.Joystick6Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button7);
        }
        if (Input.GetKey(KeyCode.Joystick6Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button8);
        }
        if (Input.GetKey(KeyCode.Joystick6Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button9);
        }
        if (Input.GetKey(KeyCode.Joystick6Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button10);
        }
        if (Input.GetKey(KeyCode.Joystick6Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button11);
        }
        if (Input.GetKey(KeyCode.Joystick6Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button12);
        }
        if (Input.GetKey(KeyCode.Joystick6Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button13);
        }
        if (Input.GetKey(KeyCode.Joystick6Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button14);
        }
        if (Input.GetKey(KeyCode.Joystick6Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button15);
        }
        if (Input.GetKey(KeyCode.Joystick6Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button16);
        }
        if (Input.GetKey(KeyCode.Joystick6Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button17);
        }
        if (Input.GetKey(KeyCode.Joystick6Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button18);
        }
        if (Input.GetKey(KeyCode.Joystick6Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button19);
        }
        if (Input.GetKey(KeyCode.Joystick7Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button0);
        }
        if (Input.GetKey(KeyCode.Joystick7Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button1);
        }
        if (Input.GetKey(KeyCode.Joystick7Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button2);
        }
        if (Input.GetKey(KeyCode.Joystick7Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button3);
        }
        if (Input.GetKey(KeyCode.Joystick7Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button4);
        }
        if (Input.GetKey(KeyCode.Joystick7Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button5);
        }
        if (Input.GetKey(KeyCode.Joystick7Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button6);
        }
        if (Input.GetKey(KeyCode.Joystick7Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button7);
        }
        if (Input.GetKey(KeyCode.Joystick7Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button8);
        }
        if (Input.GetKey(KeyCode.Joystick7Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button9);
        }
        if (Input.GetKey(KeyCode.Joystick7Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button10);
        }
        if (Input.GetKey(KeyCode.Joystick7Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button11);
        }
        if (Input.GetKey(KeyCode.Joystick7Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button12);
        }
        if (Input.GetKey(KeyCode.Joystick7Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button13);
        }
        if (Input.GetKey(KeyCode.Joystick7Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button14);
        }
        if (Input.GetKey(KeyCode.Joystick7Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button15);
        }
        if (Input.GetKey(KeyCode.Joystick7Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button16);
        }
        if (Input.GetKey(KeyCode.Joystick7Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button17);
        }
        if (Input.GetKey(KeyCode.Joystick7Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button18);
        }
        if (Input.GetKey(KeyCode.Joystick7Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button19);
        }
        if (Input.GetKey(KeyCode.Joystick8Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button0);
        }
        if (Input.GetKey(KeyCode.Joystick8Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button1);
        }
        if (Input.GetKey(KeyCode.Joystick8Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button2);
        }
        if (Input.GetKey(KeyCode.Joystick8Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button3);
        }
        if (Input.GetKey(KeyCode.Joystick8Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button4);
        }
        if (Input.GetKey(KeyCode.Joystick8Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button5);
        }
        if (Input.GetKey(KeyCode.Joystick8Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button6);
        }
        if (Input.GetKey(KeyCode.Joystick8Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button7);
        }
        if (Input.GetKey(KeyCode.Joystick8Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button8);
        }
        if (Input.GetKey(KeyCode.Joystick8Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button9);
        }
        if (Input.GetKey(KeyCode.Joystick8Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button10);
        }
        if (Input.GetKey(KeyCode.Joystick8Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button11);
        }
        if (Input.GetKey(KeyCode.Joystick8Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button12);
        }
        if (Input.GetKey(KeyCode.Joystick8Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button13);
        }
        if (Input.GetKey(KeyCode.Joystick8Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button14);
        }
        if (Input.GetKey(KeyCode.Joystick8Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button15);
        }
        if (Input.GetKey(KeyCode.Joystick8Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button16);
        }
        if (Input.GetKey(KeyCode.Joystick8Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button17);
        }
        if (Input.GetKey(KeyCode.Joystick8Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button18);
        }
        if (Input.GetKey(KeyCode.Joystick8Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button19);
        }

        #endregion Key

        #region KeyUp

        if (Input.GetKeyUp(KeyCode.None))
        {
            BindableControls.BindingDown(KeyCode.None);
        }
        if (Input.GetKeyUp(KeyCode.Backspace))
        {
            BindableControls.BindingDown(KeyCode.Backspace);
        }
        if (Input.GetKeyUp(KeyCode.Delete))
        {
            BindableControls.BindingDown(KeyCode.Delete);
        }
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            BindableControls.BindingDown(KeyCode.Tab);
        }
        if (Input.GetKeyUp(KeyCode.Clear))
        {
            BindableControls.BindingDown(KeyCode.Clear);
        }
        if (Input.GetKeyUp(KeyCode.Return))
        {
            BindableControls.BindingDown(KeyCode.Return);
        }
        if (Input.GetKeyUp(KeyCode.Pause))
        {
            BindableControls.BindingDown(KeyCode.Pause);
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            BindableControls.BindingDown(KeyCode.Escape);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            BindableControls.BindingDown(KeyCode.Space);
        }
        if (Input.GetKeyUp(KeyCode.Keypad0))
        {
            BindableControls.BindingDown(KeyCode.Keypad0);
        }
        if (Input.GetKeyUp(KeyCode.Keypad1))
        {
            BindableControls.BindingDown(KeyCode.Keypad1);
        }
        if (Input.GetKeyUp(KeyCode.Keypad2))
        {
            BindableControls.BindingDown(KeyCode.Keypad2);
        }
        if (Input.GetKeyUp(KeyCode.Keypad3))
        {
            BindableControls.BindingDown(KeyCode.Keypad3);
        }
        if (Input.GetKeyUp(KeyCode.Keypad4))
        {
            BindableControls.BindingDown(KeyCode.Keypad4);
        }
        if (Input.GetKeyUp(KeyCode.Keypad5))
        {
            BindableControls.BindingDown(KeyCode.Keypad5);
        }
        if (Input.GetKeyUp(KeyCode.Keypad6))
        {
            BindableControls.BindingDown(KeyCode.Keypad6);
        }
        if (Input.GetKeyUp(KeyCode.Keypad7))
        {
            BindableControls.BindingDown(KeyCode.Keypad7);
        }
        if (Input.GetKeyUp(KeyCode.Keypad8))
        {
            BindableControls.BindingDown(KeyCode.Keypad8);
        }
        if (Input.GetKeyUp(KeyCode.Keypad9))
        {
            BindableControls.BindingDown(KeyCode.Keypad9);
        }
        if (Input.GetKeyUp(KeyCode.KeypadPeriod))
        {
            BindableControls.BindingDown(KeyCode.KeypadPeriod);
        }
        if (Input.GetKeyUp(KeyCode.KeypadDivide))
        {
            BindableControls.BindingDown(KeyCode.KeypadDivide);
        }
        if (Input.GetKeyUp(KeyCode.KeypadMultiply))
        {
            BindableControls.BindingDown(KeyCode.KeypadMultiply);
        }
        if (Input.GetKeyUp(KeyCode.KeypadMinus))
        {
            BindableControls.BindingDown(KeyCode.KeypadMinus);
        }
        if (Input.GetKeyUp(KeyCode.KeypadPlus))
        {
            BindableControls.BindingDown(KeyCode.KeypadPlus);
        }
        if (Input.GetKeyUp(KeyCode.KeypadEnter))
        {
            BindableControls.BindingDown(KeyCode.KeypadEnter);
        }
        if (Input.GetKeyUp(KeyCode.KeypadEquals))
        {
            BindableControls.BindingDown(KeyCode.KeypadEquals);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            BindableControls.BindingDown(KeyCode.UpArrow);
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            BindableControls.BindingDown(KeyCode.DownArrow);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            BindableControls.BindingDown(KeyCode.RightArrow);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            BindableControls.BindingDown(KeyCode.LeftArrow);
        }
        if (Input.GetKeyUp(KeyCode.Insert))
        {
            BindableControls.BindingDown(KeyCode.Insert);
        }
        if (Input.GetKeyUp(KeyCode.Home))
        {
            BindableControls.BindingDown(KeyCode.Home);
        }
        if (Input.GetKeyUp(KeyCode.End))
        {
            BindableControls.BindingDown(KeyCode.End);
        }
        if (Input.GetKeyUp(KeyCode.PageUp))
        {
            BindableControls.BindingDown(KeyCode.PageUp);
        }
        if (Input.GetKeyUp(KeyCode.PageDown))
        {
            BindableControls.BindingDown(KeyCode.PageDown);
        }
        if (Input.GetKeyUp(KeyCode.F1))
        {
            BindableControls.BindingDown(KeyCode.F1);
        }
        if (Input.GetKeyUp(KeyCode.F2))
        {
            BindableControls.BindingDown(KeyCode.F2);
        }
        if (Input.GetKeyUp(KeyCode.F3))
        {
            BindableControls.BindingDown(KeyCode.F3);
        }
        if (Input.GetKeyUp(KeyCode.F4))
        {
            BindableControls.BindingDown(KeyCode.F4);
        }
        if (Input.GetKeyUp(KeyCode.F5))
        {
            BindableControls.BindingDown(KeyCode.F5);
        }
        if (Input.GetKeyUp(KeyCode.F6))
        {
            BindableControls.BindingDown(KeyCode.F6);
        }
        if (Input.GetKeyUp(KeyCode.F7))
        {
            BindableControls.BindingDown(KeyCode.F7);
        }
        if (Input.GetKeyUp(KeyCode.F8))
        {
            BindableControls.BindingDown(KeyCode.F8);
        }
        if (Input.GetKeyUp(KeyCode.F9))
        {
            BindableControls.BindingDown(KeyCode.F9);
        }
        if (Input.GetKeyUp(KeyCode.F10))
        {
            BindableControls.BindingDown(KeyCode.F10);
        }
        if (Input.GetKeyUp(KeyCode.F11))
        {
            BindableControls.BindingDown(KeyCode.F11);
        }
        if (Input.GetKeyUp(KeyCode.F12))
        {
            BindableControls.BindingDown(KeyCode.F12);
        }
        if (Input.GetKeyUp(KeyCode.F13))
        {
            BindableControls.BindingDown(KeyCode.F13);
        }
        if (Input.GetKeyUp(KeyCode.F14))
        {
            BindableControls.BindingDown(KeyCode.F14);
        }
        if (Input.GetKeyUp(KeyCode.F15))
        {
            BindableControls.BindingDown(KeyCode.F15);
        }
        if (Input.GetKeyUp(KeyCode.Alpha0))
        {
            BindableControls.BindingDown(KeyCode.Alpha0);
        }
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            BindableControls.BindingDown(KeyCode.Alpha1);
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            BindableControls.BindingDown(KeyCode.Alpha2);
        }
        if (Input.GetKeyUp(KeyCode.Alpha3))
        {
            BindableControls.BindingDown(KeyCode.Alpha3);
        }
        if (Input.GetKeyUp(KeyCode.Alpha4))
        {
            BindableControls.BindingDown(KeyCode.Alpha4);
        }
        if (Input.GetKeyUp(KeyCode.Alpha5))
        {
            BindableControls.BindingDown(KeyCode.Alpha5);
        }
        if (Input.GetKeyUp(KeyCode.Alpha6))
        {
            BindableControls.BindingDown(KeyCode.Alpha6);
        }
        if (Input.GetKeyUp(KeyCode.Alpha7))
        {
            BindableControls.BindingDown(KeyCode.Alpha7);
        }
        if (Input.GetKeyUp(KeyCode.Alpha8))
        {
            BindableControls.BindingDown(KeyCode.Alpha8);
        }
        if (Input.GetKeyUp(KeyCode.Alpha9))
        {
            BindableControls.BindingDown(KeyCode.Alpha9);
        }
        if (Input.GetKeyUp(KeyCode.Exclaim))
        {
            BindableControls.BindingDown(KeyCode.Exclaim);
        }
        if (Input.GetKeyUp(KeyCode.DoubleQuote))
        {
            BindableControls.BindingDown(KeyCode.DoubleQuote);
        }
        if (Input.GetKeyUp(KeyCode.Hash))
        {
            BindableControls.BindingDown(KeyCode.Hash);
        }
        if (Input.GetKeyUp(KeyCode.Dollar))
        {
            BindableControls.BindingDown(KeyCode.Dollar);
        }
        if (Input.GetKeyUp(KeyCode.Ampersand))
        {
            BindableControls.BindingDown(KeyCode.Ampersand);
        }
        if (Input.GetKeyUp(KeyCode.Quote))
        {
            BindableControls.BindingDown(KeyCode.Quote);
        }
        if (Input.GetKeyUp(KeyCode.LeftParen))
        {
            BindableControls.BindingDown(KeyCode.LeftParen);
        }
        if (Input.GetKeyUp(KeyCode.RightParen))
        {
            BindableControls.BindingDown(KeyCode.RightParen);
        }
        if (Input.GetKeyUp(KeyCode.Asterisk))
        {
            BindableControls.BindingDown(KeyCode.Asterisk);
        }
        if (Input.GetKeyUp(KeyCode.Plus))
        {
            BindableControls.BindingDown(KeyCode.Plus);
        }
        if (Input.GetKeyUp(KeyCode.Comma))
        {
            BindableControls.BindingDown(KeyCode.Comma);
        }
        if (Input.GetKeyUp(KeyCode.Minus))
        {
            BindableControls.BindingDown(KeyCode.Minus);
        }
        if (Input.GetKeyUp(KeyCode.Period))
        {
            BindableControls.BindingDown(KeyCode.Period);
        }
        if (Input.GetKeyUp(KeyCode.Slash))
        {
            BindableControls.BindingDown(KeyCode.Slash);
        }
        if (Input.GetKeyUp(KeyCode.Colon))
        {
            BindableControls.BindingDown(KeyCode.Colon);
        }
        if (Input.GetKeyUp(KeyCode.Semicolon))
        {
            BindableControls.BindingDown(KeyCode.Semicolon);
        }
        if (Input.GetKeyUp(KeyCode.Less))
        {
            BindableControls.BindingDown(KeyCode.Less);
        }
        if (Input.GetKeyUp(KeyCode.Equals))
        {
            BindableControls.BindingDown(KeyCode.Equals);
        }
        if (Input.GetKeyUp(KeyCode.Greater))
        {
            BindableControls.BindingDown(KeyCode.Greater);
        }
        if (Input.GetKeyUp(KeyCode.Question))
        {
            BindableControls.BindingDown(KeyCode.Question);
        }
        if (Input.GetKeyUp(KeyCode.At))
        {
            BindableControls.BindingDown(KeyCode.At);
        }
        if (Input.GetKeyUp(KeyCode.LeftBracket))
        {
            BindableControls.BindingDown(KeyCode.LeftBracket);
        }
        if (Input.GetKeyUp(KeyCode.Backslash))
        {
            BindableControls.BindingDown(KeyCode.Backslash);
        }
        if (Input.GetKeyUp(KeyCode.RightBracket))
        {
            BindableControls.BindingDown(KeyCode.RightBracket);
        }
        if (Input.GetKeyUp(KeyCode.Caret))
        {
            BindableControls.BindingDown(KeyCode.Caret);
        }
        if (Input.GetKeyUp(KeyCode.Underscore))
        {
            BindableControls.BindingDown(KeyCode.Underscore);
        }
        if (Input.GetKeyUp(KeyCode.BackQuote))
        {
            BindableControls.BindingDown(KeyCode.BackQuote);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            BindableControls.BindingDown(KeyCode.A);
        }
        if (Input.GetKeyUp(KeyCode.B))
        {
            BindableControls.BindingDown(KeyCode.B);
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            BindableControls.BindingDown(KeyCode.C);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            BindableControls.BindingDown(KeyCode.D);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            BindableControls.BindingDown(KeyCode.E);
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            BindableControls.BindingDown(KeyCode.F);
        }
        if (Input.GetKeyUp(KeyCode.G))
        {
            BindableControls.BindingDown(KeyCode.G);
        }
        if (Input.GetKeyUp(KeyCode.H))
        {
            BindableControls.BindingDown(KeyCode.H);
        }
        if (Input.GetKeyUp(KeyCode.I))
        {
            BindableControls.BindingDown(KeyCode.I);
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            BindableControls.BindingDown(KeyCode.J);
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            BindableControls.BindingDown(KeyCode.K);
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            BindableControls.BindingDown(KeyCode.L);
        }
        if (Input.GetKeyUp(KeyCode.M))
        {
            BindableControls.BindingDown(KeyCode.M);
        }
        if (Input.GetKeyUp(KeyCode.N))
        {
            BindableControls.BindingDown(KeyCode.N);
        }
        if (Input.GetKeyUp(KeyCode.O))
        {
            BindableControls.BindingDown(KeyCode.O);
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            BindableControls.BindingDown(KeyCode.P);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            BindableControls.BindingDown(KeyCode.Q);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            BindableControls.BindingDown(KeyCode.R);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            BindableControls.BindingDown(KeyCode.S);
        }
        if (Input.GetKeyUp(KeyCode.T))
        {
            BindableControls.BindingDown(KeyCode.T);
        }
        if (Input.GetKeyUp(KeyCode.U))
        {
            BindableControls.BindingDown(KeyCode.U);
        }
        if (Input.GetKeyUp(KeyCode.V))
        {
            BindableControls.BindingDown(KeyCode.V);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            BindableControls.BindingDown(KeyCode.W);
        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            BindableControls.BindingDown(KeyCode.X);
        }
        if (Input.GetKeyUp(KeyCode.Y))
        {
            BindableControls.BindingDown(KeyCode.Y);
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            BindableControls.BindingDown(KeyCode.Z);
        }
        if (Input.GetKeyUp(KeyCode.Numlock))
        {
            BindableControls.BindingDown(KeyCode.Numlock);
        }
        if (Input.GetKeyUp(KeyCode.CapsLock))
        {
            BindableControls.BindingDown(KeyCode.CapsLock);
        }
        if (Input.GetKeyUp(KeyCode.ScrollLock))
        {
            BindableControls.BindingDown(KeyCode.ScrollLock);
        }
        if (Input.GetKeyUp(KeyCode.RightShift))
        {
            BindableControls.BindingDown(KeyCode.RightShift);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            BindableControls.BindingDown(KeyCode.LeftShift);
        }
        if (Input.GetKeyUp(KeyCode.RightControl))
        {
            BindableControls.BindingDown(KeyCode.RightControl);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            BindableControls.BindingDown(KeyCode.LeftControl);
        }
        if (Input.GetKeyUp(KeyCode.RightAlt))
        {
            BindableControls.BindingDown(KeyCode.RightAlt);
        }
        if (Input.GetKeyUp(KeyCode.LeftAlt))
        {
            BindableControls.BindingDown(KeyCode.LeftAlt);
        }
        if (Input.GetKeyUp(KeyCode.LeftCommand))
        {
            BindableControls.BindingDown(KeyCode.LeftCommand);
        }
        if (Input.GetKeyUp(KeyCode.LeftWindows))
        {
            BindableControls.BindingDown(KeyCode.LeftWindows);
        }
        if (Input.GetKeyUp(KeyCode.RightCommand))
        {
            BindableControls.BindingDown(KeyCode.RightCommand);
        }
        if (Input.GetKeyUp(KeyCode.RightWindows))
        {
            BindableControls.BindingDown(KeyCode.RightWindows);
        }
        if (Input.GetKeyUp(KeyCode.AltGr))
        {
            BindableControls.BindingDown(KeyCode.AltGr);
        }
        if (Input.GetKeyUp(KeyCode.Help))
        {
            BindableControls.BindingDown(KeyCode.Help);
        }
        if (Input.GetKeyUp(KeyCode.Print))
        {
            BindableControls.BindingDown(KeyCode.Print);
        }
        if (Input.GetKeyUp(KeyCode.SysReq))
        {
            BindableControls.BindingDown(KeyCode.SysReq);
        }
        if (Input.GetKeyUp(KeyCode.Break))
        {
            BindableControls.BindingDown(KeyCode.Break);
        }
        if (Input.GetKeyUp(KeyCode.Menu))
        {
            BindableControls.BindingDown(KeyCode.Menu);
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            BindableControls.BindingDown(KeyCode.Mouse0);
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            BindableControls.BindingDown(KeyCode.Mouse1);
        }
        if (Input.GetKeyUp(KeyCode.Mouse2))
        {
            BindableControls.BindingDown(KeyCode.Mouse2);
        }
        if (Input.GetKeyUp(KeyCode.Mouse3))
        {
            BindableControls.BindingDown(KeyCode.Mouse3);
        }
        if (Input.GetKeyUp(KeyCode.Mouse4))
        {
            BindableControls.BindingDown(KeyCode.Mouse4);
        }
        if (Input.GetKeyUp(KeyCode.Mouse5))
        {
            BindableControls.BindingDown(KeyCode.Mouse5);
        }
        if (Input.GetKeyUp(KeyCode.Mouse6))
        {
            BindableControls.BindingDown(KeyCode.Mouse6);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton0))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton0);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton1))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton1);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton2))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton2);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton3))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton3);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton4))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton4);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton5))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton5);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton6))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton6);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton7))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton7);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton8))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton8);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton9))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton9);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton10))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton10);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton11))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton11);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton12))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton12);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton13))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton13);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton14))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton14);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton15))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton15);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton16))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton16);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton17))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton17);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton18))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton18);
        }
        if (Input.GetKeyUp(KeyCode.JoystickButton19))
        {
            BindableControls.BindingDown(KeyCode.JoystickButton19);
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button0);
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button1);
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button2);
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button3);
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button4);
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button5);
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button6);
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button7);
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button8);
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button9);
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button10);
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button11);
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button12);
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button13);
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button14);
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button15);
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button16);
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button17);
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button18);
        }
        if (Input.GetKeyUp(KeyCode.Joystick1Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick1Button19);
        }
        if (Input.GetKeyUp(KeyCode.Joystick2Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button0);
        }
        if (Input.GetKeyUp(KeyCode.Joystick2Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button1);
        }
        if (Input.GetKeyUp(KeyCode.Joystick2Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button2);
        }
        if (Input.GetKeyUp(KeyCode.Joystick2Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button3);
        }
        if (Input.GetKeyUp(KeyCode.Joystick2Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button4);
        }
        if (Input.GetKeyUp(KeyCode.Joystick2Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button5);
        }
        if (Input.GetKeyUp(KeyCode.Joystick2Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button6);
        }
        if (Input.GetKeyUp(KeyCode.Joystick2Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button7);
        }
        if (Input.GetKeyUp(KeyCode.Joystick2Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button8);
        }
        if (Input.GetKeyUp(KeyCode.Joystick2Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button9);
        }
        if (Input.GetKeyUp(KeyCode.Joystick2Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button10);
        }
        if (Input.GetKeyUp(KeyCode.Joystick2Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button11);
        }
        if (Input.GetKeyUp(KeyCode.Joystick2Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button12);
        }
        if (Input.GetKeyUp(KeyCode.Joystick2Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button13);
        }
        if (Input.GetKeyUp(KeyCode.Joystick2Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button14);
        }
        if (Input.GetKeyUp(KeyCode.Joystick2Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button15);
        }
        if (Input.GetKeyUp(KeyCode.Joystick2Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button16);
        }
        if (Input.GetKeyUp(KeyCode.Joystick2Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button17);
        }
        if (Input.GetKeyUp(KeyCode.Joystick2Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button18);
        }
        if (Input.GetKeyUp(KeyCode.Joystick2Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick2Button19);
        }
        if (Input.GetKeyUp(KeyCode.Joystick3Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button0);
        }
        if (Input.GetKeyUp(KeyCode.Joystick3Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button1);
        }
        if (Input.GetKeyUp(KeyCode.Joystick3Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button2);
        }
        if (Input.GetKeyUp(KeyCode.Joystick3Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button3);
        }
        if (Input.GetKeyUp(KeyCode.Joystick3Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button4);
        }
        if (Input.GetKeyUp(KeyCode.Joystick3Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button5);
        }
        if (Input.GetKeyUp(KeyCode.Joystick3Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button6);
        }
        if (Input.GetKeyUp(KeyCode.Joystick3Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button7);
        }
        if (Input.GetKeyUp(KeyCode.Joystick3Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button8);
        }
        if (Input.GetKeyUp(KeyCode.Joystick3Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button9);
        }
        if (Input.GetKeyUp(KeyCode.Joystick3Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button10);
        }
        if (Input.GetKeyUp(KeyCode.Joystick3Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button11);
        }
        if (Input.GetKeyUp(KeyCode.Joystick3Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button12);
        }
        if (Input.GetKeyUp(KeyCode.Joystick3Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button13);
        }
        if (Input.GetKeyUp(KeyCode.Joystick3Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button14);
        }
        if (Input.GetKeyUp(KeyCode.Joystick3Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button15);
        }
        if (Input.GetKeyUp(KeyCode.Joystick3Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button16);
        }
        if (Input.GetKeyUp(KeyCode.Joystick3Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button17);
        }
        if (Input.GetKeyUp(KeyCode.Joystick3Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button18);
        }
        if (Input.GetKeyUp(KeyCode.Joystick3Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick3Button19);
        }
        if (Input.GetKeyUp(KeyCode.Joystick4Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button0);
        }
        if (Input.GetKeyUp(KeyCode.Joystick4Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button1);
        }
        if (Input.GetKeyUp(KeyCode.Joystick4Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button2);
        }
        if (Input.GetKeyUp(KeyCode.Joystick4Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button3);
        }
        if (Input.GetKeyUp(KeyCode.Joystick4Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button4);
        }
        if (Input.GetKeyUp(KeyCode.Joystick4Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button5);
        }
        if (Input.GetKeyUp(KeyCode.Joystick4Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button6);
        }
        if (Input.GetKeyUp(KeyCode.Joystick4Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button7);
        }
        if (Input.GetKeyUp(KeyCode.Joystick4Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button8);
        }
        if (Input.GetKeyUp(KeyCode.Joystick4Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button9);
        }
        if (Input.GetKeyUp(KeyCode.Joystick4Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button10);
        }
        if (Input.GetKeyUp(KeyCode.Joystick4Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button11);
        }
        if (Input.GetKeyUp(KeyCode.Joystick4Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button12);
        }
        if (Input.GetKeyUp(KeyCode.Joystick4Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button13);
        }
        if (Input.GetKeyUp(KeyCode.Joystick4Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button14);
        }
        if (Input.GetKeyUp(KeyCode.Joystick4Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button15);
        }
        if (Input.GetKeyUp(KeyCode.Joystick4Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button16);
        }
        if (Input.GetKeyUp(KeyCode.Joystick4Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button17);
        }
        if (Input.GetKeyUp(KeyCode.Joystick4Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button18);
        }
        if (Input.GetKeyUp(KeyCode.Joystick4Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick4Button19);
        }
        if (Input.GetKeyUp(KeyCode.Joystick5Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button0);
        }
        if (Input.GetKeyUp(KeyCode.Joystick5Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button1);
        }
        if (Input.GetKeyUp(KeyCode.Joystick5Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button2);
        }
        if (Input.GetKeyUp(KeyCode.Joystick5Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button3);
        }
        if (Input.GetKeyUp(KeyCode.Joystick5Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button4);
        }
        if (Input.GetKeyUp(KeyCode.Joystick5Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button5);
        }
        if (Input.GetKeyUp(KeyCode.Joystick5Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button6);
        }
        if (Input.GetKeyUp(KeyCode.Joystick5Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button7);
        }
        if (Input.GetKeyUp(KeyCode.Joystick5Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button8);
        }
        if (Input.GetKeyUp(KeyCode.Joystick5Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button9);
        }
        if (Input.GetKeyUp(KeyCode.Joystick5Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button10);
        }
        if (Input.GetKeyUp(KeyCode.Joystick5Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button11);
        }
        if (Input.GetKeyUp(KeyCode.Joystick5Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button12);
        }
        if (Input.GetKeyUp(KeyCode.Joystick5Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button13);
        }
        if (Input.GetKeyUp(KeyCode.Joystick5Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button14);
        }
        if (Input.GetKeyUp(KeyCode.Joystick5Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button15);
        }
        if (Input.GetKeyUp(KeyCode.Joystick5Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button16);
        }
        if (Input.GetKeyUp(KeyCode.Joystick5Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button17);
        }
        if (Input.GetKeyUp(KeyCode.Joystick5Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button18);
        }
        if (Input.GetKeyUp(KeyCode.Joystick5Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick5Button19);
        }
        if (Input.GetKeyUp(KeyCode.Joystick6Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button0);
        }
        if (Input.GetKeyUp(KeyCode.Joystick6Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button1);
        }
        if (Input.GetKeyUp(KeyCode.Joystick6Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button2);
        }
        if (Input.GetKeyUp(KeyCode.Joystick6Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button3);
        }
        if (Input.GetKeyUp(KeyCode.Joystick6Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button4);
        }
        if (Input.GetKeyUp(KeyCode.Joystick6Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button5);
        }
        if (Input.GetKeyUp(KeyCode.Joystick6Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button6);
        }
        if (Input.GetKeyUp(KeyCode.Joystick6Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button7);
        }
        if (Input.GetKeyUp(KeyCode.Joystick6Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button8);
        }
        if (Input.GetKeyUp(KeyCode.Joystick6Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button9);
        }
        if (Input.GetKeyUp(KeyCode.Joystick6Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button10);
        }
        if (Input.GetKeyUp(KeyCode.Joystick6Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button11);
        }
        if (Input.GetKeyUp(KeyCode.Joystick6Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button12);
        }
        if (Input.GetKeyUp(KeyCode.Joystick6Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button13);
        }
        if (Input.GetKeyUp(KeyCode.Joystick6Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button14);
        }
        if (Input.GetKeyUp(KeyCode.Joystick6Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button15);
        }
        if (Input.GetKeyUp(KeyCode.Joystick6Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button16);
        }
        if (Input.GetKeyUp(KeyCode.Joystick6Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button17);
        }
        if (Input.GetKeyUp(KeyCode.Joystick6Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button18);
        }
        if (Input.GetKeyUp(KeyCode.Joystick6Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick6Button19);
        }
        if (Input.GetKeyUp(KeyCode.Joystick7Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button0);
        }
        if (Input.GetKeyUp(KeyCode.Joystick7Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button1);
        }
        if (Input.GetKeyUp(KeyCode.Joystick7Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button2);
        }
        if (Input.GetKeyUp(KeyCode.Joystick7Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button3);
        }
        if (Input.GetKeyUp(KeyCode.Joystick7Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button4);
        }
        if (Input.GetKeyUp(KeyCode.Joystick7Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button5);
        }
        if (Input.GetKeyUp(KeyCode.Joystick7Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button6);
        }
        if (Input.GetKeyUp(KeyCode.Joystick7Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button7);
        }
        if (Input.GetKeyUp(KeyCode.Joystick7Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button8);
        }
        if (Input.GetKeyUp(KeyCode.Joystick7Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button9);
        }
        if (Input.GetKeyUp(KeyCode.Joystick7Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button10);
        }
        if (Input.GetKeyUp(KeyCode.Joystick7Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button11);
        }
        if (Input.GetKeyUp(KeyCode.Joystick7Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button12);
        }
        if (Input.GetKeyUp(KeyCode.Joystick7Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button13);
        }
        if (Input.GetKeyUp(KeyCode.Joystick7Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button14);
        }
        if (Input.GetKeyUp(KeyCode.Joystick7Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button15);
        }
        if (Input.GetKeyUp(KeyCode.Joystick7Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button16);
        }
        if (Input.GetKeyUp(KeyCode.Joystick7Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button17);
        }
        if (Input.GetKeyUp(KeyCode.Joystick7Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button18);
        }
        if (Input.GetKeyUp(KeyCode.Joystick7Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick7Button19);
        }
        if (Input.GetKeyUp(KeyCode.Joystick8Button0))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button0);
        }
        if (Input.GetKeyUp(KeyCode.Joystick8Button1))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button1);
        }
        if (Input.GetKeyUp(KeyCode.Joystick8Button2))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button2);
        }
        if (Input.GetKeyUp(KeyCode.Joystick8Button3))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button3);
        }
        if (Input.GetKeyUp(KeyCode.Joystick8Button4))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button4);
        }
        if (Input.GetKeyUp(KeyCode.Joystick8Button5))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button5);
        }
        if (Input.GetKeyUp(KeyCode.Joystick8Button6))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button6);
        }
        if (Input.GetKeyUp(KeyCode.Joystick8Button7))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button7);
        }
        if (Input.GetKeyUp(KeyCode.Joystick8Button8))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button8);
        }
        if (Input.GetKeyUp(KeyCode.Joystick8Button9))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button9);
        }
        if (Input.GetKeyUp(KeyCode.Joystick8Button10))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button10);
        }
        if (Input.GetKeyUp(KeyCode.Joystick8Button11))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button11);
        }
        if (Input.GetKeyUp(KeyCode.Joystick8Button12))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button12);
        }
        if (Input.GetKeyUp(KeyCode.Joystick8Button13))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button13);
        }
        if (Input.GetKeyUp(KeyCode.Joystick8Button14))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button14);
        }
        if (Input.GetKeyUp(KeyCode.Joystick8Button15))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button15);
        }
        if (Input.GetKeyUp(KeyCode.Joystick8Button16))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button16);
        }
        if (Input.GetKeyUp(KeyCode.Joystick8Button17))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button17);
        }
        if (Input.GetKeyUp(KeyCode.Joystick8Button18))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button18);
        }
        if (Input.GetKeyUp(KeyCode.Joystick8Button19))
        {
            BindableControls.BindingDown(KeyCode.Joystick8Button19);
        }

        #endregion KeyUp
    }
}