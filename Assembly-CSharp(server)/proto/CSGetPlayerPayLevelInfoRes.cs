using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200079D RID: 1949
	[Token(Token = "0x200079D")]
	[ProtoContract]
	public class CSGetPlayerPayLevelInfoRes
	{
		// Token: 0x060024AC RID: 9388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024AC")]
		[Address(RVA = "0x21B5598", Offset = "0x21B5598", VA = "0x7BBC9B5598")]
		public CSGetPlayerPayLevelInfoRes()
		{
		}

		// Token: 0x040025AE RID: 9646
		[Token(Token = "0x40025AE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110E510", Offset = "0x110E510")]
		public List<PlayLevelInfo> infos;
	}
}
