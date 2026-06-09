using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020015D7 RID: 5591
	[Token(Token = "0x20015D7")]
	public class UIHudMatchResultRankingRewardState : UIHudMatchResultStateBase
	{
		// Token: 0x06006311 RID: 25361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006311")]
		[Address(RVA = "0x17AE1EC", Offset = "0x17AE1EC", VA = "0x7BBBFAE1EC")]
		public UIHudMatchResultRankingRewardState(UIHudMatchResultStateMachine machine)
		{
		}

		// Token: 0x06006312 RID: 25362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006312")]
		[Address(RVA = "0x17AE284", Offset = "0x17AE284", VA = "0x7BBBFAE284", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06006313 RID: 25363 RVA: 0x0001C8F0 File Offset: 0x0001AAF0
		[Token(Token = "0x6006313")]
		[Address(RVA = "0x17AE3E8", Offset = "0x17AE3E8", VA = "0x7BBBFAE3E8", Slot = "5")]
		protected override bool OnCheck()
		{
			return default(bool);
		}

		// Token: 0x06006314 RID: 25364 RVA: 0x0001C908 File Offset: 0x0001AB08
		[Token(Token = "0x6006314")]
		[Address(RVA = "0x17AE454", Offset = "0x17AE454", VA = "0x7BBBFAE454", Slot = "6")]
		protected override bool OnEnter()
		{
			return default(bool);
		}

		// Token: 0x06006315 RID: 25365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006315")]
		[Address(RVA = "0x17AE91C", Offset = "0x17AE91C", VA = "0x7BBBFAE91C", Slot = "7")]
		protected override void OnFinish()
		{
		}

		// Token: 0x06006316 RID: 25366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006316")]
		[Address(RVA = "0x17AEA08", Offset = "0x17AEA08", VA = "0x7BBBFAEA08", Slot = "8")]
		protected override void OnExit()
		{
		}

		// Token: 0x040081DD RID: 33245
		[Token(Token = "0x40081DD")]
		[FieldOffset(Offset = "0x20")]
		private List<LadderLevelData> m_RankUpRewardList;

		// Token: 0x020015D8 RID: 5592
		[Token(Token = "0x20015D8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EF48C", Offset = "0x10EF48C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006318 RID: 25368 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006318")]
			[Address(RVA = "0x17AEACC", Offset = "0x17AEACC", VA = "0x7BBBFAEACC")]
			public <>c()
			{
			}

			// Token: 0x06006319 RID: 25369 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006319")]
			[Address(RVA = "0x17AEAD4", Offset = "0x17AEAD4", VA = "0x7BBBFAEAD4")]
			internal void <OnEnter>b__4_0()
			{
			}

			// Token: 0x0600631A RID: 25370 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600631A")]
			[Address(RVA = "0x17AEBF8", Offset = "0x17AEBF8", VA = "0x7BBBFAEBF8")]
			internal CommonRewardItemInfo <OnEnter>b__4_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x040081DE RID: 33246
			[Token(Token = "0x40081DE")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHudMatchResultRankingRewardState.<>c <>9;

			// Token: 0x040081DF RID: 33247
			[Token(Token = "0x40081DF")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__4_0;

			// Token: 0x040081E0 RID: 33248
			[Token(Token = "0x40081E0")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__4_1;
		}
	}
}
