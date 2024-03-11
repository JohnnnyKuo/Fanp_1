using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;
public class Menu_event : MonoBehaviour
{
    public GameObject HowtoPlay_canvas;
    public GameObject CG;
    public float x;
    public float alpha=0;
    public bool alphaopen=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cg();
    }

    public void QuitGame()
    {
        Application.Quit();//bulid後才會有用
        EditorApplication.isPlaying=false;//編輯狀態關閉執行
    }

    public void start_game_click()
    {
        //click遊戲開始跳轉道mainScene
    }
    public void open_HowToPlay_canvas()
    {
        HowtoPlay_canvas.SetActive(true);
    }

    public void close_HowToPlay_canvas()
    {
        HowtoPlay_canvas.SetActive(false);
    }
    public void startclick(){
        //update判定與轉場景等待
        alphaopen=true;
        CG.SetActive(true);
        Invoke("startchange",3.5f);
    }
    public void startchange(){
        SceneManager.LoadScene("scene_ver1");
    }
    public void cg(){
        //漸變黑暗
        if(alphaopen==true){
        alpha=alpha+x*Time.deltaTime;
        if(alpha<1){
            CG.GetComponent<Image>().color = new Color(CG.GetComponent<Image>().color.r,CG.GetComponent<Image>().color.g,CG.GetComponent<Image>().color.b,alpha);
        }
        else if(alpha>=1){
            alphaopen=false;
        }
    }     
    }
}
