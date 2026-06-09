using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AC0 RID: 2752
	[Token(Token = "0x2000AC0")]
	[ProtoContract]
	public class ECard
	{
		// Token: 0x060027CA RID: 10186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CA")]
		[Address(RVA = "0x21B97E0", Offset = "0x21B97E0", VA = "0x7BBC9B97E0")]
		public ECard()
		{
		}

		// Token: 0x02000AC1 RID: 2753
		[Token(Token = "0x2000AC1")]
		[ProtoContract]
		public enum ImageURLType
		{
			// Token: 0x040033BF RID: 13247
			[Token(Token = "0x40033BF")]
			ImageURLType_NONE,
			// Token: 0x040033C0 RID: 13248
			[Token(Token = "0x40033C0")]
			ImageURLType_BACK
		}
	}
}
