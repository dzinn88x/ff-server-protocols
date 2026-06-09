using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001614 RID: 5652
	[Token(Token = "0x2001614")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10EF9F4", Offset = "0x10EF9F4")]
	internal class UISPHudTeammatesInfoController : UIBaseController, IUIModelDataChangeObserver
	{
		// Token: 0x06006562 RID: 25954 RVA: 0x0001CFF8 File Offset: 0x0001B1F8
		[Token(Token = "0x6006562")]
		[Address(RVA = "0x1621A68", Offset = "0x1621A68", VA = "0x7BBBE21A68")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06006563 RID: 25955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006563")]
		[Address(RVA = "0x1621AB8", Offset = "0x1621AB8", VA = "0x7BBBE21AB8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06006564 RID: 25956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006564")]
		[Address(RVA = "0x1621E80", Offset = "0x1621E80", VA = "0x7BBBE21E80", Slot = "14")]
		protected override void OnUIOpen()
		{
		}

		// Token: 0x06006565 RID: 25957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006565")]
		[Address(RVA = "0x1622438", Offset = "0x1622438", VA = "0x7BBBE22438", Slot = "16")]
		protected override void OnUIDestory()
		{
		}

		// Token: 0x06006566 RID: 25958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006566")]
		[Address(RVA = "0x1622A7C", Offset = "0x1622A7C", VA = "0x7BBBE22A7C", Slot = "28")]
		public void OnDataChanged(UIBaseModel model, uint propID, params object[] param)
		{
		}

		// Token: 0x06006567 RID: 25959 RVA: 0x0001D010 File Offset: 0x0001B210
		[Token(Token = "0x6006567")]
		[Address(RVA = "0x1623AFC", Offset = "0x1623AFC", VA = "0x7BBBE23AFC", Slot = "29")]
		public uint GetInterestedPropID(UIBaseModel model)
		{
			return 0U;
		}

		// Token: 0x06006568 RID: 25960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006568")]
		[Address(RVA = "0x1623B60", Offset = "0x1623B60", VA = "0x7BBBE23B60")]
		private void OnPlayerHPChanged(params object[] data)
		{
		}

		// Token: 0x06006569 RID: 25961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006569")]
		[Address(RVA = "0x1623D58", Offset = "0x1623D58", VA = "0x7BBBE23D58")]
		private void OnPlayerMaxHPChanged(params object[] data)
		{
		}

		// Token: 0x0600656A RID: 25962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600656A")]
		[Address(RVA = "0x1623EDC", Offset = "0x1623EDC", VA = "0x7BBBE23EDC")]
		private void OnRemoveMapMark(object[] data)
		{
		}

		// Token: 0x0600656B RID: 25963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600656B")]
		[Address(RVA = "0x1623FE4", Offset = "0x1623FE4", VA = "0x7BBBE23FE4")]
		private void OnUpdateMapMark(object[] data)
		{
		}

		// Token: 0x0600656C RID: 25964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600656C")]
		[Address(RVA = "0x16240EC", Offset = "0x16240EC", VA = "0x7BBBE240EC")]
		private void OnPlayerGetOnVehicle(object[] data)
		{
		}

		// Token: 0x0600656D RID: 25965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600656D")]
		[Address(RVA = "0x1624268", Offset = "0x1624268", VA = "0x7BBBE24268")]
		private void OnPlayerGetOffVehicle(object[] data)
		{
		}

		// Token: 0x0600656E RID: 25966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600656E")]
		[Address(RVA = "0x16243E4", Offset = "0x16243E4", VA = "0x7BBBE243E4")]
		private void OnTeammateKnockDown(object[] data)
		{
		}

		// Token: 0x0600656F RID: 25967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600656F")]
		[Address(RVA = "0x1624588", Offset = "0x1624588", VA = "0x7BBBE24588")]
		private void OnTeammateRevive(object[] data)
		{
		}

		// Token: 0x06006570 RID: 25968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006570")]
		[Address(RVA = "0x1624748", Offset = "0x1624748", VA = "0x7BBBE24748")]
		private void OnPlayerKnockDownStateChanged(object[] data)
		{
		}

		// Token: 0x06006571 RID: 25969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006571")]
		[Address(RVA = "0x1624898", Offset = "0x1624898", VA = "0x7BBBE24898")]
		private void OnTeammateQuit(object[] data)
		{
		}

		// Token: 0x06006572 RID: 25970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006572")]
		[Address(RVA = "0x16249CC", Offset = "0x16249CC", VA = "0x7BBBE249CC")]
		private void OnTeamateVadStateChange(object[] data)
		{
		}

		// Token: 0x06006573 RID: 25971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006573")]
		[Address(RVA = "0x1624B54", Offset = "0x1624B54", VA = "0x7BBBE24B54")]
		private void OnTeamateStateChange(object[] data)
		{
		}

		// Token: 0x06006574 RID: 25972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006574")]
		[Address(RVA = "0x1624CF0", Offset = "0x1624CF0", VA = "0x7BBBE24CF0")]
		private void OnTeamInfoGet(object[] data)
		{
		}

		// Token: 0x06006575 RID: 25973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006575")]
		[Address(RVA = "0x16239D8", Offset = "0x16239D8", VA = "0x7BBBE239D8")]
		private void UpdatePlayerKillCount(PlayerData pData)
		{
		}

		// Token: 0x06006576 RID: 25974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006576")]
		[Address(RVA = "0x1623284", Offset = "0x1623284", VA = "0x7BBBE23284")]
		private void UpdateTeamKillCount({QAb\u0082~u pId)
		{
		}

		// Token: 0x06006577 RID: 25975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006577")]
		[Address(RVA = "0x16233AC", Offset = "0x16233AC", VA = "0x7BBBE233AC")]
		private void UpdateTeamName({QAb\u0082~u pId)
		{
		}

		// Token: 0x06006578 RID: 25976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006578")]
		[Address(RVA = "0x1625214", Offset = "0x1625214", VA = "0x7BBBE25214")]
		private void OnLocalPlayerNewItemOnHand(params object[] param)
		{
		}

		// Token: 0x06006579 RID: 25977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006579")]
		[Address(RVA = "0x1625448", Offset = "0x1625448", VA = "0x7BBBE25448")]
		private void OnTeammateNewItemOnHand(params object[] param)
		{
		}

		// Token: 0x0600657A RID: 25978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600657A")]
		[Address(RVA = "0x1625660", Offset = "0x1625660", VA = "0x7BBBE25660")]
		private void OnPlayerFire(params object[] param)
		{
		}

		// Token: 0x0600657B RID: 25979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600657B")]
		[Address(RVA = "0x1625930", Offset = "0x1625930", VA = "0x7BBBE25930")]
		private void OnTeamParachuteModeChange(params object[] param)
		{
		}

		// Token: 0x0600657C RID: 25980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600657C")]
		[Address(RVA = "0x16234D8", Offset = "0x16234D8", VA = "0x7BBBE234D8")]
		private void UpdateTeamIcon()
		{
		}

		// Token: 0x0600657D RID: 25981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600657D")]
		[Address(RVA = "0x1625C48", Offset = "0x1625C48", VA = "0x7BBBE25C48")]
		public UISPHudTeammatesInfoController()
		{
		}

		// Token: 0x040083BF RID: 33727
		[Token(Token = "0x40083BF")]
		[FieldOffset(Offset = "0x58")]
		private UISPHudTeammatesInfoView m_View;

		// Token: 0x040083C0 RID: 33728
		[Token(Token = "0x40083C0")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<{QAb\u0082~u, UISPHudTeammateItem> m_Teammates;

		// Token: 0x040083C1 RID: 33729
		[Token(Token = "0x40083C1")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<ulong, UISPHudTeammateItem> m_TeammatesWithAccountID;

		// Token: 0x040083C2 RID: 33730
		[Token(Token = "0x40083C2")]
		[FieldOffset(Offset = "0x70")]
		private UIModelMatch m_MatchModel;

		// Token: 0x040083C3 RID: 33731
		[Token(Token = "0x40083C3")]
		[FieldOffset(Offset = "0x78")]
		private List<UISPHudTeammateItem> m_ListTeammateItem;

		// Token: 0x02001615 RID: 5653
		[Token(Token = "0x2001615")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EFA2C", Offset = "0x10EFA2C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600657F RID: 25983 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600657F")]
			[Address(RVA = "0x1625D1C", Offset = "0x1625D1C", VA = "0x7BBBE25D1C")]
			public <>c()
			{
			}

			// Token: 0x06006580 RID: 25984 RVA: 0x0001D028 File Offset: 0x0001B228
			[Token(Token = "0x6006580")]
			[Address(RVA = "0x1625D24", Offset = "0x1625D24", VA = "0x7BBBE25D24")]
			internal int <OnDataChanged>b__9_0(cfSip\u007Fz.^|dlTwk a, cfSip\u007Fz.^|dlTwk b)
			{
				return 0;
			}

			// Token: 0x040083C4 RID: 33732
			[Token(Token = "0x40083C4")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UISPHudTeammatesInfoController.<>c <>9;

			// Token: 0x040083C5 RID: 33733
			[Token(Token = "0x40083C5")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<cfSip\u007Fz.^|dlTwk> <>9__9_0;
		}
	}
}
