using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenusJogo : MonoBehaviour
{
    
    public GameObject canvasMenuPrincipal;
    public GameObject canvasMenuHistoria;
    public GameObject canvasMenuInstrucoes;
    public GameObject canvasMenuCreditos;
    public GameObject canvasMenuSecundario;
    public GameObject canvasDescricaoPoder;

    
    
    // Start is called before the first frame update
    void Start()
    {
        canvasMenuPrincipal.SetActive(true);

        canvasMenuInstrucoes.SetActive(false);
        canvasMenuCreditos.SetActive(false);
        canvasMenuHistoria.SetActive(false);
        canvasMenuSecundario.SetActive(false);
        canvasDescricaoPoder.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //----------------------------------------------------MENU PRINCIPAL-------------------------------------------------------------------------

   //Função que leva o utilizador para o primeiro nível
   public void Jogar()
   {
        canvasMenuPrincipal.SetActive(false);
        SceneManager.LoadScene("lvl1");

   }

   //Função que leve o utilizador a sair do jogo
   public void Sair()
   {
        Application.Quit();

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
   }

    //Interface que contém as intruções do jogo
    public void Instrucoes()
    {
        canvasMenuInstrucoes.SetActive (true);
        canvasMenuPrincipal.SetActive(false);
    }

    //Interface que contém a história do jogo
    public void Historia()
    {
        canvasMenuPrincipal.SetActive(false);
        canvasMenuHistoria.SetActive(true);
    }

    //Interface que contém os créditos do jogo
    public void Creditos()
    {
        canvasMenuPrincipal.SetActive(false);
        canvasMenuCreditos.SetActive(true);
    }

    //Para voltar para o Menu Principal, estando no Menu das Instruções
    public void VoltarMI_MP()
    {
        canvasMenuInstrucoes.SetActive(false);
        canvasMenuPrincipal.SetActive(true);
    }


    //Para voltar para o Menu Principal, estando no Menu da História
    public void VoltarMH_MP()
    {
        canvasMenuHistoria.SetActive(false);
        canvasMenuPrincipal.SetActive(true);
    }

    //Para ver a página da Descricao do Poder, estando no Menu da História
    public void VerLivro()
    {
        canvasMenuHistoria.SetActive (false);
        canvasDescricaoPoder.SetActive(true);
    }

    //Para voltar para o Menu da História, estando na Página da Descrição do Poder
    public void VoltarDP_MH()
    {
        canvasDescricaoPoder.SetActive (false);
        canvasMenuHistoria.SetActive(true);
    }

    //Para voltar para o Menu Principal, estando no Menu dos Créditos
    public void VoltarMC_MP()
    {
        canvasMenuCreditos.SetActive (false);
        canvasMenuPrincipal.SetActive(true);
    }

    //-------------------------------------------------MENU SECUNDÁRIO--------------------------------------------------------------------

    //Volta para 1º Nível
    public void NovoJogo()
    {
        canvasMenuSecundario.SetActive(false);
        SceneManager.LoadScene("lvl1");
    }

    //Continuar a jogar
    public void ContinuarJogo()
    {
        canvasMenuSecundario.SetActive(false);

        //#if UNITY_EDITOR
        //    UnityEditor.EditorApplication.isPaused = false;
        //#endif
    }

    //Ir do Menu Secundário para o Menu Principal
    public void IrMenuPrincipal()
    {
        canvasMenuSecundario.SetActive(false);
        canvasMenuPrincipal.SetActive(true);
    }

    
}
