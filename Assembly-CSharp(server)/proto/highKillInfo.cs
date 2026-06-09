using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006FF RID: 1791
	[Token(Token = "0x20006FF")]
	[ProtoContract]
	public class highKillInfo
	{
		// Token: 0x0600240D RID: 9229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240D")]
		[Address(RVA = "0x24A1BD8", Offset = "0x24A1BD8", VA = "0x7BBCCA1BD8")]
		public highKillInfo()
		{
		}

		// Token: 0x040023AC RID: 9132
		[Token(Token = "0x40023AC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B34C", Offset = "0x110B34C")]
		public uint kill;

		// Token: 0x040023AD RID: 9133
		[Token(Token = "0x40023AD")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B360", Offset = "0x110B360")]
		public uint damage;
	}
}
