using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class Language_CTRL : MonoBehaviour
{
    public Font farsi_font , english_font ;

    // Language Variables ...
    public bool is_English;
	bool Language_Changed;
    private int E_or_P;

    string En_mohasebat_Title = "Calculations";
    string Fa_mohasebat_Title = Fa.faConvert("محاسبات");


    #region // UI Elements ...
    public Text Wellcome_txt;

    public Text rahnma_txt, dars_label_txt, dars_yek_label_txt, dars_do_label_txt, language_btn_label_txt;

    public Text Language_Guide_txt, farsi_btn_txt;

    public Text Sarfasl_dars_label_txt, Sarfasl_dars_yek_label_txt, Sarfasl_dars_do_label_txt, Guide_txt;

    public Text D1_f1, D1_f4, D1_f5, D1_f6, D1_f7, D1_f8, D1_f9;
    public Text S_D1_f1, S_D1_f4, S_D1_f5, S_D1_f6, S_D1_f7, S_D1_f8, S_D1_f9;

    public Text D2_f1, D2_f2, D2_f3, D2_f4, D2_f5;
    public Text S_D2_f1, S_D2_f2, S_D2_f3, S_D2_f4, S_D2_f5;

    public Text[] watch_video_BTN_txt;

    public Text[] Mohasebe_Buttons;

    public Text Go_Search_txt, Search_Guid_lbl_txt, Search_Guid_lbl_notif;
    

    public Text Video_Tittle;

    public Text Teacher_Label, Teacher_Name_txt;

    public Text video_BG_Text_txt;
    #endregion

    #region // ............... Content Texts ...................

        // dars 1
        public Text PQ_EXPLANE, PQ_Title;
        public Text PV_EXPLANE, PV_Title;
        public Text Slack_EXPLANE, Slack_Title;
        public Text Pakhsh_Bar_EXPLANE, Pakhsh_Bar_Title, Pakhsh_Bar_Formool_Title;
        public Text pakhsh_V_Value_Know, pakhsh_P_Value_Know, pakhsh_Q_Value_Know, pakhsh_I_Value_Know, pakhsh_Y_Value_Know;
        
        public Text Gos_Saydel_EXPLANE, Gos_Saydel_Title;
        public Text Gos_V_Value_Know, Gos_P_Value_Know, Gos_Q_Value_Know, Gos_I_Value_Know, Gos_Y_Value_Know,  Gos_A_Value_Know, Gos_majmoo_Value_Know;



        public Text Nioton_Raphson_EXPLANE, Nioton_Raphson_Title;
        public Text Nioton_Az_pish_text, Nioton_Mohasebe_Text;
        //public Text newton_newton_V_Value_Know, newton_newton_P_Value_Know, newton_newton_Q_Value_Know, newton_newton_I_Value_Know, newton_newton_Y_Value_Know;
        //public Text Bast_newton_V_Value_Know, Bast_newton_P_Value_Know, Bast_newton_Q_Value_Know, Bast_newton_I_Value_Know, Bast_newton_Y_Value_Know;
        //public Text Matris_newton_V_Value_Know, Matris_newton_P_Value_Know, Matris_newton_Q_Value_Know, Matris_newton_I_Value_Know, Matris_newton_Y_Value_Know;


        


        public Text Bast_Teylor_EXPLANE, Bast_Teylor_Title;
        public Text bast_in_Formool_txt;

        public Text Zhakoobin_Matris_EXPLANE, Zhakoobin_Matris_Title;



        public Text Check_for_short_circuit_errors_EXPLANE, Check_for_short_circuit_errors_Title; 
        public Text Asymmetric_short_circuit_EXPLANE, Asymmetric_short_circuit_Title; 
        public Text Singlephase_short_circuit_calculation_EXPLANE, Singlephase_short_circuit_calculation_Title;


        // Dars 2

        public Text Parametrs_EXPLANE, Parametrs_Title; 
        public Text teori_zareyi_EXPLANE, teori_zareyi_Title;
        public Text teori_moji_EXPLANE, teori_moji_Title;
        public Text teori_elektro_meqnatisi_EXPLANE, teori_elektro_meqnatisi_Title;
        public Text teori_koantomi_EXPLANE, teori_koantomi_Title;
        public Text shedat_noor_EXPLANE, shedat_noor_Title;
        public Text zaviye_fazayi_EXPLANE, zaviye_fazayi_Title;
        public Text monhani_pakhsh_EXPLANE, monhani_pakhsh_Title;
        public Text trakom_noor_EXPLANE, trakom_noor_Title;
        public Text shedat_roshanayi_EXPLANE, shedat_roshanayi_Title;


        //

        public Text mohasebat_roshanayi_Title;
        public Text formool_01_Value_E_Title, formool_01_Value_Φ_Title, formool_01_Value_A_Title;
        public Text formool_02_Value_Φ_Title, formool_02_Value_Φt_Title, formool_02_Value_n_Title;
        public Text formool_03_Value_LLf_Title, formool_03_Value_Φt_Title, formool_03_Value_cu_Title, formool_03_Value_E_Title, formool_03_Value_A_Title;

        public Text nokat_roshanayi_Title, nokat_roshanayi_EXPLANE;
        public Text nokat_priz_Title, nokat_priz_EXPLANE;


        //


        public Text Sath_maqta_Sim_Title;
        public Text namgozari_Sim_Title;

        public Text msrhale_01_Title, msrhale_02_Title, msrhale_03_Title, msrhale_04_Title, msrhale_05_Title;

        public Text _01_NA_EXP, _01_N_EXP;
        public Text _02_G_EXP, _02_Y_EXP;
        public Text _03_K_EXP, _03_Y_EXP, _03_AL_EXP;
        public Text _04_GB_EXP, _04_B_EXP;
        public Text _05_Y_EXP;



        public Text m_dar_Takfaz_Title, m_dar_Sefaz_Title;


        //


        public Text oyoob_dar_t_Title, oyoob_dar_t_EXPLANE;

        public Text eyb_01_Title, eyb_01_EXPLANE;
        public Text eyb_02_Title, eyb_02_EXPLANE;
        public Text eyb_03_Title, eyb_03_EXPLANE;
        public Text eyb_04_Title, eyb_04_EXPLANE;

        //


        public Text tashih_zarib_qodrat_Title, tashih_zarib_qodrat_Explane;
        




    #endregion

    
    void Start()
    {
        // Set language Persion OR English From Last Changes
        if (PlayerPrefs.GetInt("E_or_P") == 1)
		{
			is_English = true;
		}
		else if (PlayerPrefs.GetInt("E_or_P") == 2)
		{
			is_English = false;
		}

        farsi_btn_txt.text = Fa.faConvert("فارسی");

        
    }

    void Update()
    {
        if (is_English == true )
        {
			if(Language_Changed == false)
			{
				Set_Language(1);
			}
		}
        else
        {
			if(Language_Changed == false)
			{
				Set_Language(2);
			}

		}
    }



    public void Set_Language(int Key)
    {
		if (Key == 1)       //  English  ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		{
            #region English Meno
            Wellcome_txt.lineSpacing = 1;
            Wellcome_txt.font = farsi_font;
            Wellcome_txt.text = "Welcome to the World of Awareness";
            rahnma_txt.lineSpacing = 1;
            rahnma_txt.text = "You can use the available lessons to learn and remember.";
			dars_label_txt.text = "lessons";
            dars_yek_label_txt.text = "Analysis of electrical energy systems 2";
            dars_do_label_txt.text = "Electrical Installations";
            language_btn_label_txt.font = farsi_font;
            language_btn_label_txt.text = "Language";

            Language_Guide_txt.text = "Select Your Language";

            Sarfasl_dars_label_txt.text = "lesson";
            Sarfasl_dars_yek_label_txt.text = "Analysis of electrical energy systems 2";
            Sarfasl_dars_do_label_txt.text = "Electrical Installations";
            Guide_txt.lineSpacing = 1;
            Guide_txt.text = "By selecting each section, you can access its content";
            
            D1_f1.text = "PQ, PV, Slack Bus";
            D1_f4.text = "Load Spread";
            D1_f5.text = "Gauss Seidel Method";
            D1_f6.text = "Newton-Raphson Method";
            D1_f7.text = "Check for short circuit errors";
            D1_f8.text = "Asymmetric short circuit";
            D1_f9.text = "Single phase short circuit calculation";

            S_D1_f1.text = "PQ, PV, Slack Bus";
            S_D1_f4.text = "Load Spread";
            S_D1_f5.text = "Gauss Seidel Method";
            S_D1_f6.text = "Newton-Raphson Method";
            S_D1_f7.text = "Check for short circuit errors";
            S_D1_f8.text = "Asymmetric short circuit";
            S_D1_f9.text = "Singlephase short circuit calculation";

            D2_f1.text = "Parameters of Light Sources";
            D2_f2.text = "Calculation of Brightness";
            D2_f3.text = "Check Wires and Cables";
            D2_f4.text = "Inspection of Facility Protection and Safety";
            D2_f5.text = "Power Factor Correction";

            S_D2_f1.text = "Parameters of Light Sources";
            S_D2_f2.text = "Calculation of Brightness";
            S_D2_f3.text = "Check Wires and Cables";
            S_D2_f4.text = "Inspection of Facility Protection and Safety";
            S_D2_f5.text = "Power Factor Correction";

            Go_Search_txt.text = "Lets Know";
            Search_Guid_lbl_txt.text = "Search your Question ... ;)";
            Search_Guid_lbl_notif.text = "Searching in Farsi language is currently not possible.";
            

            Teacher_Label.text = "Teacher";
            Teacher_Name_txt.text = "Dr. Asadollah Kazemi";

            foreach(var item in Mohasebe_Buttons)
            {
                item.text = "";
            }

            foreach(var item in watch_video_BTN_txt)
            {
                item.text = "Tranning Video";
            }

            video_BG_Text_txt.text ="Video is Not Available";
            

			Language_Changed = true;
            #endregion
            
            Debug.Log(" Language :     English .");
            
            #region //.............................................content...................................

            PQ_EXPLANE.alignment = TextAnchor.MiddleLeft;
            PQ_EXPLANE.lineSpacing = 1f;
            PQ_Title.text = " Load Bus";
            PQ_EXPLANE.text = " When the bus is PQ, it means that in the equation, active and passive powers or pis are specified, but the voltage and angle are unknown.";

            PV_EXPLANE.alignment = TextAnchor.MiddleLeft;
            PV_EXPLANE.lineSpacing = 1f;
            PV_Title.text = "Controll Bus";
            PV_EXPLANE.text = "When the bus is PV, it means that the reactive power and angle are unknown, but P and Q are related to the load and the voltage and P of the generator are also known.";

            Slack_EXPLANE.alignment = TextAnchor.MiddleLeft;
            Slack_EXPLANE.lineSpacing = 1f;
            Slack_Title.text = "Slack ";
            Slack_EXPLANE.text = "There is a bass that must be one of the basses in the power network, and it is usually number one. And also the angle, which is usually zero, and the current voltage is known, but the power of the generator and QJ is unknown.";

            Pakhsh_Bar_EXPLANE.alignment = TextAnchor.MiddleLeft;
            Pakhsh_Bar_EXPLANE.lineSpacing = 1f;
            Pakhsh_Bar_Formool_Title.text = En_mohasebat_Title;
            Pakhsh_Bar_Title.text = "Load Flow";
            Pakhsh_Bar_EXPLANE.text = "Calculations that happen in a short period of time so that in the event of a failure in the network, the stored data from the calculations will help us in diagnosing the problem and calculations, and by diagnosing the situation and processing, if necessary, disconnect a part from the circuit so that the network continues to work. to continue";

            pakhsh_V_Value_Know.text = "Voltage";
            pakhsh_P_Value_Know.text = "active power"; 
            pakhsh_Q_Value_Know.text = "reactive power"; 
            pakhsh_I_Value_Know.text = "current"; 
            pakhsh_Y_Value_Know.text = "admittance";



            


            Gos_Saydel_EXPLANE.alignment = TextAnchor.MiddleLeft;
            Gos_Saydel_EXPLANE.lineSpacing = 1f;
            Gos_Saydel_Title.text = "Gauss Seidel method";
            Gos_Saydel_EXPLANE.text = "It is the way that we check the calculations and the results of the calculations in the previous steps used in the next steps and calculations.";

            Gos_V_Value_Know.text = "Voltage";
            Gos_P_Value_Know.text = "active power"; 
            Gos_Q_Value_Know.text = "reactive power"; 
            Gos_I_Value_Know.text = "current"; 
            Gos_Y_Value_Know.text = "admittance";
            Gos_A_Value_Know.text = "...";
            Gos_majmoo_Value_Know.text = "The amount of accuracy of calculations";



            Nioton_Raphson_EXPLANE.alignment = TextAnchor.MiddleLeft;
            Nioton_Raphson_EXPLANE.lineSpacing = 1f;
            Nioton_Raphson_Title.text = "Newton-Raphson method";
            Nioton_Raphson_EXPLANE.text = "This method is one of the methods of solving linear equations that converges faster than Gauss-Seidel's method, and its difference in Newton-Raphson's method compared to Gauss-Seidel's is the large volume that Newton-Raphson's method can have in computer programs.";

            Nioton_Az_pish_text.text = "Predetermined";
            Nioton_Mohasebe_Text.text = "Calculated";

            // newton_newton_V_Value_Know.text = "";
            // newton_newton_P_Value_Know.text = "";
            // newton_newton_Q_Value_Know.text = "";
            // newton_newton_I_Value_Know.text = "";
            // newton_newton_Y_Value_Know.text = "";
            
            // Bast_newton_V_Value_Know.text = "";
            // Bast_newton_P_Value_Know.text = "";
            // Bast_newton_Q_Value_Know.text = "";
            // Bast_newton_I_Value_Know.text = "";
            // Bast_newton_Y_Value_Know.text = "";

            // Matris_newton_V_Value_Know.text = "";
            // Matris_newton_P_Value_Know.text = "";
            // Matris_newton_Q_Value_Know.text = "";
            // Matris_newton_I_Value_Know.text = "";
            // Matris_newton_Y_Value_Know.text = "";




            Bast_Teylor_EXPLANE.alignment = TextAnchor.MiddleLeft;
            Bast_Teylor_EXPLANE.lineSpacing = 1f;
            Bast_Teylor_Title.text = "Taylor expansion";
            Bast_Teylor_EXPLANE.text = "";
            bast_in_Formool_txt.text = "For higher derivatives";

            Zhakoobin_Matris_EXPLANE.alignment = TextAnchor.MiddleLeft;
            Zhakoobin_Matris_EXPLANE.lineSpacing = 1f;
            Zhakoobin_Matris_Title.text = "Jacobian matrix";
            Zhakoobin_Matris_EXPLANE.text = "";

            //................dars 2 .............................

            Parametrs_EXPLANE.alignment = TextAnchor.MiddleLeft;
            Parametrs_EXPLANE.lineSpacing = 1f;
            Parametrs_Title.text = "Lighting";
            Parametrs_EXPLANE.text = "Illumination is the radiation energy evaluated by the eye, which is analyzed based on four theories, light particle theory, light wave theory, electromagnetic theory and quantum theory.";

            teori_zareyi_EXPLANE.alignment = TextAnchor.MiddleLeft;
            teori_zareyi_EXPLANE.lineSpacing = 1f;
            teori_zareyi_Title.text = "Particle theory of light";
            teori_zareyi_EXPLANE.text = "This theory of Newton's acceleration has been proposed and evaluated based on the following three situations:  \x0A \x0A  A luminous body emits radiant energy in the form of particles. \x0A \x0A  These particles follow a straight line. \x0A \x0A  These particles affect the retina of the eye and stimulate the optic nerves and light is felt.";

            teori_moji_EXPLANE.alignment = TextAnchor.MiddleLeft;
            teori_moji_EXPLANE.lineSpacing = 1f;
            teori_moji_Title.text = "Wave theory of light";
            teori_moji_EXPLANE.text = "This theory was proposed by Huggins and has been analyzed based on the following:  \x0A \x0A  Luminous objects appear as waves in the form of molecular vibrations in the light source.  \x0A \x0A  These vibrations spread as waves in the environment.  \x0A \x0A  These vibrations affect the retina of the eye and stimulate the optic nerves and light is felt.";

            teori_elektro_meqnatisi_EXPLANE.alignment = TextAnchor.MiddleLeft;
            teori_elektro_meqnatisi_EXPLANE.lineSpacing = 1f;
            teori_elektro_meqnatisi_Title.text = "Electromagnetic theory";
            teori_elektro_meqnatisi_EXPLANE.text = "This theory was first proposed by Maxwell and analyzed based on the following principles:  \x0A \x0A  Luminous objects radiate light as energy.  \x0A \x0A  This radiant energy is electromagnetic.  \x0A \x0A  Electromagnetic waves affect the retina of the eye and stimulate the optic nerves and light is felt.";
            
            teori_koantomi_EXPLANE.alignment = TextAnchor.MiddleLeft;
            teori_koantomi_EXPLANE.lineSpacing = 1f;
            teori_koantomi_Title.text = "Quantum theory";
            teori_koantomi_EXPLANE.text = "This theory was proposed by Planck and other people and analyzed based on the following principles: \x0A \x0A  Light energy is emitted and absorbed in the form of particles called photons.\x0A \x0A  The energy of each photon is obtained from the relation W = h.V.";

            
            
            shedat_noor_EXPLANE.alignment = TextAnchor.MiddleLeft;
            shedat_noor_EXPLANE.lineSpacing = 1f;
            shedat_noor_Title.text = "light intensity";
            shedat_noor_EXPLANE.text = "The ratio of optical flux to the value of spatial angle is called.";
            
            
            zaviye_fazayi_EXPLANE.alignment = TextAnchor.MiddleLeft;
            zaviye_fazayi_EXPLANE.lineSpacing = 1f;
            zaviye_fazayi_Title.text = "Space angle";
            zaviye_fazayi_EXPLANE.text = "Consider a sphere of unit radius, a spatial angle whose vertex is in the center separates a surface from this sphere, the numerical size of this surface is equal to the angular size of Omega.";

            monhani_pakhsh_EXPLANE.alignment = TextAnchor.MiddleLeft;
            monhani_pakhsh_EXPLANE.lineSpacing = 1f;
            monhani_pakhsh_Title.text = "Light diffusion curve";
            monhani_pakhsh_EXPLANE.text = "When we draw the light intensity ratio of different distances in terms of degrees in a polar diagram on the surface passing through the light source, a curve is obtained, which is called the light diffusion or brightness curve.";

            trakom_noor_EXPLANE.alignment = TextAnchor.MiddleLeft;
            trakom_noor_EXPLANE.lineSpacing = 1f;
            trakom_noor_Title.text = "light density";
            trakom_noor_EXPLANE.text = "According to the definition, the ratio of light intensity to the illuminated surface is called light density or luminance and is represented by L.";

            shedat_roshanayi_EXPLANE.alignment = TextAnchor.MiddleLeft;
            shedat_roshanayi_EXPLANE.lineSpacing = 1f;
            shedat_roshanayi_Title.text = "Brightness";
            shedat_roshanayi_EXPLANE.text = "According to the definitions, it is the ratio of light flux to the desired surface and is represented by E.";
            
            

            //

            mohasebat_roshanayi_Title.text = "Calculation of interior lighting";


            formool_01_Value_A_Title.text = "clip surface";
            formool_01_Value_E_Title.text = "Brightness";
            formool_01_Value_Φ_Title.text =  "The total luminous flux required";

            formool_02_Value_Φt_Title.text = "The total luminous flux required";
            formool_02_Value_n_Title.text = "number of lights";
            formool_02_Value_Φ_Title.text = "The luminous flux of each lamp";

            formool_03_Value_Φt_Title.text = "The total luminous flux required";
            formool_03_Value_LLf_Title.text = "optical loss coefficient";
            formool_03_Value_A_Title.text = "clip surface";
            formool_03_Value_E_Title.text = "Brightness";
            formool_03_Value_cu_Title.text = "Interest rate";

            nokat_roshanayi_EXPLANE.alignment = TextAnchor.MiddleLeft;
            nokat_roshanayi_EXPLANE.lineSpacing = 1f;
            nokat_roshanayi_Title.text = "Important points in lighting";
            nokat_roshanayi_EXPLANE.text = "A maximum of 12 lamps should be placed in the lighting path. \x0A  10A switch from group B must be used for lighting lines. \x0A  At least the lighting wire should be 1.5 mm. \x0A  There must be 3 wires in the places where the chandelier is placed. \x0A  All communication should be done by contact or terminal.";

            nokat_priz_EXPLANE.alignment = TextAnchor.MiddleLeft;
            nokat_priz_EXPLANE.lineSpacing = 1f;
            nokat_priz_Title.text = "Important points in sockets";
            nokat_priz_EXPLANE.text = "A maximum of 12 sockets should be placed in the path of the outlet. \x0A  At least the lighting wire should be 2.5 mm. \x0A  All sockets must be three-wire. \x0A  The miniature switch used in sockets should be 16A and be of type B or C.";
            


            //

            
            Sath_maqta_Sim_Title.text = "Cross section of wires";
            

            namgozari_Sim_Title.text = "How to name cables";


            msrhale_01_Title.text = "First letter = conductor type indicator";
            _01_NA_EXP.text = "aluminium";
            _01_N_EXP.text = "copper";

            msrhale_02_Title.text = "The second letter = indicates the insulation of the wires";
            _02_G_EXP.text = "rubber";
            _02_Y_EXP.text = "Plastic";

            msrhale_03_Title.text = "The third letter = indicates the type of sheath";
            _03_K_EXP.text = "Lead";
            _03_Y_EXP.text = "Plastic";
            _03_AL_EXP.text = "aluminium";

            msrhale_04_Title.text = "Fourth letter = armor type indicator";
            _04_GB_EXP.text = "Galvanized Steel";
            _04_B_EXP.text = "Steel";

            msrhale_05_Title.text = "The fifth letter = external insulation type indicator";
            _05_Y_EXP.text = "Plastic";


            m_dar_Takfaz_Title.text = "Calculation of cross section in single phase system";
            m_dar_Sefaz_Title.text = "Calculation of cross section in three phase system";


            //



            oyoob_dar_t_EXPLANE.alignment = TextAnchor.MiddleLeft;
            oyoob_dar_t_EXPLANE.lineSpacing = 1f;
            oyoob_dar_t_Title.text = "Defects in electrical installations";
            oyoob_dar_t_EXPLANE.text = "Among the types of defects in electrical installations, we can mention insulation defects, excessive current passing, grounding defects and connection to the body.";

            eyb_01_EXPLANE.alignment = TextAnchor.MiddleLeft;
            eyb_01_EXPLANE.lineSpacing = 1f;
            eyb_01_Title.text = "Insulation defect";
            eyb_01_EXPLANE.text = "It is said to be a defect that due to physical factors or any other factors, the insulating coating of cables and wires is damaged and the current conductor is exposed.";
            
            eyb_02_EXPLANE.alignment = TextAnchor.MiddleLeft;
            eyb_02_EXPLANE.lineSpacing = 1f;
            eyb_02_Title.text = "Grounding fault";
            eyb_02_EXPLANE.text = "Whenever a cable with potential is damaged and broken due to various factors, and due to the impact of the cable with the ground, it will cause a spark and cut off the flow path by the protective switch, but if the situation progresses in such a way that the leakage current passes through the cable to the ground, the place It will be hot and cause a fire.";
            
            eyb_03_EXPLANE.alignment = TextAnchor.MiddleLeft;
            eyb_03_EXPLANE.lineSpacing = 1f;
            eyb_03_Title.text = "High current flow";
            eyb_03_EXPLANE.text = "This defect includes two modes of overload and short circuit.";
            
            eyb_04_EXPLANE.alignment = TextAnchor.MiddleLeft;
            eyb_04_EXPLANE.lineSpacing = 1f;
            eyb_04_Title.text = "Connecting to the body";
            eyb_04_EXPLANE.text = "Whenever the electric current hits a part of the body of the system or device.";


            //


            tashih_zarib_qodrat_Explane.alignment = TextAnchor.MiddleLeft;
            tashih_zarib_qodrat_Explane.lineSpacing = 1f;
            tashih_zarib_qodrat_Title.text = "Power factor correction";
            tashih_zarib_qodrat_Explane.text = "In general, there are loads in the form of selfie and ohmic loads as consumers in the network and electrical installations, so this causes it to receive some reactive power in addition to the active power of the network, this causes the power factor of the network circuit to decrease and on the contrary Demand more current from the network, this will increase energy supply sources. The losses of the network have increased and the equipment in turn has become large and involves a lot of cost. In order to reduce the above costs, capacitor banks are usually used in the industry. Solvent banks supply a large part of the reactive power and it is prevented from drawing extra current from the network.";




            



            #endregion   //.......................................................................................
	    
        }
		if (Key == 2)       // Persion //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		{
            #region Farsi Meno
			Wellcome_txt.lineSpacing = -1.1f;
            Wellcome_txt.font = english_font;
            Wellcome_txt.text =Fa.faConvert ("به دنیای آگاهی خوش آمدید");

            rahnma_txt.lineSpacing = -1.1f;
			rahnma_txt.text = Fa.faConvert("شما می‌توانید از دروس موجود برای یادگیری و یادآوری استفاده کنید.");
			dars_label_txt.text = Fa.faConvert("دروس");
            dars_yek_label_txt.text = Fa.faConvert("تحلیل سیستم های انرژی الکتریکی 2");
            dars_do_label_txt.text = Fa.faConvert("روشنایی و تاسیسات الکتریکی");
            language_btn_label_txt.font = english_font;
            language_btn_label_txt.text = Fa.faConvert("زبان");

            Language_Guide_txt.text = Fa.faConvert("زبان خود راانتخاب کنید");

            Sarfasl_dars_label_txt.text = Fa.faConvert("درس");
            Sarfasl_dars_yek_label_txt.text = Fa.faConvert("تحلیل سیستم های انرژی الکتریکی 2");
            Sarfasl_dars_do_label_txt.text = Fa.faConvert("روشنایی و تاسیسات الکتریکی");
            Guide_txt.lineSpacing = -1.1f;
            Guide_txt.text = Fa.faConvert("با انتخاب هر بخش به محتوای آن دسترسی پیدا میکنید");

            D1_f1.text = Fa.faConvert("باس PQ, PV, Slack");
            D1_f4.text = Fa.faConvert("پخش بار");
            D1_f5.text = Fa.faConvert("روش گوس سایدل");
            D1_f6.text = Fa.faConvert("روش نیوتون رافسون");
            D1_f7.text = Fa.faConvert("بررسی خطا های اتصال کوتاه");
            D1_f8.text = Fa.faConvert("اتصال کوتاه نامتقارن");
            D1_f9.text = Fa.faConvert("محاسبه اتصال کوتاه تک فاز");

            S_D1_f1.text = Fa.faConvert("باس PQ, PV, Slack");
            S_D1_f4.text = Fa.faConvert("پخش بار");
            S_D1_f5.text = Fa.faConvert("روش گوس سایدل");
            S_D1_f6.text = Fa.faConvert("روش نیوتون رافسون");
            S_D1_f7.text = Fa.faConvert("بررسی خطا های اتصال کوتاه");
            S_D1_f8.text = Fa.faConvert("اتصال کوتاه نامتقارن");
            S_D1_f9.text = Fa.faConvert("محاسبه اتصال کوتاه تک فاز");

            D2_f1.text = Fa.faConvert("پارامترهای منابع نوری");
            D2_f2.text = Fa.faConvert("محاسبه روشنایی");
            D2_f3.text = Fa.faConvert("بررسی سیم ها و کابل ها");
            D2_f4.text = Fa.faConvert("بررسی حفاظت تاسیسات و ایمنی");
            D2_f5.text = Fa.faConvert("تصحیح ضریب قدرت");

            S_D2_f1.text = Fa.faConvert("پارامترهای منابع نوری");
            S_D2_f2.text = Fa.faConvert("محاسبه روشنایی");
            S_D2_f3.text = Fa.faConvert("بررسی سیم ها و کابل ها");
            S_D2_f4.text = Fa.faConvert("بررسی حفاظت تاسیسات و ایمنی");
            S_D2_f5.text = Fa.faConvert("تصحیح ضریب قدرت");

            Go_Search_txt.text = Fa.faConvert("جستجو کن");
            Search_Guid_lbl_txt.text =  Fa.faConvert(" :) سوال خود را بپرسید ... ");
            Search_Guid_lbl_notif.text = Fa.faConvert("جستجو به زبان فارسی فعلا امکان پذیز نمیباشد.");

            


            Teacher_Label.text = Fa.faConvert("مدرس :");
            Teacher_Name_txt.text = Fa.faConvert("دکتر اسدلله کاظمی");

            foreach(var item in Mohasebe_Buttons)
            {
                item.text = Fa.faConvert("محاسبه");
            }

            foreach(var item in watch_video_BTN_txt)
            {
                item.text = Fa.faConvert("ویدئوی آموزشی");
            }

            video_BG_Text_txt.text = Fa.faConvert("هنوز ویدئویی موجود نیست");

            

			Language_Changed = true;
            #endregion

            Debug.Log(" Language :     Persian ."); 

            #region //.............................................content...................................

            PQ_EXPLANE.alignment = TextAnchor.MiddleRight;
            PQ_EXPLANE.lineSpacing = -1f;
            PQ_Title.text = Fa.faConvert("باس بار ");
            PQ_EXPLANE.text = Fa.faConvert(" زمانی که باسPQ است به این معنیست که در معادله پی ها یا توان های اکتیو و دی اکتیو مشخصه ولی ولتاژ و زاویه مجهول میباشد .");

            PV_EXPLANE.alignment = TextAnchor.MiddleRight;
            PV_EXPLANE.lineSpacing = -1f;
            PV_Title.text = Fa.faConvert("باس کنترل");
            PV_EXPLANE.text = Fa.faConvert(" زمانی که باسPV است به این معنیست که توان دی اکتیو و زاویه مجهول ولی پی و کیو مربوط به بار و اندازه ولتاژ و پی ژنراتور نیز معلوم میباشند .");

            Slack_EXPLANE.alignment = TextAnchor.MiddleRight;
            Slack_EXPLANE.lineSpacing = -1f;
            Slack_Title.text = Fa.faConvert(" باس اصلی )مادر(");
            Slack_EXPLANE.text = Fa.faConvert(" باسی هست که در شبکه قدرت حتما یکی از باس ها باس اسلک میباشد و معمولا شماره یک است . و همچنین زاویه که معمولا صفر است و ولتاژ جریان معوم ولی توان ژنراتور و کیوی جیش مجهول میباشد. ");
            
            Pakhsh_Bar_EXPLANE.alignment = TextAnchor.MiddleRight;
            Pakhsh_Bar_EXPLANE.lineSpacing = -1f;
            Pakhsh_Bar_Formool_Title.text = Fa_mohasebat_Title;
            Pakhsh_Bar_Title.text = Fa.faConvert("پخش بار");
            Pakhsh_Bar_EXPLANE.text = Fa.faConvert(" محاسباتی که در بازه زمانی کوتاه اتفاق می افتد تا در صورت بروز خرابی در شبکه اصلاعات ذخیره شده از محاسبات در تشخیص مشکل و محاسبات به ما کمک کند و با تشخیص وضعیت و پردازش در صورت لازم بخشی رو از مدار جدا بکند تا شبکه همچنان به کار خود ادامه دهد. ");
            
            pakhsh_V_Value_Know.text = Fa.faConvert("ولتاژ");
            pakhsh_P_Value_Know.text = Fa.faConvert("توان اکتیو"); 
            pakhsh_Q_Value_Know.text = Fa.faConvert("توان راکتیو");
            pakhsh_I_Value_Know.text = Fa.faConvert("جریان");
            pakhsh_Y_Value_Know.text = Fa.faConvert("ادمیتانس");




            Gos_Saydel_EXPLANE.alignment = TextAnchor.MiddleRight;
            Gos_Saydel_EXPLANE.lineSpacing = -1f;
            Gos_Saydel_Title.text = Fa.faConvert("گوس سایدل");
            Gos_Saydel_EXPLANE.text = Fa.faConvert(" روشی است که ما محاسبات و نتایج محاسبات در مراحل قبل رو در مراحل و محاسبات بعدی استفاده شده و همچنین چک میکنیم.");

            Gos_V_Value_Know.text = Fa.faConvert("ولتاژ");
            Gos_P_Value_Know.text = Fa.faConvert("توان اکتیو"); 
            Gos_Q_Value_Know.text = Fa.faConvert("توان راکتیو");
            Gos_I_Value_Know.text = Fa.faConvert("جریان");
            Gos_Y_Value_Know.text = Fa.faConvert("ادمیتانس");
            Gos_A_Value_Know.text = Fa.faConvert("...");
            Gos_majmoo_Value_Know.text = Fa.faConvert("مقدار دقت محاسبات");



            
            Nioton_Raphson_EXPLANE.alignment = TextAnchor.MiddleRight;
            Nioton_Raphson_EXPLANE.lineSpacing = -1f;
            Nioton_Raphson_Title.text = Fa.faConvert("نیوتون رافسون");
            Nioton_Raphson_EXPLANE.text = Fa.faConvert("این روش یکی از روش های حل معادلات خطی بوده که نسبت به روش گوس سایدل سریع تر همگرا می شود و تفاوت آن در روش نیوتون رافسون نسبت به گوس سایدل حجم زیاد است که روش نیوتون رافسون می تواند در برنامه های کامپیوتری داشته باشد.");
            
            Nioton_Az_pish_text.text = Fa.faConvert("از پیش تعیین شده");
            Nioton_Mohasebe_Text.text = Fa.faConvert("محاسبه شده");

            // newton_newton_V_Value_Know.text = Fa.faConvert("");
            // newton_newton_P_Value_Know.text = Fa.faConvert("");
            // newton_newton_Q_Value_Know.text = Fa.faConvert("");
            // newton_newton_I_Value_Know.text = Fa.faConvert("");
            // newton_newton_Y_Value_Know.text = Fa.faConvert("");

            // Bast_newton_V_Value_Know.text = Fa.faConvert("");
            // Bast_newton_P_Value_Know.text = Fa.faConvert("");
            // Bast_newton_Q_Value_Know.text = Fa.faConvert("");
            // Bast_newton_I_Value_Know.text = Fa.faConvert("");
            // Bast_newton_Y_Value_Know.text = Fa.faConvert("");

            // Matris_newton_V_Value_Know.text = Fa.faConvert("");
            // Matris_newton_P_Value_Know.text = Fa.faConvert("");
            // Matris_newton_Q_Value_Know.text = Fa.faConvert("");
            // Matris_newton_I_Value_Know.text = Fa.faConvert("");
            // Matris_newton_Y_Value_Know.text = Fa.faConvert("");



            Bast_Teylor_EXPLANE.alignment = TextAnchor.MiddleRight;
            Bast_Teylor_EXPLANE.lineSpacing = -1f;
            Bast_Teylor_Title.text = Fa.faConvert("بسط تیلور");
            Bast_Teylor_EXPLANE.text = Fa.faConvert("");
            bast_in_Formool_txt.text = Fa.faConvert("برای مشتقات بالاتر");

            
            Zhakoobin_Matris_EXPLANE.alignment = TextAnchor.MiddleRight;
            Zhakoobin_Matris_EXPLANE.lineSpacing = -1f;
            Zhakoobin_Matris_Title.text = Fa.faConvert("ماتریس ژاکوبین");
            Zhakoobin_Matris_EXPLANE.text = Fa.faConvert("");
            
            
            // .......................dars 2 ......................

            Parametrs_EXPLANE.lineSpacing = -1f;
            Parametrs_EXPLANE.alignment = TextAnchor.MiddleRight;
            Parametrs_Title.text = Fa.faConvert("روشنایی");
            Parametrs_EXPLANE.text = Fa.faConvert("روشنایی عبارت است از انرژی تشعشعی ارزیابی شده توسط چشم که بر اساس چهار تئوری ، تئوری ذره‌ای نور ، تئوری موجی نور، تئوری الکترومغناطیسی و تئوری کوانتومی مورد بررسی قرار میگیرد.");

            teori_zareyi_EXPLANE.lineSpacing = -1f;
            teori_zareyi_EXPLANE.alignment = TextAnchor.MiddleRight;
            teori_zareyi_Title.text = Fa.faConvert("تئوری ذره‌ای نور ");
            teori_zareyi_EXPLANE.text = Fa.faConvert(" این ذرات بر شبکیه‌ی چشم اثر گذاشته و اعصاب بینایی را تحریک نموده و نور احساس می شود. \x0A \x0A  این ذرات به دنبال هم خط مستقیم را دنبال می کنند. \x0A \x0A  جسم نورانی انرژی تشعشعی را به صورت ذره ای از خود ساطع می کند. \x0A \x0A این تئوری تسط نیوتون مطرح و بر اساس سه حالت زیر ارزیابی شده است : ");
                                                    
            teori_moji_EXPLANE.lineSpacing = -1f;
            teori_moji_EXPLANE.alignment = TextAnchor.MiddleRight;
            teori_moji_Title.text = Fa.faConvert("تئوری موجی نور");
            teori_moji_EXPLANE.text = Fa.faConvert(" این ارتعاشات بر شبکیه‌ی چشم اثر گذاشته و اعصاب بینایی را تحریک نموده و نور احساس می شود. \x0A \x0A  این ارتعاشات به صورت موجی در محیط پخش میشود \x0A \x0A  اجسام نورانی به شکل موجی به صورت ارتعاش مولکولی در منبع نورانی ظاهر می شود. \x0A \x0A این تئوری توسط هوگینس مطرح گردید و بر اساس موارد زیر مورد تجزیه و تحلیل قرار گرفته است: ");

            teori_elektro_meqnatisi_EXPLANE.lineSpacing = -1f;
            teori_elektro_meqnatisi_EXPLANE.alignment = TextAnchor.MiddleRight;
            teori_elektro_meqnatisi_Title.text = Fa.faConvert("تئوری الکترومغناطیسی ");
            teori_elektro_meqnatisi_EXPLANE.text = Fa.faConvert(" امواج الکترومغناطیس بر شبکیه‌ی چشم اثر گذاشته و اعصاب بینایی را تحریک نموده و نور احساس می شود. \x0A \x0A  این انرژی تشعشعی به صورت الکترومغناطیسی می باشد. \x0A \x0A  اجسام نورانی از خود نور را به صورت انرژی تشعشع می کند. \x0A \x0A این تئوری اولین بار توسط ماکسول مطرح و بر اساس اصول زیر مورد تجزیه تحلیل قرار می گیرد :");
            
            teori_koantomi_EXPLANE.lineSpacing = -1f;
            teori_koantomi_EXPLANE.alignment = TextAnchor.MiddleRight;
            teori_koantomi_Title.text = Fa.faConvert("تئوری کوانتومی ");
            teori_koantomi_EXPLANE.text = Fa.faConvert(" انرژی هر فوتون از رابطه W = h.V به دست می آید.  \x0A \x0A  انرژی نورانی به صورت ذرات به نام فوتون ساطع و جذب می شود. \x0A \x0A این تئوری توسط پلانک و سایر افراد مطرح و بر اساس اصول زیر مورد تجزیه تحلیل قرار گرفته است: ");
            
            


            shedat_noor_EXPLANE.alignment = TextAnchor.MiddleRight;
            shedat_noor_EXPLANE.lineSpacing = -1f;
            shedat_noor_Title.text = Fa.faConvert("شدت نور ");
            shedat_noor_EXPLANE.text = Fa.faConvert("نسبت شار نوری به مقدار زاویه فضایی می گویند.");
            
            
            zaviye_fazayi_EXPLANE.alignment = TextAnchor.MiddleRight;
            zaviye_fazayi_EXPLANE.lineSpacing = -1f;
            zaviye_fazayi_Title.text = Fa.faConvert("زاویه فضایی ");
            zaviye_fazayi_EXPLANE.text = Fa.faConvert("کره ای به شعاع واحد در نظر بگیرید یک زاویه فضایی که راس آن در مرکز قرار داردسطحی از این کره را جدا می کند، اندازه عددی این سطح مساوی اندازه زاویه ای امگاست.");

            monhani_pakhsh_EXPLANE.alignment = TextAnchor.MiddleRight;
            monhani_pakhsh_EXPLANE.lineSpacing = -1f;
            monhani_pakhsh_Title.text = Fa.faConvert("منحنی پخش نور ");
            monhani_pakhsh_EXPLANE.text = Fa.faConvert("هرگاه در یک دیاگرام قطبی در سطح عبور کننده از منبع نور نسبت شدت نور فواصل مختلف بر حسب درجه را رسم نماییم منحنی بدست می آید که به آن منحنی پخش نور یا روشنایی می گویند.");

            trakom_noor_EXPLANE.alignment = TextAnchor.MiddleRight;
            trakom_noor_EXPLANE.lineSpacing = -1f;
            trakom_noor_Title.text = Fa.faConvert("تراکم نور ");
            trakom_noor_EXPLANE.text = Fa.faConvert("طبق تعریف نسبت شدت نور به سطح روشن شده را تراکم نور یا درخشندگی گویند و با L نمایش می دهند.");

            shedat_roshanayi_EXPLANE.alignment = TextAnchor.MiddleRight;
            shedat_roshanayi_EXPLANE.lineSpacing = -1f;
            shedat_roshanayi_Title.text = Fa.faConvert("شدت روشنایی ");
            shedat_roshanayi_EXPLANE.text = Fa.faConvert("بنا به تعاریف عبارت است از نسبت شار نوری به سطح مورد نظر و با E نمایش می دهند.");



            //


            mohasebat_roshanayi_Title.text = Fa.faConvert("محاسبه روشنایی داخلی");



            formool_01_Value_A_Title.text = Fa.faConvert("سطح");
            formool_01_Value_E_Title.text = Fa.faConvert("شدت روشنایی");
            formool_01_Value_Φ_Title.text = Fa.faConvert("کل شار نوری مورد نیاز");

            formool_02_Value_Φt_Title.text = Fa.faConvert("کل شار نوری مورد نیاز");
            formool_02_Value_n_Title.text = Fa.faConvert("تعداد چراغ");
            formool_02_Value_Φ_Title.text = Fa.faConvert("شار نوری هر چراق");

            formool_03_Value_Φt_Title.text = Fa.faConvert("کل شار نوری مورد نیاز");
            formool_03_Value_LLf_Title.text = Fa.faConvert("ضریب تلفات نوری");
            formool_03_Value_A_Title.text = Fa.faConvert("سطح");
            formool_03_Value_E_Title.text = Fa.faConvert("شدت روشنایی");
            formool_03_Value_cu_Title.text = Fa.faConvert("ضریب بهره");
            
            nokat_roshanayi_EXPLANE.alignment = TextAnchor.MiddleRight;
            nokat_roshanayi_EXPLANE.lineSpacing = 1f;
            nokat_roshanayi_Title.text = Fa.faConvert("نکات مهم در روشنایی ");
            nokat_roshanayi_EXPLANE.text = Fa.faConvert("در مسیر روشنایی حد اکثر 12 لامپ قرار داده شود. \x0A برای خطوط روشنایی حتما از کلید 10A از گروه B استفاده می شود. \x0A حد اقل سیم روشنایی می بایست 1.5 mm باشد. \x0A در جاهایی که لوستر قرار می گیرد حتما 3 سیمه باشد. \x0A تمامی ارتباطات باید توسط کنتاکت یا ترمینال انجام شود. ");

            nokat_priz_EXPLANE.alignment = TextAnchor.MiddleRight;
            nokat_priz_EXPLANE.lineSpacing = 1f;
            nokat_priz_Title.text = Fa.faConvert("نکات مهم در پریز ها ");
            nokat_priz_EXPLANE.text = Fa.faConvert("در مسیر پریز حد اکثر 12 پریز قرار داده شود\x0A . حد اقل سیم روشنایی می بایست 2.5 mm باشد. کلیه پریز ها باید سه سیمه باشند. کلید مینیاتوری مورد استفاده در پریز ها باید 16A باشد و از نوع B یا C باشد. ");
            




            //

            
            Sath_maqta_Sim_Title.text = Fa.faConvert("سطح مقطع سیم ها");
            

            namgozari_Sim_Title.text = Fa.faConvert("نحوه نام گذاری کابل ها");
            

            msrhale_01_Title.text = Fa.faConvert("اولین حرف = نشانگر نوع هادی");
            _01_NA_EXP.text = Fa.faConvert("آلمینیوم");
            _01_N_EXP.text = Fa.faConvert("مس");

            msrhale_02_Title.text = Fa.faConvert("دومین حرف = نشانگر عایق سیم ها");
            _02_G_EXP.text = Fa.faConvert("لاستیک");
            _02_Y_EXP.text = Fa.faConvert("پلاستیک");

            msrhale_03_Title.text = Fa.faConvert("سومین حرف = نشانگر نوع غلاف");
            _03_K_EXP.text = Fa.faConvert("سربی");
            _03_Y_EXP.text = Fa.faConvert("پلاستیک");
            _03_AL_EXP.text = Fa.faConvert("آلمینیوم");
            
            msrhale_04_Title.text = Fa.faConvert("چهارمین حرف = نشانگر نوع زره ");
            _04_GB_EXP.text = Fa.faConvert("فولاد گالوانیزه");
            _04_B_EXP.text = Fa.faConvert("فولاد");

            msrhale_05_Title.text = Fa.faConvert("پنجمین حرف = نشانگر عایق بیرونی");
            _05_Y_EXP.text = Fa.faConvert("پلاستیک");



            m_dar_Takfaz_Title.text = Fa.faConvert("محاسبه سطح مقطع در تک فاز");
            m_dar_Sefaz_Title.text = Fa.faConvert("محاسبه سطح مقطع در سیستم سه فاز");


            //


            oyoob_dar_t_EXPLANE.alignment = TextAnchor.MiddleRight;
            oyoob_dar_t_EXPLANE.lineSpacing = -1f;
            oyoob_dar_t_Title.text = Fa.faConvert("عیوب در تاسیسات الکتریکی ");
            oyoob_dar_t_EXPLANE.text = Fa.faConvert("در انواع عیب ها در تاسیسات برقی میتوان به عیب عایقی ، عبور جریان زیاد ، عیب اتصال به زمین و اتصال به بدنه اشاره کرد.");

            eyb_01_EXPLANE.alignment = TextAnchor.MiddleRight;
            eyb_01_EXPLANE.lineSpacing = -1f;
            eyb_01_Title.text = Fa.faConvert("عیب عایقی ");
            eyb_01_EXPLANE.text = Fa.faConvert("ه عیبی گفته می شود که در اثر عوامل فیزیکی یا هر عامل دیگری پوشش عایقی کابل ها و سیم ها دچار آسیب شده و هادی جریان نمایان می شود.");
            
            eyb_02_EXPLANE.alignment = TextAnchor.MiddleRight;
            eyb_02_EXPLANE.lineSpacing = -1f;
            eyb_02_Title.text = Fa.faConvert("عیب اتصال به زمین ");
            eyb_02_EXPLANE.text = Fa.faConvert("هرگاه یک کابل دارای پتانسیل بر اثر عوامل مختلف آسیب ببیند و پاره شود و در اثر برخورد کابل با زمین موجب جرقه و قطع شدن مسیر جریان توسط کلید حفاظتی خواهد شد اما اگر شرایط طوری پیش رود که جریان نشتی از کابل به سمت زمین عبور کند محل مورد نظر با حرارت خواهد بود و موجب آتش سوزی خواهد شد.");
            
            eyb_03_EXPLANE.alignment = TextAnchor.MiddleRight;
            eyb_03_EXPLANE.lineSpacing = -1f;
            eyb_03_Title.text = Fa.faConvert("عبور جریان زیاد ");
            eyb_03_EXPLANE.text = Fa.faConvert("این عیب شامل دو حالت اضافه بار و اتصال کوتاه است.");
            
            eyb_04_EXPLANE.alignment = TextAnchor.MiddleRight;
            eyb_04_EXPLANE.lineSpacing = -1f;
            eyb_04_Title.text = Fa.faConvert("اتصال به بدنه ");
            eyb_04_EXPLANE.text = Fa.faConvert("هرگاه جریان الکتریکی به قسمتی از بدنه سیستم یا دستگاه برخورد کند.");



            //



            tashih_zarib_qodrat_Explane.alignment = TextAnchor.MiddleRight;
            tashih_zarib_qodrat_Explane.lineSpacing = -1f;
            tashih_zarib_qodrat_Title.text = Fa.faConvert("تصحیح ضریب قدرت ");
            tashih_zarib_qodrat_Explane.text = Fa.faConvert("به طور کلی بار ها به صورت سلفی و اهمی به عنوان مصرف کننده در شبکه و تاسیسات الکتریکی وجود دارد، لذا این امر موجب می شود علاوه بر توان اکتیو مقداری راکتیو شبکه دریافت نماید این امر موجب ضریب قدرت مدار شبکه کاهش پیدا کرده و در مقابل جریان زیاد تری از شبکه تقاضا نماید این امر موجب می شود منابع تامین انرژی افزایش پیدا کند. تلفات شبکه افزایش پیدا کرده و تجهیزات به نوبۀ خود بزرگ شده و هزینه ی زیادی را در بر داشته باشد برای کاهش هزینه های فوق در صنعت معمولا از بانک های خازنی استفاده می کنند. بانک های خلزنی بخش زیادی از توان های رأکتیو را تامین نموده و از کشیدن جریان اضافی از شبکه جلوگیری می شود.");




            #endregion  //.......................................................................................

		}
	}
    
	/// /////////////////////////////////////////////////////////////////////////

    public void Farsi()
    {
		Language_Changed = false;

		PlayerPrefs.SetInt("E_or_P", 2);
		is_English = false;
	}

    public void English()
	{
		Language_Changed = false;
		
		PlayerPrefs.SetInt("E_or_P", 1);
		is_English = true;
	}

    /// //////////////////////////////////////////////////////////////////////////

    public void set_V_Tittle_To__PQ_PV_Slack()
    {
        Video_Tittle.text = S_D1_f1.text;
    }

    public void set_V_Tittle_To__Pakhsh_Bar()
    {
        Video_Tittle.text = S_D1_f4.text;
    }

    public void set_V_Tittle_To__Gos_Saydel()
    {
        Video_Tittle.text = S_D1_f5.text;
    }

    public void set_V_Tittle_To__Nioton_Rafson()
    {
        Video_Tittle.text = S_D1_f6.text;
    }

    public void set_V_Tittle_To__Bast_Teylor()
    {
        Video_Tittle.text = S_D1_f7.text;
    }

    public void set_V_Tittle_To__Zhakoobin_Matrix()
    {
        Video_Tittle.text = S_D1_f8.text;
    }







    public void set_V_Tittle_To__Parameters()
    {
        Video_Tittle.text = S_D2_f1.text;
    }

    public void set_V_Tittle_To__Mohasebe_Roshanayi()
    {
        Video_Tittle.text = S_D2_f2.text;
    }

    public void set_V_Tittle_To__Barresi_SimHa()
    {
        Video_Tittle.text = S_D2_f3.text;
    }

    public void set_V_Tittle_To__Barresi_Hefazat()
    {
        Video_Tittle.text = S_D2_f4.text;
    }

    public void set_V_Tittle_To__Tashih_Zarib_Qodrat()
    {
        Video_Tittle.text = S_D2_f5.text;
    }





}

