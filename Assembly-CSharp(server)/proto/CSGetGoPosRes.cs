using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200080D RID: 2061
	[Token(Token = "0x200080D")]
	[ProtoContract]
	public class CSGetGoPosRes
	{
		// Token: 0x0600251C RID: 9500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251C")]
		[Address(RVA = "0x21B405C", Offset = "0x21B405C", VA = "0x7BBC9B405C")]
		public CSGetGoPosRes()
		{
		}

		// Token: 0x04002701 RID: 9985
		[Token(Token = "0x4002701")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110BBC", Offset = "0x1110BBC")]
		public List<GoPos> go_pos;
	}
}
