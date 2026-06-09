using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A1D RID: 2589
	[Token(Token = "0x2000A1D")]
	[ProtoContract]
	public class DebugIPDesc
	{
		// Token: 0x06002727 RID: 10023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002727")]
		[Address(RVA = "0x21B9478", Offset = "0x21B9478", VA = "0x7BBC9B9478")]
		public DebugIPDesc()
		{
		}

		// Token: 0x04002F3B RID: 12091
		[Token(Token = "0x4002F3B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111ED84", Offset = "0x111ED84")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x111ED84", Offset = "0x111ED84")]
		public string debug_ip;
	}
}
