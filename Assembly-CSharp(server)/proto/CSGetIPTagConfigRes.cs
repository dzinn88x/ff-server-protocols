using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200080F RID: 2063
	[Token(Token = "0x200080F")]
	[ProtoContract]
	public class CSGetIPTagConfigRes
	{
		// Token: 0x0600251E RID: 9502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251E")]
		[Address(RVA = "0x21B41E0", Offset = "0x21B41E0", VA = "0x7BBC9B41E0")]
		public CSGetIPTagConfigRes()
		{
		}

		// Token: 0x04002703 RID: 9987
		[Token(Token = "0x4002703")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1110BE4", Offset = "0x1110BE4")]
		public List<IPTagConfigDesc> ip_tag_config;
	}
}
