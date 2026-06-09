using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004DD RID: 1245
	[Token(Token = "0x20004DD")]
	[ProtoContract]
	public class MatchmakingGroupStartReq
	{
		// Token: 0x06001F0F RID: 7951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F0F")]
		[Address(RVA = "0x24A5064", Offset = "0x24A5064", VA = "0x7BBCCA5064")]
		public MatchmakingGroupStartReq()
		{
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06001F10 RID: 7952 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F11 RID: 7953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700048E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156EE8", Offset = "0x1156EE8")]
		public uint[] map_ids
		{
			[Token(Token = "0x6001F10")]
			[Address(RVA = "0x24A5128", Offset = "0x24A5128", VA = "0x7BBCCA5128")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11375A4", Offset = "0x11375A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F11")]
			[Address(RVA = "0x24A5130", Offset = "0x24A5130", VA = "0x7BBCCA5130")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11375B4", Offset = "0x11375B4")]
			set
			{
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001F12 RID: 7954 RVA: 0x0000D4A0 File Offset: 0x0000B6A0
		// (set) Token: 0x06001F13 RID: 7955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700048F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156F24", Offset = "0x1156F24")]
		public ulong group_id
		{
			[Token(Token = "0x6001F12")]
			[Address(RVA = "0x24A5138", Offset = "0x24A5138", VA = "0x7BBCCA5138")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11375C4", Offset = "0x11375C4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001F13")]
			[Address(RVA = "0x24A5140", Offset = "0x24A5140", VA = "0x7BBCCA5140")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11375D4", Offset = "0x11375D4")]
			set
			{
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06001F14 RID: 7956 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		// (set) Token: 0x06001F15 RID: 7957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000490")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156F38", Offset = "0x1156F38")]
		public EMatch.GroupMode group_mode
		{
			[Token(Token = "0x6001F14")]
			[Address(RVA = "0x24A5148", Offset = "0x24A5148", VA = "0x7BBCCA5148")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11375E4", Offset = "0x11375E4")]
			get
			{
				return EMatch.GroupMode.GroupMode_SOLO;
			}
			[Token(Token = "0x6001F15")]
			[Address(RVA = "0x24A5150", Offset = "0x24A5150", VA = "0x7BBCCA5150")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11375F4", Offset = "0x11375F4")]
			set
			{
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06001F16 RID: 7958 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F17 RID: 7959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000491")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156F4C", Offset = "0x1156F4C")]
		public List<MatchmakingPlayer> players
		{
			[Token(Token = "0x6001F16")]
			[Address(RVA = "0x24A5158", Offset = "0x24A5158", VA = "0x7BBCCA5158")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137604", Offset = "0x1137604")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F17")]
			[Address(RVA = "0x24A5110", Offset = "0x24A5110", VA = "0x7BBCCA5110")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137614", Offset = "0x1137614")]
			private set
			{
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001F18 RID: 7960 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		// (set) Token: 0x06001F19 RID: 7961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000492")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156F60", Offset = "0x1156F60")]
		public EMatch.GameMode game_mode
		{
			[Token(Token = "0x6001F18")]
			[Address(RVA = "0x24A5160", Offset = "0x24A5160", VA = "0x7BBCCA5160")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137624", Offset = "0x1137624")]
			get
			{
				return EMatch.GameMode.GameMode_NONE;
			}
			[Token(Token = "0x6001F19")]
			[Address(RVA = "0x24A5168", Offset = "0x24A5168", VA = "0x7BBCCA5168")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137634", Offset = "0x1137634")]
			set
			{
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001F1A RID: 7962 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		// (set) Token: 0x06001F1B RID: 7963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000493")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156F74", Offset = "0x1156F74")]
		public uint difficulty
		{
			[Token(Token = "0x6001F1A")]
			[Address(RVA = "0x24A5170", Offset = "0x24A5170", VA = "0x7BBCCA5170")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137644", Offset = "0x1137644")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F1B")]
			[Address(RVA = "0x24A5178", Offset = "0x24A5178", VA = "0x7BBCCA5178")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137654", Offset = "0x1137654")]
			set
			{
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001F1C RID: 7964 RVA: 0x0000D500 File Offset: 0x0000B700
		// (set) Token: 0x06001F1D RID: 7965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000494")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156F88", Offset = "0x1156F88")]
		public bool auto_group
		{
			[Token(Token = "0x6001F1C")]
			[Address(RVA = "0x24A5180", Offset = "0x24A5180", VA = "0x7BBCCA5180")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137664", Offset = "0x1137664")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F1D")]
			[Address(RVA = "0x24A5188", Offset = "0x24A5188", VA = "0x7BBCCA5188")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137674", Offset = "0x1137674")]
			set
			{
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001F1E RID: 7966 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F1F RID: 7967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000495")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156F9C", Offset = "0x1156F9C")]
		public List<GroupMemberAccounts> group_members
		{
			[Token(Token = "0x6001F1E")]
			[Address(RVA = "0x24A5194", Offset = "0x24A5194", VA = "0x7BBCCA5194")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137684", Offset = "0x1137684")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F1F")]
			[Address(RVA = "0x24A5118", Offset = "0x24A5118", VA = "0x7BBCCA5118")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137694", Offset = "0x1137694")]
			private set
			{
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001F20 RID: 7968 RVA: 0x0000D518 File Offset: 0x0000B718
		// (set) Token: 0x06001F21 RID: 7969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000496")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156FB0", Offset = "0x1156FB0")]
		public ulong auto_group_id
		{
			[Token(Token = "0x6001F20")]
			[Address(RVA = "0x24A519C", Offset = "0x24A519C", VA = "0x7BBCCA519C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11376A4", Offset = "0x11376A4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001F21")]
			[Address(RVA = "0x24A51A4", Offset = "0x24A51A4", VA = "0x7BBCCA51A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11376B4", Offset = "0x11376B4")]
			set
			{
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001F22 RID: 7970 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F23 RID: 7971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000497")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156FC4", Offset = "0x1156FC4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1156FC4", Offset = "0x1156FC4")]
		public string group_idc
		{
			[Token(Token = "0x6001F22")]
			[Address(RVA = "0x24A51AC", Offset = "0x24A51AC", VA = "0x7BBCCA51AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11376C4", Offset = "0x11376C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F23")]
			[Address(RVA = "0x24A5120", Offset = "0x24A5120", VA = "0x7BBCCA5120")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11376D4", Offset = "0x11376D4")]
			set
			{
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001F24 RID: 7972 RVA: 0x0000D530 File Offset: 0x0000B730
		// (set) Token: 0x06001F25 RID: 7973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000498")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157014", Offset = "0x1157014")]
		public EMatch.MatchMode match_mode
		{
			[Token(Token = "0x6001F24")]
			[Address(RVA = "0x24A51B4", Offset = "0x24A51B4", VA = "0x7BBCCA51B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11376E4", Offset = "0x11376E4")]
			get
			{
				return EMatch.MatchMode.MatchMode_NONE;
			}
			[Token(Token = "0x6001F25")]
			[Address(RVA = "0x24A51BC", Offset = "0x24A51BC", VA = "0x7BBCCA51BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11376F4", Offset = "0x11376F4")]
			set
			{
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001F26 RID: 7974 RVA: 0x0000D548 File Offset: 0x0000B748
		// (set) Token: 0x06001F27 RID: 7975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000499")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157028", Offset = "0x1157028")]
		public uint random_map_id
		{
			[Token(Token = "0x6001F26")]
			[Address(RVA = "0x24A51C4", Offset = "0x24A51C4", VA = "0x7BBCCA51C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137704", Offset = "0x1137704")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F27")]
			[Address(RVA = "0x24A51CC", Offset = "0x24A51CC", VA = "0x7BBCCA51CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137714", Offset = "0x1137714")]
			set
			{
			}
		}

		// Token: 0x0400170D RID: 5901
		[Token(Token = "0x400170D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103094", Offset = "0x1103094")]
		private uint[] <map_ids>k__BackingField;

		// Token: 0x0400170E RID: 5902
		[Token(Token = "0x400170E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11030A4", Offset = "0x11030A4")]
		private ulong <group_id>k__BackingField;

		// Token: 0x0400170F RID: 5903
		[Token(Token = "0x400170F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11030B4", Offset = "0x11030B4")]
		private EMatch.GroupMode <group_mode>k__BackingField;

		// Token: 0x04001710 RID: 5904
		[Token(Token = "0x4001710")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11030C4", Offset = "0x11030C4")]
		private List<MatchmakingPlayer> <players>k__BackingField;

		// Token: 0x04001711 RID: 5905
		[Token(Token = "0x4001711")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11030D4", Offset = "0x11030D4")]
		private EMatch.GameMode <game_mode>k__BackingField;

		// Token: 0x04001712 RID: 5906
		[Token(Token = "0x4001712")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11030E4", Offset = "0x11030E4")]
		private uint <difficulty>k__BackingField;

		// Token: 0x04001713 RID: 5907
		[Token(Token = "0x4001713")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11030F4", Offset = "0x11030F4")]
		private bool <auto_group>k__BackingField;

		// Token: 0x04001714 RID: 5908
		[Token(Token = "0x4001714")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103104", Offset = "0x1103104")]
		private List<GroupMemberAccounts> <group_members>k__BackingField;

		// Token: 0x04001715 RID: 5909
		[Token(Token = "0x4001715")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103114", Offset = "0x1103114")]
		private ulong <auto_group_id>k__BackingField;

		// Token: 0x04001716 RID: 5910
		[Token(Token = "0x4001716")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103124", Offset = "0x1103124")]
		private string <group_idc>k__BackingField;

		// Token: 0x04001717 RID: 5911
		[Token(Token = "0x4001717")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103134", Offset = "0x1103134")]
		private EMatch.MatchMode <match_mode>k__BackingField;

		// Token: 0x04001718 RID: 5912
		[Token(Token = "0x4001718")]
		[FieldOffset(Offset = "0x5C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103144", Offset = "0x1103144")]
		private uint <random_map_id>k__BackingField;
	}
}
