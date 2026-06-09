using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004DF RID: 1247
	[Token(Token = "0x20004DF")]
	[ProtoContract]
	public class MatchmakingSussNtf
	{
		// Token: 0x06001F2B RID: 7979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F2B")]
		[Address(RVA = "0x24A5488", Offset = "0x24A5488", VA = "0x7BBCCA5488")]
		public MatchmakingSussNtf()
		{
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001F2C RID: 7980 RVA: 0x0000D560 File Offset: 0x0000B760
		// (set) Token: 0x06001F2D RID: 7981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700049B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157078", Offset = "0x1157078")]
		public ulong match_id
		{
			[Token(Token = "0x6001F2C")]
			[Address(RVA = "0x24A5500", Offset = "0x24A5500", VA = "0x7BBCCA5500")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137744", Offset = "0x1137744")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001F2D")]
			[Address(RVA = "0x24A5508", Offset = "0x24A5508", VA = "0x7BBCCA5508")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137754", Offset = "0x1137754")]
			set
			{
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001F2E RID: 7982 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F2F RID: 7983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700049C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x115708C", Offset = "0x115708C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115708C", Offset = "0x115708C")]
		public string server_addr
		{
			[Token(Token = "0x6001F2E")]
			[Address(RVA = "0x24A5510", Offset = "0x24A5510", VA = "0x7BBCCA5510")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137764", Offset = "0x1137764")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F2F")]
			[Address(RVA = "0x24A54E8", Offset = "0x24A54E8", VA = "0x7BBCCA54E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137774", Offset = "0x1137774")]
			set
			{
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001F30 RID: 7984 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F31 RID: 7985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700049D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11570DC", Offset = "0x11570DC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11570DC", Offset = "0x11570DC")]
		public string secret
		{
			[Token(Token = "0x6001F30")]
			[Address(RVA = "0x24A5518", Offset = "0x24A5518", VA = "0x7BBCCA5518")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137784", Offset = "0x1137784")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F31")]
			[Address(RVA = "0x24A54F0", Offset = "0x24A54F0", VA = "0x7BBCCA54F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137794", Offset = "0x1137794")]
			set
			{
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001F32 RID: 7986 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F33 RID: 7987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700049E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115712C", Offset = "0x115712C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x115712C", Offset = "0x115712C")]
		public string prepare_token
		{
			[Token(Token = "0x6001F32")]
			[Address(RVA = "0x24A5520", Offset = "0x24A5520", VA = "0x7BBCCA5520")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11377A4", Offset = "0x11377A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F33")]
			[Address(RVA = "0x24A54F8", Offset = "0x24A54F8", VA = "0x7BBCCA54F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11377B4", Offset = "0x11377B4")]
			set
			{
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001F34 RID: 7988 RVA: 0x0000D578 File Offset: 0x0000B778
		// (set) Token: 0x06001F35 RID: 7989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700049F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115717C", Offset = "0x115717C")]
		public uint sleep_ms
		{
			[Token(Token = "0x6001F34")]
			[Address(RVA = "0x24A5528", Offset = "0x24A5528", VA = "0x7BBCCA5528")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11377C4", Offset = "0x11377C4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F35")]
			[Address(RVA = "0x24A5530", Offset = "0x24A5530", VA = "0x7BBCCA5530")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11377D4", Offset = "0x11377D4")]
			set
			{
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001F36 RID: 7990 RVA: 0x0000D590 File Offset: 0x0000B790
		// (set) Token: 0x06001F37 RID: 7991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157190", Offset = "0x1157190")]
		public uint map_id
		{
			[Token(Token = "0x6001F36")]
			[Address(RVA = "0x24A5538", Offset = "0x24A5538", VA = "0x7BBCCA5538")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11377E4", Offset = "0x11377E4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F37")]
			[Address(RVA = "0x24A5540", Offset = "0x24A5540", VA = "0x7BBCCA5540")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11377F4", Offset = "0x11377F4")]
			set
			{
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001F38 RID: 7992 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
		// (set) Token: 0x06001F39 RID: 7993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A1")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11571A4", Offset = "0x11571A4")]
		public uint game_mode
		{
			[Token(Token = "0x6001F38")]
			[Address(RVA = "0x24A5548", Offset = "0x24A5548", VA = "0x7BBCCA5548")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137804", Offset = "0x1137804")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F39")]
			[Address(RVA = "0x24A5550", Offset = "0x24A5550", VA = "0x7BBCCA5550")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137814", Offset = "0x1137814")]
			set
			{
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001F3A RID: 7994 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
		// (set) Token: 0x06001F3B RID: 7995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A2")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11571B8", Offset = "0x11571B8")]
		public uint match_mode
		{
			[Token(Token = "0x6001F3A")]
			[Address(RVA = "0x24A5558", Offset = "0x24A5558", VA = "0x7BBCCA5558")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137824", Offset = "0x1137824")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F3B")]
			[Address(RVA = "0x24A5560", Offset = "0x24A5560", VA = "0x7BBCCA5560")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137834", Offset = "0x1137834")]
			set
			{
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001F3C RID: 7996 RVA: 0x0000D5D8 File Offset: 0x0000B7D8
		// (set) Token: 0x06001F3D RID: 7997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A3")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11571CC", Offset = "0x11571CC")]
		public bool use_cache
		{
			[Token(Token = "0x6001F3C")]
			[Address(RVA = "0x24A5568", Offset = "0x24A5568", VA = "0x7BBCCA5568")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137844", Offset = "0x1137844")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F3D")]
			[Address(RVA = "0x24A5570", Offset = "0x24A5570", VA = "0x7BBCCA5570")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137854", Offset = "0x1137854")]
			set
			{
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001F3E RID: 7998 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
		// (set) Token: 0x06001F3F RID: 7999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11571E0", Offset = "0x11571E0")]
		public uint level_visual_style
		{
			[Token(Token = "0x6001F3E")]
			[Address(RVA = "0x24A557C", Offset = "0x24A557C", VA = "0x7BBCCA557C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137864", Offset = "0x1137864")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F3F")]
			[Address(RVA = "0x24A5584", Offset = "0x24A5584", VA = "0x7BBCCA5584")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137874", Offset = "0x1137874")]
			set
			{
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001F40 RID: 8000 RVA: 0x0000D608 File Offset: 0x0000B808
		// (set) Token: 0x06001F41 RID: 8001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A5")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11571F4", Offset = "0x11571F4")]
		public uint difficulty
		{
			[Token(Token = "0x6001F40")]
			[Address(RVA = "0x24A558C", Offset = "0x24A558C", VA = "0x7BBCCA558C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137884", Offset = "0x1137884")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F41")]
			[Address(RVA = "0x24A5594", Offset = "0x24A5594", VA = "0x7BBCCA5594")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137894", Offset = "0x1137894")]
			set
			{
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001F42 RID: 8002 RVA: 0x0000D620 File Offset: 0x0000B820
		// (set) Token: 0x06001F43 RID: 8003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A6")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157208", Offset = "0x1157208")]
		public bool first_login
		{
			[Token(Token = "0x6001F42")]
			[Address(RVA = "0x24A559C", Offset = "0x24A559C", VA = "0x7BBCCA559C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11378A4", Offset = "0x11378A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F43")]
			[Address(RVA = "0x24A55A4", Offset = "0x24A55A4", VA = "0x7BBCCA55A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11378B4", Offset = "0x11378B4")]
			set
			{
			}
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001F44 RID: 8004 RVA: 0x0000D638 File Offset: 0x0000B838
		// (set) Token: 0x06001F45 RID: 8005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A7")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115721C", Offset = "0x115721C")]
		public bool is_in_special_pool
		{
			[Token(Token = "0x6001F44")]
			[Address(RVA = "0x24A55B0", Offset = "0x24A55B0", VA = "0x7BBCCA55B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11378C4", Offset = "0x11378C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F45")]
			[Address(RVA = "0x24A55B8", Offset = "0x24A55B8", VA = "0x7BBCCA55B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11378D4", Offset = "0x11378D4")]
			set
			{
			}
		}

		// Token: 0x0400171A RID: 5914
		[Token(Token = "0x400171A")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103164", Offset = "0x1103164")]
		private ulong <match_id>k__BackingField;

		// Token: 0x0400171B RID: 5915
		[Token(Token = "0x400171B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103174", Offset = "0x1103174")]
		private string <server_addr>k__BackingField;

		// Token: 0x0400171C RID: 5916
		[Token(Token = "0x400171C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103184", Offset = "0x1103184")]
		private string <secret>k__BackingField;

		// Token: 0x0400171D RID: 5917
		[Token(Token = "0x400171D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103194", Offset = "0x1103194")]
		private string <prepare_token>k__BackingField;

		// Token: 0x0400171E RID: 5918
		[Token(Token = "0x400171E")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11031A4", Offset = "0x11031A4")]
		private uint <sleep_ms>k__BackingField;

		// Token: 0x0400171F RID: 5919
		[Token(Token = "0x400171F")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11031B4", Offset = "0x11031B4")]
		private uint <map_id>k__BackingField;

		// Token: 0x04001720 RID: 5920
		[Token(Token = "0x4001720")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11031C4", Offset = "0x11031C4")]
		private uint <game_mode>k__BackingField;

		// Token: 0x04001721 RID: 5921
		[Token(Token = "0x4001721")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11031D4", Offset = "0x11031D4")]
		private uint <match_mode>k__BackingField;

		// Token: 0x04001722 RID: 5922
		[Token(Token = "0x4001722")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11031E4", Offset = "0x11031E4")]
		private bool <use_cache>k__BackingField;

		// Token: 0x04001723 RID: 5923
		[Token(Token = "0x4001723")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11031F4", Offset = "0x11031F4")]
		private uint <level_visual_style>k__BackingField;

		// Token: 0x04001724 RID: 5924
		[Token(Token = "0x4001724")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103204", Offset = "0x1103204")]
		private uint <difficulty>k__BackingField;

		// Token: 0x04001725 RID: 5925
		[Token(Token = "0x4001725")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103214", Offset = "0x1103214")]
		private bool <first_login>k__BackingField;

		// Token: 0x04001726 RID: 5926
		[Token(Token = "0x4001726")]
		[FieldOffset(Offset = "0x4D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103224", Offset = "0x1103224")]
		private bool <is_in_special_pool>k__BackingField;
	}
}
