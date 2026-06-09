using System;
using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.Gameplay
{
	// Token: 0x020026A3 RID: 9891
	[Token(Token = "0x20026A3")]
	internal class PlayerArmsRace : PlayerNetwork
	{
		// Token: 0x0600CCF8 RID: 52472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCF8")]
		[Address(RVA = "0x1B82310", Offset = "0x1B82310", VA = "0x7BBC382310", Slot = "20")]
		protected override void OnUserDefineReplicationInfo()
		{
		}

		// Token: 0x0600CCF9 RID: 52473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCF9")]
		[Address(RVA = "0x1B82578", Offset = "0x1B82578", VA = "0x7BBC382578")]
		private void OnPlayerLevelAndPointsChange(ushort oldValue, ushort newValue)
		{
		}

		// Token: 0x0600CCFA RID: 52474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCFA")]
		[Address(RVA = "0x1B82C90", Offset = "0x1B82C90", VA = "0x7BBC382C90")]
		private void OnPlayerRankChange(byte oldValue, byte newValue)
		{
		}

		// Token: 0x0600CCFB RID: 52475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCFB")]
		[Address(RVA = "0x1B82DB8", Offset = "0x1B82DB8", VA = "0x7BBC382DB8")]
		private void OnPlayerIsLeaderChange(bool oldValue, bool newValue)
		{
		}

		// Token: 0x0600CCFC RID: 52476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCFC")]
		[Address(RVA = "0x1B830D4", Offset = "0x1B830D4", VA = "0x7BBC3830D4")]
		private void OnOpponentLevelChange(byte oldLevel, byte newLevel)
		{
		}

		// Token: 0x0600CCFD RID: 52477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCFD")]
		[Address(RVA = "0x1B829FC", Offset = "0x1B829FC", VA = "0x7BBC3829FC")]
		private void UpdateMatchModeLocalPlayerArmsLevel(int level)
		{
		}

		// Token: 0x0600CCFE RID: 52478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCFE")]
		[Address(RVA = "0x1B83214", Offset = "0x1B83214", VA = "0x7BBC383214")]
		private void UpdateMatchModeOpponentArmsLevel(int level)
		{
		}

		// Token: 0x0600CCFF RID: 52479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCFF")]
		[Address(RVA = "0x1B833B4", Offset = "0x1B833B4", VA = "0x7BBC3833B4")]
		public PlayerArmsRace()
		{
		}

		// Token: 0x040100AB RID: 65707
		[Token(Token = "0x40100AB")]
		[FieldOffset(Offset = "0xB30")]
		private UIModelMatch m_UIModelMatch;

		// Token: 0x040100AC RID: 65708
		[Token(Token = "0x40100AC")]
		[FieldOffset(Offset = "0xB38")]
		private GameObject m_LeaderIcon;
	}
}
