using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Formool_Test : MonoBehaviour
{

    public float f_z, f_x, f_y , f_a, f_b, f_c;
    public Text z, x, y , a, b, c;

    public bool IsNull_z, IsNull_x, IsNull_y, IsNull_a, IsNull_b, IsNull_c;

    public Text Answer_Label, Answer_Value;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void set_Floats()
    {
        if(IsNull_z == false)
        {
            f_z = (float) Convert.ToByte(z.text);
        }
        
        if(IsNull_x == false)
        {
            f_x = (float) Convert.ToByte(x.text);
        }
        
        if(IsNull_y == false)
        {
            f_y = (float) Convert.ToByte(y.text);
        }
        
        if(IsNull_a == false)
        {
            f_a = (float) Convert.ToByte(a.text);
        }

        if(IsNull_b == false)
        {
            f_b = (float) Convert.ToByte(b.text);
        }

        if(IsNull_c == false)
        {
            f_c = (float) Convert.ToByte(c.text);  
        }
        
        
    }

    public void Check_IsNull()
    {
        if(z.text == "z")
        {
            IsNull_z = true;
        }
        else
        {
            IsNull_z = false;
        }

        if(x.text == "x")
        {
            IsNull_x = true;
        }
        else
        {
            IsNull_x = false;
        }

        if(y.text == "y")
        {
            IsNull_y = true;
        }
        else
        {
            IsNull_y = false;
        }

        if(a.text == "a")
        {
            IsNull_a = true;
        }
        else
        {
            IsNull_a = false;
        }

        if(b.text == "b")
        {
            IsNull_b = true;
        }
        else
        {
            IsNull_b = false;
        }

        if(c.text == "c")
        {
            IsNull_c = true;
        }
        else
        {
            IsNull_c = false;
        }

    }


    public void Mohasebe_Btn()
    {
        Check_IsNull();
        set_Floats();

        if(IsNull_z)
        {
            f_z = (((f_x + f_y)*f_c)/(f_a * f_b));

            Answer_Label.text = "Z";
            Answer_Value.text = f_z.ToString();    
        }
        else if(IsNull_x)
        {
            f_x = (( (f_a * f_b * f_z) / (f_c) ) - f_y);

            Answer_Label.text = "X";
            Answer_Value.text = f_x.ToString(); 
            
        }
        else if(IsNull_y)
        {
            f_y = (( (f_a * f_b * f_z) / (f_c) ) - f_x);

            Answer_Label.text = "Y";
            Answer_Value.text = f_y.ToString(); 
        }
        else if(IsNull_a)
        {
            f_a = (((f_x + f_y)*f_c)/(f_z * f_b));

            Answer_Label.text = "A";
            Answer_Value.text = f_a.ToString(); 
        }
        else if(IsNull_b)
        {
            f_b = (((f_x + f_y)*f_c)/(f_z * f_a));

            Answer_Label.text = "B";
            Answer_Value.text = f_b.ToString(); 
        }
        else if(IsNull_c)
        {
            f_c = (( (f_a * f_b * f_z) / (f_y + f_x) ));

            Answer_Label.text = "C";
            Answer_Value.text = f_c.ToString(); 
        }
        else{
            print("do majhooooli ?!!");
        }

    }

    
}
