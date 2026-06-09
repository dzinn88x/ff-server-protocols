using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001CB3 RID: 7347
	[Token(Token = "0x2001CB3")]
	public class BigEventIntroDataManager : SingletonModule<BigEventIntroDataManager>
	{
		// Token: 0x0600A04E RID: 41038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A04E")]
		[Address(RVA = "0x21D79E8", Offset = "0x21D79E8", VA = "0x7BBC9D79E8", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A04F RID: 41039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A04F")]
		[Address(RVA = "0x21D7C74", Offset = "0x21D7C74", VA = "0x7BBC9D7C74", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A050 RID: 41040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A050")]
		[Address(RVA = "0x21D7CD4", Offset = "0x21D7CD4", VA = "0x7BBC9D7CD4")]
		public BigEventIntroData GetIntroData(ELimitedEvent.EventID eventId, EBigEventIntroTiming timing)
		{
			return null;
		}

		// Token: 0x0600A051 RID: 41041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A051")]
		[Address(RVA = "0x21D7DF0", Offset = "0x21D7DF0", VA = "0x7BBC9D7DF0")]
		public BigEventIntroDataManager()
		{
		}

		// Token: 0x0400A733 RID: 42803
		[Token(Token = "0x400A733")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, List<BigEventIntroData>> m_Data;

		// Token: 0x02001CB4 RID: 7348
		[Token(Token = "0x2001CB4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB944", Offset = "0x10FB944")]
		private sealed class <>c__DisplayClass3_0
		{
			// Token: 0x0600A052 RID: 41042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A052")]
			[Address(RVA = "0x21D7DE8", Offset = "0x21D7DE8", VA = "0x7BBC9D7DE8")]
			public <>c__DisplayClass3_0()
			{
			}

			// Token: 0x0600A053 RID: 41043 RVA: 0x00029F10 File Offset: 0x00028110
			[Token(Token = "0x600A053")]
			[Address(RVA = "0x21D7E88", Offset = "0x21D7E88", VA = "0x7BBC9D7E88")]
			internal bool <GetIntroData>b__0(BigEventIntroData e)
			{
				return default(bool);
			}

			// Token: 0x0400A734 RID: 42804
			[Token(Token = "0x400A734")]
			[FieldOffset(Offset = "0x10")]
			public EBigEventIntroTiming timing;
		}
	}
}
