using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    int currentLevel;
    void Start()
    {
        if (PlayerPrefs.HasKey("Level"))
        {
            currentLevel = PlayerPrefs.GetInt("Level");
        }
        else
        {
            currentLevel = 1;
            PlayerPrefs.SetInt("Level", currentLevel);
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.transform != null && int.Parse(hit.transform.name) >= currentLevel)
                {
                    SceneManager.LoadScene(int.Parse(hit.transform.name));
                }
            }
        }
    }
}
