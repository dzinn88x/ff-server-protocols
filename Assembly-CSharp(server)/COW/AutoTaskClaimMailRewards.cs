using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using message;
using proto;

namespace COW
{
	// Token: 0x02001329 RID: 4905
	[Token(Token = "0x2001329")]
	internal class AutoTaskClaimMailRewards : AutoPopupTask
	{
		// Token: 0x06004DCA RID: 19914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DCA")]
		[Address(RVA = "0x1557BE4", Offset = "0x1557BE4", VA = "0x7BBBD57BE4", Slot = "4")]
		public override ServiceMessageTypeHTTP[] NeedHttpRequests()
		{
			return null;
		}

		// Token: 0x06004DCB RID: 19915 RVA: 0x000178E0 File Offset: 0x00015AE0
		[Token(Token = "0x6004DCB")]
		[Address(RVA = "0x1557C64", Offset = "0x1557C64", VA = "0x7BBBD57C64", Slot = "5")]
		public override bool Do()
		{
			return default(bool);
		}

		// Token: 0x06004DCC RID: 19916 RVA: 0x000178F8 File Offset: 0x00015AF8
		[Token(Token = "0x6004DCC")]
		[Address(RVA = "0x15580CC", Offset = "0x15580CC", VA = "0x7BBBD580CC", Slot = "6")]
		public override bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x06004DCD RID: 19917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DCD")]
		[Address(RVA = "0x1558134", Offset = "0x1558134", VA = "0x7BBBD58134")]
		public AutoTaskClaimMailRewards()
		{
		}

		// Token: 0x0400753E RID: 30014
		[Token(Token = "0x400753E")]
		[FieldOffset(Offset = "0x10")]
		private List<GiftRewardPopupData> m_giftRewardPopupData;

		// Token: 0x0200132A RID: 4906
		[Token(Token = "0x200132A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB158", Offset = "0x10EB158")]
		private sealed class <>c__DisplayClass2_0
		{
			// Token: 0x06004DCE RID: 19918 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004DCE")]
			[Address(RVA = "0x15580BC", Offset = "0x15580BC", VA = "0x7BBBD580BC")]
			public <>c__DisplayClass2_0()
			{
			}

			// Token: 0x0400753F RID: 30015
			[Token(Token = "0x400753F")]
			[FieldOffset(Offset = "0x10")]
			public AutoTaskClaimMailRewards <>4__this;

			// Token: 0x04007540 RID: 30016
			[Token(Token = "0x4007540")]
			[FieldOffset(Offset = "0x18")]
			public UIModelMail modelMail;
		}

		// Token: 0x0200132B RID: 4907
		[Token(Token = "0x200132B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB168", Offset = "0x10EB168")]
		private sealed class <>c__DisplayClass2_1
		{
			// Token: 0x06004DCF RID: 19919 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004DCF")]
			[Address(RVA = "0x15580C4", Offset = "0x15580C4", VA = "0x7BBBD580C4")]
			public <>c__DisplayClass2_1()
			{
			}

			// Token: 0x06004DD0 RID: 19920 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004DD0")]
			[Address(RVA = "0x155813C", Offset = "0x155813C", VA = "0x7BBBD5813C")]
			internal void <Do>b__0()
			{
			}

			// Token: 0x04007541 RID: 30017
			[Token(Token = "0x4007541")]
			[FieldOffset(Offset = "0x10")]
			public MailInfo info;

			// Token: 0x04007542 RID: 30018
			[Token(Token = "0x4007542")]
			[FieldOffset(Offset = "0x18")]
			public AutoTaskClaimMailRewards.<>c__DisplayClass2_0 CS$<>8__locals1;
		}
	}
}
