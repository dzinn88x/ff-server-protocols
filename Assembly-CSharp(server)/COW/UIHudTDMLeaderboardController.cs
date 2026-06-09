using System;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x0200196D RID: 6509
	[Token(Token = "0x200196D")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x10F645C", Offset = "0x10F645C")]
	internal class UIHudTDMLeaderboardController : UIHUDTeamBattleScoreBoardController<UIHudCSLeaderboardItemController>
	{
		// Token: 0x0600846B RID: 33899 RVA: 0x00023F10 File Offset: 0x00022110
		[Token(Token = "0x600846B")]
		[Address(RVA = "0x1676EFC", Offset = "0x1676EFC", VA = "0x7BBBE76EFC")]
		public new static ResourceID GetResourceID()
		{
			return default(ResourceID);
		}

		// Token: 0x0600846C RID: 33900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600846C")]
		[Address(RVA = "0x1676F4C", Offset = "0x1676F4C", VA = "0x7BBBE76F4C", Slot = "13")]
		protected override void OnUIInit()
		{
		}

		// Token: 0x0600846D RID: 33901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600846D")]
		[Address(RVA = "0x1676FCC", Offset = "0x1676FCC", VA = "0x7BBBE76FCC", Slot = "28")]
		protected override void SetInfoType()
		{
		}

		// Token: 0x0600846E RID: 33902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600846E")]
		[Address(RVA = "0x16770C4", Offset = "0x16770C4", VA = "0x7BBBE770C4", Slot = "30")]
		public override void RegisterUIEvent()
		{
		}

		// Token: 0x0600846F RID: 33903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600846F")]
		[Address(RVA = "0x1677340", Offset = "0x1677340", VA = "0x7BBBE77340", Slot = "31")]
		public override void UnRegisterUIEvent()
		{
		}

		// Token: 0x06008470 RID: 33904 RVA: 0x00023F28 File Offset: 0x00022128
		[Token(Token = "0x6008470")]
		[Address(RVA = "0x16775BC", Offset = "0x16775BC", VA = "0x7BBBE775BC", Slot = "34")]
		protected override bool IsTeamOnLeft({QAb\u0082~u pId)
		{
			return default(bool);
		}

		// Token: 0x06008471 RID: 33905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008471")]
		[Address(RVA = "0x16776E8", Offset = "0x16776E8", VA = "0x7BBBE776E8")]
		private void Sort({QAb\u0082~u pId)
		{
		}

		// Token: 0x06008472 RID: 33906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008472")]
		[Address(RVA = "0x1677858", Offset = "0x1677858", VA = "0x7BBBE77858", Slot = "37")]
		protected override void OnKillCountChanged(params object[] param)
		{
		}

		// Token: 0x06008473 RID: 33907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008473")]
		[Address(RVA = "0x1677924", Offset = "0x1677924", VA = "0x7BBBE77924", Slot = "38")]
		protected override void OnDeadCountChanged(params object[] param)
		{
		}

		// Token: 0x06008474 RID: 33908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008474")]
		[Address(RVA = "0x16779F0", Offset = "0x16779F0", VA = "0x7BBBE779F0", Slot = "39")]
		protected override void OnTotalDamageChanged(params object[] param)
		{
		}

		// Token: 0x06008475 RID: 33909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008475")]
		[Address(RVA = "0x1677ABC", Offset = "0x1677ABC", VA = "0x7BBBE77ABC")]
		private void OnCSNewPhaseStarted(params object[] param)
		{
		}

		// Token: 0x06008476 RID: 33910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008476")]
		[Address(RVA = "0x1677B70", Offset = "0x1677B70", VA = "0x7BBBE77B70")]
		private void OnToggleRoundInfo(params object[] parap)
		{
		}

		// Token: 0x06008477 RID: 33911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008477")]
		[Address(RVA = "0x1677BCC", Offset = "0x1677BCC", VA = "0x7BBBE77BCC", Slot = "19")]
		protected override void OnVisibilityChanged()
		{
		}

		// Token: 0x06008478 RID: 33912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008478")]
		[Address(RVA = "0x1677C68", Offset = "0x1677C68", VA = "0x7BBBE77C68")]
		private void OnTeamScoreChange(params object[] data)
		{
		}

		// Token: 0x06008479 RID: 33913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008479")]
		[Address(RVA = "0x1677D24", Offset = "0x1677D24", VA = "0x7BBBE77D24")]
		private void UpdateTeamScore(int teamIndex, int score)
		{
		}

		// Token: 0x0600847A RID: 33914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600847A")]
		[Address(RVA = "0x1677D9C", Offset = "0x1677D9C", VA = "0x7BBBE77D9C")]
		public UIHudTDMLeaderboardController()
		{
		}

		// Token: 0x0200196E RID: 6510
		[Token(Token = "0x200196E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10F6494", Offset = "0x10F6494")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600847C RID: 33916 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600847C")]
			[Address(RVA = "0x1677E50", Offset = "0x1677E50", VA = "0x7BBBE77E50")]
			public <>c()
			{
			}

			// Token: 0x0600847D RID: 33917 RVA: 0x00023F40 File Offset: 0x00022140
			[Token(Token = "0x600847D")]
			[Address(RVA = "0x1677E58", Offset = "0x1677E58", VA = "0x7BBBE77E58")]
			internal int <Sort>b__6_0(Transform item2, Transform item1)
			{
				return 0;
			}

			// Token: 0x040094B4 RID: 38068
			[Token(Token = "0x40094B4")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHudTDMLeaderboardController.<>c <>9;

			// Token: 0x040094B5 RID: 38069
			[Token(Token = "0x40094B5")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<Transform> <>9__6_0;
		}
	}
}
