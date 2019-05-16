using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    bool called = false;
    private AudioSource[] allAudioSources;
    bool pause = false;

    void Update()
    {
        //始めるときミュージックスタート
        if (PlayerPrefs.GetInt("Start") == 1 && !called)
        {
            GetComponent<AudioSource>().Play();
            called = true;
        }
        //ミュージックポーズ
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            if (pause == false&&Input.GetKeyDown(KeyCode.Escape))
            {
                audioS.Pause();
                pause = true;
                Time.timeScale = 0f;

            }
            else if (pause == true && Input.GetKeyDown(KeyCode.Escape))
            {
                audioS.UnPause();
                pause = false;
                Time.timeScale = 1f;

            }

        }

    }
}
