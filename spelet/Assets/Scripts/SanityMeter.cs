using Completed;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SanityMeter : MonoBehaviour
{
    public GUIStyle empty;
    public GUIStyle full;

    public float curSanity;

    Vector2 pos = new Vector2(10, 50);
    Vector2 size = new Vector2(250, 50);

    public Texture2D emptyTexture;
    public Texture2D fullTexture;

    private void OnGUI()
    {
        GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y), emptyTexture, empty);

        GUI.Box(new Rect(0, 0, size.x, size.y), fullTexture, full);

        GUI.BeginGroup(new Rect(pos.x, pos.y, size.x * curSanity, size.y));
        GUI.Box(new Rect(0, 0, size.x, size.y), fullTexture, full);

        GUI.EndGroup();
        GUI.EndGroup();
    }


    // Update is called once per frame
    void Update()
    {
        curSanity = Player.curSanity/Player.maxSanity;
    }
}
