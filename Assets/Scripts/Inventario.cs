using UnityEngine;
// Este script coloca um CharacterController no GameObject que ele está anexado, se ainda não houver um.
// Para ele conseguir abrir o inventário, o GameObject precisa ter um CharacterController, caso contrário, o script não funcionará corretamente.
[RequireComponent(typeof(CharacterController))]
public class Inventario : MonoBehaviour
{
    //variáveis do inventário

    public int Chaves = 0;
    public int Pocoes = 0;
    public int Moedas = 0;
    public GameObject PainelInventario;
    public TMPro.TextMeshProUGUI TextoInventario;
    //painel do inventário, esse código definir o texto do inventário, mas não define o painel
    public void AtualizarInventario()
    {
        TextoInventario.text =
            "Inventário\n\n" +
            "Moedas: " + Moedas +
            "\nChaves: " + Chaves +
            "\nPoções: " + Pocoes;
    }
    void Start()// Este Start() chama a função AtualizarInventario() para definir o texto do inventário quando o jogo começa.
    {
        AtualizarInventario();
    }
    // Este Update() verifica se a tecla "I" foi pressionada e alterna a visibilidade do painel do inventário. 
    // trazendo o texto do inventário que foi definido na função AtualizarInventario() para o painel do inventário.
    // O script acima desse 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I)) //para esse código funcionar tem mudar o Input Sytem package para both na configuração Player
        {
            PainelInventario.SetActive(
                !PainelInventario.activeSelf
            );
        }
    }
    // Este é um código para adicionar moedas ao inventário, vamos usar para servir de teste
    public void GanharMoedas()
    {
        Moedas += 10;

        AtualizarInventario();
    }
}
