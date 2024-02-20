using UnityEngine;
using UnityEngine.UI;

public class respawnBound : MonoBehaviour
{
    public Transform respawnPoint; // Set the respawn point in the Inspector
    public Transform redCube;
    public Transform blueCube;
    public Transform yellowCube;
    public Transform pestleSpawn;
    public Text HUD;

    public GameObject redPlant;
    public GameObject bluePlant;
    public GameObject yellowPlant;
    public GameObject pestle;
    public GameObject player;

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("blue"))
        {
            Destroy(other.gameObject);
            Instantiate(bluePlant, blueCube.position, blueCube.rotation);
           // HUD.text = "destroying blue";
        }
        else if (other.CompareTag("red"))
        {
            Destroy(other.gameObject);
            Instantiate(redPlant, redCube.position, redCube.rotation);
            //HUD.text = "destroying blue";
        }
        else if(other.CompareTag("yellow"))
        {
            Destroy(other.gameObject);
            Instantiate(yellowPlant, yellowCube.position, yellowCube.rotation);
           // HUD.text = "destroying blue";
        }
       else if(other.CompareTag("pestle"))
        {
            pestle.transform.position = pestleSpawn.position;
            pestle.transform.rotation = pestleSpawn.rotation;
            //HUD.text = "destroying pestle";
        }
        else if(other.CompareTag("Player"))
        {
            // player.transform.position = resetBase.position;
            player.transform.position = respawnPoint.position;
            player.transform.rotation = respawnPoint.rotation;
            //HUD.text = "destroying blue";
        }
    }
}
