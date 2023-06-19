using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Subject
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            NotifyObservers(PlayerColor.Red);
        } else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            NotifyObservers(PlayerColor.Green);
        } else if (Input.GetKeyDown(KeyCode.Alpha3)) {
            NotifyObservers(PlayerColor.Blue);
        } else if (Input.GetKeyDown(KeyCode.Alpha4)) {
            NotifyObservers(PlayerColor.Orange);
        } else if (Input.GetKeyDown(KeyCode.Alpha5)) {
            NotifyObservers(PlayerColor.Yellow);
        }
    }
}
