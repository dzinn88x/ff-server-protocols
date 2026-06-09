using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A29 RID: 2601
	[Token(Token = "0x2000A29")]
	[ProtoContract]
	public class VeteranRewardDesc
	{
		// Token: 0x06002733 RID: 10035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002733")]
		[Address(RVA = "0x24A159C", Offset = "0x24A159C", VA = "0x7BBCCA159C")]
		public VeteranRewardDesc()
		{
		}

		// Token: 0x04002F62 RID: 12130
		[Token(Token = "0x4002F62")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F3D8", Offset = "0x111F3D8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111F3D8", Offset = "0x111F3D8")]
		public string region;

		// Token: 0x04002F63 RID: 12131
		[Token(Token = "0x4002F63")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F428", Offset = "0x111F428")]
		public uint id;

		// Token: 0x04002F64 RID: 12132
		[Token(Token = "0x4002F64")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F43C", Offset = "0x111F43C")]
		public AwardDesc award;

		// Token: 0x04002F65 RID: 12133
		[Token(Token = "0x4002F65")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111F450", Offset = "0x111F450")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111F450", Offset = "0x111F450")]
		public string cdn_url_key;
	}
}
