using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (RawImage))]
public class RenderTextureReset : MonoBehaviour
{
    private RenderTexture renderTexture;

    private void Awake()
    {
        renderTexture = (RenderTexture)GetComponent<RawImage>().texture;
    }

    public void ClearOutRenderTexture()
    {
        RenderTexture rt = RenderTexture.active;
        RenderTexture.active = renderTexture;
        GL.Clear(true, true, Color.clear);
        RenderTexture.active = rt;
    }

    private void OnDisable()
    {
        ClearOutRenderTexture();
    }
}
