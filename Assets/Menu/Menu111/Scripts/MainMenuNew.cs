using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenuNew : MonoBehaviour {

		Animator CameraObject;
    public GameObject mainCanvas;
    public GameObject PanelControls;
    public GameObject PanelGame;
    public GameObject PanelMovement;
    public GameObject PanelGeneral;
    public GameObject hoverSound;
    public GameObject sliderSound;
    public GameObject swooshSound;
    public GameObject mainMenu;
    public GameObject playMenu;
    public GameObject exitMenu;
    public GameObject lineGame;
    public GameObject lineVideo;
    public GameObject lineControls;
    public GameObject lineKeyBindings;
    public GameObject lineMovement;
    public GameObject lineCombat;
		

		
		void Start(){
			CameraObject = transform.GetComponent<Animator>();
		}

		public void  PlayCampaign (){
			exitMenu.gameObject.SetActive(false);
			playMenu.gameObject.SetActive(true);
		}
		
		public void  PlayCampaignMobile (){
			exitMenu.gameObject.SetActive(false);
			playMenu.gameObject.SetActive(true);
			mainMenu.gameObject.SetActive(false);
		}

		public void  ReturnMenu (){
			playMenu.gameObject.SetActive(false);
			exitMenu.gameObject.SetActive(false);
			mainMenu.gameObject.SetActive(true);
		}

    public void DisablePlayCampaign()
    {
        playMenu.gameObject.SetActive(false);
    }
    public void Position2()
    {
        DisablePlayCampaign();
        CameraObject.SetFloat("Animate", 1);
    }
    public void Position1()
    {
        CameraObject.SetFloat("Animate", 0);
    }

    public void GamePanel()
    {
        PanelControls.gameObject.SetActive(false);
        PanelGame.gameObject.SetActive(true);
        lineGame.gameObject.SetActive(true);
        lineControls.gameObject.SetActive(false);


    }






    public void ControlsPanel()
    {
        PanelControls.gameObject.SetActive(true);
        PanelGame.gameObject.SetActive(false);
        lineGame.gameObject.SetActive(false);
        lineControls.gameObject.SetActive(true);


    }
    public void CombatPanel()
    {
        PanelMovement.gameObject.SetActive(false);
       ;
        PanelGeneral.gameObject.SetActive(false);

        lineMovement.gameObject.SetActive(false);
        lineCombat.gameObject.SetActive(true);
      ;
    }

    public void GeneralPanel()
    {
        PanelMovement.gameObject.SetActive(false);
       
        PanelGeneral.gameObject.SetActive(true);

        lineMovement.gameObject.SetActive(false);
        lineCombat.gameObject.SetActive(false);
        
    }

    public void PlayHover()
    {
        hoverSound.GetComponent<AudioSource>().Play();
    }
    public void PlaySFXHover()
    {
        sliderSound.GetComponent<AudioSource>().Play();
    }
    public void PlaySwoosh()
    {
        swooshSound.GetComponent<AudioSource>().Play();
    }
    public void AreYouSure()
    {
        exitMenu.gameObject.SetActive(true);
        DisablePlayCampaign();
    }

    public void AreYouSureMobile()
    {
        exitMenu.gameObject.SetActive(true);
        mainMenu.gameObject.SetActive(false);
        DisablePlayCampaign();
    }

    public void Yes()
    {
        Application.Quit();
    }
}
        




		

		
				
			
		
	
