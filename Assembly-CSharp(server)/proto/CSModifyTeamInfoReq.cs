using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000906 RID: 2310
	[Token(Token = "0x2000906")]
	[ProtoContract]
	public class CSModifyTeamInfoReq
	{
		// Token: 0x06002614 RID: 9748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002614")]
		[Address(RVA = "0x21B6ACC", Offset = "0x21B6ACC", VA = "0x7BBC9B6ACC")]
		public CSModifyTeamInfoReq()
		{
		}

		// Token: 0x04002AD5 RID: 10965
		[Token(Token = "0x4002AD5")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117BD8", Offset = "0x1117BD8")]
		public ulong team_id;

		// Token: 0x04002AD6 RID: 10966
		[Token(Token = "0x4002AD6")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117BEC", Offset = "0x1117BEC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1117BEC", Offset = "0x1117BEC")]
		public string team_name;

		// Token: 0x04002AD7 RID: 10967
		[Token(Token = "0x4002AD7")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1117C3C", Offset = "0x1117C3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117C3C", Offset = "0x1117C3C")]
		public string country_or_area;

		// Token: 0x04002AD8 RID: 10968
		[Token(Token = "0x4002AD8")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117C8C", Offset = "0x1117C8C")]
		public uint head_pic;

		// Token: 0x04002AD9 RID: 10969
		[Token(Token = "0x4002AD9")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117CA0", Offset = "0x1117CA0")]
		public uint banner_id;
	}
}