#region // Fa Class
namespace System.Collections
{
	public static class Fa {
		
		public static Dictionary <int,int[]> charStorage = new Dictionary<int, int[]> ()
		{
			{65165, new int[] {65165, 65166, 65165, 65166}},	{65167, new int[] {65167, 65168, 65169, 65170}},	{64342, new int[] {64342, 64343, 64344, 64345}},	{65173, new int[] {65173, 65174, 65175, 65176}},	{65177, new int[] {65177, 65178, 65179, 65180}},	{65181, new int[] {65181, 65182, 65183, 65184}},	{64378, new int[] {64378, 64379, 64380, 64381}},	{65185, new int[] {65185, 65186, 65187, 65188}},	{65189, new int[] {65189, 65190, 65191, 65192}},	{65193, new int[] {65193, 65194, 65193, 65194}},	{65195, new int[] {65195, 65196, 65195, 65196}},	{65197, new int[] {65197, 65198, 65197, 65198}},	{65199, new int[] {65199, 65200, 65199, 65200}},	{64394, new int[] {64394, 64395, 64394, 64395}},	{65201, new int[] {65201, 65202, 65203, 65204}},	{65205, new int[] {65205, 65206, 65207, 65208}},	{65209, new int[] {65209, 65210, 65211, 65212}},	{65213, new int[] {65213, 65214, 65215, 65216}},	{65217, new int[] {65217, 65218, 65219, 65220}},	{65221, new int[] {65221, 65222, 65223, 65224}},	{65225, new int[] {65225, 65226, 65227, 65228}},	{65229, new int[] {65229, 65230, 65231, 65232}},	{65233, new int[] {65233, 65234, 65235, 65236}},	{65237, new int[] {65237, 65238, 65239, 65240}},	{64398, new int[] {64398, 64399, 64400, 64401}},	{64402, new int[] {64402, 64403, 64404, 64405}},	{65245, new int[] {65245, 65246, 65247, 65248}},	{65249, new int[] {65249, 65250, 65251, 65252}},	{65253, new int[] {65253, 65254, 65255, 65256}},	{65261, new int[] {65261, 65262, 65261, 65262}},	{65257, new int[] {65257, 65258, 65259, 65260}},	{64508, new int[] {64508, 64509, 64510, 64511}},	{65153, new int[] {65153, 65154, 65153, 65154}},
			{1575, new int[] {1575, 65166, 65165, 65166}},	{1576, new int[] {1576, 65168, 65169, 65170}},	{1662, new int[] {1662, 64343, 64344, 64345}},	{1578, new int[] {1578, 65174, 65175, 65176}},	{1579, new int[] {1579, 65178, 65179, 65180}},	{1580, new int[] {1580, 65182, 65183, 65184}},	{1670, new int[] {1670, 64379, 64380, 64381}},	{1581, new int[] {1581, 65186, 65187, 65188}},	{1582, new int[] {1582, 65190, 65191, 65192}},	{1583, new int[] {1583, 65194, 65193, 65194}},	{1584, new int[] {1584, 65196, 65195, 65196}},	{1585, new int[] {1585, 65198, 65197, 65198}},	{1586, new int[] {1586, 65200, 65199, 65200}},	{1688, new int[] {1688, 64395, 64394, 64395}},	{1587, new int[] {1587, 65202, 65203, 65204}},	{1588, new int[] {1588, 65206, 65207, 65208}},	{1589, new int[] {1589, 65210, 65211, 65212}},	{1590, new int[] {1590, 65214, 65215, 65216}},	{1591, new int[] {1591, 65218, 65219, 65220}},	{1592, new int[] {1592, 65222, 65223, 65224}},	{1593, new int[] {1593, 65226, 65227, 65228}},	{1594, new int[] {1594, 65230, 65231, 65232}},	{1601, new int[] {1601, 65234, 65235, 65236}},	{1602, new int[] {1602, 65238, 65239, 65240}},	{1705, new int[] {1705, 64399, 64400, 64401}},	{1711, new int[] {1711, 64403, 64404, 64405}},	{1604, new int[] {1604, 65246, 65247, 65248}},	{1605, new int[] {1605, 65250, 65251, 65252}},	{1606, new int[] {1606, 65254, 65255, 65256}},	{1608, new int[] {1608, 65262, 65261, 65262}},	{1607, new int[] {1607, 65258, 65259, 65260}},	{1740, new int[] {1740, 64509, 64510, 64511}},	{1570, new int[] {1570, 65154, 65153, 65154}},

			{65265, new int[] {65265, 65266, 65267, 65268}}, {65171, new int[] {65171, 65172, 65171, 65172}}, {65263, new int[] {65263, 65264, 65263, 65264}},	{65157, new int[] {65157, 65158, 65157, 65158}},	{65155, new int[] {65155, 65156, 65155, 65156}},	{65159, new int[] {65159, 65160, 65159, 65160}},	{65241, new int[] {65241, 65242, 65243, 65244}},	{65161, new int[] {65161, 65162, 65163, 65164}},
			{1610, new int[] {65265, 65266, 65267, 65268}}, {1577, new int[] {65171, 65172, 65171, 65172}}, {1609, new int[] {65263, 65264, 65263, 65264}},	{1572, new int[] {65157, 65158, 65157, 65158}},	{1571, new int[] {65155, 65156, 65155, 65156}},	{1573, new int[] {65159, 65160, 65159, 65160}},	{1603, new int[] {65241, 65242, 65243, 65244}},	{1574, new int[] {65161, 65162, 65163, 65164}},

		};
		
