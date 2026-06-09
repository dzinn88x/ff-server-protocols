using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000753 RID: 1875
	[Token(Token = "0x2000753")]
	[ProtoContract]
	public class CSModifyCupTeamInfoReq
	{
		// Token: 0x06002460 RID: 9312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002460")]
		[Address(RVA = "0x21B69B8", Offset = "0x21B69B8", VA = "0x7BBC9B69B8")]
		public CSModifyCupTeamInfoReq()
		{
		}

		// Token: 0x040024E5 RID: 9445
		[Token(Token = "0x40024E5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D048", Offset = "0x110D048")]
		public ulong team_id;

		// Token: 0x040024E6 RID: 9446
		[Token(Token = "0x40024E6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110D05C", Offset = "0x110D05C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D05C", Offset = "0x110D05C")]
		public string team_name;

		// Token: 0x040024E7 RID: 9447
		[Token(Token = "0x40024E7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D0AC", Offset = "0x110D0AC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x110D0AC", Offset = "0x110D0AC")]
		public string country_or_area;

		// Token: 0x040024E8 RID: 9448
		[Token(Token = "0x40024E8")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D0FC", Offset = "0x110D0FC")]
		public uint head_pic;

		// Token: 0x040024E9 RID: 9449
		[Token(Token = "0x40024E9")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110D110", Offset = "0x110D110")]
		public uint banner_id;
	}
}
