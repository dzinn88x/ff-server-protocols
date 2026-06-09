using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200050D RID: 1293
	[Token(Token = "0x200050D")]
	[ProtoContract]
	public class JoinRoomPlayerInfo
	{
		// Token: 0x06002045 RID: 8261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002045")]
		[Address(RVA = "0x24A4530", Offset = "0x24A4530", VA = "0x7BBCCA4530")]
		public JoinRoomPlayerInfo()
		{
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06002046 RID: 8262 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
		// (set) Token: 0x06002047 RID: 8263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157FC8", Offset = "0x1157FC8")]
		public ulong conn_id
		{
			[Token(Token = "0x6002046")]
			[Address(RVA = "0x24A4594", Offset = "0x24A4594", VA = "0x7BBCCA4594")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138724", Offset = "0x1138724")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002047")]
			[Address(RVA = "0x24A459C", Offset = "0x24A459C", VA = "0x7BBCCA459C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138734", Offset = "0x1138734")]
			set
			{
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06002048 RID: 8264 RVA: 0x0000DDB8 File Offset: 0x0000BFB8
		// (set) Token: 0x06002049 RID: 8265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157FDC", Offset = "0x1157FDC")]
		public uint emulator_score
		{
			[Token(Token = "0x6002048")]
			[Address(RVA = "0x24A45A4", Offset = "0x24A45A4", VA = "0x7BBCCA45A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138744", Offset = "0x1138744")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002049")]
			[Address(RVA = "0x24A45AC", Offset = "0x24A45AC", VA = "0x7BBCCA45AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138754", Offset = "0x1138754")]
			set
			{
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x0600204A RID: 8266 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600204B RID: 8267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157FF0", Offset = "0x1157FF0")]
		public AccountMatchInfo basic_info
		{
			[Token(Token = "0x600204A")]
			[Address(RVA = "0x24A45B4", Offset = "0x24A45B4", VA = "0x7BBCCA45B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138764", Offset = "0x1138764")]
			get
			{
				return null;
			}
			[Token(Token = "0x600204B")]
			[Address(RVA = "0x24A45BC", Offset = "0x24A45BC", VA = "0x7BBCCA45BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138774", Offset = "0x1138774")]
			set
			{
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x0600204C RID: 8268 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600204D RID: 8269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158004", Offset = "0x1158004")]
		public uint[] available_maps
		{
			[Token(Token = "0x600204C")]
			[Address(RVA = "0x24A45C4", Offset = "0x24A45C4", VA = "0x7BBCCA45C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138784", Offset = "0x1138784")]
			get
			{
				return null;
			}
			[Token(Token = "0x600204D")]
			[Address(RVA = "0x24A45CC", Offset = "0x24A45CC", VA = "0x7BBCCA45CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138794", Offset = "0x1138794")]
			set
			{
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x0600204E RID: 8270 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600204F RID: 8271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051E")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1158040", Offset = "0x1158040")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158040", Offset = "0x1158040")]
		public string country_code
		{
			[Token(Token = "0x600204E")]
			[Address(RVA = "0x24A45D4", Offset = "0x24A45D4", VA = "0x7BBCCA45D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11387A4", Offset = "0x11387A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600204F")]
			[Address(RVA = "0x24A458C", Offset = "0x24A458C", VA = "0x7BBCCA458C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11387B4", Offset = "0x11387B4")]
			set
			{
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06002050 RID: 8272 RVA: 0x0000DDD0 File Offset: 0x0000BFD0
		// (set) Token: 0x06002051 RID: 8273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158090", Offset = "0x1158090")]
		public uint using_version
		{
			[Token(Token = "0x6002050")]
			[Address(RVA = "0x24A45DC", Offset = "0x24A45DC", VA = "0x7BBCCA45DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11387C4", Offset = "0x11387C4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002051")]
			[Address(RVA = "0x24A45E4", Offset = "0x24A45E4", VA = "0x7BBCCA45E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11387D4", Offset = "0x11387D4")]
			set
			{
			}
		}

		// Token: 0x04001834 RID: 6196
		[Token(Token = "0x4001834")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103954", Offset = "0x1103954")]
		private ulong <conn_id>k__BackingField;

		// Token: 0x04001835 RID: 6197
		[Token(Token = "0x4001835")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103964", Offset = "0x1103964")]
		private uint <emulator_score>k__BackingField;

		// Token: 0x04001836 RID: 6198
		[Token(Token = "0x4001836")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103974", Offset = "0x1103974")]
		private AccountMatchInfo <basic_info>k__BackingField;

		// Token: 0x04001837 RID: 6199
		[Token(Token = "0x4001837")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103984", Offset = "0x1103984")]
		private uint[] <available_maps>k__BackingField;

		// Token: 0x04001838 RID: 6200
		[Token(Token = "0x4001838")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103994", Offset = "0x1103994")]
		private string <country_code>k__BackingField;

		// Token: 0x04001839 RID: 6201
		[Token(Token = "0x4001839")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11039A4", Offset = "0x11039A4")]
		private uint <using_version>k__BackingField;
	}
}
