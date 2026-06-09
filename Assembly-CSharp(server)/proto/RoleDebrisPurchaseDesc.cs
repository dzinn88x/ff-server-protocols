using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000B1A RID: 2842
	[Token(Token = "0x2000B1A")]
	[ProtoContract]
	public class RoleDebrisPurchaseDesc
	{
		// Token: 0x06002822 RID: 10274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002822")]
		[Address(RVA = "0x24A0270", Offset = "0x24A0270", VA = "0x7BBCCA0270")]
		public RoleDebrisPurchaseDesc()
		{
		}

		// Token: 0x040035EC RID: 13804
		[Token(Token = "0x40035EC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BC8C", Offset = "0x112BC8C")]
		public uint debris_id;

		// Token: 0x040035ED RID: 13805
		[Token(Token = "0x40035ED")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BCA0", Offset = "0x112BCA0")]
		public uint purchase_count;

		// Token: 0x040035EE RID: 13806
		[Token(Token = "0x40035EE")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BCB4", Offset = "0x112BCB4")]
		public uint gold_price;

		// Token: 0x040035EF RID: 13807
		[Token(Token = "0x40035EF")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112BCC8", Offset = "0x112BCC8")]
		public uint diamond_price;
	}
}
