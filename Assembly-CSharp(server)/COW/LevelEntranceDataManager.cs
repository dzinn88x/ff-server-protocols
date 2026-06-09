using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200111B RID: 4379
	[Token(Token = "0x200111B")]
	public class LevelEntranceDataManager : SingletonModule<LevelEntranceDataManager>
	{
		// Token: 0x06004487 RID: 17543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004487")]
		[Address(RVA = "0x140152C", Offset = "0x140152C", VA = "0x7BBBC0152C", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x06004488 RID: 17544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004488")]
		[Address(RVA = "0x14015E0", Offset = "0x14015E0", VA = "0x7BBBC015E0", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x06004489 RID: 17545 RVA: 0x00015030 File Offset: 0x00013230
		[Token(Token = "0x6004489")]
		[Address(RVA = "0x14015E4", Offset = "0x14015E4", VA = "0x7BBBC015E4")]
		public uint GetLockStatusByEntranceId(uint entranceId, uint curLevel)
		{
			return 0U;
		}

		// Token: 0x0600448A RID: 17546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600448A")]
		[Address(RVA = "0x1401628", Offset = "0x1401628", VA = "0x7BBBC01628")]
		public LevelEntranceData GetEntranceDataByEntranceId(uint entranceId)
		{
			return null;
		}

		// Token: 0x0600448B RID: 17547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600448B")]
		[Address(RVA = "0x1401790", Offset = "0x1401790", VA = "0x7BBBC01790")]
		public LevelEntranceData GetEntranceDataByUnlockLevel(uint unlockLevel)
		{
			return null;
		}

		// Token: 0x0600448C RID: 17548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600448C")]
		[Address(RVA = "0x14018D0", Offset = "0x14018D0", VA = "0x7BBBC018D0")]
		public LevelEntranceData GetEntranceDataByAnnounceLevel(uint announceLevel)
		{
			return null;
		}

		// Token: 0x0600448D RID: 17549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600448D")]
		[Address(RVA = "0x14019FC", Offset = "0x14019FC", VA = "0x7BBBC019FC")]
		public LevelEntranceDataManager()
		{
		}

		// Token: 0x0400548E RID: 21646
		[Token(Token = "0x400548E")]
		[FieldOffset(Offset = "0x18")]
		public List<LevelEntranceData> m_EntranceDataList;

		// Token: 0x0200111C RID: 4380
		[Token(Token = "0x200111C")]
		public enum EntranceIdType
		{
			// Token: 0x04005490 RID: 21648
			[Token(Token = "0x4005490")]
			NewPlayerSignin = 1,
			// Token: 0x04005491 RID: 21649
			[Token(Token = "0x4005491")]
			Avatar,
			// Token: 0x04005492 RID: 21650
			[Token(Token = "0x4005492")]
			LowLoadOut,
			// Token: 0x04005493 RID: 21651
			[Token(Token = "0x4005493")]
			EPContainer,
			// Token: 0x04005494 RID: 21652
			[Token(Token = "0x4005494")]
			Manual,
			// Token: 0x04005495 RID: 21653
			[Token(Token = "0x4005495")]
			Collection,
			// Token: 0x04005496 RID: 21654
			[Token(Token = "0x4005496")]
			HighLoadOut,
			// Token: 0x04005497 RID: 21655
			[Token(Token = "0x4005497")]
			Gacha,
			// Token: 0x04005498 RID: 21656
			[Token(Token = "0x4005498")]
			Pet,
			// Token: 0x04005499 RID: 21657
			[Token(Token = "0x4005499")]
			Championship,
			// Token: 0x0400549A RID: 21658
			[Token(Token = "0x400549A")]
			LobbyClan,
			// Token: 0x0400549B RID: 21659
			[Token(Token = "0x400549B")]
			RankMatch,
			// Token: 0x0400549C RID: 21660
			[Token(Token = "0x400549C")]
			NormalSignIn,
			// Token: 0x0400549D RID: 21661
			[Token(Token = "0x400549D")]
			BindAccount,
			// Token: 0x0400549E RID: 21662
			[Token(Token = "0x400549E")]
			RankLadder,
			// Token: 0x0400549F RID: 21663
			[Token(Token = "0x400549F")]
			Task
		}

		// Token: 0x0200111D RID: 4381
		[Token(Token = "0x200111D")]
		public enum EntranceUnlockType
		{
			// Token: 0x040054A1 RID: 21665
			[Token(Token = "0x40054A1")]
			Level = 1,
			// Token: 0x040054A2 RID: 21666
			[Token(Token = "0x40054A2")]
			Day
		}

		// Token: 0x0200111E RID: 4382
		[Token(Token = "0x200111E")]
		public enum LockStatusType
		{
			// Token: 0x040054A4 RID: 21668
			[Token(Token = "0x40054A4")]
			NoLock,
			// Token: 0x040054A5 RID: 21669
			[Token(Token = "0x40054A5")]
			Locked,
			// Token: 0x040054A6 RID: 21670
			[Token(Token = "0x40054A6")]
			Hided
		}

		// Token: 0x0200111F RID: 4383
		[Token(Token = "0x200111F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAC54", Offset = "0x10EAC54")]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x0600448E RID: 17550 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600448E")]
			[Address(RVA = "0x1401788", Offset = "0x1401788", VA = "0x7BBBC01788")]
			public <>c__DisplayClass7_0()
			{
			}

			// Token: 0x0600448F RID: 17551 RVA: 0x00015048 File Offset: 0x00013248
			[Token(Token = "0x600448F")]
			[Address(RVA = "0x1401A6C", Offset = "0x1401A6C", VA = "0x7BBBC01A6C")]
			internal bool <GetEntranceDataByEntranceId>b__0(LevelEntranceData x)
			{
				return default(bool);
			}

			// Token: 0x040054A7 RID: 21671
			[Token(Token = "0x40054A7")]
			[FieldOffset(Offset = "0x10")]
			public uint entranceId;
		}
	}
}
