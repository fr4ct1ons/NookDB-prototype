using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetResolution : MonoBehaviour
{
    [SerializeField] private string screenshotName;

    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(540, 960, FullScreenMode.Windowed);
    }

    [ContextMenu("Take screenshot")]
    public void TakeScreenshot()
    {
        ScreenCapture.CaptureScreenshot(screenshotName + ".png");
    }
}
