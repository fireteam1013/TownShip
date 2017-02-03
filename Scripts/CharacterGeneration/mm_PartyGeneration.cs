using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mm_PartyGeneration : MonoBehaviour
{
    [Header("Party")]
    public int numOfParty;

    [SerializeField]
    private GameObject p_partyPanel;
    [SerializeField]
    private GameObject p_partyButton;

    public unitCreation[] unitsToCreate;

    GameObject[] unitButtons;
    unitCreation selectedUnit;
    Text t_Name;
    Text t_NickName;
    Text t_RaceClass;
    Text t_HealthMagic;
    Text[] unitText;

    [Space]
    [Header("Creator Panels")]
    [SerializeField]
    GameObject p_RacePanel;
    [SerializeField]
    GameObject p_ClassPanel;
    [SerializeField]
    GameObject p_AppearancePanel;
    [SerializeField]
    GameObject p_NamePanel;
    GameObject[] panels;

    [Space]
    [Header("Text and Inputs")]
    [SerializeField]
    private Text t_ClassName;
    [SerializeField]
    private Text t_ClassDescription;


    [SerializeField]
    InputField if_GivenName;
    [SerializeField]
    InputField if_SurName;
    [SerializeField]
    InputField if_NickName;
    [SerializeField]
    InputField if_Background;


    void Start()
    {
        panels = new GameObject[] { p_RacePanel, p_ClassPanel, p_AppearancePanel, p_NamePanel };
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(false);
        }
        unitButtons = new GameObject[numOfParty];
        unitsToCreate = new unitCreation[numOfParty];
        for (int i = 0; i < numOfParty; i++)
        {
            unitsToCreate[i] = gameObject.AddComponent<unitCreation>();
        }
        InstantiatePartyButtons();
        
        for (int i = 0; i < numOfParty; i++)
        {
            selectedUnit = unitsToCreate[i];
            foreach (GameObject units in unitButtons)
            {
                unitText = units.GetComponentsInChildren<Text>();
                t_Name = unitText[0];
                t_NickName = unitText[1];
                t_RaceClass = unitText[2];
                t_HealthMagic = unitText[3];
                t_Name.text = null;
                t_NickName.text = null;
                t_RaceClass.text = null;
                t_HealthMagic.text = null;
            }
        }
        SelectUnit(0);
    }

    //========================================
    void InstantiatePartyButtons()
    //========================================
    {
        for (int i = 0; i < numOfParty; i++)
        {
            int partyMember = i;

            //Instantiate the party buttons
            GameObject x = Instantiate(p_partyButton, transform.position, transform.rotation, p_partyPanel.transform);
            x.name = "PartyMember_" + i.ToString();
            unitButtons[i] = x;
            //Places the button in the party panel
            x.GetComponent<RectTransform>().anchoredPosition = new Vector2(8, -1 * (56 + (i * (x.GetComponent<RectTransform>().sizeDelta.y + 8))));

            //Set the button response
            x.GetComponent<Button>().onClick.AddListener(delegate () { SelectUnit(partyMember); });
        }
    }

    //========================================
    void SelectUnit(int x)
    //========================================
    {
        Debug.Log(x);
        selectedUnit = unitsToCreate[x];

        unitText = unitButtons[x].GetComponentsInChildren<Text>();





        t_Name = unitText[0];
        t_NickName = unitText[1];
        t_RaceClass = unitText[2];
        t_HealthMagic = unitText[3];

        if_GivenName.text = selectedUnit.givenName;
        if_SurName.text = selectedUnit.surName;
        if_NickName.text = selectedUnit.nickName;
    }

    void UpdateText()
    {
        t_NickName.text = "'" + selectedUnit.nickName + "'";
        t_Name.text = selectedUnit.givenName + " " + selectedUnit.surName;
        t_RaceClass.text = selectedUnit.selectedRace.RaceName + " " + selectedUnit.selectedClass.ClassName;
        
    }

    public void SetRace(int x)
    {
        selectedUnit.SetRace(x);
        UpdateText();
    }
    
    public void SetClass(int x)
    {
        selectedUnit.SetClass(x);
        UpdateText();
    }

    public void SetGivenName(string x)
    {
        selectedUnit.SetGivenName(x);
        UpdateText();
    }
    public void SetSurName(string x)
    {
        selectedUnit.SetSurName(x);
        UpdateText();
    }
    public void SetNickname(string x)
    {
        selectedUnit.SetNickName(x);
        UpdateText();
    }

    #region OpenPanels
    //========================================
    public void OpenRacePanel()
    //========================================
    {
        togglePanels(0);
    }

    //========================================
    public void OpenClassPanel()
    //========================================
    {
        togglePanels(1);
    }

    //========================================
    public void OpenAppearancePanel()
    //========================================
    {
        togglePanels(2);
    }

    //========================================
    public void OpenNamePanel()
    //========================================
    {
        togglePanels(3);
    }

    //Feed in the button pressed to toggle 
    //========================================
    public void togglePanels(int x)
    //========================================
    {
        for (int i = 0; i < panels.Length; i++)
        {
            if( i == x)
            {
                panels[i].SetActive(true);
            }else
            {
                panels[i].SetActive(false);
            }
        }
    }
    #endregion

}