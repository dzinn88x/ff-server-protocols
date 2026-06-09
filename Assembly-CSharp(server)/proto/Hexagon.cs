using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200099A RID: 2458
	[Token(Token = "0x200099A")]
	[ProtoContract]
	public class Hexagon
	{
		// Token: 0x060026A8 RID: 9896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A8")]
		[Address(RVA = "0x21BB2A8", Offset = "0x21BB2A8", VA = "0x7BBC9BB2A8")]
		public Hexagon()
		{
		}

		// Token: 0x04002C63 RID: 11363
		[Token(Token = "0x4002C63")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A090", Offset = "0x111A090")]
		public Point center;

		// Token: 0x04002C64 RID: 11364
		[Token(Token = "0x4002C64")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A0A4", Offset = "0x111A0A4")]
		public double radius;

		// Token: 0x04002C65 RID: 11365
		[Token(Token = "0x4002C65")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A0B8", Offset = "0x111A0B8")]
		public uint index;

		// Token: 0x04002C66 RID: 11366
		[Token(Token = "0x4002C66")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A0CC", Offset = "0x111A0CC")]
		public EMiniGame.HexagonStatus status;
	}
}
