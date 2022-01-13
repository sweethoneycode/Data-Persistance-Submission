using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    private AudioSource menuAudio;

    // Start is called before the first frame update
    void Start()
    {
        menuAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound()
    {
        menuAudio.Play();
        SceneManager.LoadScene("Main");
    }

    public void Exit()
    {
        #if UNITY_EDITOR
                EditorApplication.ExitPlaymode();
        #else
                Application.Quit(); // original code to quit Unity player
        #endif
    }
    
}
