using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200068F RID: 1679
	[Token(Token = "0x200068F")]
	[ProtoContract]
	public class BlacklistReq
	{
		// Token: 0x060023CD RID: 9165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CD")]
		[Address(RVA = "0x21AFACC", Offset = "0x21AFACC", VA = "0x7BBC9AFACC")]
		public BlacklistReq()
		{
		}

		// Token: 0x0400210A RID: 8458
		[Token(Token = "0x400210A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108D68", Offset = "0x1108D68")]
		public ulong account_id;

		// Token: 0x0400210B RID: 8459
		[Token(Token = "0x400210B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108D7C", Offset = "0x1108D7C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1108D7C", Offset = "0x1108D7C")]
		public string device_id;
	}
}
