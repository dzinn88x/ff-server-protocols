using System;
using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014CE RID: 5326
	[Token(Token = "0x20014CE")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED9D4", Offset = "0x10ED9D4")]
	internal class UIHudCSSOMatchInfoController : UIBaseController
	{
		// Token: 0x06005AD8 RID: 23256 RVA: 0x0001AA18 File Offset: 0x00018C18
		[Token(Token = "0x6005AD8")]
		[Address(RVA = "0x19C6A6C", Offset = "0x19C6A6C", VA = "0x7BBC1C6A6C")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005AD9 RID: 23257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD9")]
		[Address(RVA = "0x19C6ABC", Offset = "0x19C6ABC", VA = "0x7BBC1C6ABC", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005ADA RID: 23258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADA")]
		[Address(RVA = "0x19C7134", Offset = "0x19C7134", VA = "0x7BBC1C7134", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005ADB RID: 23259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADB")]
		[Address(RVA = "0x19C7490", Offset = "0x19C7490", VA = "0x7BBC1C7490", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06005ADC RID: 23260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADC")]
		[Address(RVA = "0x19C7564", Offset = "0x19C7564", VA = "0x7BBC1C7564")]
		private void OnBtnLeaderboardClick()
		{
		}

		// Token: 0x06005ADD RID: 23261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADD")]
		[Address(RVA = "0x19C74C8", Offset = "0x19C74C8", VA = "0x7BBC1C74C8")]
		private void SetUIData()
		{
		}

		// Token: 0x06005ADE RID: 23262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADE")]
		[Address(RVA = "0x19C80B4", Offset = "0x19C80B4", VA = "0x7BBC1C80B4")]
		private void RefreshTeamStatesUI({QAb\u0082~u pId)
		{
		}

		// Token: 0x06005ADF RID: 23263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADF")]
		[Address(RVA = "0x19C780C", Offset = "0x19C780C", VA = "0x7BBC1C780C")]
		private void SetTeamStatesUI(List<{QAb\u0082~u> pids, List<UIHudCSPlayerStateInfoView> views, bool ascending = true)
		{
		}

		// Token: 0x06005AE0 RID: 23264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AE0")]
		[Address(RVA = "0x19C81C4", Offset = "0x19C81C4", VA = "0x7BBC1C81C4")]
		private void Update()
		{
		}

		// Token: 0x06005AE1 RID: 23265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AE1")]
		[Address(RVA = "0x19C855C", Offset = "0x19C855C", VA = "0x7BBC1C855C")]
		private void OnPlayerHPChanged(params object[] data)
		{
		}

		// Token: 0x06005AE2 RID: 23266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AE2")]
		[Address(RVA = "0x19C863C", Offset = "0x19C863C", VA = "0x7BBC1C863C")]
		private void OnPlayerStateChanged(params object[] data)
		{
		}

		// Token: 0x06005AE3 RID: 23267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AE3")]
		[Address(RVA = "0x19C86E4", Offset = "0x19C86E4", VA = "0x7BBC1C86E4")]
		private void OnPlayerQuit(params object[] data)
		{
		}

		// Token: 0x06005AE4 RID: 23268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AE4")]
		[Address(RVA = "0x19C87C0", Offset = "0x19C87C0", VA = "0x7BBC1C87C0")]
		private void OnNewPhaseEnter(params object[] data)
		{
		}

		// Token: 0x06005AE5 RID: 23269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AE5")]
		[Address(RVA = "0x19C8B88", Offset = "0x19C8B88", VA = "0x7BBC1C8B88")]
		private void OnNewMiniPhaseEnter(params object[] data)
		{
		}

		// Token: 0x06005AE6 RID: 23270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AE6")]
		[Address(RVA = "0x19C8C88", Offset = "0x19C8C88", VA = "0x7BBC1C8C88")]
		private void OnStartMatchEndShow(object[] data)
		{
		}

		// Token: 0x06005AE7 RID: 23271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AE7")]
		[Address(RVA = "0x19C767C", Offset = "0x19C767C", VA = "0x7BBC1C767C")]
		private void SetRoundInfoUI()
		{
		}

		// Token: 0x06005AE8 RID: 23272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AE8")]
		[Address(RVA = "0x19C7D58", Offset = "0x19C7D58", VA = "0x7BBC1C7D58")]
		private void SetUIColor()
		{
		}

		// Token: 0x06005AE9 RID: 23273 RVA: 0x0001AA30 File Offset: 0x00018C30
		[Token(Token = "0x6005AE9")]
		[Address(RVA = "0x19C8A28", Offset = "0x19C8A28", VA = "0x7BBC1C8A28")]
		private int CalTeamCount()
		{
			return 0;
		}

		// Token: 0x06005AEA RID: 23274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AEA")]
		[Address(RVA = "0x19C8C90", Offset = "0x19C8C90", VA = "0x7BBC1C8C90")]
		public UIHudCSSOMatchInfoController()
		{
		}

		// Token: 0x04007D9B RID: 32155
		[Token(Token = "0x4007D9B")]
		[FieldOffset(Offset = "0x58")]
		private UIHudCSSOMatchInfoView m_View;

		// Token: 0x04007D9C RID: 32156
		[Token(Token = "0x4007D9C")]
		[FieldOffset(Offset = "0x60")]
		private int mSeconds;

		// Token: 0x04007D9D RID: 32157
		[Token(Token = "0x4007D9D")]
		[FieldOffset(Offset = "0x68")]
		private StringBuilder m_Timer;

		// Token: 0x04007D9E RID: 32158
		[Token(Token = "0x4007D9E")]
		[FieldOffset(Offset = "0x70")]
		private uint min;

		// Token: 0x04007D9F RID: 32159
		[Token(Token = "0x4007D9F")]
		[FieldOffset(Offset = "0x74")]
		private uint sec;

		// Token: 0x04007DA0 RID: 32160
		[Token(Token = "0x4007DA0")]
		[FieldOffset(Offset = "0x78")]
		private List<UIHudCSPlayerStateInfoView> m_MyTeamViews;

		// Token: 0x04007DA1 RID: 32161
		[Token(Token = "0x4007DA1")]
		[FieldOffset(Offset = "0x80")]
		private List<UIHudCSPlayerStateInfoView> m_OppoTeamViews;

		// Token: 0x04007DA2 RID: 32162
		[Token(Token = "0x4007DA2")]
		[FieldOffset(Offset = "0x88")]
		private UIHudCSSOTeamInfoView m_MyTeam;

		// Token: 0x04007DA3 RID: 32163
		[Token(Token = "0x4007DA3")]
		[FieldOffset(Offset = "0x90")]
		private UIHudCSSOTeamInfoView m_OppoTeam;

		// Token: 0x04007DA4 RID: 32164
		[Token(Token = "0x4007DA4")]
		[FieldOffset(Offset = "0x98")]
		private BmPqYDk mGame;

		// Token: 0x04007DA5 RID: 32165
		[Token(Token = "0x4007DA5")]
		[FieldOffset(Offset = "0xA0")]
		private UIModelMatch m_ModelMatch;

		// Token: 0x04007DA6 RID: 32166
		[Token(Token = "0x4007DA6")]
		[FieldOffset(Offset = "0xA8")]
		private int m_TeamCount;
	}
}
