﻿using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {
    [InlineEditor()]public Controls controls;

    void Start() {
        if (!controls)
            controls = Resources.Load<Controls>("DefaultControls");
    }

    public void UpdateControlMethod(Slider slider) {
        controls.inputMethod = (Controls.InputMethod) slider.value;
    }
}