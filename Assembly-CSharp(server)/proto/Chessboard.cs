using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200099D RID: 2461
	[Token(Token = "0x200099D")]
	[ProtoContract]
	public class Chessboard
	{
		// Token: 0x060026AB RID: 9899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026AB")]
		[Address(RVA = "0x21B82DC", Offset = "0x21B82DC", VA = "0x7BBC9B82DC")]
		public Chessboard()
		{
		}

		// Token: 0x04002C77 RID: 11383
		[Token(Token = "0x4002C77")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A220", Offset = "0x111A220")]
		public List<Hexagon> hexagons;
	}
}
