using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008E4 RID: 2276
	[Token(Token = "0x20008E4")]
	[ProtoContract]
	public class StreamerBaseInfo
	{
		// Token: 0x060025F2 RID: 9714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025F2")]
		[Address(RVA = "0x24A0928", Offset = "0x24A0928", VA = "0x7BBCCA0928")]
		public StreamerBaseInfo()
		{
		}

		// Token: 0x04002A89 RID: 10889
		[Token(Token = "0x4002A89")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111732C", Offset = "0x111732C")]
		public ulong account_id;

		// Token: 0x04002A8A RID: 10890
		[Token(Token = "0x4002A8A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117340", Offset = "0x1117340")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1117340", Offset = "0x1117340")]
		public string nickname;

		// Token: 0x04002A8B RID: 10891
		[Token(Token = "0x4002A8B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1117390", Offset = "0x1117390")]
		public uint head_pic;

		// Token: 0x04002A8C RID: 10892
		[Token(Token = "0x4002A8C")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11173A4", Offset = "0x11173A4")]
		public uint banner_id;
	}
}
