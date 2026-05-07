using UnityEngine;
using TMPro;

public class InteracaoQuadro : MonoBehaviour
{
    [Header("Configurações do Quadro")]
    public string nomeDoQuadro;
    public AudioSource meuAudio;
    public Light minhaLuz;
    public TextMeshProUGUI textoUI;

    private void Start()
    {
        // Começa tudo desligado
        if (minhaLuz != null) minhaLuz.enabled = false;
        if (textoUI != null) textoUI.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // --- SISTEMA DE LIMPEZA (Para não encavalar) ---
            // Procura todos os scripts de interação na cena
            InteracaoQuadro[] todosOsQuadros = FindObjectsByType<InteracaoQuadro>(FindObjectsSortMode.None);
            
            foreach (InteracaoQuadro quadro in todosOsQuadros)
            {
                // Para o áudio de todos e apaga todas as luzes de quadro
                if (quadro.meuAudio != null) quadro.meuAudio.Stop();
                if (quadro.minhaLuz != null) quadro.minhaLuz.enabled = false;
            }

            // --- ATIVA O QUADRO ATUAL ---
            if (meuAudio != null) meuAudio.Play();
            
            if (minhaLuz != null) minhaLuz.enabled = true;

            if (textoUI != null)
            {
                textoUI.text = nomeDoQuadro;
                textoUI.gameObject.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Quando sai da área, apenas limpa este quadro
            if (meuAudio != null) meuAudio.Stop();
            if (minhaLuz != null) minhaLuz.enabled = false;
            if (textoUI != null) textoUI.gameObject.SetActive(false);
        }
    }
}