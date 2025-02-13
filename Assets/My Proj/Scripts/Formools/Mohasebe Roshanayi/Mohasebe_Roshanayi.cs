using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Mohasebe_Roshanayi : MonoBehaviour
{
    Video_CTRL V_CTRL;

    public VideoClip Mohasebe_Roshanayi_Video;


    void Start()
    {
        if(GameObject.FindGameObjectWithTag("Meno ctrl") != null)
		{
			V_CTRL = GameObject.FindGameObjectWithTag("Meno ctrl").GetComponent<Video_CTRL>();
		}

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void get_video_Ready()
    {
        V_CTRL.set_the_video_clip(Mohasebe_Roshanayi_Video);
    }
}
