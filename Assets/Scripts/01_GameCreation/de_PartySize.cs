using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class de_PartySize : MonoBehaviour {

    [SerializeField]
    GameObject p_NewGamePanel;
    [SerializeField]
    Text partyDescriptionText;

    [SerializeField]
    GameObject p_PartyPanel, partyMember;

    GameObject[] partyMemberUnits;
    de_Unit[] partyMemberScripts;

    void Start()
    {
        p_NewGamePanel.SetActive(true);
        p_PartyPanel.SetActive(false);
        partyDescriptionText.text = "Select game difficulty.";
    }


    string[] partyDescription = new string[4] 
    {
        "Start the game with a party of six.",
        "Start the game with a party of four.",
        "Start the game with a party of two.  Focus on survival, and managing your settlement before exploring.",
        "Start the game with only one unit.  Survival will be very difficult, and early combat will be impossible."
    };

    int partySize;


    public void MouseOver(int x)
    {
        partyDescriptionText.text = partyDescription[x];
    }

    public void SetPartySize(int x)
    {
        partySize = x;
        p_NewGamePanel.SetActive(false);
        ConfigurePartyPanel();
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }


    public void ConfigurePartyPanel()
    {
        p_PartyPanel.SetActive(true);
        partyMemberUnits = new GameObject[partySize];
        partyMemberScripts = new de_Unit[partySize];

        for (int i = 0; i < partySize; i++)
        {
            GameObject partyTile = Instantiate(partyMember, transform.position, transform.rotation, p_PartyPanel.transform);
            if(partySize == 1)
            {
                partyTile.transform.localPosition = new Vector2(0, 0);
            }
            else
            {
                //TODO: Recalculate
                int minX = (8+(16 * (partySize / 2))) + (128 * (partySize / 2));
                partyTile.transform.localPosition = new Vector2(-minX + ((i-1) * 256), 0);
            }
            
        }
    }
}
