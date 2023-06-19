using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour, IObserver
{
    Subject playerScript;
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        playerScript = GetComponentInParent<Subject>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void OnNotify(PlayerColor color)
    {
        switch (color) {
            case PlayerColor.Red:
                spriteRenderer.color = Color.red;
                break;
            case PlayerColor.Green:
                spriteRenderer.color = Color.green;
                break;
            case PlayerColor.Blue:
                spriteRenderer.color = Color.blue;
                break;
            case PlayerColor.Orange:
                spriteRenderer.color = new Color32(255, 133, 0, 255);
                break;
            case PlayerColor.Yellow:
                spriteRenderer.color = Color.yellow;
                break;

        }
    }

    private void OnEnable()
    {
        playerScript.AddObserver(this);
    }

    private void OnDisable()
    {
        playerScript.RemoveObserver(this);
    }
}
