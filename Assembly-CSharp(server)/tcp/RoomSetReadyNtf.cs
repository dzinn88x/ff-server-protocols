using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200051C RID: 1308
	[Token(Token = "0x200051C")]
	[ProtoContract]
	public class RoomSetReadyNtf
	{
		// Token: 0x060020CE RID: 8398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020CE")]
		[Address(RVA = "0x24A6CFC", Offset = "0x24A6CFC", VA = "0x7BBCCA6CFC")]
		public RoomSetReadyNtf()
		{
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x060020CF RID: 8399 RVA: 0x0000E220 File Offset: 0x0000C420
		// (set) Token: 0x060020D0 RID: 8400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000557")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158568", Offset = "0x1158568")]
		public ulong room_id
		{
			[Token(Token = "0x60020CF")]
			[Address(RVA = "0x24A6D78", Offset = "0x24A6D78", VA = "0x7BBCCA6D78")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138EC4", Offset = "0x1138EC4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60020D0")]
			[Address(RVA = "0x24A6D80", Offset = "0x24A6D80", VA = "0x7BBCCA6D80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138ED4", Offset = "0x1138ED4")]
			set
			{
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x060020D1 RID: 8401 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020D2 RID: 8402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000558")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115857C", Offset = "0x115857C")]
		public List<RoomPlayerInfo> players
		{
			[Token(Token = "0x60020D1")]
			[Address(RVA = "0x24A6D88", Offset = "0x24A6D88", VA = "0x7BBCCA6D88")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138EE4", Offset = "0x1138EE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020D2")]
			[Address(RVA = "0x24A6D70", Offset = "0x24A6D70", VA = "0x7BBCCA6D70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138EF4", Offset = "0x1138EF4")]
			private set
			{
			}
		}

		// Token: 0x04001871 RID: 6257
		[Token(Token = "0x4001871")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103D24", Offset = "0x1103D24")]
		private ulong <room_id>k__BackingField;

		// Token: 0x04001872 RID: 6258
		[Token(Token = "0x4001872")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103D34", Offset = "0x1103D34")]
		private List<RoomPlayerInfo> <players>k__BackingField;
	}
}
