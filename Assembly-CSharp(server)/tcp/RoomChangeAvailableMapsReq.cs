using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000522 RID: 1314
	[Token(Token = "0x2000522")]
	[ProtoContract]
	public class RoomChangeAvailableMapsReq
	{
		// Token: 0x06002160 RID: 8544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002160")]
		[Address(RVA = "0x24A5F00", Offset = "0x24A5F00", VA = "0x7BBCCA5F00")]
		public RoomChangeAvailableMapsReq()
		{
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06002161 RID: 8545 RVA: 0x0000E790 File Offset: 0x0000C990
		// (set) Token: 0x06002162 RID: 8546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700059D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158C70", Offset = "0x1158C70")]
		public ulong room_id
		{
			[Token(Token = "0x6002161")]
			[Address(RVA = "0x24A5F08", Offset = "0x24A5F08", VA = "0x7BBCCA5F08")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139784", Offset = "0x1139784")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002162")]
			[Address(RVA = "0x24A5F10", Offset = "0x24A5F10", VA = "0x7BBCCA5F10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139794", Offset = "0x1139794")]
			set
			{
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06002163 RID: 8547 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002164 RID: 8548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700059E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158C84", Offset = "0x1158C84")]
		public uint[] available_maps
		{
			[Token(Token = "0x6002163")]
			[Address(RVA = "0x24A5F18", Offset = "0x24A5F18", VA = "0x7BBCCA5F18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11397A4", Offset = "0x11397A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002164")]
			[Address(RVA = "0x24A5F20", Offset = "0x24A5F20", VA = "0x7BBCCA5F20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11397B4", Offset = "0x11397B4")]
			set
			{
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06002165 RID: 8549 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
		// (set) Token: 0x06002166 RID: 8550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700059F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158CC0", Offset = "0x1158CC0")]
		public ERoom.Type room_type
		{
			[Token(Token = "0x6002165")]
			[Address(RVA = "0x24A5F28", Offset = "0x24A5F28", VA = "0x7BBCCA5F28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11397C4", Offset = "0x11397C4")]
			get
			{
				return ERoom.Type.Type_NONE;
			}
			[Token(Token = "0x6002166")]
			[Address(RVA = "0x24A5F30", Offset = "0x24A5F30", VA = "0x7BBCCA5F30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11397D4", Offset = "0x11397D4")]
			set
			{
			}
		}

		// Token: 0x040018B7 RID: 6327
		[Token(Token = "0x40018B7")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104184", Offset = "0x1104184")]
		private ulong <room_id>k__BackingField;

		// Token: 0x040018B8 RID: 6328
		[Token(Token = "0x40018B8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1104194", Offset = "0x1104194")]
		private uint[] <available_maps>k__BackingField;

		// Token: 0x040018B9 RID: 6329
		[Token(Token = "0x40018B9")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11041A4", Offset = "0x11041A4")]
		private ERoom.Type <room_type>k__BackingField;
	}
}
