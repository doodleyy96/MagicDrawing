﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour {
    public Button BtnSlider;
    public Button BtnSlider_active;
    public Button btnContract;
    public GameObject panel_line;
    public GameObject panel_constract;
    public GameObject line;
    public GameObject contrast;
    // Use this for initialization
    public Button Record;
    public Button Recording;
    public Button BtnPush;
    public Button BtnPushActive;
    void Start() {

        BtnSlider.onClick.AddListener(() =>
        {
            BtnSlider.gameObject.SetActive(false);
            BtnSlider_active.gameObject.SetActive(true);
            btnContract.gameObject.SetActive(true);
            btnContract.gameObject.transform.Find("contrast").gameObject.SetActive(false);
            btnContract.gameObject.transform.Find("line").gameObject.SetActive(true);
            line.SetActive(true);
            contrast.SetActive(false);
            panel_line.SetActive(true);
            BtnPushActive.gameObject.SetActive(false);
            BtnPush.gameObject.SetActive(true);
        });

        BtnSlider_active.onClick.AddListener(() =>
        {
            BtnSlider_active.gameObject.SetActive(false);
            BtnSlider.gameObject.SetActive(true);
            btnContract.gameObject.SetActive(false);
            panel_line.SetActive(false);
            panel_constract.SetActive(false);
        });

        btnContract.onClick.AddListener(() =>
        {
            bool stateLine = panel_line.activeSelf;
            //btnContract.gameObject.transform.Find("line").gameObject.SetActive(!stateLine);
            //btnContract.gameObject.transform.Find("contrast").gameObject.SetActive(stateLine);            
            line.SetActive(!stateLine);
            contrast.SetActive(stateLine);
            panel_line.SetActive(!stateLine);
            panel_constract.SetActive(stateLine);
        });

        Record.onClick.AddListener(() =>
        {
            Record.gameObject.SetActive(false);
            Recording.gameObject.SetActive(true);            
        });

        Recording.onClick.AddListener(() =>
        {
            Recording.gameObject.SetActive(false);
            Record.gameObject.SetActive(true);
        });

        BtnPush.onClick.AddListener(() =>
        {
            BtnPush.gameObject.SetActive(false);
            BtnPushActive.gameObject.SetActive(true);
            BtnSlider_active.gameObject.SetActive(false);
            BtnSlider.gameObject.SetActive(true);
            panel_line.SetActive(false);
            panel_constract.SetActive(false);
            btnContract.gameObject.SetActive(false);
        });

        BtnPushActive.onClick.AddListener(() =>
        {
            BtnPushActive.gameObject.SetActive(false);
            BtnPush.gameObject.SetActive(true);
        });
    }
}
