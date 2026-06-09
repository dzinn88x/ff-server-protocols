using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000511 RID: 1297
	[Token(Token = "0x2000511")]
	[ProtoContract]
	public class RoomKickReq
	{
		// Token: 0x06002063 RID: 8291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002063")]
		[Address(RVA = "0x24A69A4", Offset = "0x24A69A4", VA = "0x7BBCCA69A4")]
		public RoomKickReq()
		{
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06002064 RID: 8292 RVA: 0x0000DE30 File Offset: 0x0000C030
		// (set) Token: 0x06002065 RID: 8293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000527")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158130", Offset = "0x1158130")]
		public ulong kick_account_id
		{
			[Token(Token = "0x6002064")]
			[Address(RVA = "0x24A69AC", Offset = "0x24A69AC", VA = "0x7BBCCA69AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11388C4", Offset = "0x11388C4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002065")]
			[Address(RVA = "0x24A69B4", Offset = "0x24A69B4", VA = "0x7BBCCA69B4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11388D4", Offset = "0x11388D4")]
			set
			{
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06002066 RID: 8294 RVA: 0x0000DE48 File Offset: 0x0000C048
		// (set) Token: 0x06002067 RID: 8295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000528")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158144", Offset = "0x1158144")]
		public ulong room_id
		{
			[Token(Token = "0x6002066")]
			[Address(RVA = "0x24A69BC", Offset = "0x24A69BC", VA = "0x7BBCCA69BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11388E4", Offset = "0x11388E4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002067")]
			[Address(RVA = "0x24A69C4", Offset = "0x24A69C4", VA = "0x7BBCCA69C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11388F4", Offset = "0x11388F4")]
			set
			{
			}
		}

		// Token: 0x04001841 RID: 6209
		[Token(Token = "0x4001841")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103A24", Offset = "0x1103A24")]
		private ulong <kick_account_id>k__BackingField;

		// Token: 0x04001842 RID: 6210
		[Token(Token = "0x4001842")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103A34", Offset = "0x1103A34")]
		private ulong <room_id>k__BackingField;
	}
}
