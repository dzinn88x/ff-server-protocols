using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000464 RID: 1124
	[Token(Token = "0x2000464")]
	[ProtoContract]
	public class ChannelIDReq
	{
		// Token: 0x06001C67 RID: 7271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C67")]
		[Address(RVA = "0x24A2A04", Offset = "0x24A2A04", VA = "0x7BBCCA2A04")]
		public ChannelIDReq()
		{
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001C68 RID: 7272 RVA: 0x0000C108 File Offset: 0x0000A308
		// (set) Token: 0x06001C69 RID: 7273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000365")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154A58", Offset = "0x1154A58")]
		public ulong channel_id
		{
			[Token(Token = "0x6001C68")]
			[Address(RVA = "0x24A2A68", Offset = "0x24A2A68", VA = "0x7BBCCA2A68")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135084", Offset = "0x1135084")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001C69")]
			[Address(RVA = "0x24A2A70", Offset = "0x24A2A70", VA = "0x7BBCCA2A70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135094", Offset = "0x1135094")]
			set
			{
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x0000C120 File Offset: 0x0000A320
		// (set) Token: 0x06001C6B RID: 7275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000366")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154A6C", Offset = "0x1154A6C")]
		public uint channel_type
		{
			[Token(Token = "0x6001C6A")]
			[Address(RVA = "0x24A2A78", Offset = "0x24A2A78", VA = "0x7BBCCA2A78")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11350A4", Offset = "0x11350A4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001C6B")]
			[Address(RVA = "0x24A2A80", Offset = "0x24A2A80", VA = "0x7BBCCA2A80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11350B4", Offset = "0x11350B4")]
			set
			{
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001C6C RID: 7276 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C6D RID: 7277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000367")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154A80", Offset = "0x1154A80")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1154A80", Offset = "0x1154A80")]
		public string channel_lang
		{
			[Token(Token = "0x6001C6C")]
			[Address(RVA = "0x24A2A88", Offset = "0x24A2A88", VA = "0x7BBCCA2A88")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11350C4", Offset = "0x11350C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C6D")]
			[Address(RVA = "0x24A2A60", Offset = "0x24A2A60", VA = "0x7BBCCA2A60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11350D4", Offset = "0x11350D4")]
			set
			{
			}
		}

		// Token: 0x040014CC RID: 5324
		[Token(Token = "0x40014CC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101E04", Offset = "0x1101E04")]
		private ulong <channel_id>k__BackingField;

		// Token: 0x040014CD RID: 5325
		[Token(Token = "0x40014CD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101E14", Offset = "0x1101E14")]
		private uint <channel_type>k__BackingField;

		// Token: 0x040014CE RID: 5326
		[Token(Token = "0x40014CE")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101E24", Offset = "0x1101E24")]
		private string <channel_lang>k__BackingField;
	}
}
