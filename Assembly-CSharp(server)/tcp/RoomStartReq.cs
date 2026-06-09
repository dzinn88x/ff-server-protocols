using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200050C RID: 1292
	[Token(Token = "0x200050C")]
	[ProtoContract]
	public class RoomStartReq
	{
		// Token: 0x06002042 RID: 8258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002042")]
		[Address(RVA = "0x24A6EF0", Offset = "0x24A6EF0", VA = "0x7BBCCA6EF0")]
		public RoomStartReq()
		{
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06002043 RID: 8259 RVA: 0x0000DD88 File Offset: 0x0000BF88
		// (set) Token: 0x06002044 RID: 8260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000519")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157FB4", Offset = "0x1157FB4")]
		public ulong room_id
		{
			[Token(Token = "0x6002043")]
			[Address(RVA = "0x24A6EF8", Offset = "0x24A6EF8", VA = "0x7BBCCA6EF8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138704", Offset = "0x1138704")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002044")]
			[Address(RVA = "0x24A6F00", Offset = "0x24A6F00", VA = "0x7BBCCA6F00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138714", Offset = "0x1138714")]
			set
			{
			}
		}

		// Token: 0x04001833 RID: 6195
		[Token(Token = "0x4001833")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103944", Offset = "0x1103944")]
		private ulong <room_id>k__BackingField;
	}
}
