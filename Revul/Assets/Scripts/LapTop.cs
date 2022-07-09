using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTop : MonoBehaviour
{
    public Button buttonQ;
    public Button buttonW;
    public Button buttonE;
    public Button buttonR;
    public Button buttonT;
    public Button buttonY;
    public Button buttonU;
    public Button buttonI;
    public Button buttonO;
    public Button buttonP;
    public Button buttonP1;
    public Button buttonP2;
    public Button buttonA;
    public Button buttonS;
    public Button buttonD;
    public Button buttonF;
    public Button buttonG;
    public Button buttonH;
    public Button buttonJ;
    public Button buttonK;
    public Button buttonL;
    public Button buttonL1;
    public Button buttonL2;
    public Button buttonZ;
    public Button buttonX;
    public Button buttonC;
    public Button buttonV;
    public Button buttonB;
    public Button buttonN;
    public Button buttonM;
    public Button buttonM1;
    public Button buttonM2;
    public Button buttonM3;

    public Text codeText;
    private string _currentText = "";
    public string properKey = "2908";

    public Animator Lid;

    public bool wasSolved;

    public AudioSource openDoorSound;

    public AudioSource sound;
    
    public GameObject book;
    public GameObject cam;
    public GameObject player;
    public bool cursorIsVisible;
    

    // Start is called before the first frame update
    void Start()
    {
        buttonQ.onClick.AddListener(ButtonClickedQ);
        buttonW.onClick.AddListener(ButtonClickedW);
        buttonE.onClick.AddListener(ButtonClickedE);
        buttonR.onClick.AddListener(ButtonClickedR);
        buttonT.onClick.AddListener(ButtonClickedT);
        buttonY.onClick.AddListener(ButtonClickedY);
        buttonU.onClick.AddListener(ButtonClickedU);
        buttonI.onClick.AddListener(ButtonClickedI);
        buttonO.onClick.AddListener(ButtonClickedO);
        buttonP.onClick.AddListener(ButtonClickedP);
        buttonP1.onClick.AddListener(ButtonClickedP1);
        buttonP2.onClick.AddListener(ButtonClickedP2);
        
        buttonA.onClick.AddListener(ButtonClickedA);
        buttonS.onClick.AddListener(ButtonClickedS);
        buttonD.onClick.AddListener(ButtonClickedD);
        buttonF.onClick.AddListener(ButtonClickedF);
        buttonG.onClick.AddListener(ButtonClickedG);
        buttonH.onClick.AddListener(ButtonClickedH);
        buttonJ.onClick.AddListener(ButtonClickedJ);
        buttonK.onClick.AddListener(ButtonClickedK);
        buttonL.onClick.AddListener(ButtonClickedL);
        buttonL1.onClick.AddListener(ButtonClickedL1);
        buttonL2.onClick.AddListener(ButtonClickedL2);
        
        
        buttonZ.onClick.AddListener(ButtonClickedZ);
        buttonX.onClick.AddListener(ButtonClickedX);
        buttonC.onClick.AddListener(ButtonClickedC);
        buttonV.onClick.AddListener(ButtonClickedV);
        buttonB.onClick.AddListener(ButtonClickedB);
        buttonN.onClick.AddListener(ButtonClickedN);
        buttonM.onClick.AddListener(ButtonClickedM);
        buttonM1.onClick.AddListener(ButtonClickedM1);
        buttonM2.onClick.AddListener(ButtonClickedM2);
        buttonM3.onClick.AddListener(ButtonClickedM3);
    }

    // Update is called once per frame
    void Update()
    {
        codeText.text = _currentText;

        if (_currentText == properKey)
        {
            //openDoorSound.Play();
            wasSolved = true;
            OpenDoor();
            book.SetActive(true);
        }

        if (_currentText.Length >= 6)
        {
            _currentText = "";
        }
    }

    void OpenDoor()
    {
        Lid.SetBool("state", true);
    }

    public void AddDigit(string digit)
    {
        _currentText += digit;
    }

    private void ButtonClickedQ()
    {
        sound.Play();
        AddDigit("й");
    }
    
    private void ButtonClickedW()
    {
        sound.Play();
        AddDigit("ц");
    }
    
    private void ButtonClickedE()
    {
        sound.Play();
        AddDigit("у");
    }
    
    private void ButtonClickedR()
    {
        sound.Play();
        AddDigit("к");
    }
    
    private void ButtonClickedT()
    {
        sound.Play();
        AddDigit("е");
    }
    
    private void ButtonClickedY()
    {
        sound.Play();
        AddDigit("н");
    }
    
    private void ButtonClickedU()
    {
        sound.Play();
        AddDigit("г");
    }
    
    private void ButtonClickedI()
    {
        sound.Play();
        AddDigit("ш");
    }
    
    private void ButtonClickedO()
    {
        sound.Play();
        AddDigit("щ");
    }
    
    private void ButtonClickedP()
    {
        sound.Play();
        AddDigit("з");
    }
    
    private void ButtonClickedP1()
    {
        sound.Play();
        AddDigit("х");
    }
    
    private void ButtonClickedP2()
    {
        sound.Play();
        AddDigit("ъ");
    }
    private void ButtonClickedA()
    {
        sound.Play();
        AddDigit("ф");
    }
    
    private void ButtonClickedS()
    {
        sound.Play();
        AddDigit("ы");
    }
    
    private void ButtonClickedD()
    {
        sound.Play();
        AddDigit("в");
    }
    
    private void ButtonClickedF()
    {
        sound.Play();
        AddDigit("а");
    }
    
    private void ButtonClickedG()
    {
        sound.Play();
        AddDigit("п");
    }
    
    private void ButtonClickedH()
    {
        sound.Play();
        AddDigit("р");
    }
    
    private void ButtonClickedJ()
    {
        sound.Play();
        AddDigit("о");
    }
    
    private void ButtonClickedK()
    {
        sound.Play();
        AddDigit("л");
    }
    
    private void ButtonClickedL()
    {
        sound.Play();
        AddDigit("д");
    }
    
    private void ButtonClickedL1()
    {
        sound.Play();
        AddDigit("ж");
    }
    
    private void ButtonClickedL2()
    {
        sound.Play();
        AddDigit("э");
    }
    private void ButtonClickedZ()
    {
        sound.Play();
        AddDigit("я");
    }
    
    private void ButtonClickedX()
    {
        sound.Play();
        AddDigit("ч");
    }
    
    private void ButtonClickedC()
    {
        sound.Play();
        AddDigit("с");
    }
    
    private void ButtonClickedV()
    {
        sound.Play();
        AddDigit("м");
    }
    
    private void ButtonClickedB()
    {
        sound.Play();
        AddDigit("и");
    }
    
    private void ButtonClickedN()
    {
        sound.Play();
        AddDigit("т");
    }
    
    private void ButtonClickedM()
    {
        sound.Play();
        AddDigit("ь");
    }
    
    private void ButtonClickedM1()
    {
        sound.Play();
        AddDigit("б");
    }
    
    private void ButtonClickedM2()
    {
        sound.Play();
        AddDigit("ю");
    }
    
    private void ButtonClickedM3()
    {
        sound.Play();
        AddDigit("ё");
    }
}

