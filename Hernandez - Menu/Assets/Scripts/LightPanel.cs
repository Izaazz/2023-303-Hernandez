using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPanel : MonoBehaviour
{
    public int verifica = 0;
    [SerializeField] GameObject tvQuebrada;
    [SerializeField] GameObject tvCrash;
    [SerializeField] GameObject luz;
    [SerializeField] GameObject computador;

    [SerializeField] GameObject tvButton;
    [SerializeField] DisplayImage displayImage;
    // Update is called once per frame
    void Update()
    {
        if(verifica == 2){
            Actions.OnStoryAdvanced(1);
            this.luz.SetActive(false);
            this.tvCrash.SetActive(true);
            this.tvQuebrada.SetActive(false);
            this.computador.SetActive(true);
            this.displayImage.TurnOffLightPanel();
            this.tvButton.SetActive(true);

        } else{
            this.tvButton.SetActive(false);
        }

    }
}
