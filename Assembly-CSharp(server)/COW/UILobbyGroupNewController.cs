using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x020019F6 RID: 6646
	[Token(Token = "0x20019F6")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F7564", Offset = "0x10F7564")]
	public class UILobbyGroupNewController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06008986 RID: 35206 RVA: 0x00024F00 File Offset: 0x00023100
		[Token(Token = "0x6008986")]
		[Address(RVA = "0x152E4BC", Offset = "0x152E4BC", VA = "0x7BBBD2E4BC")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008987 RID: 35207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008987")]
		[Address(RVA = "0x152E50C", Offset = "0x152E50C", VA = "0x7BBBD2E50C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008988 RID: 35208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008988")]
		[Address(RVA = "0x153127C", Offset = "0x153127C", VA = "0x7BBBD3127C")]
		private void UpdateGroupInfo()
		{
		}

		// Token: 0x06008989 RID: 35209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008989")]
		[Address(RVA = "0x1531D08", Offset = "0x1531D08", VA = "0x7BBBD31D08")]
		private void OnClickOpenInvite()
		{
		}

		// Token: 0x0600898A RID: 35210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600898A")]
		[Address(RVA = "0x1531DD4", Offset = "0x1531DD4", VA = "0x7BBBD31DD4")]
		private void OnClickChangePublic()
		{
		}

		// Token: 0x0600898B RID: 35211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600898B")]
		[Address(RVA = "0x1530A54", Offset = "0x1530A54", VA = "0x7BBBD30A54")]
		private void ChangePublicState(params object[] args)
		{
		}

		// Token: 0x0600898C RID: 35212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600898C")]
		[Address(RVA = "0x15320BC", Offset = "0x15320BC", VA = "0x7BBBD320BC")]
		public void SetData(string modeName, string mapName, uint groupMode)
		{
		}

		// Token: 0x0600898D RID: 35213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600898D")]
		[Address(RVA = "0x15320C8", Offset = "0x15320C8", VA = "0x7BBBD320C8")]
		private void OnClickLeaveGroup(object[] data)
		{
		}

		// Token: 0x0600898E RID: 35214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600898E")]
		[Address(RVA = "0x15320CC", Offset = "0x15320CC", VA = "0x7BBBD320CC")]
		private void onLeaveBtnClick()
		{
		}

		// Token: 0x0600898F RID: 35215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600898F")]
		[Address(RVA = "0x1532508", Offset = "0x1532508", VA = "0x7BBBD32508", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06008990 RID: 35216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008990")]
		[Address(RVA = "0x1532FF0", Offset = "0x1532FF0", VA = "0x7BBBD32FF0")]
		private void OnMatchmakingHide(object[] data)
		{
		}

		// Token: 0x06008991 RID: 35217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008991")]
		[Address(RVA = "0x1533064", Offset = "0x1533064", VA = "0x7BBBD33064")]
		private void OnMatchmakingShow(object[] data)
		{
		}

		// Token: 0x06008992 RID: 35218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008992")]
		[Address(RVA = "0x15330D8", Offset = "0x15330D8", VA = "0x7BBBD330D8")]
		private void OnGroupQuit(object[] data)
		{
		}

		// Token: 0x06008993 RID: 35219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008993")]
		[Address(RVA = "0x15331F0", Offset = "0x15331F0", VA = "0x7BBBD331F0", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06008994 RID: 35220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008994")]
		[Address(RVA = "0x1533578", Offset = "0x1533578", VA = "0x7BBBD33578", Slot = "15")]
		protected override void OnUIClose()
		{
		}

		// Token: 0x06008995 RID: 35221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008995")]
		[Address(RVA = "0x1533114", Offset = "0x1533114", VA = "0x7BBBD33114")]
		public void CloseGroupUI()
		{
		}

		// Token: 0x06008996 RID: 35222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008996")]
		[Address(RVA = "0x1533844", Offset = "0x1533844", VA = "0x7BBBD33844")]
		private void OnPlayBtnClick()
		{
		}

		// Token: 0x06008997 RID: 35223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008997")]
		[Address(RVA = "0x1534684", Offset = "0x1534684", VA = "0x7BBBD34684")]
		private void OnReadyBtnClick()
		{
		}

		// Token: 0x06008998 RID: 35224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008998")]
		[Address(RVA = "0x1534D5C", Offset = "0x1534D5C", VA = "0x7BBBD34D5C")]
		[Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x11438E8", Offset = "0x11438E8")]
		private IEnumerator SetButtonCoolDown(UIButton btn, float delayTime)
		{
			return null;
		}

		// Token: 0x06008999 RID: 35225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008999")]
		[Address(RVA = "0x15344C8", Offset = "0x15344C8", VA = "0x7BBBD344C8")]
		private void StartMatchMaking()
		{
		}

		// Token: 0x0600899A RID: 35226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600899A")]
		[Address(RVA = "0x1534E3C", Offset = "0x1534E3C", VA = "0x7BBBD34E3C", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x0600899B RID: 35227 RVA: 0x00024F18 File Offset: 0x00023118
		[Token(Token = "0x600899B")]
		[Address(RVA = "0x153517C", Offset = "0x153517C", VA = "0x7BBBD3517C", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x0600899C RID: 35228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600899C")]
		[Address(RVA = "0x153525C", Offset = "0x153525C", VA = "0x7BBBD3525C")]
		private void OnGroupStartNtf(params object[] data)
		{
		}

		// Token: 0x0600899D RID: 35229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600899D")]
		[Address(RVA = "0x153532C", Offset = "0x153532C", VA = "0x7BBBD3532C")]
		private void OnJoinedGameVoiceRoom(params object[] data)
		{
		}

		// Token: 0x0600899E RID: 35230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600899E")]
		[Address(RVA = "0x153537C", Offset = "0x153537C", VA = "0x7BBBD3537C")]
		private void OnLeavedGameVoiceRoom(params object[] data)
		{
		}

		// Token: 0x0600899F RID: 35231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600899F")]
		[Address(RVA = "0x15353C0", Offset = "0x15353C0", VA = "0x7BBBD353C0")]
		private void OnMicBtnClick()
		{
		}

		// Token: 0x060089A0 RID: 35232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089A0")]
		[Address(RVA = "0x1531364", Offset = "0x1531364", VA = "0x7BBBD31364")]
		private void RefreshGameVoiceBtnView()
		{
		}

		// Token: 0x060089A1 RID: 35233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089A1")]
		[Address(RVA = "0x153569C", Offset = "0x153569C", VA = "0x7BBBD3569C")]
		private void OnSpeackerBtnClick()
		{
		}

		// Token: 0x060089A2 RID: 35234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089A2")]
		[Address(RVA = "0x15357B8", Offset = "0x15357B8", VA = "0x7BBBD357B8")]
		private void onBgBtnClick()
		{
		}

		// Token: 0x060089A3 RID: 35235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089A3")]
		[Address(RVA = "0x153583C", Offset = "0x153583C", VA = "0x7BBBD3583C")]
		private void onCheckBtnClick()
		{
		}

		// Token: 0x060089A4 RID: 35236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089A4")]
		[Address(RVA = "0x15358E0", Offset = "0x15358E0", VA = "0x7BBBD358E0")]
		private void OnGroupStopNtf(params object[] data)
		{
		}

		// Token: 0x060089A5 RID: 35237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089A5")]
		[Address(RVA = "0x15307C0", Offset = "0x15307C0", VA = "0x7BBBD307C0")]
		private void OnGroupReadyNtf(params object[] data)
		{
		}

		// Token: 0x060089A6 RID: 35238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089A6")]
		[Address(RVA = "0x15304CC", Offset = "0x15304CC", VA = "0x7BBBD304CC")]
		private void onUIGroupAllReady(params object[] data)
		{
		}

		// Token: 0x060089A7 RID: 35239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089A7")]
		[Address(RVA = "0x1534598", Offset = "0x1534598", VA = "0x7BBBD34598")]
		private void ShowReadyEffect(bool show)
		{
		}

		// Token: 0x060089A8 RID: 35240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089A8")]
		[Address(RVA = "0x1535E4C", Offset = "0x1535E4C", VA = "0x7BBBD35E4C")]
		private void OnGroupChangeNtf(params object[] data)
		{
		}

		// Token: 0x060089A9 RID: 35241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089A9")]
		[Address(RVA = "0x153159C", Offset = "0x153159C", VA = "0x7BBBD3159C")]
		private void RefreshChampionshipInfo()
		{
		}

		// Token: 0x060089AA RID: 35242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089AA")]
		[Address(RVA = "0x153503C", Offset = "0x153503C", VA = "0x7BBBD3503C")]
		private void RefreshTeamName()
		{
		}

		// Token: 0x060089AB RID: 35243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089AB")]
		[Address(RVA = "0x1530DC8", Offset = "0x1530DC8", VA = "0x7BBBD30DC8")]
		private void RefreshAutoMatchUI()
		{
		}

		// Token: 0x060089AC RID: 35244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089AC")]
		[Address(RVA = "0x1535F48", Offset = "0x1535F48", VA = "0x7BBBD35F48")]
		private void OnServiceOff(params object[] data)
		{
		}

		// Token: 0x060089AD RID: 35245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089AD")]
		[Address(RVA = "0x1536184", Offset = "0x1536184", VA = "0x7BBBD36184")]
		private void OnQuitToSolo(params object[] data)
		{
		}

		// Token: 0x060089AE RID: 35246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089AE")]
		[Address(RVA = "0x15361C0", Offset = "0x15361C0", VA = "0x7BBBD361C0")]
		private void OnCreateGroupFail(params object[] data)
		{
		}

		// Token: 0x060089AF RID: 35247 RVA: 0x00024F30 File Offset: 0x00023130
		[Token(Token = "0x60089AF")]
		[Address(RVA = "0x1536204", Offset = "0x1536204", VA = "0x7BBBD36204", Slot = "30")]
		protected virtual Vector3 GetGameVoiceGroupPos()
		{
			return default(Vector3);
		}

		// Token: 0x060089B0 RID: 35248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089B0")]
		[Address(RVA = "0x153624C", Offset = "0x153624C", VA = "0x7BBBD3624C")]
		private void OnDismissNtf(params object[] data)
		{
		}

		// Token: 0x060089B1 RID: 35249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089B1")]
		[Address(RVA = "0x1536250", Offset = "0x1536250", VA = "0x7BBBD36250")]
		private void NotInGroup(params object[] data)
		{
		}

		// Token: 0x060089B2 RID: 35250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089B2")]
		[Address(RVA = "0x1536254", Offset = "0x1536254", VA = "0x7BBBD36254")]
		private void OnGroupCodeHelperBtnClick()
		{
		}

		// Token: 0x060089B3 RID: 35251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089B3")]
		[Address(RVA = "0x1531538", Offset = "0x1531538", VA = "0x7BBBD31538")]
		private void AdjustUIForNotchScreen()
		{
		}

		// Token: 0x060089B4 RID: 35252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089B4")]
		[Address(RVA = "0x15363F0", Offset = "0x15363F0", VA = "0x7BBBD363F0")]
		private void OnClickJoinInvite()
		{
		}

		// Token: 0x060089B5 RID: 35253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089B5")]
		[Address(RVA = "0x1536B4C", Offset = "0x1536B4C", VA = "0x7BBBD36B4C")]
		private void OnTicketBtnClick()
		{
		}

		// Token: 0x060089B6 RID: 35254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089B6")]
		[Address(RVA = "0x1536DD4", Offset = "0x1536DD4", VA = "0x7BBBD36DD4")]
		private void OnClickWeaponBtn()
		{
		}

		// Token: 0x060089B7 RID: 35255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089B7")]
		[Address(RVA = "0x1536E74", Offset = "0x1536E74", VA = "0x7BBBD36E74")]
		public void RefreshBonusEventInfo(MapModeData mapModeData, zTfbhtW groupMode)
		{
		}

		// Token: 0x060089B8 RID: 35256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089B8")]
		[Address(RVA = "0x1536F28", Offset = "0x1536F28", VA = "0x7BBBD36F28")]
		public void StartNewbieGuide()
		{
		}

		// Token: 0x060089B9 RID: 35257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089B9")]
		[Address(RVA = "0x15370A8", Offset = "0x15370A8", VA = "0x7BBBD370A8")]
		public void StopNewbieGuide(params object[] args)
		{
		}

		// Token: 0x060089BA RID: 35258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089BA")]
		[Address(RVA = "0x1533694", Offset = "0x1533694", VA = "0x7BBBD33694")]
		public void OnStopGroupNewbieGuide()
		{
		}

		// Token: 0x060089BB RID: 35259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089BB")]
		[Address(RVA = "0x15370AC", Offset = "0x15370AC", VA = "0x7BBBD370AC")]
		private void OnShowLobbyStartGameGuide(params object[] data)
		{
		}

		// Token: 0x060089BC RID: 35260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089BC")]
		[Address(RVA = "0x15373B4", Offset = "0x15373B4", VA = "0x7BBBD373B4")]
		private void OnGroupCodeBtnClick()
		{
		}

		// Token: 0x060089BD RID: 35261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089BD")]
		[Address(RVA = "0x153118C", Offset = "0x153118C", VA = "0x7BBBD3118C")]
		private void UpdateGroupCode(params object[] data)
		{
		}

		// Token: 0x060089BE RID: 35262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089BE")]
		[Address(RVA = "0x153745C", Offset = "0x153745C", VA = "0x7BBBD3745C")]
		private void OnGroupNotReady(params object[] data)
		{
		}

		// Token: 0x060089BF RID: 35263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089BF")]
		[Address(RVA = "0x1537648", Offset = "0x1537648", VA = "0x7BBBD37648")]
		private void OnSelfNotReady(params object[] data)
		{
		}

		// Token: 0x060089C0 RID: 35264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089C0")]
		[Address(RVA = "0x1532F50", Offset = "0x1532F50", VA = "0x7BBBD32F50")]
		private void CancelPlayDelayCall()
		{
		}

		// Token: 0x060089C1 RID: 35265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089C1")]
		[Address(RVA = "0x1537840", Offset = "0x1537840", VA = "0x7BBBD37840")]
		public UILobbyGroupNewController()
		{
		}

		// Token: 0x060089C2 RID: 35266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089C2")]
		[Address(RVA = "0x1537850", Offset = "0x1537850", VA = "0x7BBBD37850")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114394C", Offset = "0x114394C")]
		private void <onLeaveBtnClick>b__28_0()
		{
		}

		// Token: 0x060089C3 RID: 35267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089C3")]
		[Address(RVA = "0x153788C", Offset = "0x153788C", VA = "0x7BBBD3788C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114395C", Offset = "0x114395C")]
		private void <onLeaveBtnClick>b__28_1()
		{
		}

		// Token: 0x060089C4 RID: 35268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089C4")]
		[Address(RVA = "0x1537894", Offset = "0x1537894", VA = "0x7BBBD37894")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114396C", Offset = "0x114396C")]
		private void <OnClickJoinInvite>b__66_0()
		{
		}

		// Token: 0x060089C5 RID: 35269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089C5")]
		[Address(RVA = "0x15378A4", Offset = "0x15378A4", VA = "0x7BBBD378A4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114397C", Offset = "0x114397C")]
		private void <StartNewbieGuide>b__70_0()
		{
		}

		// Token: 0x060089C6 RID: 35270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089C6")]
		[Address(RVA = "0x1537C38", Offset = "0x1537C38", VA = "0x7BBBD37C38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114398C", Offset = "0x114398C")]
		private void <StartNewbieGuide>b__70_1()
		{
		}

		// Token: 0x060089C7 RID: 35271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60089C7")]
		[Address(RVA = "0x1537EC4", Offset = "0x1537EC4", VA = "0x7BBBD37EC4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114399C", Offset = "0x114399C")]
		private void <OnGroupNotReady>b__76_0()
		{
		}

		// Token: 0x04009799 RID: 38809
		[Token(Token = "0x4009799")]
		[FieldOffset(Offset = "0x58")]
		private UILobbyGroupNewView m_View;

		// Token: 0x0400979A RID: 38810
		[Token(Token = "0x400979A")]
		[FieldOffset(Offset = "0x60")]
		private UIModelGroup m_ModelGroup;

		// Token: 0x0400979B RID: 38811
		[Token(Token = "0x400979B")]
		[FieldOffset(Offset = "0x68")]
		private UIModelMapOpeningInfo m_ModelMap;

		// Token: 0x0400979C RID: 38812
		[Token(Token = "0x400979C")]
		[FieldOffset(Offset = "0x70")]
		private UIModelChampionship m_ModelChampionship;

		// Token: 0x0400979D RID: 38813
		[Token(Token = "0x400979D")]
		[FieldOffset(Offset = "0x78")]
		private UIPopupMessageBoxController m_MessageBox;

		// Token: 0x0400979E RID: 38814
		[Token(Token = "0x400979E")]
		[FieldOffset(Offset = "0x80")]
		private UILobbyBonusEventInfoController m_UIBonusEventInfo;

		// Token: 0x0400979F RID: 38815
		[Token(Token = "0x400979F")]
		[FieldOffset(Offset = "0x88")]
		protected byte m_GameMode;

		// Token: 0x040097A0 RID: 38816
		[Token(Token = "0x40097A0")]
		[FieldOffset(Offset = "0x90")]
		private UIPopupMessageBoxController m_QuitDialog;

		// Token: 0x040097A1 RID: 38817
		[Token(Token = "0x40097A1")]
		[FieldOffset(Offset = "0x98")]
		private zTfbhtW m_GroupMode;

		// Token: 0x040097A2 RID: 38818
		[Token(Token = "0x40097A2")]
		[FieldOffset(Offset = "0xA0")]
		private string m_MapName;

		// Token: 0x040097A3 RID: 38819
		[Token(Token = "0x40097A3")]
		[FieldOffset(Offset = "0xA8")]
		private string m_ModeName;

		// Token: 0x040097A4 RID: 38820
		[Token(Token = "0x40097A4")]
		[FieldOffset(Offset = "0xB0")]
		private uint m_DelayCallID;

		// Token: 0x040097A5 RID: 38821
		[Token(Token = "0x40097A5")]
		[FieldOffset(Offset = "0xB4")]
		private bool m_CanInviteJoin;

		// Token: 0x040097A6 RID: 38822
		[Token(Token = "0x40097A6")]
		[FieldOffset(Offset = "0xB8")]
		private BoxCollider m_CheckBtnCollider;

		// Token: 0x040097A7 RID: 38823
		[Token(Token = "0x40097A7")]
		[FieldOffset(Offset = "0xC0")]
		private readonly int INVITE_GUIDE_TIME;

		// Token: 0x040097A8 RID: 38824
		[Token(Token = "0x40097A8")]
		[FieldOffset(Offset = "0xC4")]
		private uint m_TipsGuideCall;

		// Token: 0x040097A9 RID: 38825
		[Token(Token = "0x40097A9")]
		[FieldOffset(Offset = "0xC8")]
		private uint m_StartGameGuideCall;

		// Token: 0x040097AA RID: 38826
		[Token(Token = "0x40097AA")]
		[FieldOffset(Offset = "0xD0")]
		private UICommonGuideController m_CommonGuideCtrl;

		// Token: 0x040097AB RID: 38827
		[Token(Token = "0x40097AB")]
		[FieldOffset(Offset = "0xD8")]
		private uint m_PlayDelayCall;

		// Token: 0x040097AC RID: 38828
		[Token(Token = "0x40097AC")]
		[FieldOffset(Offset = "0xE0")]
		private ulong m_LastChangePublicTime;

		// Token: 0x020019F7 RID: 6647
		[Token(Token = "0x20019F7")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F759C", Offset = "0x10F759C")]
		private sealed class <SetButtonCoolDown>d__38 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x060089C8 RID: 35272 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60089C8")]
			[Address(RVA = "0x1534E10", Offset = "0x1534E10", VA = "0x7BBBD34E10")]
			[DebuggerHidden]
			public <SetButtonCoolDown>d__38(int <>1__state)
			{
			}

			// Token: 0x060089C9 RID: 35273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60089C9")]
			[Address(RVA = "0x1537ECC", Offset = "0x1537ECC", VA = "0x7BBBD37ECC", Slot = "5")]
			[DebuggerHidden]
			private void Dispose()
			{
			}

			// Token: 0x060089CA RID: 35274 RVA: 0x00024F48 File Offset: 0x00023148
			[Token(Token = "0x60089CA")]
			[Address(RVA = "0x1537ED0", Offset = "0x1537ED0", VA = "0x7BBBD37ED0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x170009BF RID: 2495
			// (get) Token: 0x060089CB RID: 35275 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009BF")]
			private object Current
			{
				[Token(Token = "0x60089CB")]
				[Address(RVA = "0x1537FAC", Offset = "0x1537FAC", VA = "0x7BBBD37FAC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x060089CC RID: 35276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60089CC")]
			[Address(RVA = "0x1537FB4", Offset = "0x1537FB4", VA = "0x7BBBD37FB4", Slot = "8")]
			[DebuggerHidden]
			private void Reset()
			{
			}

			// Token: 0x170009C0 RID: 2496
			// (get) Token: 0x060089CD RID: 35277 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170009C0")]
			private object Current
			{
				[Token(Token = "0x60089CD")]
				[Address(RVA = "0x153801C", Offset = "0x153801C", VA = "0x7BBBD3801C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			// Token: 0x040097AD RID: 38829
			[Token(Token = "0x40097AD")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x040097AE RID: 38830
			[Token(Token = "0x40097AE")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x040097AF RID: 38831
			[Token(Token = "0x40097AF")]
			[FieldOffset(Offset = "0x20")]
			public float delayTime;

			// Token: 0x040097B0 RID: 38832
			[Token(Token = "0x40097B0")]
			[FieldOffset(Offset = "0x28")]
			public UILobbyGroupNewController <>4__this;

			// Token: 0x040097B1 RID: 38833
			[Token(Token = "0x40097B1")]
			[FieldOffset(Offset = "0x30")]
			public UIButton btn;
		}
	}
}
