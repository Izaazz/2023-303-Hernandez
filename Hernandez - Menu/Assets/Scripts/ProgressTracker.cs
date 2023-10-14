using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProgressTracker : MonoBehaviour
{
    //cada progresso do jogo será salvo em uma posição diferente do array, dessa forma, é possível verificar quais puzzles já foram solucionados
    //para chamar a função StoryProgress serão utilizados ACTIONS
    //EU VOU CORINGAR HAHAHAHAHAHAHAHHAHAHA

    [SerializeField] bool[] progress = new bool[12];
    [SerializeField] TextMeshProUGUI dicas;
    void Start(){
        this.dicas.text = "Eu preciso restaurar a energia, talvez o jogo dos 8 me ajude com isso";
    }

    private void OnEnable(){
        Actions.OnStoryAdvanced += StoryProgress;
    }

    
    private void OnDisable(){
        Actions.OnStoryAdvanced -= StoryProgress;
    }


    public void StoryProgress(int progressNum){

        this.progress[progressNum] = true;
        Debug.Log("aqui o ");
        Debug.Log(progressNum);

        for(int i = 0; i<=10; i++){
            
            if(this.progress[i]){

                this.AtualizaDica(i);
            } else
            {
                break;
            }
        }

    }


    public void AtualizaDica(int num){

        switch(num)
        {
            case 0:
                this.dicas.text = "Falta um fusível, deve ter um perdido em algum lugar por aqui";
                break;
            case 1:
                this.dicas.text = "Parece que a TV ligou, como devo sintonizá-la para prosseguir?";
                break;
            case 2:
                this.dicas.text = "Esse vídeo parece me dar alguma dica sobre a senha da cômoda, talvez algo relacionado a data de gravação";
                break;
            case 3:
                this.dicas.text = "Os post-its perto do computador mostram um martelo quebrando algo, talvez seja uma dica";
                break;
            case 4:
                this.dicas.text = "O que devo fazer com essa lâmpada UV? Será que há algum abajur por perto?";
                break;
            case 5:
                this.dicas.text = "Algo apareceu nesses papéis perto do abajur... uma senha? Onde devo usá-la?";
                break;
            case 6:
                this.dicas.text = "Esse áudio no computador se refere a um quadro, lembro de ter visto um por aqui";
                break;
            case 7:
                this.dicas.text = "O poema parece contar uma história, será que tem relação com aquelas fotos do varal ao lado da porta?";
                break;
            case 8:
                this.dicas.text = "Os símbolos dos livros se parecem com os símbolos do cadeado ao lado do computador";
                break;
             case 9:
                this.dicas.text = "Talvez eu devesse procurar outra parte da chave em algum lugar, será que é algo relacionado ao computador?";
                break;
            case 10:
                this.dicas.text = "O medalhão com um K parece encaixar perfeitamente na porta";
                break;
        }
    }
}
