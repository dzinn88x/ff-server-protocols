using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020009E2 RID: 2530
	[Token(Token = "0x20009E2")]
	[ProtoContract]
	public class FullscreenItemDesc
	{
		// Token: 0x060026EC RID: 9964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026EC")]
		[Address(RVA = "0x21BA520", Offset = "0x21BA520", VA = "0x7BBC9BA520")]
		public FullscreenItemDesc()
		{
		}

		// Token: 0x04002DB2 RID: 11698
		[Token(Token = "0x4002DB2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BBE8", Offset = "0x111BBE8")]
		public uint item_id;

		// Token: 0x04002DB3 RID: 11699
		[Token(Token = "0x4002DB3")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111BBFC", Offset = "0x111BBFC")]
		public bool is_open;
	}
}
