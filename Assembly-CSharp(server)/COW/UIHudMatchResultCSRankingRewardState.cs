using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x020015D0 RID: 5584
	[Token(Token = "0x20015D0")]
	public class UIHudMatchResultCSRankingRewardState : UIHudMatchResultStateBase
	{
		// Token: 0x060062EF RID: 25327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062EF")]
		[Address(RVA = "0x15CD970", Offset = "0x15CD970", VA = "0x7BBBDCD970")]
		public UIHudMatchResultCSRankingRewardState(UIHudMatchResultStateMachine machine)
		{
		}

		// Token: 0x060062F0 RID: 25328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062F0")]
		[Address(RVA = "0x15CD9F4", Offset = "0x15CD9F4", VA = "0x7BBBDCD9F4", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x060062F1 RID: 25329 RVA: 0x0001C7E8 File Offset: 0x0001A9E8
		[Token(Token = "0x60062F1")]
		[Address(RVA = "0x15CDB80", Offset = "0x15CDB80", VA = "0x7BBBDCDB80", Slot = "5")]
		protected override bool OnCheck()
		{
			return default(bool);
		}

		// Token: 0x060062F2 RID: 25330 RVA: 0x0001C800 File Offset: 0x0001AA00
		[Token(Token = "0x60062F2")]
		[Address(RVA = "0x15CDBEC", Offset = "0x15CDBEC", VA = "0x7BBBDCDBEC", Slot = "6")]
		protected override bool OnEnter()
		{
			return default(bool);
		}

		// Token: 0x060062F3 RID: 25331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062F3")]
		[Address(RVA = "0x15CE1AC", Offset = "0x15CE1AC", VA = "0x7BBBDCE1AC", Slot = "7")]
		protected override void OnFinish()
		{
		}

		// Token: 0x060062F4 RID: 25332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062F4")]
		[Address(RVA = "0x15CE250", Offset = "0x15CE250", VA = "0x7BBBDCE250", Slot = "8")]
		protected override void OnExit()
		{
		}

		// Token: 0x040081CF RID: 33231
		[Token(Token = "0x40081CF")]
		[FieldOffset(Offset = "0x20")]
		private List<CSRankData> m_CSRankUpRewardList;

		// Token: 0x020015D1 RID: 5585
		[Token(Token = "0x20015D1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EF46C", Offset = "0x10EF46C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060062F6 RID: 25334 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062F6")]
			[Address(RVA = "0x15CE320", Offset = "0x15CE320", VA = "0x7BBBDCE320")]
			public <>c()
			{
			}

			// Token: 0x060062F7 RID: 25335 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60062F7")]
			[Address(RVA = "0x15CE328", Offset = "0x15CE328", VA = "0x7BBBDCE328")]
			internal void <OnEnter>b__4_0()
			{
			}

			// Token: 0x060062F8 RID: 25336 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60062F8")]
			[Address(RVA = "0x15CE44C", Offset = "0x15CE44C", VA = "0x7BBBDCE44C")]
			internal BaseItemInfo <OnEnter>b__4_1(AwardDesc item)
			{
				return null;
			}

			// Token: 0x060062F9 RID: 25337 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60062F9")]
			[Address(RVA = "0x15CE4B4", Offset = "0x15CE4B4", VA = "0x7BBBDCE4B4")]
			internal CommonRewardItemInfo <OnEnter>b__4_2(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x040081D0 RID: 33232
			[Token(Token = "0x40081D0")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHudMatchResultCSRankingRewardState.<>c <>9;

			// Token: 0x040081D1 RID: 33233
			[Token(Token = "0x40081D1")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__4_0;

			// Token: 0x040081D2 RID: 33234
			[Token(Token = "0x40081D2")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<AwardDesc, BaseItemInfo> <>9__4_1;

			// Token: 0x040081D3 RID: 33235
			[Token(Token = "0x40081D3")]
			[FieldOffset(Offset = "0x18")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__4_2;
		}
	}
}
