using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200050F RID: 1295
	[Token(Token = "0x200050F")]
	[ProtoContract]
	public class RoomLeaveNtf
	{
		// Token: 0x06002057 RID: 8279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002057")]
		[Address(RVA = "0x24A69CC", Offset = "0x24A69CC", VA = "0x7BBCCA69CC")]
		public RoomLeaveNtf()
		{
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06002058 RID: 8280 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002059 RID: 8281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000522")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11580CC", Offset = "0x11580CC")]
		public RoomPlayerInfo leaver_info
		{
			[Token(Token = "0x6002058")]
			[Address(RVA = "0x24A69D4", Offset = "0x24A69D4", VA = "0x7BBCCA69D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138824", Offset = "0x1138824")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002059")]
			[Address(RVA = "0x24A69DC", Offset = "0x24A69DC", VA = "0x7BBCCA69DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138834", Offset = "0x1138834")]
			set
			{
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x0600205A RID: 8282 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600205B RID: 8283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000523")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11580E0", Offset = "0x11580E0")]
		public RoomInfo room_info
		{
			[Token(Token = "0x600205A")]
			[Address(RVA = "0x24A69E4", Offset = "0x24A69E4", VA = "0x7BBCCA69E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138844", Offset = "0x1138844")]
			get
			{
				return null;
			}
			[Token(Token = "0x600205B")]
			[Address(RVA = "0x24A69EC", Offset = "0x24A69EC", VA = "0x7BBCCA69EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138854", Offset = "0x1138854")]
			set
			{
			}
		}

		// Token: 0x0400183C RID: 6204
		[Token(Token = "0x400183C")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11039D4", Offset = "0x11039D4")]
		private RoomPlayerInfo <leaver_info>k__BackingField;

		// Token: 0x0400183D RID: 6205
		[Token(Token = "0x400183D")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11039E4", Offset = "0x11039E4")]
		private RoomInfo <room_info>k__BackingField;
	}
}
