using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000945 RID: 2373
	[Token(Token = "0x2000945")]
	[ProtoContract]
	public class VeteranTaskInfo
	{
		// Token: 0x06002653 RID: 9811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002653")]
		[Address(RVA = "0x24A16B0", Offset = "0x24A16B0", VA = "0x7BBCCA16B0")]
		public VeteranTaskInfo()
		{
		}

		// Token: 0x04002BB1 RID: 11185
		[Token(Token = "0x4002BB1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119014", Offset = "0x1119014")]
		public uint id;

		// Token: 0x04002BB2 RID: 11186
		[Token(Token = "0x4002BB2")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1119028", Offset = "0x1119028")]
		public uint data;

		// Token: 0x04002BB3 RID: 11187
		[Token(Token = "0x4002BB3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111903C", Offset = "0x111903C")]
		public EActivity.State state;
	}
}
