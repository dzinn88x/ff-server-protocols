using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000867 RID: 2151
	[Token(Token = "0x2000867")]
	[ProtoContract]
	public class ActIds
	{
		// Token: 0x06002575 RID: 9589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002575")]
		[Address(RVA = "0x21AE8B8", Offset = "0x21AE8B8", VA = "0x7BBC9AE8B8")]
		public ActIds()
		{
		}

		// Token: 0x04002827 RID: 10279
		[Token(Token = "0x4002827")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112854", Offset = "0x1112854")]
		public uint pool;

		// Token: 0x04002828 RID: 10280
		[Token(Token = "0x4002828")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1112868", Offset = "0x1112868")]
		public uint[] ids;
	}
}
