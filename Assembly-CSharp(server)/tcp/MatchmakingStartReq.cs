using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004DC RID: 1244
	[Token(Token = "0x20004DC")]
	[ProtoContract]
	public class MatchmakingStartReq
	{
		// Token: 0x06001EFC RID: 7932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001EFC")]
		[Address(RVA = "0x24A5384", Offset = "0x24A5384", VA = "0x7BBCCA5384")]
		public MatchmakingStartReq()
		{
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001EFD RID: 7933 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001EFE RID: 7934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000485")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156DE4", Offset = "0x1156DE4")]
		public uint[] map_ids
		{
			[Token(Token = "0x6001EFD")]
			[Address(RVA = "0x24A5400", Offset = "0x24A5400", VA = "0x7BBCCA5400")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137484", Offset = "0x1137484")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EFE")]
			[Address(RVA = "0x24A5408", Offset = "0x24A5408", VA = "0x7BBCCA5408")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137494", Offset = "0x1137494")]
			set
			{
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06001EFF RID: 7935 RVA: 0x0000D428 File Offset: 0x0000B628
		// (set) Token: 0x06001F00 RID: 7936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000486")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156E20", Offset = "0x1156E20")]
		public uint game_mode
		{
			[Token(Token = "0x6001EFF")]
			[Address(RVA = "0x24A5410", Offset = "0x24A5410", VA = "0x7BBCCA5410")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11374A4", Offset = "0x11374A4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F00")]
			[Address(RVA = "0x24A5418", Offset = "0x24A5418", VA = "0x7BBCCA5418")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11374B4", Offset = "0x11374B4")]
			set
			{
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06001F01 RID: 7937 RVA: 0x0000D440 File Offset: 0x0000B640
		// (set) Token: 0x06001F02 RID: 7938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000487")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156E34", Offset = "0x1156E34")]
		public uint difficulty
		{
			[Token(Token = "0x6001F01")]
			[Address(RVA = "0x24A5420", Offset = "0x24A5420", VA = "0x7BBCCA5420")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11374C4", Offset = "0x11374C4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F02")]
			[Address(RVA = "0x24A5428", Offset = "0x24A5428", VA = "0x7BBCCA5428")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11374D4", Offset = "0x11374D4")]
			set
			{
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001F03 RID: 7939 RVA: 0x0000D458 File Offset: 0x0000B658
		// (set) Token: 0x06001F04 RID: 7940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000488")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156E48", Offset = "0x1156E48")]
		public uint wta_currency_type
		{
			[Token(Token = "0x6001F03")]
			[Address(RVA = "0x24A5430", Offset = "0x24A5430", VA = "0x7BBCCA5430")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11374E4", Offset = "0x11374E4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F04")]
			[Address(RVA = "0x24A5438", Offset = "0x24A5438", VA = "0x7BBCCA5438")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11374F4", Offset = "0x11374F4")]
			set
			{
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001F05 RID: 7941 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F06 RID: 7942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000489")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156E5C", Offset = "0x1156E5C")]
		public List<AccountIDCPingInfo> ping_list
		{
			[Token(Token = "0x6001F05")]
			[Address(RVA = "0x24A5440", Offset = "0x24A5440", VA = "0x7BBCCA5440")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137504", Offset = "0x1137504")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F06")]
			[Address(RVA = "0x24A53F8", Offset = "0x24A53F8", VA = "0x7BBCCA53F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137514", Offset = "0x1137514")]
			private set
			{
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06001F07 RID: 7943 RVA: 0x0000D470 File Offset: 0x0000B670
		// (set) Token: 0x06001F08 RID: 7944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700048A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156E70", Offset = "0x1156E70")]
		public uint match_mode
		{
			[Token(Token = "0x6001F07")]
			[Address(RVA = "0x24A5448", Offset = "0x24A5448", VA = "0x7BBCCA5448")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137524", Offset = "0x1137524")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F08")]
			[Address(RVA = "0x24A5450", Offset = "0x24A5450", VA = "0x7BBCCA5450")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137534", Offset = "0x1137534")]
			set
			{
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001F09 RID: 7945 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F0A RID: 7946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700048B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156E84", Offset = "0x1156E84")]
		public uint[] available_maps
		{
			[Token(Token = "0x6001F09")]
			[Address(RVA = "0x24A5458", Offset = "0x24A5458", VA = "0x7BBCCA5458")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137544", Offset = "0x1137544")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F0A")]
			[Address(RVA = "0x24A5460", Offset = "0x24A5460", VA = "0x7BBCCA5460")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137554", Offset = "0x1137554")]
			set
			{
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001F0B RID: 7947 RVA: 0x0000D488 File Offset: 0x0000B688
		// (set) Token: 0x06001F0C RID: 7948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700048C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156EC0", Offset = "0x1156EC0")]
		public uint system_platform
		{
			[Token(Token = "0x6001F0B")]
			[Address(RVA = "0x24A5468", Offset = "0x24A5468", VA = "0x7BBCCA5468")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137564", Offset = "0x1137564")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F0C")]
			[Address(RVA = "0x24A5470", Offset = "0x24A5470", VA = "0x7BBCCA5470")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137574", Offset = "0x1137574")]
			set
			{
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001F0D RID: 7949 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F0E RID: 7950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700048D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156ED4", Offset = "0x1156ED4")]
		public MatchClientInfo client_info
		{
			[Token(Token = "0x6001F0D")]
			[Address(RVA = "0x24A5478", Offset = "0x24A5478", VA = "0x7BBCCA5478")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137584", Offset = "0x1137584")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F0E")]
			[Address(RVA = "0x24A5480", Offset = "0x24A5480", VA = "0x7BBCCA5480")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137594", Offset = "0x1137594")]
			set
			{
			}
		}

		// Token: 0x04001704 RID: 5892
		[Token(Token = "0x4001704")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103004", Offset = "0x1103004")]
		private uint[] <map_ids>k__BackingField;

		// Token: 0x04001705 RID: 5893
		[Token(Token = "0x4001705")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103014", Offset = "0x1103014")]
		private uint <game_mode>k__BackingField;

		// Token: 0x04001706 RID: 5894
		[Token(Token = "0x4001706")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103024", Offset = "0x1103024")]
		private uint <difficulty>k__BackingField;

		// Token: 0x04001707 RID: 5895
		[Token(Token = "0x4001707")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103034", Offset = "0x1103034")]
		private uint <wta_currency_type>k__BackingField;

		// Token: 0x04001708 RID: 5896
		[Token(Token = "0x4001708")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103044", Offset = "0x1103044")]
		private List<AccountIDCPingInfo> <ping_list>k__BackingField;

		// Token: 0x04001709 RID: 5897
		[Token(Token = "0x4001709")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103054", Offset = "0x1103054")]
		private uint <match_mode>k__BackingField;

		// Token: 0x0400170A RID: 5898
		[Token(Token = "0x400170A")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103064", Offset = "0x1103064")]
		private uint[] <available_maps>k__BackingField;

		// Token: 0x0400170B RID: 5899
		[Token(Token = "0x400170B")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103074", Offset = "0x1103074")]
		private uint <system_platform>k__BackingField;

		// Token: 0x0400170C RID: 5900
		[Token(Token = "0x400170C")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103084", Offset = "0x1103084")]
		private MatchClientInfo <client_info>k__BackingField;
	}
}
