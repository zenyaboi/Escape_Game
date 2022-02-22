using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGame : MonoBehaviour
{
    void Start() {
        UnlockMouse();
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Reach")
        {
            SceneManager.LoadScene(2);
        }
    }

    void UnlockMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
