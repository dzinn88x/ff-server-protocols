using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x0200063A RID: 1594
	[Token(Token = "0x200063A")]
	[ProtoContract]
	public class ItemCollect
	{
		// Token: 0x060023A4 RID: 9124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A4")]
		[Address(RVA = "0x21BB704", Offset = "0x21BB704", VA = "0x7BBC9BB704")]
		public ItemCollect()
		{
		}

		// Token: 0x04001F9C RID: 8092
		[Token(Token = "0x4001F9C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108160", Offset = "0x1108160")]
		public uint item_id;

		// Token: 0x04001F9D RID: 8093
		[Token(Token = "0x4001F9D")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108174", Offset = "0x1108174")]
		public uint cnt;
	}
}
