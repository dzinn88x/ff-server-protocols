using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x020008A9 RID: 2217
	[Token(Token = "0x20008A9")]
	[ProtoContract]
	public class CSSendGiftRes
	{
		// Token: 0x060025B7 RID: 9655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B7")]
		[Address(RVA = "0x21B765C", Offset = "0x21B765C", VA = "0x7BBC9B765C")]
		public CSSendGiftRes()
		{
		}

		// Token: 0x040029CE RID: 10702
		[Token(Token = "0x40029CE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115E50", Offset = "0x1115E50")]
		public ulong[] remove_ids;

		// Token: 0x040029CF RID: 10703
		[Token(Token = "0x40029CF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1115E8C", Offset = "0x1115E8C")]
		public uint send_gift_times_today;
	}
}
