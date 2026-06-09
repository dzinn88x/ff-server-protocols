using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A9B RID: 2715
	[Token(Token = "0x2000A9B")]
	[ProtoContract]
	public class GiftStoreDesc
	{
		// Token: 0x060027A5 RID: 10149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A5")]
		[Address(RVA = "0x21BAD78", Offset = "0x21BAD78", VA = "0x7BBC9BAD78")]
		public GiftStoreDesc()
		{
		}

		// Token: 0x04003294 RID: 12948
		[Token(Token = "0x4003294")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124EB4", Offset = "0x1124EB4")]
		public uint store_id;

		// Token: 0x04003295 RID: 12949
		[Token(Token = "0x4003295")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1124EC8", Offset = "0x1124EC8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124EC8", Offset = "0x1124EC8")]
		public string open_time;

		// Token: 0x04003296 RID: 12950
		[Token(Token = "0x4003296")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124F18", Offset = "0x1124F18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1124F18", Offset = "0x1124F18")]
		public string close_time;

		// Token: 0x04003297 RID: 12951
		[Token(Token = "0x4003297")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124F68", Offset = "0x1124F68")]
		public bool is_time_show;

		// Token: 0x04003298 RID: 12952
		[Token(Token = "0x4003298")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124F7C", Offset = "0x1124F7C")]
		public uint giver_level;

		// Token: 0x04003299 RID: 12953
		[Token(Token = "0x4003299")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124F90", Offset = "0x1124F90")]
		public uint receiver_level;

		// Token: 0x0400329A RID: 12954
		[Token(Token = "0x400329A")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124FA4", Offset = "0x1124FA4")]
		public uint gift_time_limited;

		// Token: 0x0400329B RID: 12955
		[Token(Token = "0x400329B")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1124FB8", Offset = "0x1124FB8")]
		public uint gift_num_limited;
	}
}
