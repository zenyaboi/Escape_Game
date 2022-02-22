using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void Start() {
        UnlockMouse();
    }
    
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "PlayerDeath")
        {
            SceneManager.LoadScene(3);
        }
    }

    void UnlockMouse()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
