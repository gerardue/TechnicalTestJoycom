﻿using UnityEngine;

public class KeyboardInputControl : MonoBehaviour
{
    public string Horizontal = "Horizontal";
    public string Vertical = "Vertical";

    public Vector2 CreatingInput()
    {
        return new Vector2
        {
            x = Input.GetAxis(Horizontal),
            y = Input.GetAxis(Vertical)
        };
    }
}
