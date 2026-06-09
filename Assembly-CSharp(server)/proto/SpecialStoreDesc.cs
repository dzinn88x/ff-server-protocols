using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000AA8 RID: 2728
	[Token(Token = "0x2000AA8")]
	[ProtoContract]
	public class SpecialStoreDesc
	{
		// Token: 0x060027B2 RID: 10162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027B2")]
		[Address(RVA = "0x24A06A4", Offset = "0x24A06A4", VA = "0x7BBCCA06A4")]
		public SpecialStoreDesc()
		{
		}

		// Token: 0x04003333 RID: 13107
		[Token(Token = "0x4003333")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112628C", Offset = "0x112628C")]
		public EStore.PbwActivityType id;

		// Token: 0x04003334 RID: 13108
		[Token(Token = "0x4003334")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11262A0", Offset = "0x11262A0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11262A0", Offset = "0x11262A0")]
		public string activity_name;

		// Token: 0x04003335 RID: 13109
		[Token(Token = "0x4003335")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11262F0", Offset = "0x11262F0")]
		public uint weight;

		// Token: 0x04003336 RID: 13110
		[Token(Token = "0x4003336")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1126304", Offset = "0x1126304")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1126304", Offset = "0x1126304")]
		public string icon;
	}
}
