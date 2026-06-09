using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000937 RID: 2359
	[Token(Token = "0x2000937")]
	[ProtoContract]
	public class CSGetLinkageActivityInfoRes
	{
		// Token: 0x06002645 RID: 9797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002645")]
		[Address(RVA = "0x21B45D8", Offset = "0x21B45D8", VA = "0x7BBC9B45D8")]
		public CSGetLinkageActivityInfoRes()
		{
		}

		// Token: 0x04002B8D RID: 11149
		[Token(Token = "0x4002B8D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118C90", Offset = "0x1118C90")]
		public uint day;

		// Token: 0x04002B8E RID: 11150
		[Token(Token = "0x4002B8E")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118CA4", Offset = "0x1118CA4")]
		public uint activity_id;

		// Token: 0x04002B8F RID: 11151
		[Token(Token = "0x4002B8F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118CB8", Offset = "0x1118CB8")]
		public uint activity_type;

		// Token: 0x04002B90 RID: 11152
		[Token(Token = "0x4002B90")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118CCC", Offset = "0x1118CCC")]
		public uint today_data;

		// Token: 0x04002B91 RID: 11153
		[Token(Token = "0x4002B91")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118CE0", Offset = "0x1118CE0")]
		public uint total_data;

		// Token: 0x04002B92 RID: 11154
		[Token(Token = "0x4002B92")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118CF4", Offset = "0x1118CF4")]
		public EActivity.State state;

		// Token: 0x04002B93 RID: 11155
		[Token(Token = "0x4002B93")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118D08", Offset = "0x1118D08")]
		public long timezone_offset_secs;

		// Token: 0x04002B94 RID: 11156
		[Token(Token = "0x4002B94")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118D1C", Offset = "0x1118D1C")]
		public ulong global_ep_badges;

		// Token: 0x04002B95 RID: 11157
		[Token(Token = "0x4002B95")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118D30", Offset = "0x1118D30")]
		public List<LinkageProcessRewards> process_rewards;

		// Token: 0x04002B96 RID: 11158
		[Token(Token = "0x4002B96")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1118D44", Offset = "0x1118D44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1118D44", Offset = "0x1118D44")]
		public string cdn_url;
	}
}
