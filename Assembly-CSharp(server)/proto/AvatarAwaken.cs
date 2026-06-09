using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A63 RID: 2659
	[Token(Token = "0x2000A63")]
	[ProtoContract]
	public class AvatarAwaken
	{
		// Token: 0x0600276D RID: 10093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276D")]
		[Address(RVA = "0x21AF3F4", Offset = "0x21AF3F4", VA = "0x7BBC9AF3F4")]
		public AvatarAwaken()
		{
		}

		// Token: 0x04003099 RID: 12441
		[Token(Token = "0x4003099")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121584", Offset = "0x1121584")]
		public uint awaken_avatar_id;

		// Token: 0x0400309A RID: 12442
		[Token(Token = "0x400309A")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121598", Offset = "0x1121598")]
		public uint original_avatar_id;

		// Token: 0x0400309B RID: 12443
		[Token(Token = "0x400309B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11215AC", Offset = "0x11215AC")]
		public uint unlock_level;

		// Token: 0x0400309C RID: 12444
		[Token(Token = "0x400309C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11215C0", Offset = "0x11215C0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11215C0", Offset = "0x11215C0")]
		public string awaken_cdn;

		// Token: 0x0400309D RID: 12445
		[Token(Token = "0x400309D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121610", Offset = "0x1121610")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1121610", Offset = "0x1121610")]
		public string unlock_time;

		// Token: 0x0400309E RID: 12446
		[Token(Token = "0x400309E")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121660", Offset = "0x1121660")]
		public List<AwardDesc> awards;

		// Token: 0x0400309F RID: 12447
		[Token(Token = "0x400309F")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121674", Offset = "0x1121674")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1121674", Offset = "0x1121674")]
		public string awaken_description;

		// Token: 0x040030A0 RID: 12448
		[Token(Token = "0x40030A0")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11216C4", Offset = "0x11216C4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11216C4", Offset = "0x11216C4")]
		public string awaken_title;

		// Token: 0x040030A1 RID: 12449
		[Token(Token = "0x40030A1")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1121714", Offset = "0x1121714")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1121714", Offset = "0x1121714")]
		public string go_pos;
	}
}
