using UnityEngine;

public class VozDoAlém : MonoBehaviour
{
    public AudioClip[] vozesSuspenso;
    public AudioClip[] vozesTerror;
    public AudioClip[] vozesMisteriosa;
    public AudioSource fonteAudio;

    public enum TipoVoz { Suspenso, Terror, Misteriosa }
    public TipoVoz modoAtual = TipoVoz.Misteriosa;

    public void Falar(string mensagemTexto)
    {
        // Mostra a mensagem na tela
        Alertas.Mostrar($"🔊 Voz do Além: {mensagemTexto}");

        // Toca o som correspondente
        switch (modoAtual)
        {
            case TipoVoz.Suspenso:
                TocarAleatorio(vozesSuspenso);
                break;
            case TipoVoz.Terror:
                TocarAleatorio(vozesTerror);
                break;
            case TipoVoz.Misteriosa:
                TocarAleatorio(vozesMisteriosa);
                break;
        }
    }

    private void TocarAleatorio(AudioClip[] lista)
    {
        if (lista.Length == 0) return;
        int indice = Random.Range(0, lista.Length);
        fonteAudio.clip = lista[indice];
        fonteAudio.Play();
    }

    public void TrocarModo(TipoVoz novoModo)
    {
        modoAtual = novoModo;
        Alertas.Mostrar($"Modo da Voz do Além alterado para: {novoModo}");
    }
}
