using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SpaceScene()
    {
        SceneManager.LoadScene("Gameplay Scene (Space Level)");
    }

    public void PlatformScene()
    {
        SceneManager.LoadScene("Gameplay Scene (Platform)");
    }

    public void GroundScene()
    {
        SceneManager.LoadScene("Gameplay Scene (Ground Level)");
    }
}



