using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001896 RID: 6294
	[Token(Token = "0x2001896")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F46BC", Offset = "0x10F46BC")]
	internal class UIHudControlLeaderboardItemController : UIBaseController
	{
		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06007CB6 RID: 31926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700098C")]
		public LeaderboardData DataInfo
		{
			[Token(Token = "0x6007CB6")]
			[Address(RVA = "0x1A92CAC", Offset = "0x1A92CAC", VA = "0x7BBC292CAC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007CB7 RID: 31927 RVA: 0x000223F8 File Offset: 0x000205F8
		[Token(Token = "0x6007CB7")]
		[Address(RVA = "0x1A92CB4", Offset = "0x1A92CB4", VA = "0x7BBC292CB4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007CB8 RID: 31928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CB8")]
		[Address(RVA = "0x1A92D04", Offset = "0x1A92D04", VA = "0x7BBC292D04", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007CB9 RID: 31929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CB9")]
		[Address(RVA = "0x1A92F28", Offset = "0x1A92F28", VA = "0x7BBC292F28")]
		public void SetTypes(EMatchResultPlayerInfoType type1, EMatchResultPlayerInfoType type2, EMatchResultPlayerInfoType type3)
		{
		}

		// Token: 0x06007CBA RID: 31930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CBA")]
		[Address(RVA = "0x1A92E7C", Offset = "0x1A92E7C", VA = "0x7BBC292E7C")]
		public void SetDetailData(EMatchResultPlayerInfoType type, string text)
		{
		}

		// Token: 0x06007CBB RID: 31931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CBB")]
		[Address(RVA = "0x1A9302C", Offset = "0x1A9302C", VA = "0x7BBC29302C")]
		public void SetRankInfo(int rankLevel)
		{
		}

		// Token: 0x06007CBC RID: 31932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CBC")]
		[Address(RVA = "0x1A93168", Offset = "0x1A93168", VA = "0x7BBC293168")]
		public void SetDataInfo(LeaderboardData dataInfo)
		{
		}

		// Token: 0x06007CBD RID: 31933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CBD")]
		[Address(RVA = "0x1A92DF4", Offset = "0x1A92DF4", VA = "0x7BBC292DF4")]
		private void SetBackground(bool isLocalPlayer)
		{
		}

		// Token: 0x06007CBE RID: 31934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CBE")]
		[Address(RVA = "0x1A9323C", Offset = "0x1A9323C", VA = "0x7BBC29323C")]
		public void SetKillCount(int k)
		{
		}

		// Token: 0x06007CBF RID: 31935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CBF")]
		[Address(RVA = "0x1A93298", Offset = "0x1A93298", VA = "0x7BBC293298")]
		public void SetDMG(int k)
		{
		}

		// Token: 0x06007CC0 RID: 31936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CC0")]
		[Address(RVA = "0x1A932F4", Offset = "0x1A932F4", VA = "0x7BBC2932F4")]
		public void SetBuffCount(int d)
		{
		}

		// Token: 0x06007CC1 RID: 31937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CC1")]
		[Address(RVA = "0x1A93330", Offset = "0x1A93330", VA = "0x7BBC293330")]
		public void SetOnTimeZone(int a)
		{
		}

		// Token: 0x06007CC2 RID: 31938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CC2")]
		[Address(RVA = "0x1A93418", Offset = "0x1A93418", VA = "0x7BBC293418")]
		public void SetCapePointCount(int a)
		{
		}

		// Token: 0x06007CC3 RID: 31939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007CC3")]
		[Address(RVA = "0x1A93474", Offset = "0x1A93474", VA = "0x7BBC293474")]
		public UIHudControlLeaderboardItemController()
		{
		}

		// Token: 0x0400907D RID: 36989
		[Token(Token = "0x400907D")]
		[FieldOffset(Offset = "0x58")]
		private UIHudControlLeaderboardItemView m_View;

		// Token: 0x0400907E RID: 36990
		[Token(Token = "0x400907E")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<EMatchResultPlayerInfoType, UILabel> m_Type2Label;

		// Token: 0x0400907F RID: 36991
		[Token(Token = "0x400907F")]
		[FieldOffset(Offset = "0x68")]
		private LeaderboardData m_DataInfo;
	}
}
