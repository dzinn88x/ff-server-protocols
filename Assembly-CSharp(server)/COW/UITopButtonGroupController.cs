using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001BB6 RID: 7094
	[Token(Token = "0x2001BB6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10FAABC", Offset = "0x10FAABC")]
	public class UITopButtonGroupController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x0600991D RID: 39197 RVA: 0x00028530 File Offset: 0x00026730
		[Token(Token = "0x600991D")]
		[Address(RVA = "0x1F56FB8", Offset = "0x1F56FB8", VA = "0x7BBC756FB8")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600991E RID: 39198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600991E")]
		[Address(RVA = "0x1F57008", Offset = "0x1F57008", VA = "0x7BBC757008", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600991F RID: 39199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600991F")]
		[Address(RVA = "0x1F5809C", Offset = "0x1F5809C", VA = "0x7BBC75809C", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06009920 RID: 39200 RVA: 0x00028548 File Offset: 0x00026748
		[Token(Token = "0x6009920")]
		[Address(RVA = "0x1F580A4", Offset = "0x1F580A4", VA = "0x7BBC7580A4")]
		public Vector3 GetTitleLeftPos()
		{
			return default(Vector3);
		}

		// Token: 0x06009921 RID: 39201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009921")]
		[Address(RVA = "0x1F580E4", Offset = "0x1F580E4", VA = "0x7BBC7580E4")]
		public Transform GetCustomizedCtrlTrans()
		{
			return null;
		}

		// Token: 0x06009922 RID: 39202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009922")]
		[Address(RVA = "0x1F58110", Offset = "0x1F58110", VA = "0x7BBC758110")]
		public void SetViewState(bool isLobby)
		{
		}

		// Token: 0x06009923 RID: 39203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009923")]
		[Address(RVA = "0x1F581B0", Offset = "0x1F581B0", VA = "0x7BBC7581B0")]
		public void ShowHelpBtn(bool show)
		{
		}

		// Token: 0x06009924 RID: 39204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009924")]
		[Address(RVA = "0x1F5824C", Offset = "0x1F5824C", VA = "0x7BBC75824C")]
		public void ShowVoiceBtn(bool show)
		{
		}

		// Token: 0x06009925 RID: 39205 RVA: 0x00028560 File Offset: 0x00026760
		[Token(Token = "0x6009925")]
		[Address(RVA = "0x1F58528", Offset = "0x1F58528", VA = "0x7BBC758528")]
		public bool IsVoiceBtnShow()
		{
			return default(bool);
		}

		// Token: 0x06009926 RID: 39206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009926")]
		[Address(RVA = "0x1F58568", Offset = "0x1F58568", VA = "0x7BBC758568")]
		private void OnHelpBtnClick()
		{
		}

		// Token: 0x06009927 RID: 39207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009927")]
		[Address(RVA = "0x1F58604", Offset = "0x1F58604", VA = "0x7BBC758604", Slot = "30")]
		protected virtual void OnBackButtonClick()
		{
		}

		// Token: 0x06009928 RID: 39208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009928")]
		[Address(RVA = "0x1F586A0", Offset = "0x1F586A0", VA = "0x7BBC7586A0")]
		private void OnMicBtnClick()
		{
		}

		// Token: 0x06009929 RID: 39209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009929")]
		[Address(RVA = "0x1F5897C", Offset = "0x1F5897C", VA = "0x7BBC75897C")]
		private void OnSpeackerBtnClick()
		{
		}

		// Token: 0x0600992A RID: 39210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600992A")]
		[Address(RVA = "0x1F58354", Offset = "0x1F58354", VA = "0x7BBC758354")]
		private void RefreshGameVoiceBtnView()
		{
		}

		// Token: 0x0600992B RID: 39211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600992B")]
		[Address(RVA = "0x1F58A98", Offset = "0x1F58A98", VA = "0x7BBC758A98")]
		private void OnMailBtnClick()
		{
		}

		// Token: 0x0600992C RID: 39212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600992C")]
		[Address(RVA = "0x1F58B48", Offset = "0x1F58B48", VA = "0x7BBC758B48", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x0600992D RID: 39213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600992D")]
		[Address(RVA = "0x1F58D18", Offset = "0x1F58D18", VA = "0x7BBC758D18")]
		private void OnFriendBtnClick()
		{
		}

		// Token: 0x0600992E RID: 39214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600992E")]
		[Address(RVA = "0x1F58E18", Offset = "0x1F58E18", VA = "0x7BBC758E18")]
		private void OnSettingBtnClick()
		{
		}

		// Token: 0x0600992F RID: 39215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600992F")]
		[Address(RVA = "0x1F5920C", Offset = "0x1F5920C", VA = "0x7BBC75920C")]
		public void MailButtonEnabled(bool v)
		{
		}

		// Token: 0x06009930 RID: 39216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009930")]
		[Address(RVA = "0x1F59254", Offset = "0x1F59254", VA = "0x7BBC759254")]
		public void FriendButtonEnabled(bool v)
		{
		}

		// Token: 0x06009931 RID: 39217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009931")]
		[Address(RVA = "0x1F593A4", Offset = "0x1F593A4", VA = "0x7BBC7593A4")]
		public UIWidget GetFriendWidget()
		{
			return null;
		}

		// Token: 0x06009932 RID: 39218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009932")]
		[Address(RVA = "0x1F593AC", Offset = "0x1F593AC", VA = "0x7BBC7593AC")]
		public void SettingButtonEnabled(bool v)
		{
		}

		// Token: 0x06009933 RID: 39219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009933")]
		[Address(RVA = "0x1F593F4", Offset = "0x1F593F4", VA = "0x7BBC7593F4", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06009934 RID: 39220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009934")]
		[Address(RVA = "0x1F57A98", Offset = "0x1F57A98", VA = "0x7BBC757A98")]
		private void UpdateMailTips()
		{
		}

		// Token: 0x06009935 RID: 39221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009935")]
		[Address(RVA = "0x1F57BE0", Offset = "0x1F57BE0", VA = "0x7BBC757BE0")]
		private void UpdateLobbySettingTips()
		{
		}

		// Token: 0x06009936 RID: 39222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009936")]
		[Address(RVA = "0x1F59494", Offset = "0x1F59494", VA = "0x7BBC759494")]
		private void UpdateLobbyMailBtnTips(object[] data)
		{
		}

		// Token: 0x06009937 RID: 39223 RVA: 0x00028578 File Offset: 0x00026778
		[Token(Token = "0x6009937")]
		[Address(RVA = "0x1F59548", Offset = "0x1F59548", VA = "0x7BBC759548", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06009938 RID: 39224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009938")]
		[Address(RVA = "0x1F57CB8", Offset = "0x1F57CB8", VA = "0x7BBC757CB8")]
		private void UpdateBattery(params object[] parameters)
		{
		}

		// Token: 0x06009939 RID: 39225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009939")]
		[Address(RVA = "0x1F595A4", Offset = "0x1F595A4", VA = "0x7BBC7595A4")]
		public void UpdateTitle(string title)
		{
		}

		// Token: 0x0600993A RID: 39226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600993A")]
		[Address(RVA = "0x1F57F00", Offset = "0x1F57F00", VA = "0x7BBC757F00")]
		public void CheckTips()
		{
		}

		// Token: 0x0600993B RID: 39227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600993B")]
		[Address(RVA = "0x1F58FC0", Offset = "0x1F58FC0", VA = "0x7BBC758FC0")]
		public void SetTips()
		{
		}

		// Token: 0x0600993C RID: 39228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600993C")]
		[Address(RVA = "0x1F57918", Offset = "0x1F57918", VA = "0x7BBC757918")]
		public void ResetTopItemState()
		{
		}

		// Token: 0x0600993D RID: 39229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600993D")]
		[Address(RVA = "0x1F595EC", Offset = "0x1F595EC", VA = "0x7BBC7595EC")]
		public void SetToken1Visibility(bool flag = false)
		{
		}

		// Token: 0x0600993E RID: 39230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600993E")]
		[Address(RVA = "0x1F59688", Offset = "0x1F59688", VA = "0x7BBC759688")]
		public void SetToken2Visibility(bool flag = false)
		{
		}

		// Token: 0x0600993F RID: 39231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600993F")]
		[Address(RVA = "0x1F59724", Offset = "0x1F59724", VA = "0x7BBC759724")]
		public void HideGotoBtnVisibility(bool flag = false)
		{
		}

		// Token: 0x06009940 RID: 39232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009940")]
		[Address(RVA = "0x1F59808", Offset = "0x1F59808", VA = "0x7BBC759808")]
		public void UpdateGotoBtnShow(ResourceID GotoSpriteID, ResourceID GotoTagID, string label)
		{
		}

		// Token: 0x06009941 RID: 39233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009941")]
		[Address(RVA = "0x1F59C0C", Offset = "0x1F59C0C", VA = "0x7BBC759C0C")]
		public void UpdateGotoBtnShow(string GotoSpriteName, string GototagSpriteName, string label)
		{
		}

		// Token: 0x06009942 RID: 39234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009942")]
		[Address(RVA = "0x1F59D64", Offset = "0x1F59D64", VA = "0x7BBC759D64")]
		public void UpdateTokenByIndex(int index, ResourceID id, int num, bool timeLimit = false)
		{
		}

		// Token: 0x06009943 RID: 39235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009943")]
		[Address(RVA = "0x1F59FD4", Offset = "0x1F59FD4", VA = "0x7BBC759FD4")]
		public void UpdateTokenByIndex(int index, string spriteName, int num, bool timeLimit = false)
		{
		}

		// Token: 0x06009944 RID: 39236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009944")]
		[Address(RVA = "0x1F5A0E8", Offset = "0x1F5A0E8", VA = "0x7BBC75A0E8")]
		public Transform GetTokenTransformByIndex(int index)
		{
			return null;
		}

		// Token: 0x06009945 RID: 39237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009945")]
		[Address(RVA = "0x1F5A1B0", Offset = "0x1F5A1B0", VA = "0x7BBC75A1B0")]
		public Transform GetExchangeTransform()
		{
			return null;
		}

		// Token: 0x06009946 RID: 39238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009946")]
		[Address(RVA = "0x1F5A1F0", Offset = "0x1F5A1F0", VA = "0x7BBC75A1F0")]
		private void OnToken1Click()
		{
		}

		// Token: 0x06009947 RID: 39239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009947")]
		[Address(RVA = "0x1F5A380", Offset = "0x1F5A380", VA = "0x7BBC75A380")]
		private void OnToken2Click()
		{
		}

		// Token: 0x06009948 RID: 39240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009948")]
		[Address(RVA = "0x1F5A510", Offset = "0x1F5A510", VA = "0x7BBC75A510")]
		private void OnExchangeStoreClick()
		{
		}

		// Token: 0x06009949 RID: 39241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009949")]
		[Address(RVA = "0x1F5A5C8", Offset = "0x1F5A5C8", VA = "0x7BBC75A5C8")]
		public UITopButtonGroupController()
		{
		}

		// Token: 0x0400A09A RID: 41114
		[Token(Token = "0x400A09A")]
		[FieldOffset(Offset = "0x58")]
		private UITopButtonGroupView m_View;

		// Token: 0x0400A09B RID: 41115
		[Token(Token = "0x400A09B")]
		[FieldOffset(Offset = "0x60")]
		private UICommonGuideController m_CommonGuideCtrl;

		// Token: 0x0400A09C RID: 41116
		[Token(Token = "0x400A09C")]
		[FieldOffset(Offset = "0x68")]
		private UIWidget m_FriendWidget;

		// Token: 0x0400A09D RID: 41117
		[Token(Token = "0x400A09D")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<int, UISprite> m_TokenSpriteDic;

		// Token: 0x0400A09E RID: 41118
		[Token(Token = "0x400A09E")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<int, UILabel> m_TokenCountLebelDic;

		// Token: 0x0400A09F RID: 41119
		[Token(Token = "0x400A09F")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<int, GameObject> m_TokenTimeLimitDic;

		// Token: 0x0400A0A0 RID: 41120
		[Token(Token = "0x400A0A0")]
		[FieldOffset(Offset = "0x88")]
		private Dictionary<int, UIButton> m_TokenButtonDic;

		// Token: 0x0400A0A1 RID: 41121
		[Token(Token = "0x400A0A1")]
		private const float BATTERY_EMPTY_DISPLAY_SCALE = 0.1f;

		// Token: 0x0400A0A2 RID: 41122
		[Token(Token = "0x400A0A2")]
		private const float BATTERY_LEVEL_THRESHOLD_LOW_MEDIUM = 0.2f;

		// Token: 0x0400A0A3 RID: 41123
		[Token(Token = "0x400A0A3")]
		private const float BATTERY_LEVEL_THRESHOLD_MEDIUM_HIGH = 0.5f;

		// Token: 0x0400A0A4 RID: 41124
		[Token(Token = "0x400A0A4")]
		[FieldOffset(Offset = "0x90")]
		private readonly Color BATTERY_LEVEL_COLOR_LOW;

		// Token: 0x0400A0A5 RID: 41125
		[Token(Token = "0x400A0A5")]
		[FieldOffset(Offset = "0xA0")]
		private readonly Color BATTERY_LEVEL_COLOR_MEDIUM;

		// Token: 0x0400A0A6 RID: 41126
		[Token(Token = "0x400A0A6")]
		[FieldOffset(Offset = "0xB0")]
		private readonly Color BATTERY_LEVEL_COLOR_HIGH;

		// Token: 0x0400A0A7 RID: 41127
		[Token(Token = "0x400A0A7")]
		[FieldOffset(Offset = "0xC0")]
		private readonly Color BATTERY_LEVEL_COLOR_CHARGING;

		// Token: 0x0400A0A8 RID: 41128
		[Token(Token = "0x400A0A8")]
		[FieldOffset(Offset = "0xD0")]
		private Vector3 batteryLevelScale;

		// Token: 0x0400A0A9 RID: 41129
		[Token(Token = "0x400A0A9")]
		private const string NEW_SETTING_TIPS = "NEW_SETTING_TIPS";
	}
}
