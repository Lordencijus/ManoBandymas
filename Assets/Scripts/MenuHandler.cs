using UnityEngine;
using System.Collections;

public class MenuHandler : MonoBehaviour
{

    public string language;



    public GameObject LangMenu;
    public GameObject MainMenuEN;
    public GameObject MainMenuLT;
    public GameObject MainMenuRU;
    public GameObject MainMenuNO;
    public GameObject MiniHouse;
    public GameObject ProjectsEN;

    void Start ()
    {
        //Svaros sumetimais
        LangMenu.GetComponent<Canvas>().enabled = true;
        MainMenuEN.GetComponent<Canvas>().enabled = false;
        MainMenuLT.GetComponent<Canvas>().enabled = false;
        MainMenuRU.GetComponent<Canvas>().enabled = false;
        MainMenuNO.GetComponent<Canvas>().enabled = false;
        ProjectsEN.GetComponent<Canvas>().enabled = false;
        MiniHouse.SetActive(false);
    }

    public void GoToMainEn ()
    {
        //Anglu
        LangMenu.GetComponent<Canvas>().enabled = false;
        MainMenuEN.GetComponent<Canvas>().enabled = true;
        ProjectsEN.GetComponent<Canvas>().enabled = false;
        MiniHouse.SetActive(false);
    }

    public void GoToMainLt()
    {
        //Lietuviu
        LangMenu.GetComponent<Canvas>().enabled = false;
        MainMenuLT.GetComponent<Canvas>().enabled = true;
    }

    public void GoToMainRu()
    {
        //Rusu
        LangMenu.GetComponent<Canvas>().enabled = false;
        MainMenuRU.GetComponent<Canvas>().enabled = true;
    }

    public void GoToMainNo()
    {
        //Norvegu
        LangMenu.GetComponent<Canvas>().enabled = false;
        MainMenuNO.GetComponent<Canvas>().enabled = true;
    }

    public void BackToLang ()
    {
        //Atgal i meniu
        LangMenu.GetComponent<Canvas>().enabled = true;
        MainMenuEN.GetComponent<Canvas>().enabled = false;
        MainMenuLT.GetComponent<Canvas>().enabled = false;
        MainMenuRU.GetComponent<Canvas>().enabled = false;
        MainMenuNO.GetComponent<Canvas>().enabled = false;
        MiniHouse.SetActive(false);
    }

    public void GoToProjEn()
    {
        MainMenuEN.GetComponent<Canvas>().enabled = false;
        ProjectsEN.GetComponent<Canvas>().enabled = true;
        MiniHouse.SetActive(true);
    }

    public void LoadKriaute01()
    {
        Application.LoadLevel("bush");
    }
}
