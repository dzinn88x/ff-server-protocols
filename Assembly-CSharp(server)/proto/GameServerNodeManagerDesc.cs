using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AEB RID: 2795
	[Token(Token = "0x2000AEB")]
	[ProtoContract]
	public class GameServerNodeManagerDesc
	{
		// Token: 0x060027F3 RID: 10227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027F3")]
		[Address(RVA = "0x21BA900", Offset = "0x21BA900", VA = "0x7BBC9BA900")]
		public GameServerNodeManagerDesc()
		{
		}

		// Token: 0x040034AE RID: 13486
		[Token(Token = "0x40034AE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1128F8C", Offset = "0x1128F8C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128F8C", Offset = "0x1128F8C")]
		public string region;

		// Token: 0x040034AF RID: 13487
		[Token(Token = "0x40034AF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1128FDC", Offset = "0x1128FDC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1128FDC", Offset = "0x1128FDC")]
		public string node_name;

		// Token: 0x040034B0 RID: 13488
		[Token(Token = "0x40034B0")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x112902C", Offset = "0x112902C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112902C", Offset = "0x112902C")]
		public string server_ip;

		// Token: 0x040034B1 RID: 13489
		[Token(Token = "0x40034B1")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112907C", Offset = "0x112907C")]
		public bool is_default;

		// Token: 0x040034B2 RID: 13490
		[Token(Token = "0x40034B2")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1129090", Offset = "0x1129090")]
		public uint warn_capacity;
	}
}
