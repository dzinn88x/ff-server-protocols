using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001A76 RID: 6774
	[Token(Token = "0x2001A76")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F8364", Offset = "0x10F8364")]
	public class UIMatchZombieResultInfoItemController : UIBaseController
	{
		// Token: 0x06008EAE RID: 36526 RVA: 0x000260B8 File Offset: 0x000242B8
		[Token(Token = "0x6008EAE")]
		[Address(RVA = "0x14829F4", Offset = "0x14829F4", VA = "0x7BBBC829F4")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06008EAF RID: 36527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EAF")]
		[Address(RVA = "0x1482A44", Offset = "0x1482A44", VA = "0x7BBBC82A44", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06008EB0 RID: 36528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EB0")]
		[Address(RVA = "0x1482C60", Offset = "0x1482C60", VA = "0x7BBBC82C60")]
		public void SetPlayerData(MatchStats statsData, MatchIncome incomeData, bool isMVP, uint all_damage)
		{
		}

		// Token: 0x06008EB1 RID: 36529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EB1")]
		[Address(RVA = "0x1483278", Offset = "0x1483278", VA = "0x7BBBC83278")]
		public void SetCustomRoomPlayerData(MatchStats statsData, bool isMVP, uint all_damage)
		{
		}

		// Token: 0x06008EB2 RID: 36530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EB2")]
		[Address(RVA = "0x1483730", Offset = "0x1483730", VA = "0x7BBBC83730")]
		public void SetTeammateData(TeammateStats data, bool last, bool isMVP, uint all_damage)
		{
		}

		// Token: 0x06008EB3 RID: 36531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EB3")]
		[Address(RVA = "0x1483228", Offset = "0x1483228", VA = "0x7BBBC83228")]
		private void ShowMVPIcon()
		{
		}

		// Token: 0x06008EB4 RID: 36532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EB4")]
		[Address(RVA = "0x148318C", Offset = "0x148318C", VA = "0x7BBBC8318C")]
		private void HideItems(bool isTeammate, bool showPointsRaceStar = false)
		{
		}

		// Token: 0x06008EB5 RID: 36533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EB5")]
		[Address(RVA = "0x1483CDC", Offset = "0x1483CDC", VA = "0x7BBBC83CDC")]
		private void OnAddBtnClick()
		{
		}

		// Token: 0x06008EB6 RID: 36534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EB6")]
		[Address(RVA = "0x1483E4C", Offset = "0x1483E4C", VA = "0x7BBBC83E4C")]
		private void OnExpBonusClick()
		{
		}

		// Token: 0x06008EB7 RID: 36535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EB7")]
		[Address(RVA = "0x1484084", Offset = "0x1484084", VA = "0x7BBBC84084")]
		private void OnGoldBonusClick()
		{
		}

		// Token: 0x06008EB8 RID: 36536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008EB8")]
		[Address(RVA = "0x14842BC", Offset = "0x14842BC", VA = "0x7BBBC842BC")]
		public UIMatchZombieResultInfoItemController()
		{
		}

		// Token: 0x04009A4D RID: 39501
		[Token(Token = "0x4009A4D")]
		[FieldOffset(Offset = "0x58")]
		private UIMatchZombieResultInfoItemView m_View;

		// Token: 0x04009A4E RID: 39502
		[Token(Token = "0x4009A4E")]
		[FieldOffset(Offset = "0x60")]
		private UIBaseProfileInfoController m_Profile;

		// Token: 0x04009A4F RID: 39503
		[Token(Token = "0x4009A4F")]
		[FieldOffset(Offset = "0x68")]
		private UIBriefProfileInfoController m_BriefProfile;

		// Token: 0x04009A50 RID: 39504
		[Token(Token = "0x4009A50")]
		[FieldOffset(Offset = "0x70")]
		private int m_GoldBonus;

		// Token: 0x04009A51 RID: 39505
		[Token(Token = "0x4009A51")]
		[FieldOffset(Offset = "0x74")]
		private int m_ExpBonus;

		// Token: 0x04009A52 RID: 39506
		[Token(Token = "0x4009A52")]
		[FieldOffset(Offset = "0x78")]
		private ulong m_accountID;

		// Token: 0x04009A53 RID: 39507
		[Token(Token = "0x4009A53")]
		[FieldOffset(Offset = "0x80")]
		protected bool m_isMVP;
	}
}
