using System.Collections.Generic;
using UnityEngine;

public static class BindableControls
{
    /// <summary>
    /// The bindings
    /// <para>NOT SORTED</para>
    /// </summary>
    private static List<KeyValuePair<KeyCode?, KeyFunction>> bindings = new List<KeyValuePair<KeyCode?, KeyFunction>>();

    /// <summary>
    /// The function delegate that the keys will bind to
    /// </summary>
    public delegate void KeyFunction();

    /// <summary>
    /// Access control for the bindings
    /// </summary>
    public static List<KeyValuePair<KeyCode?, KeyFunction>> Bindings
    {
        get
        {
            return bindings;
        }

        private set
        {
            bindings = value;
        }
    }

    /// <summary>
    /// Add a binding with no Key assigned
    /// </summary>
    /// <param name="function"></param>
    /// <returns></returns>
    public static bool AddBinding(KeyFunction function)
    {
        return AddBinding(null, function);
    }

    /// <summary>
    /// Add a binding with both a key and a function
    /// </summary>
    /// <param name="Key"></param>
    /// <param name="function"></param>
    /// <returns>Returns false if a duplicate binding is found</returns>
    public static bool AddBinding(KeyCode? Key, KeyFunction function)
    {
        if (Bindings.Contains(new KeyValuePair<KeyCode?, KeyFunction>(Key, function)))
        {
            return false;
        }
        Bindings.Add(new KeyValuePair<KeyCode?, KeyFunction>(Key, function));
        return true;
    }

    /// <summary>
    /// Called on the first frame that a key is pressed
    /// </summary>
    /// <param name="key"></param>
    public static void BindingDown(KeyCode key)
    {
        KeyFunction[] functions = GetBoundFunctions(key);
        foreach (KeyFunction function in functions)
        {
            if (function != null)
            {
                function.Invoke();
            }
        }
    }

    /// <summary>
    /// Called when a key is released
    /// </summary>
    /// <param name="key"></param>
    public static void BindingUp(KeyCode key)
    {
        KeyFunction[] functions = GetBoundFunctions(key);
        foreach (KeyFunction function in functions)
        {
            if (function != null)
            {
                function.Invoke();
            }
        }
    }

    /// <summary>
    /// Gets a Binding's index by the function bound
    /// </summary>
    /// <param name="function"></param>
    /// <returns>Returns -1 if no binding exists for the given function</returns>
    public static int[] GetBindingIndexs(KeyFunction function)
    {
        List<int> ints = new List<int>();
        int i = 0;
        foreach (KeyValuePair<KeyCode?, KeyFunction> Binding in Bindings)
        {
            if (Binding.Value == function)
            {
                ints.Add(i);
            }
            i++;
        }
        Debug.LogWarning("Attempted to get the index of a binding that does not exist");
        return ints.ToArray();
    }

    /// <summary>
    /// Gets first available function bound to the given key
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public static KeyFunction GetBoundFunction(KeyCode? key)
    {
        foreach (KeyValuePair<KeyCode?, KeyFunction> Binding in Bindings)
        {
            if (Binding.Key == key)
            {
                return Binding.Value;
            }
        }
        return null;
    }

    /// <summary>
    /// Gets the functions bound to a key
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public static KeyFunction[] GetBoundFunctions(KeyCode key)
    {
        List<KeyFunction> Functions = new List<KeyFunction>();
        foreach (KeyValuePair<KeyCode?, KeyFunction> Binding in Bindings)
        {
            if (Binding.Key == key)
            {
                Functions.Add(Binding.Value);
            }
        }
        return Functions.ToArray();
    }

    /// <summary>
    /// Called when a key is being pressed, and every frame it is held down
    /// </summary>
    /// <param name="key"></param>
    private static void Binding(KeyCode key)
    {
        KeyFunction[] functions = GetBoundFunctions(key);
        foreach (KeyFunction function in functions)
        {
            if (function != null)
            {
                function.Invoke();
            }
        }
    }

    /// <summary>
    /// Gets a Binding's index by the key bound
    /// </summary>
    /// <param name="Key"></param>
    /// <returns>Returns -1 if no binding exists for the given key</returns>
    private static int[] GetBindingIndexes(KeyCode Key)
    {
        List<int> ints = new List<int>();
        int i = 0;
        foreach (KeyValuePair<KeyCode?, KeyFunction> Binding in Bindings)
        {
            if (Binding.Key == Key)
            {
                ints.Add(i);
            }
            i++;
        }
        Debug.LogWarning("Attempted to get the index of a binding that does not exist");
        return ints.ToArray();
    }
}