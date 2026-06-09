using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004E0 RID: 1248
	[Token(Token = "0x20004E0")]
	[ProtoContract]
	public class MatchmakingPlayer
	{
		// Token: 0x06001F46 RID: 8006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F46")]
		[Address(RVA = "0x24A51D4", Offset = "0x24A51D4", VA = "0x7BBCCA51D4")]
		public MatchmakingPlayer()
		{
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001F47 RID: 8007 RVA: 0x0000D650 File Offset: 0x0000B850
		// (set) Token: 0x06001F48 RID: 8008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157230", Offset = "0x1157230")]
		public ulong account_id
		{
			[Token(Token = "0x6001F47")]
			[Address(RVA = "0x24A5288", Offset = "0x24A5288", VA = "0x7BBCCA5288")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11378E4", Offset = "0x11378E4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001F48")]
			[Address(RVA = "0x24A5290", Offset = "0x24A5290", VA = "0x7BBCCA5290")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11378F4", Offset = "0x11378F4")]
			set
			{
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001F49 RID: 8009 RVA: 0x0000D668 File Offset: 0x0000B868
		// (set) Token: 0x06001F4A RID: 8010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004A9")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157244", Offset = "0x1157244")]
		public ulong conn_id
		{
			[Token(Token = "0x6001F49")]
			[Address(RVA = "0x24A5298", Offset = "0x24A5298", VA = "0x7BBCCA5298")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137904", Offset = "0x1137904")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001F4A")]
			[Address(RVA = "0x24A52A0", Offset = "0x24A52A0", VA = "0x7BBCCA52A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137914", Offset = "0x1137914")]
			set
			{
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001F4B RID: 8011 RVA: 0x0000D680 File Offset: 0x0000B880
		// (set) Token: 0x06001F4C RID: 8012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AA")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157258", Offset = "0x1157258")]
		public ulong group_id
		{
			[Token(Token = "0x6001F4B")]
			[Address(RVA = "0x24A52A8", Offset = "0x24A52A8", VA = "0x7BBCCA52A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137924", Offset = "0x1137924")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001F4C")]
			[Address(RVA = "0x24A52B0", Offset = "0x24A52B0", VA = "0x7BBCCA52B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137934", Offset = "0x1137934")]
			set
			{
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001F4D RID: 8013 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F4E RID: 8014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AB")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115726C", Offset = "0x115726C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x115726C", Offset = "0x115726C")]
		public string noti_region
		{
			[Token(Token = "0x6001F4D")]
			[Address(RVA = "0x24A52B8", Offset = "0x24A52B8", VA = "0x7BBCCA52B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137944", Offset = "0x1137944")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F4E")]
			[Address(RVA = "0x24A5268", Offset = "0x24A5268", VA = "0x7BBCCA5268")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137954", Offset = "0x1137954")]
			set
			{
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001F4F RID: 8015 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F50 RID: 8016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AC")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11572BC", Offset = "0x11572BC")]
		public AccountMatchInfo basic_info
		{
			[Token(Token = "0x6001F4F")]
			[Address(RVA = "0x24A52C0", Offset = "0x24A52C0", VA = "0x7BBCCA52C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137964", Offset = "0x1137964")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F50")]
			[Address(RVA = "0x24A52C8", Offset = "0x24A52C8", VA = "0x7BBCCA52C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137974", Offset = "0x1137974")]
			set
			{
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x0000D698 File Offset: 0x0000B898
		// (set) Token: 0x06001F52 RID: 8018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AD")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11572D0", Offset = "0x11572D0")]
		public bool is_hacker
		{
			[Token(Token = "0x6001F51")]
			[Address(RVA = "0x24A52D0", Offset = "0x24A52D0", VA = "0x7BBCCA52D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137984", Offset = "0x1137984")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F52")]
			[Address(RVA = "0x24A52D8", Offset = "0x24A52D8", VA = "0x7BBCCA52D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137994", Offset = "0x1137994")]
			set
			{
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001F53 RID: 8019 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		// (set) Token: 0x06001F54 RID: 8020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AE")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11572E4", Offset = "0x11572E4")]
		public uint using_version
		{
			[Token(Token = "0x6001F53")]
			[Address(RVA = "0x24A52E4", Offset = "0x24A52E4", VA = "0x7BBCCA52E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11379A4", Offset = "0x11379A4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F54")]
			[Address(RVA = "0x24A52EC", Offset = "0x24A52EC", VA = "0x7BBCCA52EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11379B4", Offset = "0x11379B4")]
			set
			{
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001F55 RID: 8021 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F56 RID: 8022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AF")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11572F8", Offset = "0x11572F8")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11572F8", Offset = "0x11572F8")]
		public string ip_region
		{
			[Token(Token = "0x6001F55")]
			[Address(RVA = "0x24A52F4", Offset = "0x24A52F4", VA = "0x7BBCCA52F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11379C4", Offset = "0x11379C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F56")]
			[Address(RVA = "0x24A5270", Offset = "0x24A5270", VA = "0x7BBCCA5270")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11379D4", Offset = "0x11379D4")]
			set
			{
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x0000D6C8 File Offset: 0x0000B8C8
		// (set) Token: 0x06001F58 RID: 8024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157348", Offset = "0x1157348")]
		public uint emulator_score
		{
			[Token(Token = "0x6001F57")]
			[Address(RVA = "0x24A52FC", Offset = "0x24A52FC", VA = "0x7BBCCA52FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11379E4", Offset = "0x11379E4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F58")]
			[Address(RVA = "0x24A5304", Offset = "0x24A5304", VA = "0x7BBCCA5304")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11379F4", Offset = "0x11379F4")]
			set
			{
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001F59 RID: 8025 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
		// (set) Token: 0x06001F5A RID: 8026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B1")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115735C", Offset = "0x115735C")]
		public uint hacker_cdt_id
		{
			[Token(Token = "0x6001F59")]
			[Address(RVA = "0x24A530C", Offset = "0x24A530C", VA = "0x7BBCCA530C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137A04", Offset = "0x1137A04")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001F5A")]
			[Address(RVA = "0x24A5314", Offset = "0x24A5314", VA = "0x7BBCCA5314")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137A14", Offset = "0x1137A14")]
			set
			{
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001F5B RID: 8027 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F5C RID: 8028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B2")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157370", Offset = "0x1157370")]
		public List<AccountIDCPingInfo> ping_list
		{
			[Token(Token = "0x6001F5B")]
			[Address(RVA = "0x24A531C", Offset = "0x24A531C", VA = "0x7BBCCA531C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137A24", Offset = "0x1137A24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F5C")]
			[Address(RVA = "0x24A5278", Offset = "0x24A5278", VA = "0x7BBCCA5278")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137A34", Offset = "0x1137A34")]
			private set
			{
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001F5D RID: 8029 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F5E RID: 8030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B3")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157384", Offset = "0x1157384")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1157384", Offset = "0x1157384")]
		public string pre_group_idc
		{
			[Token(Token = "0x6001F5D")]
			[Address(RVA = "0x24A5324", Offset = "0x24A5324", VA = "0x7BBCCA5324")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137A44", Offset = "0x1137A44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F5E")]
			[Address(RVA = "0x24A5280", Offset = "0x24A5280", VA = "0x7BBCCA5280")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137A54", Offset = "0x1137A54")]
			set
			{
			}
		}

		// Token: 0x04001727 RID: 5927
		[Token(Token = "0x4001727")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103234", Offset = "0x1103234")]
		private ulong <account_id>k__BackingField;

		// Token: 0x04001728 RID: 5928
		[Token(Token = "0x4001728")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103244", Offset = "0x1103244")]
		private ulong <conn_id>k__BackingField;

		// Token: 0x04001729 RID: 5929
		[Token(Token = "0x4001729")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103254", Offset = "0x1103254")]
		private ulong <group_id>k__BackingField;

		// Token: 0x0400172A RID: 5930
		[Token(Token = "0x400172A")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103264", Offset = "0x1103264")]
		private string <noti_region>k__BackingField;

		// Token: 0x0400172B RID: 5931
		[Token(Token = "0x400172B")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103274", Offset = "0x1103274")]
		private AccountMatchInfo <basic_info>k__BackingField;

		// Token: 0x0400172C RID: 5932
		[Token(Token = "0x400172C")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103284", Offset = "0x1103284")]
		private bool <is_hacker>k__BackingField;

		// Token: 0x0400172D RID: 5933
		[Token(Token = "0x400172D")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103294", Offset = "0x1103294")]
		private uint <using_version>k__BackingField;

		// Token: 0x0400172E RID: 5934
		[Token(Token = "0x400172E")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11032A4", Offset = "0x11032A4")]
		private string <ip_region>k__BackingField;

		// Token: 0x0400172F RID: 5935
		[Token(Token = "0x400172F")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11032B4", Offset = "0x11032B4")]
		private uint <emulator_score>k__BackingField;

		// Token: 0x04001730 RID: 5936
		[Token(Token = "0x4001730")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11032C4", Offset = "0x11032C4")]
		private uint <hacker_cdt_id>k__BackingField;

		// Token: 0x04001731 RID: 5937
		[Token(Token = "0x4001731")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11032D4", Offset = "0x11032D4")]
		private List<AccountIDCPingInfo> <ping_list>k__BackingField;

		// Token: 0x04001732 RID: 5938
		[Token(Token = "0x4001732")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11032E4", Offset = "0x11032E4")]
		private string <pre_group_idc>k__BackingField;
	}
}
