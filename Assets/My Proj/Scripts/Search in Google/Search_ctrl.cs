using System.Collections;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Search_ctrl : MonoBehaviour
{
    Meno_CTRL M_C;
    public InputField Search_Input;

    string Site_Name;

    void Start()
    {
        M_C = GameObject.FindGameObjectWithTag("Meno ctrl").GetComponent<Meno_CTRL>();
    }

    public void Search_BTN()
    {
        if(Search_Input.text != null)
        {
            Site_Name = Search_Input.text;


            Application.OpenURL($"https://www.google.com/search?q={Site_Name}");
        }
        else
        {
            print("injaye karim");
        }
        
    }

    public void close_Search()
    {
        M_C.Close_Page(3);
    }
}
