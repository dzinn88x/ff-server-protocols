using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000779 RID: 1913
	[Token(Token = "0x2000779")]
	[ProtoContract]
	public class CSOpenOptionalBundleReq
	{
		// Token: 0x06002486 RID: 9350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002486")]
		[Address(RVA = "0x21B6D08", Offset = "0x21B6D08", VA = "0x7BBC9B6D08")]
		public CSOpenOptionalBundleReq()
		{
		}

		// Token: 0x04002546 RID: 9542
		[Token(Token = "0x4002546")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DAD4", Offset = "0x110DAD4")]
		public uint item_id;

		// Token: 0x04002547 RID: 9543
		[Token(Token = "0x4002547")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110DAE8", Offset = "0x110DAE8")]
		public uint option_order;
	}
}
