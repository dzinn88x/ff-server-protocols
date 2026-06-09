using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000766 RID: 1894
	[Token(Token = "0x2000766")]
	[ProtoContract]
	public class CSGetStoreReq
	{
		// Token: 0x06002473 RID: 9331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002473")]
		[Address(RVA = "0x21B5BC0", Offset = "0x21B5BC0", VA = "0x7BBC9B5BC0")]
		public CSGetStoreReq()
		{
		}

		// Token: 0x0400251D RID: 9501
		[Token(Token = "0x400251D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D688", Offset = "0x110D688")]
		public ulong account_id;

		// Token: 0x0400251E RID: 9502
		[Token(Token = "0x400251E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D69C", Offset = "0x110D69C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110D69C", Offset = "0x110D69C")]
		public string lock_region;

		// Token: 0x0400251F RID: 9503
		[Token(Token = "0x400251F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110D6EC", Offset = "0x110D6EC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D6EC", Offset = "0x110D6EC")]
		public string language;
	}
}
