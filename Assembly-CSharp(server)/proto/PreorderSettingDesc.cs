using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000A88 RID: 2696
	[Token(Token = "0x2000A88")]
	[ProtoContract]
	public class PreorderSettingDesc
	{
		// Token: 0x06002792 RID: 10130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002792")]
		[Address(RVA = "0x249F6EC", Offset = "0x249F6EC", VA = "0x7BBCC9F6EC")]
		public PreorderSettingDesc()
		{
		}

		// Token: 0x0400319A RID: 12698
		[Token(Token = "0x400319A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11230B4", Offset = "0x11230B4")]
		public uint ep_id;

		// Token: 0x0400319B RID: 12699
		[Token(Token = "0x400319B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11230C8", Offset = "0x11230C8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11230C8", Offset = "0x11230C8")]
		public string region;

		// Token: 0x0400319C RID: 12700
		[Token(Token = "0x400319C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123118", Offset = "0x1123118")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1123118", Offset = "0x1123118")]
		public string start_time;

		// Token: 0x0400319D RID: 12701
		[Token(Token = "0x400319D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123168", Offset = "0x1123168")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1123168", Offset = "0x1123168")]
		public string end_time;

		// Token: 0x0400319E RID: 12702
		[Token(Token = "0x400319E")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11231B8", Offset = "0x11231B8")]
		public EInventory.AwardType extra_award_type1;

		// Token: 0x0400319F RID: 12703
		[Token(Token = "0x400319F")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11231CC", Offset = "0x11231CC")]
		public uint extra_award_id1;

		// Token: 0x040031A0 RID: 12704
		[Token(Token = "0x40031A0")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11231E0", Offset = "0x11231E0")]
		public uint extra_award_num1;

		// Token: 0x040031A1 RID: 12705
		[Token(Token = "0x40031A1")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11231F4", Offset = "0x11231F4")]
		public EInventory.AwardType extra_award_type2;

		// Token: 0x040031A2 RID: 12706
		[Token(Token = "0x40031A2")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123208", Offset = "0x1123208")]
		public uint extra_award_id2;

		// Token: 0x040031A3 RID: 12707
		[Token(Token = "0x40031A3")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112321C", Offset = "0x112321C")]
		public uint extra_award_num2;

		// Token: 0x040031A4 RID: 12708
		[Token(Token = "0x40031A4")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123230", Offset = "0x1123230")]
		public long start_timestamp;

		// Token: 0x040031A5 RID: 12709
		[Token(Token = "0x40031A5")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123244", Offset = "0x1123244")]
		public long end_timestamp;

		// Token: 0x040031A6 RID: 12710
		[Token(Token = "0x40031A6")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123258", Offset = "0x1123258")]
		public long subscription_start_time;

		// Token: 0x040031A7 RID: 12711
		[Token(Token = "0x40031A7")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x112326C", Offset = "0x112326C")]
		public long subscription_end_time;

		// Token: 0x040031A8 RID: 12712
		[Token(Token = "0x40031A8")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123280", Offset = "0x1123280")]
		public uint award_time1;

		// Token: 0x040031A9 RID: 12713
		[Token(Token = "0x40031A9")]
		[FieldOffset(Offset = "0x6C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1123294", Offset = "0x1123294")]
		public uint award_time2;
	}
}
