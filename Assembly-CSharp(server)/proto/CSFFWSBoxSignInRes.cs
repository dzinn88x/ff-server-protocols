using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009BF RID: 2495
	[Token(Token = "0x20009BF")]
	[ProtoContract]
	public class CSFFWSBoxSignInRes
	{
		// Token: 0x060026CD RID: 9933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026CD")]
		[Address(RVA = "0x21B12A0", Offset = "0x21B12A0", VA = "0x7BBC9B12A0")]
		public CSFFWSBoxSignInRes()
		{
		}

		// Token: 0x04002CC1 RID: 11457
		[Token(Token = "0x4002CC1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A9DC", Offset = "0x111A9DC")]
		public uint treasure_id;
	}
}
