using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020005F1 RID: 1521
	[Token(Token = "0x20005F1")]
	[ProtoContract]
	public class MsgToPlayers
	{
		// Token: 0x06002371 RID: 9073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002371")]
		[Address(RVA = "0x249E538", Offset = "0x249E538", VA = "0x7BBCC9E538")]
		public MsgToPlayers()
		{
		}

		// Token: 0x04001E6F RID: 7791
		[Token(Token = "0x4001E6F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106B08", Offset = "0x1106B08")]
		public ulong[] account_ids;

		// Token: 0x04001E70 RID: 7792
		[Token(Token = "0x4001E70")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106B44", Offset = "0x1106B44")]
		public uint protocol;

		// Token: 0x04001E71 RID: 7793
		[Token(Token = "0x4001E71")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106B58", Offset = "0x1106B58")]
		public uint ret;

		// Token: 0x04001E72 RID: 7794
		[Token(Token = "0x4001E72")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106B6C", Offset = "0x1106B6C")]
		public uint cmd;

		// Token: 0x04001E73 RID: 7795
		[Token(Token = "0x4001E73")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1106B80", Offset = "0x1106B80")]
		public byte[] content;
	}
}
