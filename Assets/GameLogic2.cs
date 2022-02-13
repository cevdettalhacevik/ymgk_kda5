using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic2 : MonoBehaviour
{
    [SerializeField]
    AudioSource [] audisource;
    string adı;
    private AudioSource[] audiobulucu;
    // Start is called before the first frame update
    void Awake()
    {
        audiobulucu = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 clickpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 click2D = new Vector2(clickpos.x, clickpos.y);

            RaycastHit2D hit = Physics2D.Raycast(click2D, Vector2.zero);
            if (hit.collider != null)
            {
                adı = hit.collider.gameObject.name;
                foreach (AudioSource bulunan in audiobulucu)
                {
                    bulunan.Stop();
                }
                switch (adı)
                {
                    case "Monitor":
                        audisource[0].Play();
                        break;
                    case "Kasa":
                        audisource[1].Play();
                        break;
                    case "Mouse":
                        audisource[2].Play();
                        
                        break;
                    case "Klavye":
                        audisource[3].Play();
                        break;
                    
                }
            }
        }
    }
}
