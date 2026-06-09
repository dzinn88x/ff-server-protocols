using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000666 RID: 1638
	[Token(Token = "0x2000666")]
	[ProtoContract]
	public class ChoosedEmote
	{
		// Token: 0x060023B9 RID: 9145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B9")]
		[Address(RVA = "0x21B8518", Offset = "0x21B8518", VA = "0x7BBC9B8518")]
		public ChoosedEmote()
		{
		}

		// Token: 0x04002057 RID: 8279
		[Token(Token = "0x4002057")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108714", Offset = "0x1108714")]
		public uint slot_id;

		// Token: 0x04002058 RID: 8280
		[Token(Token = "0x4002058")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108728", Offset = "0x1108728")]
		public uint emote_id;
	}
}
