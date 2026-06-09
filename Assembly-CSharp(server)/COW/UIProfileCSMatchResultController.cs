using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B1F RID: 6943
	[Token(Token = "0x2001B1F")]
	public class UIProfileCSMatchResultController : UIPopupWindowController
	{
		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x0600949E RID: 38046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A3B")]
		protected List<EMatchResultPlayerInfoType> InfoTypeList
		{
			[Token(Token = "0x600949E")]
			[Address(RVA = "0x1B4AB80", Offset = "0x1B4AB80", VA = "0x7BBC34AB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x0600949F RID: 38047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A3C")]
		protected Dictionary<ulong, FMatchResultPlayerData> PlayerMatchResultDataMap
		{
			[Token(Token = "0x600949F")]
			[Address(RVA = "0x1B4ABF4", Offset = "0x1B4ABF4", VA = "0x7BBC34ABF4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x060094A0 RID: 38048 RVA: 0x000274C8 File Offset: 0x000256C8
		// (set) Token: 0x060094A1 RID: 38049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A3D")]
		protected ulong WinMVPPlayerAccountID
		{
			[Token(Token = "0x60094A0")]
			[Address(RVA = "0x1B4AC68", Offset = "0x1B4AC68", VA = "0x7BBC34AC68")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60094A1")]
			[Address(RVA = "0x1B4AC70", Offset = "0x1B4AC70", VA = "0x7BBC34AC70")]
			set
			{
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x060094A2 RID: 38050 RVA: 0x000274E0 File Offset: 0x000256E0
		// (set) Token: 0x060094A3 RID: 38051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A3E")]
		protected ulong FailMVPPlayerAccountID
		{
			[Token(Token = "0x60094A2")]
			[Address(RVA = "0x1B4AC78", Offset = "0x1B4AC78", VA = "0x7BBC34AC78")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60094A3")]
			[Address(RVA = "0x1B4AC80", Offset = "0x1B4AC80", VA = "0x7BBC34AC80")]
			set
			{
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x060094A4 RID: 38052 RVA: 0x000274F8 File Offset: 0x000256F8
		// (set) Token: 0x060094A5 RID: 38053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A3F")]
		protected ulong ShowMVPPlayerAccountID
		{
			[Token(Token = "0x60094A4")]
			[Address(RVA = "0x1B4AC88", Offset = "0x1B4AC88", VA = "0x7BBC34AC88")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60094A5")]
			[Address(RVA = "0x1B4AC90", Offset = "0x1B4AC90", VA = "0x7BBC34AC90")]
			set
			{
			}
		}

		// Token: 0x060094A6 RID: 38054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60094A6")]
		[Address(RVA = "0x1B4AC98", Offset = "0x1B4AC98", VA = "0x7BBC34AC98")]
		protected EMatchResultPlayerInfoType[] GetInfoTypes()
		{
			return null;
		}

		// Token: 0x060094A7 RID: 38055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094A7")]
		[Address(RVA = "0x1B4AD04", Offset = "0x1B4AD04", VA = "0x7BBC34AD04")]
		protected void UpdateMVPInfo(List<TeammateStats> players, bool win, bool show = false)
		{
		}

		// Token: 0x060094A8 RID: 38056 RVA: 0x00027510 File Offset: 0x00025710
		[Token(Token = "0x60094A8")]
		[Address(RVA = "0x1B4AE38", Offset = "0x1B4AE38", VA = "0x7BBC34AE38")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060094A9 RID: 38057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094A9")]
		[Address(RVA = "0x1B4AE88", Offset = "0x1B4AE88", VA = "0x7BBC34AE88", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060094AA RID: 38058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094AA")]
		[Address(RVA = "0x1B4B16C", Offset = "0x1B4B16C", VA = "0x7BBC34B16C", Slot = "23")]
		public override void BeforeScreenshot()
		{
		}

		// Token: 0x060094AB RID: 38059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094AB")]
		[Address(RVA = "0x1B4B380", Offset = "0x1B4B380", VA = "0x7BBC34B380", Slot = "24")]
		public override void AfterScreenshot()
		{
		}

		// Token: 0x060094AC RID: 38060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094AC")]
		[Address(RVA = "0x1B4B558", Offset = "0x1B4B558", VA = "0x7BBC34B558")]
		private void OnShareBtnClick()
		{
		}

		// Token: 0x060094AD RID: 38061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094AD")]
		[Address(RVA = "0x1B4B798", Offset = "0x1B4B798", VA = "0x7BBC34B798")]
		private void OnNextBtnClick()
		{
		}

		// Token: 0x060094AE RID: 38062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094AE")]
		[Address(RVA = "0x1B4B7A0", Offset = "0x1B4B7A0", VA = "0x7BBC34B7A0")]
		private void OnFastGiftClick()
		{
		}

		// Token: 0x060094AF RID: 38063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094AF")]
		[Address(RVA = "0x1B4BA24", Offset = "0x1B4BA24", VA = "0x7BBC34BA24")]
		public void ShowMatchResultUIData(MatchStats stats)
		{
		}

		// Token: 0x060094B0 RID: 38064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094B0")]
		[Address(RVA = "0x1B4C40C", Offset = "0x1B4C40C", VA = "0x7BBC34C40C")]
		private void ShowBiaoqianWindow(MatchStats stats)
		{
		}

		// Token: 0x060094B1 RID: 38065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094B1")]
		[Address(RVA = "0x1B4BF98", Offset = "0x1B4BF98", VA = "0x7BBC34BF98")]
		private void SetResultDescTextByRank(uint rank)
		{
		}

		// Token: 0x060094B2 RID: 38066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094B2")]
		[Address(RVA = "0x1B4C26C", Offset = "0x1B4C26C", VA = "0x7BBC34C26C")]
		private void CheckNeedShowRewardBtn(MatchStats stats)
		{
		}

		// Token: 0x060094B3 RID: 38067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094B3")]
		[Address(RVA = "0x1B4BDD4", Offset = "0x1B4BDD4", VA = "0x7BBC34BDD4")]
		protected void OnSetMatchResultInfo(MatchStats stats)
		{
		}

		// Token: 0x060094B4 RID: 38068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094B4")]
		[Address(RVA = "0x1B4C84C", Offset = "0x1B4C84C", VA = "0x7BBC34C84C")]
		protected void UpdateInfoTitle(UILabel infoTxt, int index)
		{
		}

		// Token: 0x060094B5 RID: 38069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60094B5")]
		[Address(RVA = "0x1B4D6A0", Offset = "0x1B4D6A0", VA = "0x7BBC34D6A0")]
		public static string SetMatchResultPlayerInfoString(UILabel label, EMatchResultPlayerInfoType type)
		{
			return null;
		}

		// Token: 0x060094B6 RID: 38070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60094B6")]
		[Address(RVA = "0x1B4DB80", Offset = "0x1B4DB80", VA = "0x7BBC34DB80")]
		private Transform GetItemTransform(bool localTeam, int index)
		{
			return null;
		}

		// Token: 0x060094B7 RID: 38071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094B7")]
		[Address(RVA = "0x1B4C940", Offset = "0x1B4C940", VA = "0x7BBC34C940")]
		private void UpdateTeamInfo(MatchStats stats, bool win)
		{
		}

		// Token: 0x060094B8 RID: 38072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094B8")]
		[Address(RVA = "0x1B4B63C", Offset = "0x1B4B63C", VA = "0x7BBC34B63C")]
		private void SendShareBtnClickLog()
		{
		}

		// Token: 0x060094B9 RID: 38073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094B9")]
		[Address(RVA = "0x1B4D370", Offset = "0x1B4D370", VA = "0x7BBC34D370")]
		private void UpdateTeammateInfo(bool localTeam, List<TeammateStats> players)
		{
		}

		// Token: 0x060094BA RID: 38074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60094BA")]
		[Address(RVA = "0x1B4DC64", Offset = "0x1B4DC64", VA = "0x7BBC34DC64")]
		private FMatchResultPlayerData GetPlayerMatchResultData(ulong accountID)
		{
			return null;
		}

		// Token: 0x060094BB RID: 38075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094BB")]
		[Address(RVA = "0x1B4DCF0", Offset = "0x1B4DCF0", VA = "0x7BBC34DCF0")]
		private void CreatePlayerMatchResultData(ulong accountID, ulong localPlayerID, bool isFriend = false)
		{
		}

		// Token: 0x060094BC RID: 38076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094BC")]
		[Address(RVA = "0x1B4BB5C", Offset = "0x1B4BB5C", VA = "0x7BBC34BB5C")]
		private void ConstructPlayerMatchResultInfo(MatchStats stats)
		{
		}

		// Token: 0x060094BD RID: 38077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60094BD")]
		[Address(RVA = "0x1B4DED4", Offset = "0x1B4DED4", VA = "0x7BBC34DED4")]
		public UIProfileCSMatchResultController()
		{
		}

		// Token: 0x04009E2F RID: 40495
		[Token(Token = "0x4009E2F")]
		[FieldOffset(Offset = "0x98")]
		private UIProfileCSMatchResultView m_View;

		// Token: 0x04009E30 RID: 40496
		[Token(Token = "0x4009E30")]
		[FieldOffset(Offset = "0xA0")]
		protected bool HideGradeInfo;

		// Token: 0x04009E31 RID: 40497
		[Token(Token = "0x4009E31")]
		[FieldOffset(Offset = "0xA8")]
		private List<EMatchResultPlayerInfoType> m_InfoTypeList;

		// Token: 0x04009E32 RID: 40498
		[Token(Token = "0x4009E32")]
		[FieldOffset(Offset = "0xB0")]
		private Dictionary<ulong, FMatchResultPlayerData> m_PlayerMatchResultDataMap;

		// Token: 0x04009E33 RID: 40499
		[Token(Token = "0x4009E33")]
		[FieldOffset(Offset = "0xB8")]
		private MatchStats m_MatchStats;

		// Token: 0x04009E34 RID: 40500
		[Token(Token = "0x4009E34")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_SHowFastGift;

		// Token: 0x04009E35 RID: 40501
		[Token(Token = "0x4009E35")]
		[FieldOffset(Offset = "0xC8")]
		private ulong m_WinMVPPlayerAccountID;

		// Token: 0x04009E36 RID: 40502
		[Token(Token = "0x4009E36")]
		[FieldOffset(Offset = "0xD0")]
		private ulong m_FailMVPPlayerAccountID;

		// Token: 0x04009E37 RID: 40503
		[Token(Token = "0x4009E37")]
		[FieldOffset(Offset = "0xD8")]
		private ulong m_ShowMVPPlayerAccountID;

		// Token: 0x02001B20 RID: 6944
		[Token(Token = "0x2001B20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F94D4", Offset = "0x10F94D4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060094BF RID: 38079 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60094BF")]
			[Address(RVA = "0x1B4DF48", Offset = "0x1B4DF48", VA = "0x7BBC34DF48")]
			public <>c()
			{
			}

			// Token: 0x060094C0 RID: 38080 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60094C0")]
			[Address(RVA = "0x1B4DF50", Offset = "0x1B4DF50", VA = "0x7BBC34DF50")]
			internal FriendInfo <OnFastGiftClick>b__30_0(TeammateStats teamMate)
			{
				return null;
			}

			// Token: 0x04009E38 RID: 40504
			[Token(Token = "0x4009E38")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIProfileCSMatchResultController.<>c <>9;

			// Token: 0x04009E39 RID: 40505
			[Token(Token = "0x4009E39")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<TeammateStats, FriendInfo> <>9__30_0;
		}
	}
}
