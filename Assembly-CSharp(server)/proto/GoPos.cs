using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A60 RID: 2656
	[Token(Token = "0x2000A60")]
	[ProtoContract]
	public class GoPos
	{
		// Token: 0x0600276A RID: 10090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276A")]
		[Address(RVA = "0x21BAE98", Offset = "0x21BAE98", VA = "0x7BBC9BAE98")]
		public GoPos()
		{
		}

		// Token: 0x0400308B RID: 12427
		[Token(Token = "0x400308B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112137C", Offset = "0x112137C")]
		public uint id;

		// Token: 0x0400308C RID: 12428
		[Token(Token = "0x400308C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121390", Offset = "0x1121390")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1121390", Offset = "0x1121390")]
		public string go_pos;

		// Token: 0x0400308D RID: 12429
		[Token(Token = "0x400308D")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11213E0", Offset = "0x11213E0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11213E0", Offset = "0x11213E0")]
		public string sub_pos;

		// Token: 0x0400308E RID: 12430
		[Token(Token = "0x400308E")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121430", Offset = "0x1121430")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1121430", Offset = "0x1121430")]
		public string go_pos2;

		// Token: 0x0400308F RID: 12431
		[Token(Token = "0x400308F")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1121480", Offset = "0x1121480")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121480", Offset = "0x1121480")]
		public string sub_pos2;

		// Token: 0x04003090 RID: 12432
		[Token(Token = "0x4003090")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11214D0", Offset = "0x11214D0")]
		public uint start_time_stamp;

		// Token: 0x04003091 RID: 12433
		[Token(Token = "0x4003091")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11214E4", Offset = "0x11214E4")]
		public uint end_time_stamp;
	}
}
