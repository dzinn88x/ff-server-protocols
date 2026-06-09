using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005E3 RID: 1507
	[Token(Token = "0x20005E3")]
	[ProtoContract]
	public class DelAccountReq
	{
		// Token: 0x06002363 RID: 9059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002363")]
		[Address(RVA = "0x21B94D4", Offset = "0x21B94D4", VA = "0x7BBC9B94D4")]
		public DelAccountReq()
		{
		}

		// Token: 0x04001DCD RID: 7629
		[Token(Token = "0x4001DCD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105604", Offset = "0x1105604")]
		public ulong account_id;

		// Token: 0x04001DCE RID: 7630
		[Token(Token = "0x4001DCE")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1105618", Offset = "0x1105618")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105618", Offset = "0x1105618")]
		public string external_id;

		// Token: 0x04001DCF RID: 7631
		[Token(Token = "0x4001DCF")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1105668", Offset = "0x1105668")]
		public uint external_type;

		// Token: 0x04001DD0 RID: 7632
		[Token(Token = "0x4001DD0")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110567C", Offset = "0x110567C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110567C", Offset = "0x110567C")]
		public string lock_region;

		// Token: 0x04001DD1 RID: 7633
		[Token(Token = "0x4001DD1")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11056CC", Offset = "0x11056CC")]
		public uint plat_id;

		// Token: 0x04001DD2 RID: 7634
		[Token(Token = "0x4001DD2")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11056E0", Offset = "0x11056E0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11056E0", Offset = "0x11056E0")]
		public string login_token;
	}
}
