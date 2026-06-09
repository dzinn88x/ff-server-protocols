using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006C2 RID: 1730
	[Token(Token = "0x20006C2")]
	[ProtoContract]
	public class ERecommend
	{
		// Token: 0x060023DF RID: 9183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DF")]
		[Address(RVA = "0x21B9B2C", Offset = "0x21B9B2C", VA = "0x7BBC9B9B2C")]
		public ERecommend()
		{
		}

		// Token: 0x020006C3 RID: 1731
		[Token(Token = "0x20006C3")]
		[ProtoContract]
		public enum Type
		{
			// Token: 0x040021F5 RID: 8693
			[Token(Token = "0x40021F5")]
			Type_NONE,
			// Token: 0x040021F6 RID: 8694
			[Token(Token = "0x40021F6")]
			Type_PRUCHASE_OFFER
		}

		// Token: 0x020006C4 RID: 1732
		[Token(Token = "0x20006C4")]
		[ProtoContract]
		public enum Algorithm
		{
			// Token: 0x040021F8 RID: 8696
			[Token(Token = "0x40021F8")]
			Algorithm_NONE
		}

		// Token: 0x020006C5 RID: 1733
		[Token(Token = "0x20006C5")]
		[ProtoContract]
		public enum Origin
		{
			// Token: 0x040021FA RID: 8698
			[Token(Token = "0x40021FA")]
			Origin_CSV,
			// Token: 0x040021FB RID: 8699
			[Token(Token = "0x40021FB")]
			Origin_REDIS
		}
	}
}
