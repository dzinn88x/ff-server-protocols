using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000978 RID: 2424
	[Token(Token = "0x2000978")]
	[ProtoContract]
	public class CSGetBountyWarmUpStatusRes
	{
		// Token: 0x06002686 RID: 9862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002686")]
		[Address(RVA = "0x21B29B0", Offset = "0x21B29B0", VA = "0x7BBC9B29B0")]
		public CSGetBountyWarmUpStatusRes()
		{
		}

		// Token: 0x04002C17 RID: 11287
		[Token(Token = "0x4002C17")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11199B0", Offset = "0x11199B0")]
		public uint percent;
	}
}
