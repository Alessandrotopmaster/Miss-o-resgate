using UnityEngine;

public class PoderesEspirituais : MonoBehaviour
{
    public bool temEscudo = false;
    public bool temVisao = false;

    public void LiberarEscudo()
    {
        temEscudo = true;
        Alertas.Mostrar("Escudo de Luz disponível — protege contra calor e ataques!");
    }

    public void LiberarVisao()
    {
        temVisao = true;
        Alertas.Mostrar("Visão Clara ativada — caminhos e almas ficam visíveis!");
    }

    public void DesativarAoSair()
    {
        temEscudo = false;
        temVisao = false;
        GetComponent<ArmaLuz>().ativa = false;
        Alertas.Mostrar("Poderes do Abismo encerrados.");
    }
}
