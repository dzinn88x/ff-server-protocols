using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000639 RID: 1593
	[Token(Token = "0x2000639")]
	[ProtoContract]
	public class EPArchiveInfo
	{
		// Token: 0x060023A3 RID: 9123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A3")]
		[Address(RVA = "0x21B9890", Offset = "0x21B9890", VA = "0x7BBC9B9890")]
		public EPArchiveInfo()
		{
		}

		// Token: 0x04001F99 RID: 8089
		[Token(Token = "0x4001F99")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108124", Offset = "0x1108124")]
		public uint E;

		// Token: 0x04001F9A RID: 8090
		[Token(Token = "0x4001F9A")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108138", Offset = "0x1108138")]
		public bool O;

		// Token: 0x04001F9B RID: 8091
		[Token(Token = "0x4001F9B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110814C", Offset = "0x110814C")]
		public uint B;
	}
}
