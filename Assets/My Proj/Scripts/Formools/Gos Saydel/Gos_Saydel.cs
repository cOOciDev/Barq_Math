using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Gos_Saydel : MonoBehaviour
{
    public VideoClip Gos_Saydel_Video;

    Video_CTRL V_CTRL;

    void Start()
    {
        if(GameObject.FindGameObjectWithTag("Meno ctrl") != null)
		{
			V_CTRL = GameObject.FindGameObjectWithTag("Meno ctrl").GetComponent<Video_CTRL>();
		}
    }

 
    void Update()
    {
        
    }

    public void get_video_Ready()
    {
        V_CTRL.set_the_video_clip(Gos_Saydel_Video);
    }
}
