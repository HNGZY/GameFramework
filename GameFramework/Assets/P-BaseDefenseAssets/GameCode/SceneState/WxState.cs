using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WxState : ISceneState
{
	public WxState(SceneStateController Controller) : base(Controller)
	{
		this.StateName = "Wx";
	}

	// 開始
	public override void StateBegin()
	{
		// 取得開始按鈕
		Button tmpBtn = UITool.GetUIComponent<Button>("WXButton");
		if (tmpBtn != null)
			tmpBtn.onClick.AddListener(() => OnStartGameBtnClick(tmpBtn)) ;
	}

	// 開始戰鬥
	private void OnStartGameBtnClick(Button theButton)
	{
		//Debug.Log ("OnStartBtnClick:"+theButton.gameObject.name);
		m_Controller.SetState(new BattleState(m_Controller), "BattleScene");
	}
}
