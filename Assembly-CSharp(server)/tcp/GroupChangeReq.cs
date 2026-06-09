using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004A8 RID: 1192
	[Token(Token = "0x20004A8")]
	[ProtoContract]
	public class GroupChangeReq
	{
		// Token: 0x06001DE6 RID: 7654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DE6")]
		[Address(RVA = "0x24A333C", Offset = "0x24A333C", VA = "0x7BBCCA333C")]
		public GroupChangeReq()
		{
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x0000CC18 File Offset: 0x0000AE18
		// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700040D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155ED0", Offset = "0x1155ED0")]
		public ulong group_id
		{
			[Token(Token = "0x6001DE7")]
			[Address(RVA = "0x24A33A0", Offset = "0x24A33A0", VA = "0x7BBCCA33A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136584", Offset = "0x1136584")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001DE8")]
			[Address(RVA = "0x24A33A8", Offset = "0x24A33A8", VA = "0x7BBCCA33A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136594", Offset = "0x1136594")]
			set
			{
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001DE9 RID: 7657 RVA: 0x0000CC30 File Offset: 0x0000AE30
		// (set) Token: 0x06001DEA RID: 7658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700040E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155EE4", Offset = "0x1155EE4")]
		public bool auto_group
		{
			[Token(Token = "0x6001DE9")]
			[Address(RVA = "0x24A33B0", Offset = "0x24A33B0", VA = "0x7BBCCA33B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11365A4", Offset = "0x11365A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001DEA")]
			[Address(RVA = "0x24A33B8", Offset = "0x24A33B8", VA = "0x7BBCCA33B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11365B4", Offset = "0x11365B4")]
			set
			{
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x0000CC48 File Offset: 0x0000AE48
		// (set) Token: 0x06001DEC RID: 7660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700040F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155EF8", Offset = "0x1155EF8")]
		public uint group_mode
		{
			[Token(Token = "0x6001DEB")]
			[Address(RVA = "0x24A33C4", Offset = "0x24A33C4", VA = "0x7BBCCA33C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11365C4", Offset = "0x11365C4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001DEC")]
			[Address(RVA = "0x24A33CC", Offset = "0x24A33CC", VA = "0x7BBCCA33CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11365D4", Offset = "0x11365D4")]
			set
			{
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x0000CC60 File Offset: 0x0000AE60
		// (set) Token: 0x06001DEE RID: 7662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000410")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155F0C", Offset = "0x1155F0C")]
		public uint game_mode
		{
			[Token(Token = "0x6001DED")]
			[Address(RVA = "0x24A33D4", Offset = "0x24A33D4", VA = "0x7BBCCA33D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11365E4", Offset = "0x11365E4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001DEE")]
			[Address(RVA = "0x24A33DC", Offset = "0x24A33DC", VA = "0x7BBCCA33DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11365F4", Offset = "0x11365F4")]
			set
			{
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DF0 RID: 7664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000411")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155F20", Offset = "0x1155F20")]
		public uint[] map_ids
		{
			[Token(Token = "0x6001DEF")]
			[Address(RVA = "0x24A33E4", Offset = "0x24A33E4", VA = "0x7BBCCA33E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136604", Offset = "0x1136604")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DF0")]
			[Address(RVA = "0x24A33EC", Offset = "0x24A33EC", VA = "0x7BBCCA33EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136614", Offset = "0x1136614")]
			set
			{
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x0000CC78 File Offset: 0x0000AE78
		// (set) Token: 0x06001DF2 RID: 7666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000412")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155F5C", Offset = "0x1155F5C")]
		public uint difficulty
		{
			[Token(Token = "0x6001DF1")]
			[Address(RVA = "0x24A33F4", Offset = "0x24A33F4", VA = "0x7BBCCA33F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136624", Offset = "0x1136624")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001DF2")]
			[Address(RVA = "0x24A33FC", Offset = "0x24A33FC", VA = "0x7BBCCA33FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136634", Offset = "0x1136634")]
			set
			{
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001DF3 RID: 7667 RVA: 0x0000CC90 File Offset: 0x0000AE90
		// (set) Token: 0x06001DF4 RID: 7668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000413")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155F70", Offset = "0x1155F70")]
		public uint match_mode
		{
			[Token(Token = "0x6001DF3")]
			[Address(RVA = "0x24A3404", Offset = "0x24A3404", VA = "0x7BBCCA3404")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136644", Offset = "0x1136644")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001DF4")]
			[Address(RVA = "0x24A340C", Offset = "0x24A340C", VA = "0x7BBCCA340C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136654", Offset = "0x1136654")]
			set
			{
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
		// (set) Token: 0x06001DF6 RID: 7670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000414")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155F84", Offset = "0x1155F84")]
		public uint required_rank
		{
			[Token(Token = "0x6001DF5")]
			[Address(RVA = "0x24A3414", Offset = "0x24A3414", VA = "0x7BBCCA3414")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136664", Offset = "0x1136664")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001DF6")]
			[Address(RVA = "0x24A341C", Offset = "0x24A341C", VA = "0x7BBCCA341C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136674", Offset = "0x1136674")]
			set
			{
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001DF7 RID: 7671 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DF8 RID: 7672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000415")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155F98", Offset = "0x1155F98")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1155F98", Offset = "0x1155F98")]
		public string group_tag
		{
			[Token(Token = "0x6001DF7")]
			[Address(RVA = "0x24A3424", Offset = "0x24A3424", VA = "0x7BBCCA3424")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136684", Offset = "0x1136684")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DF8")]
			[Address(RVA = "0x24A3398", Offset = "0x24A3398", VA = "0x7BBCCA3398")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136694", Offset = "0x1136694")]
			set
			{
			}
		}

		// Token: 0x04001632 RID: 5682
		[Token(Token = "0x4001632")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102884", Offset = "0x1102884")]
		private ulong <group_id>k__BackingField;

		// Token: 0x04001633 RID: 5683
		[Token(Token = "0x4001633")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102894", Offset = "0x1102894")]
		private bool <auto_group>k__BackingField;

		// Token: 0x04001634 RID: 5684
		[Token(Token = "0x4001634")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11028A4", Offset = "0x11028A4")]
		private uint <group_mode>k__BackingField;

		// Token: 0x04001635 RID: 5685
		[Token(Token = "0x4001635")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11028B4", Offset = "0x11028B4")]
		private uint <game_mode>k__BackingField;

		// Token: 0x04001636 RID: 5686
		[Token(Token = "0x4001636")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11028C4", Offset = "0x11028C4")]
		private uint[] <map_ids>k__BackingField;

		// Token: 0x04001637 RID: 5687
		[Token(Token = "0x4001637")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11028D4", Offset = "0x11028D4")]
		private uint <difficulty>k__BackingField;

		// Token: 0x04001638 RID: 5688
		[Token(Token = "0x4001638")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11028E4", Offset = "0x11028E4")]
		private uint <match_mode>k__BackingField;

		// Token: 0x04001639 RID: 5689
		[Token(Token = "0x4001639")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11028F4", Offset = "0x11028F4")]
		private uint <required_rank>k__BackingField;

		// Token: 0x0400163A RID: 5690
		[Token(Token = "0x400163A")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102904", Offset = "0x1102904")]
		private string <group_tag>k__BackingField;
	}
}
