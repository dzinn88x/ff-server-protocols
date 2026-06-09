using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000518 RID: 1304
	[Token(Token = "0x2000518")]
	[ProtoContract]
	public class RoomCountDownReq
	{
		// Token: 0x060020B2 RID: 8370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B2")]
		[Address(RVA = "0x24A60B4", Offset = "0x24A60B4", VA = "0x7BBCCA60B4")]
		public RoomCountDownReq()
		{
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060020B3 RID: 8371 RVA: 0x0000E118 File Offset: 0x0000C318
		// (set) Token: 0x060020B4 RID: 8372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158478", Offset = "0x1158478")]
		public ulong room_id
		{
			[Token(Token = "0x60020B3")]
			[Address(RVA = "0x24A60BC", Offset = "0x24A60BC", VA = "0x7BBCCA60BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138D44", Offset = "0x1138D44")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60020B4")]
			[Address(RVA = "0x24A60C4", Offset = "0x24A60C4", VA = "0x7BBCCA60C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138D54", Offset = "0x1138D54")]
			set
			{
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x0000E130 File Offset: 0x0000C330
		// (set) Token: 0x060020B6 RID: 8374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115848C", Offset = "0x115848C")]
		public uint count_down_seconds
		{
			[Token(Token = "0x60020B5")]
			[Address(RVA = "0x24A60CC", Offset = "0x24A60CC", VA = "0x7BBCCA60CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138D64", Offset = "0x1138D64")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020B6")]
			[Address(RVA = "0x24A60D4", Offset = "0x24A60D4", VA = "0x7BBCCA60D4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138D74", Offset = "0x1138D74")]
			set
			{
			}
		}

		// Token: 0x04001865 RID: 6245
		[Token(Token = "0x4001865")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103C64", Offset = "0x1103C64")]
		private ulong <room_id>k__BackingField;

		// Token: 0x04001866 RID: 6246
		[Token(Token = "0x4001866")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103C74", Offset = "0x1103C74")]
		private uint <count_down_seconds>k__BackingField;
	}
}
