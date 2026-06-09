using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014C8 RID: 5320
	[Token(Token = "0x20014C8")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED8AC", Offset = "0x10ED8AC")]
	internal class UIHudLeaderboardItemController : UIBaseController
	{
		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06005A8E RID: 23182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A6")]
		public LeaderboardData DataInfo
		{
			[Token(Token = "0x6005A8E")]
			[Address(RVA = "0x15BA580", Offset = "0x15BA580", VA = "0x7BBBDBA580")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005A8F RID: 23183 RVA: 0x0001A988 File Offset: 0x00018B88
		[Token(Token = "0x6005A8F")]
		[Address(RVA = "0x15BA588", Offset = "0x15BA588", VA = "0x7BBBDBA588")]
		public static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005A90 RID: 23184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A90")]
		[Address(RVA = "0x15BA5D8", Offset = "0x15BA5D8", VA = "0x7BBBDBA5D8", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005A91 RID: 23185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A91")]
		[Address(RVA = "0x15B9590", Offset = "0x15B9590", VA = "0x7BBBDB9590")]
		public void SetRankInfo(int rankLevel)
		{
		}

		// Token: 0x06005A92 RID: 23186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A92")]
		[Address(RVA = "0x15B96D4", Offset = "0x15B96D4", VA = "0x7BBBDB96D4")]
		public void SetRole(uint role)
		{
		}

		// Token: 0x06005A93 RID: 23187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A93")]
		[Address(RVA = "0x15BA740", Offset = "0x15BA740", VA = "0x7BBBDBA740")]
		private void UpdateHeadIcon()
		{
		}

		// Token: 0x06005A94 RID: 23188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A94")]
		[Address(RVA = "0x15B94BC", Offset = "0x15B94BC", VA = "0x7BBBDB94BC")]
		public void SetDataInfo(LeaderboardData dataInfo)
		{
		}

		// Token: 0x06005A95 RID: 23189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A95")]
		[Address(RVA = "0x15BA6B8", Offset = "0x15BA6B8", VA = "0x7BBBDBA6B8")]
		private void SetBackground(bool isLocalPlayer)
		{
		}

		// Token: 0x06005A96 RID: 23190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A96")]
		[Address(RVA = "0x15B9A70", Offset = "0x15B9A70", VA = "0x7BBBDB9A70")]
		public void SetKillCount(int k)
		{
		}

		// Token: 0x06005A97 RID: 23191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A97")]
		[Address(RVA = "0x15B9C48", Offset = "0x15B9C48", VA = "0x7BBBDB9C48")]
		public void SetDeadCount(int d)
		{
		}

		// Token: 0x06005A98 RID: 23192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A98")]
		[Address(RVA = "0x15B9E20", Offset = "0x15B9E20", VA = "0x7BBBDB9E20")]
		public void SetAssistCount(int a)
		{
		}

		// Token: 0x06005A99 RID: 23193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A99")]
		[Address(RVA = "0x15B9FF8", Offset = "0x15B9FF8", VA = "0x7BBBDB9FF8")]
		public void SetTotalDamage(int dmg)
		{
		}

		// Token: 0x06005A9A RID: 23194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A9A")]
		[Address(RVA = "0x15BA894", Offset = "0x15BA894", VA = "0x7BBBDBA894")]
		public UIHudLeaderboardItemController()
		{
		}

		// Token: 0x04007D7A RID: 32122
		[Token(Token = "0x4007D7A")]
		[FieldOffset(Offset = "0x58")]
		private UIHudLeaderboardItemView m_View;

		// Token: 0x04007D7B RID: 32123
		[Token(Token = "0x4007D7B")]
		[FieldOffset(Offset = "0x60")]
		private LeaderboardData m_DataInfo;
	}
}
