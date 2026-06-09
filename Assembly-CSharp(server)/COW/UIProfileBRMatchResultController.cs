using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001B19 RID: 6937
	[Token(Token = "0x2001B19")]
	public class UIProfileBRMatchResultController : UIPopupWindowController
	{
		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x060093F1 RID: 37873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A39")]
		protected List<EMatchResultPlayerInfoType> InfoTypeList
		{
			[Token(Token = "0x60093F1")]
			[Address(RVA = "0x218773C", Offset = "0x218773C", VA = "0x7BBC98773C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x060093F2 RID: 37874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A3A")]
		protected Dictionary<ulong, FMatchResultPlayerData> PlayerMatchResultDataMap
		{
			[Token(Token = "0x60093F2")]
			[Address(RVA = "0x21877B0", Offset = "0x21877B0", VA = "0x7BBC9877B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060093F3 RID: 37875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60093F3")]
		[Address(RVA = "0x2187824", Offset = "0x2187824", VA = "0x7BBC987824")]
		protected EMatchResultPlayerInfoType[] GetInfoTypes(int type)
		{
			return null;
		}

		// Token: 0x060093F4 RID: 37876 RVA: 0x000273F0 File Offset: 0x000255F0
		[Token(Token = "0x60093F4")]
		[Address(RVA = "0x21878B0", Offset = "0x21878B0", VA = "0x7BBC9878B0")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x060093F5 RID: 37877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093F5")]
		[Address(RVA = "0x2187900", Offset = "0x2187900", VA = "0x7BBC987900", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x060093F6 RID: 37878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093F6")]
		[Address(RVA = "0x2187B78", Offset = "0x2187B78", VA = "0x7BBC987B78")]
		private void InitTypeList(MatchStats stats)
		{
		}

		// Token: 0x060093F7 RID: 37879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093F7")]
		[Address(RVA = "0x2187C50", Offset = "0x2187C50", VA = "0x7BBC987C50", Slot = "23")]
		public override void BeforeScreenshot()
		{
		}

		// Token: 0x060093F8 RID: 37880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093F8")]
		[Address(RVA = "0x2187E64", Offset = "0x2187E64", VA = "0x7BBC987E64", Slot = "24")]
		public override void AfterScreenshot()
		{
		}

		// Token: 0x060093F9 RID: 37881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093F9")]
		[Address(RVA = "0x218803C", Offset = "0x218803C", VA = "0x7BBC98803C")]
		private void OnShareBtnClick()
		{
		}

		// Token: 0x060093FA RID: 37882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093FA")]
		[Address(RVA = "0x218827C", Offset = "0x218827C", VA = "0x7BBC98827C")]
		private void OnNextBtnClick()
		{
		}

		// Token: 0x060093FB RID: 37883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093FB")]
		[Address(RVA = "0x2188284", Offset = "0x2188284", VA = "0x7BBC988284")]
		private void OnFastGiftClick()
		{
		}

		// Token: 0x060093FC RID: 37884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093FC")]
		[Address(RVA = "0x2188508", Offset = "0x2188508", VA = "0x7BBC988508")]
		public void ShowMatchResultUIData(MatchStats stats)
		{
		}

		// Token: 0x060093FD RID: 37885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093FD")]
		[Address(RVA = "0x2189050", Offset = "0x2189050", VA = "0x7BBC989050")]
		private void ShowBiaoqianWindow(MatchStats stats)
		{
		}

		// Token: 0x060093FE RID: 37886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093FE")]
		[Address(RVA = "0x2188BDC", Offset = "0x2188BDC", VA = "0x7BBC988BDC")]
		private void SetResultDescTextByRank(uint rank)
		{
		}

		// Token: 0x060093FF RID: 37887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60093FF")]
		[Address(RVA = "0x2188EB0", Offset = "0x2188EB0", VA = "0x7BBC988EB0")]
		private void CheckNeedShowRewardBtn(MatchStats stats)
		{
		}

		// Token: 0x06009400 RID: 37888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009400")]
		[Address(RVA = "0x21888C4", Offset = "0x21888C4", VA = "0x7BBC9888C4")]
		protected void OnSetMatchResultInfo(MatchStats stats)
		{
		}

		// Token: 0x06009401 RID: 37889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009401")]
		[Address(RVA = "0x2189490", Offset = "0x2189490", VA = "0x7BBC989490")]
		protected void UpdateInfoTitle(UILabel infoTxt, int index)
		{
		}

		// Token: 0x06009402 RID: 37890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009402")]
		[Address(RVA = "0x218996C", Offset = "0x218996C", VA = "0x7BBC98996C")]
		public static string SetMatchResultPlayerInfoString(UILabel label, EMatchResultPlayerInfoType type)
		{
			return null;
		}

		// Token: 0x06009403 RID: 37891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009403")]
		[Address(RVA = "0x2189EB0", Offset = "0x2189EB0", VA = "0x7BBC989EB0")]
		private Transform GetItemTransform(int index)
		{
			return null;
		}

		// Token: 0x06009404 RID: 37892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009404")]
		[Address(RVA = "0x218972C", Offset = "0x218972C", VA = "0x7BBC98972C")]
		private void UpdatePlayerListInfo(List<TeammateStats> players)
		{
		}

		// Token: 0x06009405 RID: 37893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009405")]
		[Address(RVA = "0x2188120", Offset = "0x2188120", VA = "0x7BBC988120")]
		private void SendShareBtnClickLog()
		{
		}

		// Token: 0x06009406 RID: 37894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009406")]
		[Address(RVA = "0x2189584", Offset = "0x2189584", VA = "0x7BBC989584")]
		private TeammateStats ConstructSelfTeammateData(MatchStats stats)
		{
			return null;
		}

		// Token: 0x06009407 RID: 37895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009407")]
		[Address(RVA = "0x2189F50", Offset = "0x2189F50", VA = "0x7BBC989F50")]
		private FMatchResultPlayerData GetPlayerMatchResultData(ulong accountID)
		{
			return null;
		}

		// Token: 0x06009408 RID: 37896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009408")]
		[Address(RVA = "0x2189FDC", Offset = "0x2189FDC", VA = "0x7BBC989FDC")]
		private void CreatePlayerMatchResultData(ulong accountID, ulong localPlayerID, bool isFriend = false)
		{
		}

		// Token: 0x06009409 RID: 37897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009409")]
		[Address(RVA = "0x218864C", Offset = "0x218864C", VA = "0x7BBC98864C")]
		private void ConstructPlayerMatchResultInfo(MatchStats stats)
		{
		}

		// Token: 0x0600940A RID: 37898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600940A")]
		[Address(RVA = "0x218A1C0", Offset = "0x218A1C0", VA = "0x7BBC98A1C0")]
		public UIProfileBRMatchResultController()
		{
		}

		// Token: 0x04009DCC RID: 40396
		[Token(Token = "0x4009DCC")]
		[FieldOffset(Offset = "0x98")]
		private UIProfileBRMatchResultView m_View;

		// Token: 0x04009DCD RID: 40397
		[Token(Token = "0x4009DCD")]
		[FieldOffset(Offset = "0xA0")]
		private List<EMatchResultPlayerInfoType> m_InfoTypeList;

		// Token: 0x04009DCE RID: 40398
		[Token(Token = "0x4009DCE")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<ulong, FMatchResultPlayerData> m_PlayerMatchResultDataMap;

		// Token: 0x04009DCF RID: 40399
		[Token(Token = "0x4009DCF")]
		[FieldOffset(Offset = "0xB0")]
		private MatchStats m_MatchStats;

		// Token: 0x04009DD0 RID: 40400
		[Token(Token = "0x4009DD0")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_SHowFastGift;

		// Token: 0x02001B1A RID: 6938
		[Token(Token = "0x2001B1A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F947C", Offset = "0x10F947C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600940C RID: 37900 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600940C")]
			[Address(RVA = "0x218A22C", Offset = "0x218A22C", VA = "0x7BBC98A22C")]
			public <>c()
			{
			}

			// Token: 0x0600940D RID: 37901 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600940D")]
			[Address(RVA = "0x218A234", Offset = "0x218A234", VA = "0x7BBC98A234")]
			internal FriendInfo <OnFastGiftClick>b__17_0(TeammateStats teamMate)
			{
				return null;
			}

			// Token: 0x04009DD1 RID: 40401
			[Token(Token = "0x4009DD1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIProfileBRMatchResultController.<>c <>9;

			// Token: 0x04009DD2 RID: 40402
			[Token(Token = "0x4009DD2")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<TeammateStats, FriendInfo> <>9__17_0;
		}
	}
}
