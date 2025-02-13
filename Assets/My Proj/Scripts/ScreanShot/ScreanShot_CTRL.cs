using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class ScreanShot_CTRL : MonoBehaviour
{

    public string File_Path;
    public string File_Name;
    DirectoryInfo Di_i;
    public GameObject Canvas;

    int i;

    void Start()
    {
        File_Name = "ScreanShot 000" ; // 11 char
        File_Path = Application.persistentDataPath + "/ScreanShots/";
        Di_i = Directory.CreateDirectory(File_Path);

        




        print("...................................");
        print(Application.persistentDataPath);
        print("...................................");
    }

    void Update()
    {
        
    }

    public void ScreanShot_Button()
    {
        

        string Name_F;
        Name_F = File_Name.Remove(0, 11);
        i = int.Parse(Name_F);
        i++;
        File_Name = "ScreanShots " + i.ToString();

        string path = Path.Combine(Di_i.FullName, File_Name + ".png");
        ScreenCapture.CaptureScreenshot(path);
    }
}

