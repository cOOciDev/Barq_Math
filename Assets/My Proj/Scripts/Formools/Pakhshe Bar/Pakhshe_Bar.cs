using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Pakhshe_Bar : MonoBehaviour
{
    public VideoClip Pakhsh_Bar_Video;

    Video_CTRL V_CTRL;



    #region  // Formool Variables //......................

    public InputField P_Value_Inp;
    public InputField Q_Value_Inp;
    public InputField V_Value_Inp;
    public InputField I_Value_Inp;
    public InputField Y_Value_Inp;
    public InputField Θ_Value_Inp;
    public InputField n_Value_Inp;
    public InputField k_Value_Inp;
    public InputField δ_i_Value_Inp;
    public InputField δ_k_Value_Inp;


    public Text V_Value_Depends_txt;
    public Text n_Value_Depends_txt;
    public Text k_Value_Depends_txt;

    #endregion


    void Start()
    {
        if(GameObject.FindGameObjectWithTag("Meno ctrl") != null)
		{
			V_CTRL = GameObject.FindGameObjectWithTag("Meno ctrl").GetComponent<Video_CTRL>();
		}
    }

    
    void Update()
    {

        //check to fill in the depends in Formools UI ....
        if(string.IsNullOrEmpty(n_Value_Inp.text))
        {
            n_Value_Depends_txt.text = "n";
        }
        else
        {
            n_Value_Depends_txt.text = n_Value_Inp.text;
        }

        if(string.IsNullOrEmpty(k_Value_Inp.text))
        {
            k_Value_Depends_txt.text = "1";
        }
        else
        {
            k_Value_Depends_txt.text = k_Value_Inp.text;
        }

        if(string.IsNullOrEmpty(V_Value_Inp.text))
        {
            V_Value_Depends_txt.text = "V";
        }
        else
        {
            V_Value_Depends_txt.text = V_Value_Inp.text;
        }


        // check for computing method ....
        if(string.IsNullOrEmpty(P_Value_Inp.text))
        {

        }
    }

    public void get_video_Ready()
    {
        V_CTRL.set_the_video_clip(Pakhsh_Bar_Video);
    }




    public void computing_P_i_index()
    {

    }
}
