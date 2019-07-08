using UnityEngine; 
using System.Collections;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour {

	public GameObject player;
	public GameObject eventSystem;
	public GameObject startUI;
    public GameObject startPoint;
    public GameObject btnMedicina;
    public GameObject btnEntretenimento;
    public GameObject btnAutomotivo;
    public GameObject btnEnsino;
    public GameObject btnConstrucao;
    public VideoPlayer videoPlayer;
    public VideoClip[] videos;




    // Use this for initialization
    void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}


    private void MedicinaClick()
    {
        videoPlayer.clip = videos[0];
        videoPlayer.Play();
    }

    private void AutomotivoClick()
    {
        videoPlayer.clip = videos[1];
        videoPlayer.Play();
    }

    private void EnsinoClick()
    {
        videoPlayer.clip = videos[2];
        videoPlayer.Play();
    }

    private void EntretenimentoClick()
    {
        videoPlayer.clip = videos[3];
        videoPlayer.Play();
    }

    private void ConstrucaoClick()
    {
        videoPlayer.clip = videos[4];
        videoPlayer.Play();
    }

    public void startTour(Button button) { //Begin the puzzle sequence
		startUI.SetActive (false);
		eventSystem.SetActive(false);
		iTween.MoveTo (player, startPoint.transform.position, 5f);
        eventSystem.SetActive(true);
        switch (button.name)
        {
            case "Entretenimento":
                Invoke("EntretenimentoClick", 1.5f);
                break;
            case "Medicina":
                Invoke("MedicinaClick", 1.5f);
                break;
            case "Ensino":
                Invoke("EnsinoClick", 1.5f);
                break;
            case "Automotivo":
                Invoke("AutomotivoClick", 1.5f);
                break;
            case "Construção":
                Invoke("ConstrucaoClick", 1.5f);
                break;
            default:
                break;
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}