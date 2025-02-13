using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Video;
using UnityEngine.UI;

public class Video_CTRL : MonoBehaviour, IDragHandler, IPointerDownHandler
{
    [SerializeField]
    public Slider Volume_SL ; 

    public GameObject Pause_icon , Play_icon;
    bool play_or_pause; // play = true 

    public Image progress;

    VideoClip _video;


    VideoPlayer VP;

    public RawImage Video_Texture;
    public Text video_BG_Text_txt;


    void Start()
    {
        VP = GameObject.FindGameObjectWithTag("video_player").GetComponent<VideoPlayer>();
        play_or_pause = false;
    }

    void Update()
    {
        VP.SetDirectAudioVolume(0 , Volume_SL.value);

        if(VP.frameCount > 0)
        {
            progress.fillAmount = (float)VP.frame / (float)VP.frameCount;
        }

        if(_video == null)
        {
            Video_Texture.enabled = false;
        }
        else
        {
            Video_Texture.enabled = true;
        }
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        TrySkip(eventData);
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        TrySkip(eventData);
    }

    private void TrySkip(PointerEventData eventData)
    {
        Vector2 localpoint;
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(progress.rectTransform, eventData.position, null, out localpoint))
        {
            float Pct = Mathf.InverseLerp(progress.rectTransform.rect.xMin, progress.rectTransform.rect.xMax, localpoint.x);
            SkipToPercent(Pct);
        }
    }   

    private void SkipToPercent(float pct)
    {
        var frame = VP.frameCount*pct;
        VP.frame = (long)frame;
    }

    public void Pause_Video_BTN()
    {
        Play_icon.SetActive(true);
        Pause_icon.SetActive(false);

        VP.Pause();
    }

    public void Play_Video_BTN()
    {
        Play_icon.SetActive(false);
        Pause_icon.SetActive(true);

        VP.Play();


    }

    public void Play_and_Pause()
    {
        play_or_pause = !play_or_pause;

        if(play_or_pause == true)
        {
            Play_Video_BTN();
        }
        else
        {
            Pause_Video_BTN();
        }
    }

    public void Stop_Video()
    {
        Pause_Video_BTN();
        VP.Stop();
        _video = null;
    }

    public void set_the_video_clip(VideoClip film)
    {
        _video = film;
        VP.clip = _video ;
    }
}
