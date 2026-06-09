using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009B9 RID: 2489
	[Token(Token = "0x20009B9")]
	[ProtoContract]
	public class BattleTagCount
	{
		// Token: 0x060026C7 RID: 9927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C7")]
		[Address(RVA = "0x21AF73C", Offset = "0x21AF73C", VA = "0x7BBC9AF73C")]
		public BattleTagCount()
		{
		}

		// Token: 0x04002CB3 RID: 11443
		[Token(Token = "0x4002CB3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A84C", Offset = "0x111A84C")]
		public uint tag_id;

		// Token: 0x04002CB4 RID: 11444
		[Token(Token = "0x4002CB4")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111A860", Offset = "0x111A860")]
		public uint count;
	}
}
