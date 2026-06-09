using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A33 RID: 2611
	[Token(Token = "0x2000A33")]
	[ProtoContract]
	public class InstantGameConfigDesc
	{
		// Token: 0x0600273D RID: 10045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600273D")]
		[Address(RVA = "0x21BB53C", Offset = "0x21BB53C", VA = "0x7BBC9BB53C")]
		public InstantGameConfigDesc()
		{
		}

		// Token: 0x04002FA3 RID: 12195
		[Token(Token = "0x4002FA3")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FD10", Offset = "0x111FD10")]
		public uint download_item_id;

		// Token: 0x04002FA4 RID: 12196
		[Token(Token = "0x4002FA4")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x111FD24", Offset = "0x111FD24")]
		public uint download_item_num;
	}
}
