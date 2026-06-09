using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000709 RID: 1801
	[Token(Token = "0x2000709")]
	[ProtoContract]
	public class IngameItem
	{
		// Token: 0x06002416 RID: 9238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002416")]
		[Address(RVA = "0x21BB4D8", Offset = "0x21BB4D8", VA = "0x7BBC9BB4D8")]
		public IngameItem()
		{
		}

		// Token: 0x040023DE RID: 9182
		[Token(Token = "0x40023DE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B720", Offset = "0x110B720")]
		public uint itemtable_id;

		// Token: 0x040023DF RID: 9183
		[Token(Token = "0x40023DF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B734", Offset = "0x110B734")]
		public Item item;

		// Token: 0x040023E0 RID: 9184
		[Token(Token = "0x40023E0")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B748", Offset = "0x110B748")]
		public bool reach_daily_limit;

		// Token: 0x040023E1 RID: 9185
		[Token(Token = "0x40023E1")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110B75C", Offset = "0x110B75C")]
		public uint daily_limit_cnt;
	}
}
