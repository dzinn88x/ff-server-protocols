using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200049A RID: 1178
	[Token(Token = "0x200049A")]
	[ProtoContract]
	public class GroupJoinRequestNtf
	{
		// Token: 0x06001D84 RID: 7556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D84")]
		[Address(RVA = "0x24A3A88", Offset = "0x24A3A88", VA = "0x7BBCCA3A88")]
		public GroupJoinRequestNtf()
		{
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001D85 RID: 7557 RVA: 0x0000C978 File Offset: 0x0000AB78
		// (set) Token: 0x06001D86 RID: 7558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E3")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155A0C", Offset = "0x1155A0C")]
		public ulong joiner_id
		{
			[Token(Token = "0x6001D85")]
			[Address(RVA = "0x24A3B30", Offset = "0x24A3B30", VA = "0x7BBCCA3B30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136044", Offset = "0x1136044")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001D86")]
			[Address(RVA = "0x24A3B38", Offset = "0x24A3B38", VA = "0x7BBCCA3B38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136054", Offset = "0x1136054")]
			set
			{
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001D87 RID: 7559 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D88 RID: 7560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155A20", Offset = "0x1155A20")]
		public uint[] available_maps
		{
			[Token(Token = "0x6001D87")]
			[Address(RVA = "0x24A3B40", Offset = "0x24A3B40", VA = "0x7BBCCA3B40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136064", Offset = "0x1136064")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D88")]
			[Address(RVA = "0x24A3B48", Offset = "0x24A3B48", VA = "0x7BBCCA3B48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136074", Offset = "0x1136074")]
			set
			{
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001D89 RID: 7561 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D8A RID: 7562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E5")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155A5C", Offset = "0x1155A5C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1155A5C", Offset = "0x1155A5C")]
		public string nickname
		{
			[Token(Token = "0x6001D89")]
			[Address(RVA = "0x24A3B50", Offset = "0x24A3B50", VA = "0x7BBCCA3B50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136084", Offset = "0x1136084")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D8A")]
			[Address(RVA = "0x24A3B10", Offset = "0x24A3B10", VA = "0x7BBCCA3B10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136094", Offset = "0x1136094")]
			set
			{
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x0000C990 File Offset: 0x0000AB90
		// (set) Token: 0x06001D8C RID: 7564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E6")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155AAC", Offset = "0x1155AAC")]
		public uint rank
		{
			[Token(Token = "0x6001D8B")]
			[Address(RVA = "0x24A3B58", Offset = "0x24A3B58", VA = "0x7BBCCA3B58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11360A4", Offset = "0x11360A4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D8C")]
			[Address(RVA = "0x24A3B60", Offset = "0x24A3B60", VA = "0x7BBCCA3B60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11360B4", Offset = "0x11360B4")]
			set
			{
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
		// (set) Token: 0x06001D8E RID: 7566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E7")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155AC0", Offset = "0x1155AC0")]
		public uint ranking_points
		{
			[Token(Token = "0x6001D8D")]
			[Address(RVA = "0x24A3B68", Offset = "0x24A3B68", VA = "0x7BBCCA3B68")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11360C4", Offset = "0x11360C4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D8E")]
			[Address(RVA = "0x24A3B70", Offset = "0x24A3B70", VA = "0x7BBCCA3B70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11360D4", Offset = "0x11360D4")]
			set
			{
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
		// (set) Token: 0x06001D90 RID: 7568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155AD4", Offset = "0x1155AD4")]
		public uint emulator_score
		{
			[Token(Token = "0x6001D8F")]
			[Address(RVA = "0x24A3B78", Offset = "0x24A3B78", VA = "0x7BBCCA3B78")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11360E4", Offset = "0x11360E4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D90")]
			[Address(RVA = "0x24A3B80", Offset = "0x24A3B80", VA = "0x7BBCCA3B80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11360F4", Offset = "0x11360F4")]
			set
			{
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D92 RID: 7570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003E9")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155AE8", Offset = "0x1155AE8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1155AE8", Offset = "0x1155AE8")]
		public string country_code
		{
			[Token(Token = "0x6001D91")]
			[Address(RVA = "0x24A3B88", Offset = "0x24A3B88", VA = "0x7BBCCA3B88")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136104", Offset = "0x1136104")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D92")]
			[Address(RVA = "0x24A3B18", Offset = "0x24A3B18", VA = "0x7BBCCA3B18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136114", Offset = "0x1136114")]
			set
			{
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D94 RID: 7572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003EA")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155B38", Offset = "0x1155B38")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1155B38", Offset = "0x1155B38")]
		public string signature_md5
		{
			[Token(Token = "0x6001D93")]
			[Address(RVA = "0x24A3B90", Offset = "0x24A3B90", VA = "0x7BBCCA3B90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136124", Offset = "0x1136124")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D94")]
			[Address(RVA = "0x24A3B20", Offset = "0x24A3B20", VA = "0x7BBCCA3B20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136134", Offset = "0x1136134")]
			set
			{
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		// (set) Token: 0x06001D96 RID: 7574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003EB")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155B88", Offset = "0x1155B88")]
		public uint using_version
		{
			[Token(Token = "0x6001D95")]
			[Address(RVA = "0x24A3B98", Offset = "0x24A3B98", VA = "0x7BBCCA3B98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136144", Offset = "0x1136144")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D96")]
			[Address(RVA = "0x24A3BA0", Offset = "0x24A3BA0", VA = "0x7BBCCA3BA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136154", Offset = "0x1136154")]
			set
			{
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001D97 RID: 7575 RVA: 0x0000C9F0 File Offset: 0x0000ABF0
		// (set) Token: 0x06001D98 RID: 7576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003EC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155B9C", Offset = "0x1155B9C")]
		public EGroup.InviteeType target_type
		{
			[Token(Token = "0x6001D97")]
			[Address(RVA = "0x24A3BA8", Offset = "0x24A3BA8", VA = "0x7BBCCA3BA8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136164", Offset = "0x1136164")]
			get
			{
				return EGroup.InviteeType.InviteeType_NONE;
			}
			[Token(Token = "0x6001D98")]
			[Address(RVA = "0x24A3BB0", Offset = "0x24A3BB0", VA = "0x7BBCCA3BB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136174", Offset = "0x1136174")]
			set
			{
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001D99 RID: 7577 RVA: 0x0000CA08 File Offset: 0x0000AC08
		// (set) Token: 0x06001D9A RID: 7578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003ED")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155BB0", Offset = "0x1155BB0")]
		public uint system_platform
		{
			[Token(Token = "0x6001D99")]
			[Address(RVA = "0x24A3BB8", Offset = "0x24A3BB8", VA = "0x7BBCCA3BB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136184", Offset = "0x1136184")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D9A")]
			[Address(RVA = "0x24A3BC0", Offset = "0x24A3BC0", VA = "0x7BBCCA3BC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136194", Offset = "0x1136194")]
			set
			{
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001D9B RID: 7579 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001D9C RID: 7580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003EE")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155BC4", Offset = "0x1155BC4")]
		public MatchClientInfo client_info
		{
			[Token(Token = "0x6001D9B")]
			[Address(RVA = "0x24A3BC8", Offset = "0x24A3BC8", VA = "0x7BBCCA3BC8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11361A4", Offset = "0x11361A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001D9C")]
			[Address(RVA = "0x24A3BD0", Offset = "0x24A3BD0", VA = "0x7BBCCA3BD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11361B4", Offset = "0x11361B4")]
			set
			{
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001D9D RID: 7581 RVA: 0x0000CA20 File Offset: 0x0000AC20
		// (set) Token: 0x06001D9E RID: 7582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003EF")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155BD8", Offset = "0x1155BD8")]
		public uint cs_rank
		{
			[Token(Token = "0x6001D9D")]
			[Address(RVA = "0x24A3BD8", Offset = "0x24A3BD8", VA = "0x7BBCCA3BD8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11361C4", Offset = "0x11361C4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001D9E")]
			[Address(RVA = "0x24A3BE0", Offset = "0x24A3BE0", VA = "0x7BBCCA3BE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11361D4", Offset = "0x11361D4")]
			set
			{
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001D9F RID: 7583 RVA: 0x0000CA38 File Offset: 0x0000AC38
		// (set) Token: 0x06001DA0 RID: 7584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155BEC", Offset = "0x1155BEC")]
		public uint cs_ranking_points
		{
			[Token(Token = "0x6001D9F")]
			[Address(RVA = "0x24A3BE8", Offset = "0x24A3BE8", VA = "0x7BBCCA3BE8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11361E4", Offset = "0x11361E4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001DA0")]
			[Address(RVA = "0x24A3BF0", Offset = "0x24A3BF0", VA = "0x7BBCCA3BF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11361F4", Offset = "0x11361F4")]
			set
			{
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DA2 RID: 7586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F1")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155C00", Offset = "0x1155C00")]
		public List<AccountIDCPingInfo> ping_list
		{
			[Token(Token = "0x6001DA1")]
			[Address(RVA = "0x24A3BF8", Offset = "0x24A3BF8", VA = "0x7BBCCA3BF8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136204", Offset = "0x1136204")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DA2")]
			[Address(RVA = "0x24A3B28", Offset = "0x24A3B28", VA = "0x7BBCCA3B28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136214", Offset = "0x1136214")]
			private set
			{
			}
		}

		// Token: 0x04001608 RID: 5640
		[Token(Token = "0x4001608")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11025E4", Offset = "0x11025E4")]
		private ulong <joiner_id>k__BackingField;

		// Token: 0x04001609 RID: 5641
		[Token(Token = "0x4001609")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11025F4", Offset = "0x11025F4")]
		private uint[] <available_maps>k__BackingField;

		// Token: 0x0400160A RID: 5642
		[Token(Token = "0x400160A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102604", Offset = "0x1102604")]
		private string <nickname>k__BackingField;

		// Token: 0x0400160B RID: 5643
		[Token(Token = "0x400160B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102614", Offset = "0x1102614")]
		private uint <rank>k__BackingField;

		// Token: 0x0400160C RID: 5644
		[Token(Token = "0x400160C")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102624", Offset = "0x1102624")]
		private uint <ranking_points>k__BackingField;

		// Token: 0x0400160D RID: 5645
		[Token(Token = "0x400160D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102634", Offset = "0x1102634")]
		private uint <emulator_score>k__BackingField;

		// Token: 0x0400160E RID: 5646
		[Token(Token = "0x400160E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102644", Offset = "0x1102644")]
		private string <country_code>k__BackingField;

		// Token: 0x0400160F RID: 5647
		[Token(Token = "0x400160F")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102654", Offset = "0x1102654")]
		private string <signature_md5>k__BackingField;

		// Token: 0x04001610 RID: 5648
		[Token(Token = "0x4001610")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102664", Offset = "0x1102664")]
		private uint <using_version>k__BackingField;

		// Token: 0x04001611 RID: 5649
		[Token(Token = "0x4001611")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102674", Offset = "0x1102674")]
		private EGroup.InviteeType <target_type>k__BackingField;

		// Token: 0x04001612 RID: 5650
		[Token(Token = "0x4001612")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102684", Offset = "0x1102684")]
		private uint <system_platform>k__BackingField;

		// Token: 0x04001613 RID: 5651
		[Token(Token = "0x4001613")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102694", Offset = "0x1102694")]
		private MatchClientInfo <client_info>k__BackingField;

		// Token: 0x04001614 RID: 5652
		[Token(Token = "0x4001614")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11026A4", Offset = "0x11026A4")]
		private uint <cs_rank>k__BackingField;

		// Token: 0x04001615 RID: 5653
		[Token(Token = "0x4001615")]
		[FieldOffset(Offset = "0x64")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11026B4", Offset = "0x11026B4")]
		private uint <cs_ranking_points>k__BackingField;

		// Token: 0x04001616 RID: 5654
		[Token(Token = "0x4001616")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11026C4", Offset = "0x11026C4")]
		private List<AccountIDCPingInfo> <ping_list>k__BackingField;
	}
}
