using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020015D4 RID: 5588
	[Token(Token = "0x20015D4")]
	public class UIHudMatchResultItemRewardState : UIHudMatchResultStateBase
	{
		// Token: 0x06006302 RID: 25346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006302")]
		[Address(RVA = "0x17AAF48", Offset = "0x17AAF48", VA = "0x7BBBFAAF48")]
		public UIHudMatchResultItemRewardState(UIHudMatchResultStateMachine machine)
		{
		}

		// Token: 0x06006303 RID: 25347 RVA: 0x0001C878 File Offset: 0x0001AA78
		[Token(Token = "0x6006303")]
		[Address(RVA = "0x17AB000", Offset = "0x17AB000", VA = "0x7BBBFAB000", Slot = "5")]
		protected override bool OnCheck()
		{
			return default(bool);
		}

		// Token: 0x06006304 RID: 25348 RVA: 0x0001C890 File Offset: 0x0001AA90
		[Token(Token = "0x6006304")]
		[Address(RVA = "0x17AB908", Offset = "0x17AB908", VA = "0x7BBBFAB908", Slot = "6")]
		protected override bool OnEnter()
		{
			return default(bool);
		}

		// Token: 0x06006305 RID: 25349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006305")]
		[Address(RVA = "0x17ABC1C", Offset = "0x17ABC1C", VA = "0x7BBBFABC1C", Slot = "7")]
		protected override void OnFinish()
		{
		}

		// Token: 0x06006306 RID: 25350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006306")]
		[Address(RVA = "0x17ABC4C", Offset = "0x17ABC4C", VA = "0x7BBBFABC4C", Slot = "8")]
		protected override void OnExit()
		{
		}

		// Token: 0x040081D7 RID: 33239
		[Token(Token = "0x40081D7")]
		[FieldOffset(Offset = "0x20")]
		private List<BaseItemInfo> m_DebrisList;

		// Token: 0x040081D8 RID: 33240
		[Token(Token = "0x40081D8")]
		[FieldOffset(Offset = "0x28")]
		private List<BaseItemInfo> m_CommonList;

		// Token: 0x020015D5 RID: 5589
		[Token(Token = "0x20015D5")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EF47C", Offset = "0x10EF47C")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06006308 RID: 25352 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006308")]
			[Address(RVA = "0x17ABD38", Offset = "0x17ABD38", VA = "0x7BBBFABD38")]
			public <>c()
			{
			}

			// Token: 0x06006309 RID: 25353 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006309")]
			[Address(RVA = "0x17ABD40", Offset = "0x17ABD40", VA = "0x7BBBFABD40")]
			internal CommonRewardItemInfo <OnEnter>b__4_0(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x0600630A RID: 25354 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600630A")]
			[Address(RVA = "0x17ABD4C", Offset = "0x17ABD4C", VA = "0x7BBBFABD4C")]
			internal CommonRewardItemInfo <OnEnter>b__4_1(BaseItemInfo item)
			{
				return null;
			}

			// Token: 0x040081D9 RID: 33241
			[Token(Token = "0x40081D9")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIHudMatchResultItemRewardState.<>c <>9;

			// Token: 0x040081DA RID: 33242
			[Token(Token = "0x40081DA")]
			[FieldOffset(Offset = "0x8")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__4_0;

			// Token: 0x040081DB RID: 33243
			[Token(Token = "0x40081DB")]
			[FieldOffset(Offset = "0x10")]
			public static Converter<BaseItemInfo, CommonRewardItemInfo> <>9__4_1;
		}
	}
}
