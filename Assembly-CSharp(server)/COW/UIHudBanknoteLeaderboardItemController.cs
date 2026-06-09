using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001875 RID: 6261
	[Token(Token = "0x2001875")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F422C", Offset = "0x10F422C")]
	internal class UIHudBanknoteLeaderboardItemController : UIBaseController
	{
		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06007BA9 RID: 31657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000984")]
		public LeaderboardData DataInfo
		{
			[Token(Token = "0x6007BA9")]
			[Address(RVA = "0x188E2BC", Offset = "0x188E2BC", VA = "0x7BBC08E2BC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007BAA RID: 31658 RVA: 0x00021FA8 File Offset: 0x000201A8
		[Token(Token = "0x6007BAA")]
		[Address(RVA = "0x188E2C4", Offset = "0x188E2C4", VA = "0x7BBC08E2C4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06007BAB RID: 31659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BAB")]
		[Address(RVA = "0x188E314", Offset = "0x188E314", VA = "0x7BBC08E314", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06007BAC RID: 31660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BAC")]
		[Address(RVA = "0x188D8B4", Offset = "0x188D8B4", VA = "0x7BBC08D8B4")]
		public void SetTypes(EMatchResultPlayerInfoType type1, EMatchResultPlayerInfoType type2, EMatchResultPlayerInfoType type3)
		{
		}

		// Token: 0x06007BAD RID: 31661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BAD")]
		[Address(RVA = "0x188E48C", Offset = "0x188E48C", VA = "0x7BBC08E48C")]
		public void SetDetailData(EMatchResultPlayerInfoType type, string text)
		{
		}

		// Token: 0x06007BAE RID: 31662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BAE")]
		[Address(RVA = "0x188D9B8", Offset = "0x188D9B8", VA = "0x7BBC08D9B8")]
		public void SetRankInfo(int rankLevel)
		{
		}

		// Token: 0x06007BAF RID: 31663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BAF")]
		[Address(RVA = "0x188D7E0", Offset = "0x188D7E0", VA = "0x7BBC08D7E0")]
		public void SetDataInfo(LeaderboardData dataInfo)
		{
		}

		// Token: 0x06007BB0 RID: 31664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BB0")]
		[Address(RVA = "0x188E404", Offset = "0x188E404", VA = "0x7BBC08E404")]
		private void SetBackground(bool isLocalPlayer)
		{
		}

		// Token: 0x06007BB1 RID: 31665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BB1")]
		[Address(RVA = "0x188DC30", Offset = "0x188DC30", VA = "0x7BBC08DC30")]
		public void SetKillCount(int k)
		{
		}

		// Token: 0x06007BB2 RID: 31666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BB2")]
		[Address(RVA = "0x188DDC8", Offset = "0x188DDC8", VA = "0x7BBC08DDC8")]
		public void SetDMG(int k)
		{
		}

		// Token: 0x06007BB3 RID: 31667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BB3")]
		[Address(RVA = "0x188E538", Offset = "0x188E538", VA = "0x7BBC08E538")]
		public void SetBuffCount(int d)
		{
		}

		// Token: 0x06007BB4 RID: 31668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BB4")]
		[Address(RVA = "0x188E574", Offset = "0x188E574", VA = "0x7BBC08E574")]
		public void SetOnTimeZone(int a)
		{
		}

		// Token: 0x06007BB5 RID: 31669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BB5")]
		[Address(RVA = "0x188E018", Offset = "0x188E018", VA = "0x7BBC08E018")]
		public void SetCapePointCount(int a)
		{
		}

		// Token: 0x06007BB6 RID: 31670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007BB6")]
		[Address(RVA = "0x188E65C", Offset = "0x188E65C", VA = "0x7BBC08E65C")]
		public UIHudBanknoteLeaderboardItemController()
		{
		}

		// Token: 0x04009011 RID: 36881
		[Token(Token = "0x4009011")]
		[FieldOffset(Offset = "0x58")]
		private UIHudControlLeaderboardItemView m_View;

		// Token: 0x04009012 RID: 36882
		[Token(Token = "0x4009012")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<EMatchResultPlayerInfoType, UILabel> m_Type2Label;

		// Token: 0x04009013 RID: 36883
		[Token(Token = "0x4009013")]
		[FieldOffset(Offset = "0x68")]
		private LeaderboardData m_DataInfo;
	}
}