		public static Dictionary <int,int[]> boolStorage = new Dictionary<int, int[]> ()
		{
			{65165, new int[] {0, 1}}, 	{65167, new int[] {1, 1}}, 	{64342, new int[] {1, 1}}, 	{65173, new int[] {1, 1}}, 	{65177, new int[] {1, 1}}, 	{65181, new int[] {1, 1}}, 	{64378, new int[] {1, 1}}, 	{65185, new int[] {1, 1}}, 	{65189, new int[] {1, 1}}, 	{65193, new int[] {0, 1}}, 	{65195, new int[] {0, 1}}, 	{65197, new int[] {0, 1}}, 	{65199, new int[] {0, 1}}, 	{64394, new int[] {0, 1}}, 	{65201, new int[] {1, 1}}, 	{65205, new int[] {1, 1}}, 	{65209, new int[] {1, 1}}, 	{65213, new int[] {1, 1}}, 	{65217, new int[] {1, 1}}, 	{65221, new int[] {1, 1}}, 	{65225, new int[] {1, 1}}, 	{65229, new int[] {1, 1}}, 	{65233, new int[] {1, 1}}, 	{65237, new int[] {1, 1}}, 	{64398, new int[] {1, 1}}, 	{64402, new int[] {1, 1}}, 	{65245, new int[] {1, 1}}, 	{65249, new int[] {1, 1}}, 	{65253, new int[] {1, 1}}, 	{65261, new int[] {0, 1}}, 	{65257, new int[] {1, 1}}, 	{64508, new int[] {1, 1}}, 	{65153, new int[] {0, 1}}, 
			{1575, new int[] {0, 1}}, 	{1576, new int[] {1, 1}}, 	{1662, new int[] {1, 1}}, 	{1578, new int[] {1, 1}}, 	{1579, new int[] {1, 1}}, 	{1580, new int[] {1, 1}}, 	{1670, new int[] {1, 1}}, 	{1581, new int[] {1, 1}}, 	{1582, new int[] {1, 1}}, 	{1583, new int[] {0, 1}}, 	{1584, new int[] {0, 1}}, 	{1585, new int[] {0, 1}}, 	{1586, new int[] {0, 1}}, 	{1688, new int[] {0, 1}}, 	{1587, new int[] {1, 1}}, 	{1588, new int[] {1, 1}}, 	{1589, new int[] {1, 1}}, 	{1590, new int[] {1, 1}}, 	{1591, new int[] {1, 1}}, 	{1592, new int[] {1, 1}}, 	{1593, new int[] {1, 1}}, 	{1594, new int[] {1, 1}}, 	{1601, new int[] {1, 1}}, 	{1602, new int[] {1, 1}}, 	{1705, new int[] {1, 1}}, 	{1711, new int[] {1, 1}}, 	{1604, new int[] {1, 1}}, 	{1605, new int[] {1, 1}}, 	{1606, new int[] {1, 1}}, 	{1608, new int[] {0, 1}}, 	{1607, new int[] {1, 1}}, 	{1740, new int[] {1, 1}}, 	{1570, new int[] {0, 1}}, 

			{65265, new int[] {1, 1}}, 	{65171, new int[] {0, 1}}, 	{65263, new int[] {0, 1}}, 	{65157, new int[] {0, 1}}, 	{65155, new int[] {0, 1}}, 	{65159, new int[] {0, 1}}, 	{65241, new int[] {1, 1}}, 	{65161, new int[] {1, 1}}, 
			{1610, new int[] {1, 1}}, 	{1577, new int[] {0, 1}}, 	{1609, new int[] {0, 1}}, 	{1572, new int[] {0, 1}}, 	{1571, new int[] {0, 1}}, 	{1573, new int[] {0, 1}}, 	{1603, new int[] {1, 1}}, 	{1574, new int[] {1, 1}}, 

		};

