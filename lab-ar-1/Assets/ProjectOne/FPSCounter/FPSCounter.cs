using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSCounter : MonoBehaviour {

    public float frameRate;
    public float window;
    public Text text;

	void Update () {
        frameRate += ((1 / Time.deltaTime) - frameRate) * (1f / window);
        text.text = Mathf.Round(frameRate).ToString();

        if (frameRate < 20) text.color = Color.red;
        else if (frameRate < 25) text.color = Color.yellow;
        else text.color = Color.green;
	}
}
