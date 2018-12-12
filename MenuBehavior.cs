using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehavior : MonoBehaviour {

    public void triggerMenuBehavior(int i) {
        switch (i) {
            default:
            //Start button    
            case(0):
                SceneManager.LoadScene("Level1");
                break;
            //Quit game
            case(1):
                Application.Quit();
                break;
        }
    }

}
