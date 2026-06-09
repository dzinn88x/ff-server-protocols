using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020006FD RID: 1789
	[Token(Token = "0x20006FD")]
	[ProtoContract]
	public class wpSecondsAndDamage
	{
		// Token: 0x0600240B RID: 9227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240B")]
		[Address(RVA = "0x24A1C84", Offset = "0x24A1C84", VA = "0x7BBCCA1C84")]
		public wpSecondsAndDamage()
		{
		}

		// Token: 0x040023A8 RID: 9128
		[Token(Token = "0x40023A8")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B2FC", Offset = "0x110B2FC")]
		public uint seconds;

		// Token: 0x040023A9 RID: 9129
		[Token(Token = "0x40023A9")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B310", Offset = "0x110B310")]
		public uint damage;
	}
}
