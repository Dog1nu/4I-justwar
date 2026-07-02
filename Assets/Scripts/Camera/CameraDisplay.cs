using UnityEngine;
using UnityEngine.UI;

public class CameraDisplay : MonoBehaviour
{
    // RawImageをここにドラッグ＆ドロップします
    public RawImage display;

    void Start()
    {
        // 1. PCに繋がっているカメラデバイスのリストを取得
        WebCamDevice[] devices = WebCamTexture.devices;
        if (devices.Length == 0)
        {
            Debug.LogError("カメラが見つかりません！");
            return;
        }

        // 2. 最初のカメラ（通常は内蔵カメラ）を起動
        WebCamTexture camTexture = new WebCamTexture(devices[0].name);

        // 3. RawImageにカメラ映像をセット
        display.texture = camTexture;

        // 4. 再生開始
        camTexture.Play();
    }
}