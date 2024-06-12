using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class UIScript : MonoBehaviour
{
    private int pontos;
    private Label TextoPontuaca;
    
    public void adicionarPontos() {
        this.pontos++;
        this.TextoPontuaca.text = this.pontos.ToString();
    }
void Start() {
    var root = GetComponent<UIDocument>().rootVisualElement;
    textoPontuacao = root.Q<Label>("pontos");
}
}


