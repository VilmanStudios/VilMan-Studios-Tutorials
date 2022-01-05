using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject Game;
    public GameObject Settings;
    public GameObject Menu2;
    public GameObject Menu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        Game.SetActive(true);
        Menu.SetActive(false);
    }

    public void SettingsOn()
    {
        Settings.SetActive(true);
        Menu2.SetActive(false);
    }

    public void SettingsOff()
    {
        Settings.SetActive(false);
        Menu2.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
