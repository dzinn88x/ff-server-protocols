using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004AB RID: 1195
	[Token(Token = "0x20004AB")]
	[ProtoContract]
	public class GroupInfo
	{
		// Token: 0x06001E13 RID: 7699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E13")]
		[Address(RVA = "0x24A35C8", Offset = "0x24A35C8", VA = "0x7BBCCA35C8")]
		public GroupInfo()
		{
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001E14 RID: 7700 RVA: 0x0000CD80 File Offset: 0x0000AF80
		// (set) Token: 0x06001E15 RID: 7701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000422")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11561C8", Offset = "0x11561C8")]
		public ulong group_id
		{
			[Token(Token = "0x6001E14")]
			[Address(RVA = "0x24A368C", Offset = "0x24A368C", VA = "0x7BBCCA368C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136824", Offset = "0x1136824")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001E15")]
			[Address(RVA = "0x24A3694", Offset = "0x24A3694", VA = "0x7BBCCA3694")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136834", Offset = "0x1136834")]
			set
			{
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001E16 RID: 7702 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E17 RID: 7703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000423")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11561DC", Offset = "0x11561DC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11561DC", Offset = "0x11561DC")]
		public string region
		{
			[Token(Token = "0x6001E16")]
			[Address(RVA = "0x24A369C", Offset = "0x24A369C", VA = "0x7BBCCA369C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136844", Offset = "0x1136844")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E17")]
			[Address(RVA = "0x24A3664", Offset = "0x24A3664", VA = "0x7BBCCA3664")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136854", Offset = "0x1136854")]
			set
			{
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001E18 RID: 7704 RVA: 0x0000CD98 File Offset: 0x0000AF98
		// (set) Token: 0x06001E19 RID: 7705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000424")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115622C", Offset = "0x115622C")]
		public bool auto_group
		{
			[Token(Token = "0x6001E18")]
			[Address(RVA = "0x24A36A4", Offset = "0x24A36A4", VA = "0x7BBCCA36A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136864", Offset = "0x1136864")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001E19")]
			[Address(RVA = "0x24A36AC", Offset = "0x24A36AC", VA = "0x7BBCCA36AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136874", Offset = "0x1136874")]
			set
			{
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001E1A RID: 7706 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
		// (set) Token: 0x06001E1B RID: 7707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000425")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156240", Offset = "0x1156240")]
		public uint group_mode
		{
			[Token(Token = "0x6001E1A")]
			[Address(RVA = "0x24A36B8", Offset = "0x24A36B8", VA = "0x7BBCCA36B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136884", Offset = "0x1136884")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001E1B")]
			[Address(RVA = "0x24A36C0", Offset = "0x24A36C0", VA = "0x7BBCCA36C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136894", Offset = "0x1136894")]
			set
			{
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E1D RID: 7709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000426")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156254", Offset = "0x1156254")]
		public List<GroupMemberInfo> members
		{
			[Token(Token = "0x6001E1C")]
			[Address(RVA = "0x24A36C8", Offset = "0x24A36C8", VA = "0x7BBCCA36C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11368A4", Offset = "0x11368A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E1D")]
			[Address(RVA = "0x24A366C", Offset = "0x24A366C", VA = "0x7BBCCA366C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11368B4", Offset = "0x11368B4")]
			private set
			{
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001E1E RID: 7710 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E1F RID: 7711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000427")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156268", Offset = "0x1156268")]
		public uint[] map_ids
		{
			[Token(Token = "0x6001E1E")]
			[Address(RVA = "0x24A36D0", Offset = "0x24A36D0", VA = "0x7BBCCA36D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11368C4", Offset = "0x11368C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E1F")]
			[Address(RVA = "0x24A36D8", Offset = "0x24A36D8", VA = "0x7BBCCA36D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11368D4", Offset = "0x11368D4")]
			set
			{
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001E20 RID: 7712 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		// (set) Token: 0x06001E21 RID: 7713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000428")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11562A4", Offset = "0x11562A4")]
		public uint game_mode
		{
			[Token(Token = "0x6001E20")]
			[Address(RVA = "0x24A36E0", Offset = "0x24A36E0", VA = "0x7BBCCA36E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11368E4", Offset = "0x11368E4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001E21")]
			[Address(RVA = "0x24A36E8", Offset = "0x24A36E8", VA = "0x7BBCCA36E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11368F4", Offset = "0x11368F4")]
			set
			{
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001E22 RID: 7714 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		// (set) Token: 0x06001E23 RID: 7715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000429")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11562B8", Offset = "0x11562B8")]
		public uint difficulty
		{
			[Token(Token = "0x6001E22")]
			[Address(RVA = "0x24A36F0", Offset = "0x24A36F0", VA = "0x7BBCCA36F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136904", Offset = "0x1136904")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001E23")]
			[Address(RVA = "0x24A36F8", Offset = "0x24A36F8", VA = "0x7BBCCA36F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136914", Offset = "0x1136914")]
			set
			{
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x0000CDF8 File Offset: 0x0000AFF8
		// (set) Token: 0x06001E25 RID: 7717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11562CC", Offset = "0x11562CC")]
		public uint match_mode
		{
			[Token(Token = "0x6001E24")]
			[Address(RVA = "0x24A3700", Offset = "0x24A3700", VA = "0x7BBCCA3700")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136924", Offset = "0x1136924")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001E25")]
			[Address(RVA = "0x24A3708", Offset = "0x24A3708", VA = "0x7BBCCA3708")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136934", Offset = "0x1136934")]
			set
			{
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001E26 RID: 7718 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E27 RID: 7719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11562E0", Offset = "0x11562E0")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11562E0", Offset = "0x11562E0")]
		public string group_code
		{
			[Token(Token = "0x6001E26")]
			[Address(RVA = "0x24A3710", Offset = "0x24A3710", VA = "0x7BBCCA3710")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136944", Offset = "0x1136944")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E27")]
			[Address(RVA = "0x24A3674", Offset = "0x24A3674", VA = "0x7BBCCA3674")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136954", Offset = "0x1136954")]
			set
			{
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x0000CE10 File Offset: 0x0000B010
		// (set) Token: 0x06001E29 RID: 7721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156330", Offset = "0x1156330")]
		public uint ranking_match_type
		{
			[Token(Token = "0x6001E28")]
			[Address(RVA = "0x24A3718", Offset = "0x24A3718", VA = "0x7BBCCA3718")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136964", Offset = "0x1136964")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001E29")]
			[Address(RVA = "0x24A3720", Offset = "0x24A3720", VA = "0x7BBCCA3720")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136974", Offset = "0x1136974")]
			set
			{
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x0000CE28 File Offset: 0x0000B028
		// (set) Token: 0x06001E2B RID: 7723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156344", Offset = "0x1156344")]
		public bool is_public
		{
			[Token(Token = "0x6001E2A")]
			[Address(RVA = "0x24A3728", Offset = "0x24A3728", VA = "0x7BBCCA3728")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136984", Offset = "0x1136984")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001E2B")]
			[Address(RVA = "0x24A3730", Offset = "0x24A3730", VA = "0x7BBCCA3730")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136994", Offset = "0x1136994")]
			set
			{
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E2D RID: 7725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156358", Offset = "0x1156358")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1156358", Offset = "0x1156358")]
		public string secret_code
		{
			[Token(Token = "0x6001E2C")]
			[Address(RVA = "0x24A373C", Offset = "0x24A373C", VA = "0x7BBCCA373C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11369A4", Offset = "0x11369A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E2D")]
			[Address(RVA = "0x24A367C", Offset = "0x24A367C", VA = "0x7BBCCA367C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11369B4", Offset = "0x11369B4")]
			set
			{
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x0000CE40 File Offset: 0x0000B040
		// (set) Token: 0x06001E2F RID: 7727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11563A8", Offset = "0x11563A8")]
		public uint required_rank
		{
			[Token(Token = "0x6001E2E")]
			[Address(RVA = "0x24A3744", Offset = "0x24A3744", VA = "0x7BBCCA3744")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11369C4", Offset = "0x11369C4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001E2F")]
			[Address(RVA = "0x24A374C", Offset = "0x24A374C", VA = "0x7BBCCA374C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11369D4", Offset = "0x11369D4")]
			set
			{
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001E30 RID: 7728 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E31 RID: 7729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000430")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11563BC", Offset = "0x11563BC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11563BC", Offset = "0x11563BC")]
		public string group_tag
		{
			[Token(Token = "0x6001E30")]
			[Address(RVA = "0x24A3754", Offset = "0x24A3754", VA = "0x7BBCCA3754")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11369E4", Offset = "0x11369E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E31")]
			[Address(RVA = "0x24A3684", Offset = "0x24A3684", VA = "0x7BBCCA3684")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11369F4", Offset = "0x11369F4")]
			set
			{
			}
		}

		// Token: 0x04001647 RID: 5703
		[Token(Token = "0x4001647")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11029D4", Offset = "0x11029D4")]
		private ulong <group_id>k__BackingField;

		// Token: 0x04001648 RID: 5704
		[Token(Token = "0x4001648")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11029E4", Offset = "0x11029E4")]
		private string <region>k__BackingField;

		// Token: 0x04001649 RID: 5705
		[Token(Token = "0x4001649")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11029F4", Offset = "0x11029F4")]
		private bool <auto_group>k__BackingField;

		// Token: 0x0400164A RID: 5706
		[Token(Token = "0x400164A")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102A04", Offset = "0x1102A04")]
		private uint <group_mode>k__BackingField;

		// Token: 0x0400164B RID: 5707
		[Token(Token = "0x400164B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102A14", Offset = "0x1102A14")]
		private List<GroupMemberInfo> <members>k__BackingField;

		// Token: 0x0400164C RID: 5708
		[Token(Token = "0x400164C")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102A24", Offset = "0x1102A24")]
		private uint[] <map_ids>k__BackingField;

		// Token: 0x0400164D RID: 5709
		[Token(Token = "0x400164D")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102A34", Offset = "0x1102A34")]
		private uint <game_mode>k__BackingField;

		// Token: 0x0400164E RID: 5710
		[Token(Token = "0x400164E")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102A44", Offset = "0x1102A44")]
		private uint <difficulty>k__BackingField;

		// Token: 0x0400164F RID: 5711
		[Token(Token = "0x400164F")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102A54", Offset = "0x1102A54")]
		private uint <match_mode>k__BackingField;

		// Token: 0x04001650 RID: 5712
		[Token(Token = "0x4001650")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102A64", Offset = "0x1102A64")]
		private string <group_code>k__BackingField;

		// Token: 0x04001651 RID: 5713
		[Token(Token = "0x4001651")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102A74", Offset = "0x1102A74")]
		private uint <ranking_match_type>k__BackingField;

		// Token: 0x04001652 RID: 5714
		[Token(Token = "0x4001652")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102A84", Offset = "0x1102A84")]
		private bool <is_public>k__BackingField;

		// Token: 0x04001653 RID: 5715
		[Token(Token = "0x4001653")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102A94", Offset = "0x1102A94")]
		private string <secret_code>k__BackingField;

		// Token: 0x04001654 RID: 5716
		[Token(Token = "0x4001654")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102AA4", Offset = "0x1102AA4")]
		private uint <required_rank>k__BackingField;

		// Token: 0x04001655 RID: 5717
		[Token(Token = "0x4001655")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102AB4", Offset = "0x1102AB4")]
		private string <group_tag>k__BackingField;
	}
}
