using UnityEngine;

public enum EstadoJogador { Saudavel, Ferido, Preso, NoAbismo }

public class EstadoJogador : MonoBehaviour
{
    public EstadoJogador estadoAtual;
    public float vida = 100f;
    public float tempoLimite = 0f;

    void Start()
    {
        estadoAtual = EstadoJogador.Saudavel;
    }

    public void FicarFerido()
    {
        if (estadoAtual == EstadoJogador.Saudavel)
        {
            estadoAtual = EstadoJogador.Ferido;
            tempoLimite = 7f * 60f; // 7 minutos
            Alertas.MostrarAlerta($"Jogador {gameObject.name} está ferido — 7 minutos para socorrer!");
        }
    }

    public void SerSocorrido()
    {
        if (estadoAtual == EstadoJogador.Ferido)
        {
            vida = 70f;
            estadoAtual = EstadoJogador.Saudavel;
            Alertas.MostrarAlerta($"Jogador {gameObject.name} foi socorrido!");
        }
    }

    public void IrParaAbismo()
    {
        estadoAtual = EstadoJogador.NoAbismo;
        Alertas.MostrarAlerta($"Alma de {gameObject.name} levada para o Abismo!");
    }
}
