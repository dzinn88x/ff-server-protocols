using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000689 RID: 1673
	[Token(Token = "0x2000689")]
	[ProtoContract]
	public class EAntiAddiction
	{
		// Token: 0x060023CA RID: 9162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CA")]
		[Address(RVA = "0x21B97C8", Offset = "0x21B97C8", VA = "0x7BBC9B97C8")]
		public EAntiAddiction()
		{
		}

		// Token: 0x0200068A RID: 1674
		[Token(Token = "0x200068A")]
		[ProtoContract]
		public enum TotalTimeBanMode
		{
			// Token: 0x040020F4 RID: 8436
			[Token(Token = "0x40020F4")]
			TotalTimeBanMode_NONE,
			// Token: 0x040020F5 RID: 8437
			[Token(Token = "0x40020F5")]
			TotalTimeBanMode_RANKING,
			// Token: 0x040020F6 RID: 8438
			[Token(Token = "0x40020F6")]
			TotalTimeBanMode_ALL
		}

		// Token: 0x0200068B RID: 1675
		[Token(Token = "0x200068B")]
		[ProtoContract]
		public enum HintType
		{
			// Token: 0x040020F8 RID: 8440
			[Token(Token = "0x40020F8")]
			HintType_NONE,
			// Token: 0x040020F9 RID: 8441
			[Token(Token = "0x40020F9")]
			HintType_CONTINUOUS_TIME,
			// Token: 0x040020FA RID: 8442
			[Token(Token = "0x40020FA")]
			HintType_TOTAL_TIME,
			// Token: 0x040020FB RID: 8443
			[Token(Token = "0x40020FB")]
			HintType_ALL
		}

		// Token: 0x0200068C RID: 1676
		[Token(Token = "0x200068C")]
		[ProtoContract]
		public enum AgeState
		{
			// Token: 0x040020FD RID: 8445
			[Token(Token = "0x40020FD")]
			AgeState_NONE,
			// Token: 0x040020FE RID: 8446
			[Token(Token = "0x40020FE")]
			AgeState_CHILD,
			// Token: 0x040020FF RID: 8447
			[Token(Token = "0x40020FF")]
			AgeState_TEENAGER,
			// Token: 0x04002100 RID: 8448
			[Token(Token = "0x4002100")]
			AgeState_ADULT
		}
	}
}
