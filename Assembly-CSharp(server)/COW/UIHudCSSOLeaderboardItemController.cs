using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;
using UnityEngine;

namespace COW
{
	// Token: 0x020014CD RID: 5325
	[Token(Token = "0x20014CD")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED99C", Offset = "0x10ED99C")]
	internal class UIHudCSSOLeaderboardItemController : UIBaseController
	{
		// Token: 0x06005AC1 RID: 23233 RVA: 0x0001A9E8 File Offset: 0x00018BE8
		[Token(Token = "0x6005AC1")]
		[Address(RVA = "0x19C4310", Offset = "0x19C4310", VA = "0x7BBC1C4310")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005AC2 RID: 23234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC2")]
		[Address(RVA = "0x19C4360", Offset = "0x19C4360", VA = "0x7BBC1C4360", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005AC3 RID: 23235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC3")]
		[Address(RVA = "0x19C46A4", Offset = "0x19C46A4", VA = "0x7BBC1C46A4", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06005AC4 RID: 23236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC4")]
		[Address(RVA = "0x19C383C", Offset = "0x19C383C", VA = "0x7BBC1C383C")]
		public void SetDataInfo(byte lastRoundTeamID, byte teamID, int index)
		{
		}

		// Token: 0x06005AC5 RID: 23237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC5")]
		[Address(RVA = "0x19C39D0", Offset = "0x19C39D0", VA = "0x7BBC1C39D0")]
		public void SetDataInfo(byte teamID, int index)
		{
		}

		// Token: 0x06005AC6 RID: 23238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC6")]
		[Address(RVA = "0x19C3A2C", Offset = "0x19C3A2C", VA = "0x7BBC1C3A2C")]
		public void SetMatchInfo(bool showNormalMatch, bool showSpecialMatch, bool showImmediately = false)
		{
		}

		// Token: 0x06005AC7 RID: 23239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC7")]
		[Address(RVA = "0x19C491C", Offset = "0x19C491C", VA = "0x7BBC1C491C")]
		private void RefreshPlayersInfo(byte teamID)
		{
		}

		// Token: 0x06005AC8 RID: 23240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AC8")]
		[Address(RVA = "0x19C5664", Offset = "0x19C5664", VA = "0x7BBC1C5664")]
		private string PlayerKDAString(QTfiTeJ killInfo)
		{
			return null;
		}

		// Token: 0x06005AC9 RID: 23241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AC9")]
		[Address(RVA = "0x19C54F0", Offset = "0x19C54F0", VA = "0x7BBC1C54F0")]
		private void RefreshBattleResult()
		{
		}

		// Token: 0x06005ACA RID: 23242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ACA")]
		[Address(RVA = "0x19C5738", Offset = "0x19C5738", VA = "0x7BBC1C5738")]
		private void HideBattleResult()
		{
		}

		// Token: 0x06005ACB RID: 23243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ACB")]
		[Address(RVA = "0x19C57B0", Offset = "0x19C57B0", VA = "0x7BBC1C57B0")]
		private void PlayAnim()
		{
		}

		// Token: 0x06005ACC RID: 23244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ACC")]
		[Address(RVA = "0x19C5910", Offset = "0x19C5910", VA = "0x7BBC1C5910")]
		private void OnAnimFinish()
		{
		}

		// Token: 0x06005ACD RID: 23245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ACD")]
		[Address(RVA = "0x19C5934", Offset = "0x19C5934", VA = "0x7BBC1C5934")]
		private void RefreshRankChange()
		{
		}

		// Token: 0x06005ACE RID: 23246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ACE")]
		[Address(RVA = "0x19C5478", Offset = "0x19C5478", VA = "0x7BBC1C5478")]
		private void RefreshEliminateState(byte teamID)
		{
		}

		// Token: 0x06005ACF RID: 23247 RVA: 0x0001AA00 File Offset: 0x00018C00
		[Token(Token = "0x6005ACF")]
		[Address(RVA = "0x19C5340", Offset = "0x19C5340", VA = "0x7BBC1C5340")]
		private bool IsLastRoundEliminate(byte teamID)
		{
			return default(bool);
		}

		// Token: 0x06005AD0 RID: 23248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD0")]
		[Address(RVA = "0x19C4E10", Offset = "0x19C4E10", VA = "0x7BBC1C4E10")]
		private void RefreshTeamInfoView(byte teamID)
		{
		}

		// Token: 0x06005AD1 RID: 23249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD1")]
		[Address(RVA = "0x19C4F0C", Offset = "0x19C4F0C", VA = "0x7BBC1C4F0C")]
		private void RefreshIndex()
		{
		}

		// Token: 0x06005AD2 RID: 23250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD2")]
		[Address(RVA = "0x19C559C", Offset = "0x19C559C", VA = "0x7BBC1C559C")]
		private void RefreshMatchInfo()
		{
		}

		// Token: 0x06005AD3 RID: 23251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD3")]
		[Address(RVA = "0x19C5174", Offset = "0x19C5174", VA = "0x7BBC1C5174")]
		private void RefreshBGColor(byte teamID)
		{
		}

		// Token: 0x06005AD4 RID: 23252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD4")]
		[Address(RVA = "0x19C47AC", Offset = "0x19C47AC", VA = "0x7BBC1C47AC")]
		private void RefreshTeamName(byte teamID)
		{
		}

		// Token: 0x06005AD5 RID: 23253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD5")]
		[Address(RVA = "0x19C60F4", Offset = "0x19C60F4", VA = "0x7BBC1C60F4")]
		public UIHudCSSOLeaderboardItemController()
		{
		}

		// Token: 0x06005AD6 RID: 23254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD6")]
		[Address(RVA = "0x19C60FC", Offset = "0x19C60FC", VA = "0x7BBC1C60FC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F568", Offset = "0x113F568")]
		private void <SetDataInfo>b__15_0()
		{
		}

		// Token: 0x06005AD7 RID: 23255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD7")]
		[Address(RVA = "0x19C6100", Offset = "0x19C6100", VA = "0x7BBC1C6100")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113F578", Offset = "0x113F578")]
		private void <PlayAnim>b__22_0()
		{
		}

		// Token: 0x04007D8F RID: 32143
		[Token(Token = "0x4007D8F")]
		[FieldOffset(Offset = "0x58")]
		private UIHudCSSOLeaderboardItemView m_View;

		// Token: 0x04007D90 RID: 32144
		[Token(Token = "0x4007D90")]
		[FieldOffset(Offset = "0x60")]
		private UIModelMatch m_ModelMatch;

		// Token: 0x04007D91 RID: 32145
		[Token(Token = "0x4007D91")]
		[FieldOffset(Offset = "0x68")]
		private byte m_TeamID;

		// Token: 0x04007D92 RID: 32146
		[Token(Token = "0x4007D92")]
		[FieldOffset(Offset = "0x69")]
		private byte m_LastRoundTeamID;

		// Token: 0x04007D93 RID: 32147
		[Token(Token = "0x4007D93")]
		[FieldOffset(Offset = "0x70")]
		private List<UILabel> m_NameList;

		// Token: 0x04007D94 RID: 32148
		[Token(Token = "0x4007D94")]
		[FieldOffset(Offset = "0x78")]
		private List<UILabel> m_KillNumList;

		// Token: 0x04007D95 RID: 32149
		[Token(Token = "0x4007D95")]
		[FieldOffset(Offset = "0x80")]
		private int m_Index;

		// Token: 0x04007D96 RID: 32150
		[Token(Token = "0x4007D96")]
		[FieldOffset(Offset = "0x84")]
		private uint m_DelayCallID;

		// Token: 0x04007D97 RID: 32151
		[Token(Token = "0x4007D97")]
		[FieldOffset(Offset = "0x88")]
		private uint m_AnimDelayCallID;

		// Token: 0x04007D98 RID: 32152
		[Token(Token = "0x4007D98")]
		[FieldOffset(Offset = "0x8C")]
		private bool m_ShowNormalMatch;

		// Token: 0x04007D99 RID: 32153
		[Token(Token = "0x4007D99")]
		[FieldOffset(Offset = "0x8D")]
		private bool m_ShowSpecialMatch;

		// Token: 0x04007D9A RID: 32154
		[Token(Token = "0x4007D9A")]
		[FieldOffset(Offset = "0x90")]
		private Color m_BGBaseColor;
	}
}
