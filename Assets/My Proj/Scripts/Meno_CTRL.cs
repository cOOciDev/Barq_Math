using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Meno_CTRL : MonoBehaviour
{
	//Special Pages ...
    public GameObject welcome_Page, Chose_Dars_Page, Chose_Fasl_Page , chose_Language_Page , Watch_Page;
    public GameObject Search_Formool_Page, Formool_Page;


	

    // Fasl haye Dars Yek ...
	public GameObject Bas_PQ_PV_Slack_Page, Pakhsh_Bar_Page, Ravesh_Goos_Saydel_Page,
	 ravesh_Nioton_Rafson_Page, Check_for_short_circuit_errors_Page, Asymmetric_short_circuit_Page,Singlephase_short_circuit_calculation_page;

	

	// Fasl haye Dars Do ...
	public GameObject Parametrs_Page, Mohasebe_Roshanayi_Page, Barresi_Simha_Page, Barresi_Hefazat_Page, Tashih_Zarib_Page;
	
	public GameObject Parametr_Label, Mohasebe_Roshanayi_Label, Barresi_Simha_Label, Barresi_Hefazat_Label, Tashih_Zarib_Label;


	public GameObject sarfasl_Dars_Yek_Label, sarfasl_Dars_Do_Label;



	public GameObject Fasl_Yek_Scroll_Aria , Fasl_Do_Scroll_Aria;

	
	public GameObject PQ_PV_Slack_Label, Pakhsh_Bar_Label, Gos_Saydel_Label,
	 Nioton_Rafson_Label, Check_for_short_circuit_errors_Label, Asymmetric_short_circuit_Label, Singlephase_short_circuit_calculation_Label ;


	// Language controller
	public Language_CTRL L_C;

	
    // Video Player Controller
	Video_CTRL V_CTRL;
	public int Video_Key;

	//.............Formools Scripts...

	public PQ_Bus PQ_B;
	public PV_Bus PV_B;
	public Slack_Bus Slack_B;
	public Pakhshe_Bar P_Bar;
	public Gos_Saydel Gos_Say;
	public Nioton_Rafson Nioton_Raf;
	public B_Khataha B_khata_ha;
	public A_kootah A_kootah;
	public M_Etesal M_etesal;
	

	public Parameters_CTRL Parameters;
	public Mohasebe_Roshanayi M_Roshanayi;
	public Barresi_SimHa B_SimHa;
	public Barresi_Hefazat B_Hefazat;
	public Tashih_Zarib_Qodrat T_ZaribQodrat;

	//......................................................................................................................................................................//
    void Start()
    {
		Close_All_Pages();

        Open_Page(0);
        
        Invoke("Close_Wel_Page", 3f);
        
        if(GameObject.FindGameObjectWithTag("Meno ctrl") != null)
		{
			L_C = GameObject.FindGameObjectWithTag("Meno ctrl").GetComponent<Language_CTRL>();
		}

		if(GameObject.FindGameObjectWithTag("Meno ctrl") != null)
		{
			V_CTRL = GameObject.FindGameObjectWithTag("Meno ctrl").GetComponent<Video_CTRL>();
		}
    }

	public void Close_Wel_Page()
	{
		Close_Page(0);
		Open_Page(1);
	}

    void Update()
    {
        
    }

    //...........................................................................................//

 #region    //.....................close and open Pages.......................
    public void Close_Page(int Key)
    {
        if(Key == 0)                    // key 0 = welcom page
        {
            welcome_Page.SetActive(false);
        }
        else if(Key == 1)                    // key 1 = Dars page
        {
            Chose_Dars_Page.SetActive(false);
        }
        else if(Key == 2)                    // key 2 = fasl page
        {
            Chose_Fasl_Page.SetActive(false);
        }
        else if(Key == 3)                    // key 3 = Search formool page
        {
            Search_Formool_Page.SetActive(false);
        }
        else if(Key == 4)                    // key 4 = formool page
        {
            Formool_Page.SetActive(false);
        }
		else if(Key == 5)                    // key 5 = Language page
        {
            chose_Language_Page.SetActive(false);
        }
		else if(Key == 6)                    // key 6 = Watch page
        {
            Watch_Page.SetActive(false);
        }
		else if(Key == 7)                    // key 7 = Bas PQ page
        {
            Bas_PQ_PV_Slack_Page.SetActive(false);
        }
		else if(Key == 8)                    // key 8 = Pakhshe Bar Page
        {
            Pakhsh_Bar_Page.SetActive(false);
        }
		else if(Key == 9)                    // key 9 = Raveshe Goos Saydel Page
        {
            Ravesh_Goos_Saydel_Page.SetActive(false);
        }
		else if(Key == 10)                    // key 10 = raveshe Nioton Rafson Page
        {
            ravesh_Nioton_Rafson_Page.SetActive(false);
        }
		else if(Key == 11)                    // key 11 = Check_for_short_circuit_errors Page
        {
            Check_for_short_circuit_errors_Page.SetActive(false);
        }
		else if(Key == 12)                    // key 12 = Asymmetric_short_circuit Page
        {
            Asymmetric_short_circuit_Page.SetActive(false);
        }
		else if(Key == 13)                    // key 13 = Singlephase_short_circuit_calculation page
        {
            Singlephase_short_circuit_calculation_page.SetActive(false);
        }
        else
        {
            Debug.Log(" There is Nothing to Do ");
        }
    }

    public void Open_Page(int Key)
    {
        if(Key == 0)                    // key 0 = welcom page
        {
            welcome_Page.SetActive(true);
        }
        else if(Key == 1)                    // key 1 = Dars page
        {
            Chose_Dars_Page.SetActive(true);
        }
        else if(Key == 2)                    // key 2 = fasl page
        {
            Chose_Fasl_Page.SetActive(true);
        }
        else if(Key == 3)                    // key 3 = Search formool page
        {
            Search_Formool_Page.SetActive(true);
        }
        else if(Key == 4)                    // key 4 = Test formool page
        {
            Formool_Page.SetActive(true);
        }
		else if(Key == 5)                    // key 5 = Language page
        {
            chose_Language_Page.SetActive(true);
        }
		else if(Key == 6)                    // key 6 = Watch page
        {
            Watch_Page.SetActive(true);
        }
		else if(Key == 7)                    // key 7 = Bas PQ_PV_Slack page
        {
            Bas_PQ_PV_Slack_Page.SetActive(true);
        }
		else if(Key == 8)                    // key 8 = Pakhshe Bar Page
        {
            Pakhsh_Bar_Page.SetActive(true);
        }
		else if(Key == 9)                    // key 9 = Raveshe Goos Saydel Page
        {
            Ravesh_Goos_Saydel_Page.SetActive(true);
        }
		else if(Key == 10)                    // key 10 = raveshe Nioton Rafson Page
        {
            ravesh_Nioton_Rafson_Page.SetActive(true);
        }
		else if(Key == 11)                    // key 11 = Check_for_short_circuit_errors Page
        {
            Check_for_short_circuit_errors_Page.SetActive(true);
        }
		else if(Key == 12)                    // key 12 = Asymmetric_short_circuit Page
        {
            Asymmetric_short_circuit_Page.SetActive(true);
        }
		else if(Key == 13)                    // key 13 = Singlephase_short_circuit_calculation page
        {
            Singlephase_short_circuit_calculation_page.SetActive(true);
        }
        else
        {
            Debug.Log(" There is Nothing to Do ");
        }






        
    }

	public void Close_All_Pages()
	{
		for(int i = 0; i < 14; i++) 
		{
			Close_Page(i);	
		}
	}

#endregion  
	
	//...........................................................................................//

#region //.........................Change Langouage Method.....................


	
	public void Select_LANGOUAGE_BTN()
	{
		Open_Page(5);
	}

	public void Close_Language_page_BTN()
	{
		Close_Page(5);
	}

	public void Farsi_BTN()
    {
		L_C.Farsi();

		Close_Language_page_BTN();
	}

	public void English_BTN()
	{
		L_C.English();

		Close_Language_page_BTN();
	}

#endregion
    
	//...........................................................................................//
    
#region //.........................Select Dars Page Methodes...................	
	public void Tahlil_SystemHaye_Energy_Electriki_2_BTN()
	{
		Close_Dars_Open_Fasl();
		sarfasl_Dars_Yek_Label.SetActive(true);
		sarfasl_Dars_Do_Label.SetActive(false);

		Fasl_Yek_Scroll_Aria.SetActive(true);
		Fasl_Do_Scroll_Aria.SetActive(false);


	}

	public void Tasisat_Elektriki_BTN()
	{
		Close_Dars_Open_Fasl();
		sarfasl_Dars_Do_Label.SetActive(true);
		sarfasl_Dars_Yek_Label.SetActive(false);

		Fasl_Do_Scroll_Aria.SetActive(true);
		Fasl_Yek_Scroll_Aria.SetActive(false);

	}

	public void Close_Dars_Open_Fasl()
	{
		Close_Page(1);
		Open_Page(2);
		
	}
	
	public void Back_To_Select_Dars()
	{
		sarfasl_Dars_Yek_Label.SetActive(false);
		sarfasl_Dars_Do_Label.SetActive(false);

		Fasl_Yek_Scroll_Aria.SetActive(false);
		Fasl_Do_Scroll_Aria.SetActive(false);

		Open_Page(1);
		Close_Page(2);


	}
#endregion
    // ..........................................................................................//

#region //.........................Select Fasl Page Methodes........( Dars 1 )...........
	public void Bas_PQ_PV_Slack_BTN()
	{
		Close_FaslHa_Open_Formool();

		PQ_PV_Slack_Label.SetActive(true);
		Open_Page(7);

		Video_Key = 1;
	}

	public void Pakhsh_Bar_BTN()
	{
		Close_FaslHa_Open_Formool();

		Pakhsh_Bar_Label.SetActive(true);
		Open_Page(8);

		Video_Key = 2;
	}

	public void Gos_Saydel_BTN()
	{
		Close_FaslHa_Open_Formool();

		Gos_Saydel_Label.SetActive(true);
		Open_Page(9);

		Video_Key = 3;
	}

	public void Nioton_Rafson_BTN()
	{
		Close_FaslHa_Open_Formool();

		Nioton_Rafson_Label.SetActive(true);
		Open_Page(10);

		Video_Key = 4;
	}

	public void Check_for_short_circuit_errors_BTN()
	{
		Close_FaslHa_Open_Formool();

		Check_for_short_circuit_errors_Label.SetActive(true);
		Open_Page(11);

		Video_Key = 5;
	}

	
	public void Asymmetric_short_circuit_BTN()
	{
		Close_FaslHa_Open_Formool();

		Asymmetric_short_circuit_Label.SetActive(true);
		Open_Page(12);

		Video_Key = 6;
	}

	public void Singlephase_short_circuit_calculation_BTN()
	{
		Close_FaslHa_Open_Formool();

		Singlephase_short_circuit_calculation_Label.SetActive(true);
		Open_Page(13);

		Video_Key = 7;
	}
	


#endregion

#region //.........................Select Fasl Page Methodes........( Dars 2 )...........

	public void parametrhaye_manabe_BTN()
	{
		Close_FaslHa_Open_Formool();

		Parametrs_Page.SetActive(true);
		Parametr_Label.SetActive(true);

		Video_Key = 11;
	}

	public void mohasebe_roshanayi_BTN()
	{
		Close_FaslHa_Open_Formool();

		Mohasebe_Roshanayi_Page.SetActive(true);
		Mohasebe_Roshanayi_Label.SetActive(true);

		Video_Key = 12;
	}

	public void barresi_simha_BTN()
	{
		Close_FaslHa_Open_Formool();

		Barresi_Simha_Page.SetActive(true);
		Barresi_Simha_Label.SetActive(true);

		Video_Key = 13;
	}

	public void barresi_hefazat_tasisat_BTN()
	{
		Close_FaslHa_Open_Formool();

		Barresi_Hefazat_Page.SetActive(true);
		Barresi_Hefazat_Label.SetActive(true);

		Video_Key = 14;
	}

	public void tashih_zarib_qodrat_BTN()
	{
		Close_FaslHa_Open_Formool();

		Tashih_Zarib_Page.SetActive(true);
		Tashih_Zarib_Label.SetActive(true);

		Video_Key = 15;
	}

#endregion

#region //.........................Select Fasl Page Methodes........( Moshtrak ).........
	public void Close_FaslHa_Open_Formool()
	{
		Open_Page(4);
		Close_Page(2);
	}

	public void Back_To_Select_Fasl_BTN()
	{
		PQ_PV_Slack_Label.SetActive(false);
		Pakhsh_Bar_Label.SetActive(false);
		Gos_Saydel_Label.SetActive(false);
		Nioton_Rafson_Label.SetActive(false);
		Check_for_short_circuit_errors_Label.SetActive(false);
		Asymmetric_short_circuit_Label.SetActive(false);
		Singlephase_short_circuit_calculation_Label.SetActive(false);

		Bas_PQ_PV_Slack_Page.SetActive(false);
		Pakhsh_Bar_Page.SetActive(false);
		Ravesh_Goos_Saydel_Page.SetActive(false);
		ravesh_Nioton_Rafson_Page.SetActive(false);
		Check_for_short_circuit_errors_Page.SetActive(false);
		Asymmetric_short_circuit_Page.SetActive(false);
		Singlephase_short_circuit_calculation_page.SetActive(false);


		Parametr_Label.SetActive(false);
		Mohasebe_Roshanayi_Label.SetActive(false);
		Barresi_Simha_Label.SetActive(false);
		Barresi_Hefazat_Label.SetActive(false);
		Tashih_Zarib_Label.SetActive(false);
		
		Parametrs_Page.SetActive(false);
		Mohasebe_Roshanayi_Page.SetActive(false);
		Barresi_Simha_Page.SetActive(false);
		Barresi_Hefazat_Page.SetActive(false);
		Tashih_Zarib_Page.SetActive(false);


		Open_Page(2);
		Close_Page(4);

		Video_Key = 0;
	}

#endregion
	
	//..........................................................................................//
	// back to select dars for video 
	public void back_to_select_videoye_Dars()
	{
		V_CTRL.Stop_Video();
		
		Close_Page(6);
	}

	public void open_Watch_Page_BTN()
	{
		Open_Page(6);

		if(Video_Key == 1)
		{
			PQ_B.get_video_Ready();
			L_C.set_V_Tittle_To__PQ_PV_Slack();
		}
		else if(Video_Key == 2)
		{
			P_Bar.get_video_Ready();
			L_C.set_V_Tittle_To__Pakhsh_Bar();
		}
		else if(Video_Key == 3)
		{
			Gos_Say.get_video_Ready();
			L_C.set_V_Tittle_To__Gos_Saydel();
		}
		else if(Video_Key == 4)
		{
			Nioton_Raf.get_video_Ready();
			L_C.set_V_Tittle_To__Nioton_Rafson();
		}
		else if(Video_Key == 5)
		{
			B_khata_ha.get_video_Ready();
			L_C.set_V_Tittle_To__Bast_Teylor();
		}
		else if(Video_Key == 6)
		{
			A_kootah.get_video_Ready();
			L_C.set_V_Tittle_To__Zhakoobin_Matrix();
		}
		else if(Video_Key == 7)
		{
			M_etesal.get_video_Ready();
			L_C.set_V_Tittle_To__Parameters();
		}
		else
		{
			Debug.Log("There is Noting To Do ...!");
		}
		
	}

	public void Search_Page_BTN()
    {
        Open_Page(3);
    }

	

}