		public static string faConvert(this string input)
		{
			string outStr = "";
			using (StringReader reader = new StringReader(input))
			{
				string line;
				bool more = false;
				while ((line = reader.ReadLine()) != null)
				{
					if (more) outStr += "\n";
					outStr += faConvertLine(line);
					more = true;
				}
			}

            char[] eng = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] fa = { '٠', '١', '٢', '٣', '٤', '٥', '٦', '٧', '٨', '٩' };

            for (int i = 0; i < eng.Length; i++)
            {
                outStr = outStr.Replace(eng[i], fa[i]);
            }

            return outStr;
		}
		
		public static string faConvertLine(string input)
		{
			char[] charTemp = input.ToCharArray ();
			
			char chT;
			List<char> listT = new List<char>();
			List<char> listF = new List<char>();
			for (int i=0; i < charTemp.Length; i++)
			{
				if (isFarsi(charTemp[i]))
				{
					chT = convertChar((i==0)?0:Convert.ToInt32(charTemp[i-1]),
					                  Convert.ToInt32(charTemp[i]),
					                  (i==charTemp.Length-1)?0:Convert.ToInt32(charTemp[i+1]));
					
					listT.Reverse();
					listF.AddRange(listT);
					listF.Add(chT);
					
					listT.Clear();
				}
				else
				{
					listT.Add(charTemp[i]);
				}
			}
			
			listT.Reverse();
			listF.AddRange(listT);
			listF.Reverse();
			return new string (listF.ToArray());
		}
		
		public static char convertChar(int prev, int curr, int next)
		{
			
			int pr=0, ne=0;
			int[] tmp; int[] ctmp;
			
			if (boolStorage.TryGetValue (prev, out tmp))
				pr = tmp[0];
			else
				pr = 0;
			
			if (boolStorage.TryGetValue (next, out tmp))
				ne = tmp[1];
			else
				ne = 0;
			
			if (charStorage.TryGetValue(curr, out ctmp))
				return Char.ConvertFromUtf32(ctmp [pr + (ne * 2)])[0];
			else
				return Char.ConvertFromUtf32(curr)[0];
		}
		
		public static bool isFarsi(char ch)
		{
			int ch16 = Convert.ToInt32(ch);
			if ((ch16 >= 1536 && ch16 <= 1791) || (ch16 >= 65136 && ch16 <= 65279))
				return true;
			else
				return false;
		}
	}
}

// in joory estefade mishe faqat braye taqire text az code ..:
//    txtMessage.text = Fa.faConvert("نوشته شما");
#endregion