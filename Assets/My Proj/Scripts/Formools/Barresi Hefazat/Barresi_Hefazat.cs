using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Barresi_Hefazat : MonoBehaviour
{
    Video_CTRL V_CTRL;

    Language_CTRL L_CTRL;

    public VideoClip Barresi_Hefazat_Video;


    void Start()
    {
        if(GameObject.FindGameObjectWithTag("Meno ctrl") != null)
		{
			V_CTRL = GameObject.FindGameObjectWithTag("Meno ctrl").GetComponent<Video_CTRL>();
		}

        if(GameObject.FindGameObjectWithTag("Meno ctrl") != null)
		{
			L_CTRL = GameObject.FindGameObjectWithTag("Meno ctrl").GetComponent<Language_CTRL>();
		}
    }

    void Update()
    {
        
    }

    public void get_video_Ready()
    {
        V_CTRL.set_the_video_clip(Barresi_Hefazat_Video);
        V_CTRL.video_BG_Text_txt.text = L_CTRL.video_BG_Text_txt.text;
    }
}
