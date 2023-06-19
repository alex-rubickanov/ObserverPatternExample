using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceScript : MonoBehaviour, IObserver
{
    private AudioSource audioSource;
    [SerializeField] AudioClip redColor;
    [SerializeField] AudioClip greenColor;
    [SerializeField] AudioClip blueColor;
    [SerializeField] AudioClip orangeColor;
    [SerializeField] AudioClip yellowColor;
    private Player playerScript;

    private void Awake()
    {
        audioSource= GetComponent<AudioSource>();
        playerScript = GetComponentInParent<Player>();
    }

    public void OnNotify(PlayerColor color)
    {
        switch (color) {
            case PlayerColor.Red:
                audioSource.PlayOneShot(redColor, 1);
                break;
            case PlayerColor.Green:
                audioSource.PlayOneShot(greenColor, 1);
                break;
            case PlayerColor.Blue:
                audioSource.PlayOneShot(blueColor, 1);
                break;
            case PlayerColor.Orange:
                audioSource.PlayOneShot(orangeColor, 1);
                break;
            case PlayerColor.Yellow:
                audioSource.PlayOneShot(yellowColor, 1);
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
