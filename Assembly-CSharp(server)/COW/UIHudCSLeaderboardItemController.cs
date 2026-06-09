using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020014BA RID: 5306
	[Token(Token = "0x20014BA")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10ED6CC", Offset = "0x10ED6CC")]
	internal class UIHudCSLeaderboardItemController : UIHUDTeamBattleScoreBoardItemController
	{
		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06005A23 RID: 23075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A4")]
		public LeaderboardData DataInfo
		{
			[Token(Token = "0x6005A23")]
			[Address(RVA = "0x19BE748", Offset = "0x19BE748", VA = "0x7BBC1BE748")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005A24 RID: 23076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A24")]
		[Address(RVA = "0x19BE750", Offset = "0x19BE750", VA = "0x7BBC1BE750", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x06005A25 RID: 23077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A25")]
		[Address(RVA = "0x19BE7BC", Offset = "0x19BE7BC", VA = "0x7BBC1BE7BC", Slot = "28")]
		protected override void OnInitData(Player player)
		{
		}

		// Token: 0x06005A26 RID: 23078 RVA: 0x0001A880 File Offset: 0x00018A80
		[Token(Token = "0x6005A26")]
		[Address(RVA = "0x19BEA20", Offset = "0x19BEA20", VA = "0x7BBC1BEA20")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x06005A27 RID: 23079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A27")]
		[Address(RVA = "0x19BEA70", Offset = "0x19BEA70", VA = "0x7BBC1BEA70", Slot = "30")]
		protected override void OnKillChange(int kill)
		{
		}

		// Token: 0x06005A28 RID: 23080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A28")]
		[Address(RVA = "0x19BEAA4", Offset = "0x19BEAA4", VA = "0x7BBC1BEAA4", Slot = "31")]
		protected override void OnDeadChange(int dead)
		{
		}

		// Token: 0x06005A29 RID: 23081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A29")]
		[Address(RVA = "0x19BEAE0", Offset = "0x19BEAE0", VA = "0x7BBC1BEAE0", Slot = "32")]
		protected override void OnDamageChange(uint damage)
		{
		}

		// Token: 0x06005A2A RID: 23082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A2A")]
		[Address(RVA = "0x19BE8DC", Offset = "0x19BE8DC", VA = "0x7BBC1BE8DC")]
		public void SetRankInfo(int rankLevel)
		{
		}

		// Token: 0x06005A2B RID: 23083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A2B")]
		[Address(RVA = "0x19BEB1C", Offset = "0x19BEB1C", VA = "0x7BBC1BEB1C")]
		public UIHudCSLeaderboardItemController()
		{
		}

		// Token: 0x04007D40 RID: 32064
		[Token(Token = "0x4007D40")]
		[FieldOffset(Offset = "0x78")]
		private LeaderboardData m_Data;
	}
}
