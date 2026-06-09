using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000487 RID: 1159
	[Token(Token = "0x2000487")]
	[ProtoContract]
	public class RelatedFriendRequestNtf
	{
		// Token: 0x06001D04 RID: 7428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D04")]
		[Address(RVA = "0x24A5B0C", Offset = "0x24A5B0C", VA = "0x7BBCCA5B0C")]
		public RelatedFriendRequestNtf()
		{
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001D05 RID: 7429 RVA: 0x0000C5E8 File Offset: 0x0000A7E8
		// (set) Token: 0x06001D06 RID: 7430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A7")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115523C", Offset = "0x115523C")]
		public ulong friend_id
		{
			[Token(Token = "0x6001D05")]
			[Address(RVA = "0x24A5B14", Offset = "0x24A5B14", VA = "0x7BBCCA5B14")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11358C4", Offset = "0x11358C4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001D06")]
			[Address(RVA = "0x24A5B1C", Offset = "0x24A5B1C", VA = "0x7BBCCA5B1C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11358D4", Offset = "0x11358D4")]
			set
			{
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001D07 RID: 7431 RVA: 0x0000C600 File Offset: 0x0000A800
		// (set) Token: 0x06001D08 RID: 7432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155250", Offset = "0x1155250")]
		public long request_time
		{
			[Token(Token = "0x6001D07")]
			[Address(RVA = "0x24A5B24", Offset = "0x24A5B24", VA = "0x7BBCCA5B24")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11358E4", Offset = "0x11358E4")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6001D08")]
			[Address(RVA = "0x24A5B2C", Offset = "0x24A5B2C", VA = "0x7BBCCA5B2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11358F4", Offset = "0x11358F4")]
			set
			{
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x0000C618 File Offset: 0x0000A818
		// (set) Token: 0x06001D0A RID: 7434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003A9")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155264", Offset = "0x1155264")]
		public uint relation_type
		{
			[Token(Token = "0x6001D09")]
			[Address(RVA = "0x24A5B34", Offset = "0x24A5B34", VA = "0x7BBCCA5B34")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135904", Offset = "0x1135904")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D0A")]
			[Address(RVA = "0x24A5B3C", Offset = "0x24A5B3C", VA = "0x7BBCCA5B3C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135914", Offset = "0x1135914")]
			set
			{
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x0000C630 File Offset: 0x0000A830
		// (set) Token: 0x06001D0C RID: 7436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003AA")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155278", Offset = "0x1155278")]
		public bool is_create
		{
			[Token(Token = "0x6001D0B")]
			[Address(RVA = "0x24A5B44", Offset = "0x24A5B44", VA = "0x7BBCCA5B44")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135924", Offset = "0x1135924")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D0C")]
			[Address(RVA = "0x24A5B4C", Offset = "0x24A5B4C", VA = "0x7BBCCA5B4C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135934", Offset = "0x1135934")]
			set
			{
			}
		}

		// Token: 0x0400153B RID: 5435
		[Token(Token = "0x400153B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102224", Offset = "0x1102224")]
		private ulong <friend_id>k__BackingField;

		// Token: 0x0400153C RID: 5436
		[Token(Token = "0x400153C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102234", Offset = "0x1102234")]
		private long <request_time>k__BackingField;

		// Token: 0x0400153D RID: 5437
		[Token(Token = "0x400153D")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102244", Offset = "0x1102244")]
		private uint <relation_type>k__BackingField;

		// Token: 0x0400153E RID: 5438
		[Token(Token = "0x400153E")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102254", Offset = "0x1102254")]
		private bool <is_create>k__BackingField;
	}
}
