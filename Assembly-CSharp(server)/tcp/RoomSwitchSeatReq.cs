using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000516 RID: 1302
	[Token(Token = "0x2000516")]
	[ProtoContract]
	public class RoomSwitchSeatReq
	{
		// Token: 0x06002098 RID: 8344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002098")]
		[Address(RVA = "0x24A6F30", Offset = "0x24A6F30", VA = "0x7BBCCA6F30")]
		public RoomSwitchSeatReq()
		{
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x0000DFF8 File Offset: 0x0000C1F8
		// (set) Token: 0x0600209A RID: 8346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700053F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158388", Offset = "0x1158388")]
		public ulong room_id
		{
			[Token(Token = "0x6002099")]
			[Address(RVA = "0x24A6F38", Offset = "0x24A6F38", VA = "0x7BBCCA6F38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138BC4", Offset = "0x1138BC4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600209A")]
			[Address(RVA = "0x24A6F40", Offset = "0x24A6F40", VA = "0x7BBCCA6F40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138BD4", Offset = "0x1138BD4")]
			set
			{
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x0600209B RID: 8347 RVA: 0x0000E010 File Offset: 0x0000C210
		// (set) Token: 0x0600209C RID: 8348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000540")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115839C", Offset = "0x115839C")]
		public ulong account_id
		{
			[Token(Token = "0x600209B")]
			[Address(RVA = "0x24A6F48", Offset = "0x24A6F48", VA = "0x7BBCCA6F48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138BE4", Offset = "0x1138BE4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600209C")]
			[Address(RVA = "0x24A6F50", Offset = "0x24A6F50", VA = "0x7BBCCA6F50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138BF4", Offset = "0x1138BF4")]
			set
			{
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x0000E028 File Offset: 0x0000C228
		// (set) Token: 0x0600209E RID: 8350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000541")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11583B0", Offset = "0x11583B0")]
		public ERoom.PlayerRole to_role
		{
			[Token(Token = "0x600209D")]
			[Address(RVA = "0x24A6F58", Offset = "0x24A6F58", VA = "0x7BBCCA6F58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138C04", Offset = "0x1138C04")]
			get
			{
				return ERoom.PlayerRole.PlayerRole_NONE;
			}
			[Token(Token = "0x600209E")]
			[Address(RVA = "0x24A6F60", Offset = "0x24A6F60", VA = "0x7BBCCA6F60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138C14", Offset = "0x1138C14")]
			set
			{
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x0000E040 File Offset: 0x0000C240
		// (set) Token: 0x060020A0 RID: 8352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000542")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11583C4", Offset = "0x11583C4")]
		public uint to_room_pos
		{
			[Token(Token = "0x600209F")]
			[Address(RVA = "0x24A6F68", Offset = "0x24A6F68", VA = "0x7BBCCA6F68")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138C24", Offset = "0x1138C24")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020A0")]
			[Address(RVA = "0x24A6F70", Offset = "0x24A6F70", VA = "0x7BBCCA6F70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138C34", Offset = "0x1138C34")]
			set
			{
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x0000E058 File Offset: 0x0000C258
		// (set) Token: 0x060020A2 RID: 8354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000543")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11583D8", Offset = "0x11583D8")]
		public uint to_group_pos
		{
			[Token(Token = "0x60020A1")]
			[Address(RVA = "0x24A6F78", Offset = "0x24A6F78", VA = "0x7BBCCA6F78")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138C44", Offset = "0x1138C44")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020A2")]
			[Address(RVA = "0x24A6F80", Offset = "0x24A6F80", VA = "0x7BBCCA6F80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138C54", Offset = "0x1138C54")]
			set
			{
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x0000E070 File Offset: 0x0000C270
		// (set) Token: 0x060020A4 RID: 8356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000544")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11583EC", Offset = "0x11583EC")]
		public ERoom.Type room_type
		{
			[Token(Token = "0x60020A3")]
			[Address(RVA = "0x24A6F88", Offset = "0x24A6F88", VA = "0x7BBCCA6F88")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138C64", Offset = "0x1138C64")]
			get
			{
				return ERoom.Type.Type_NONE;
			}
			[Token(Token = "0x60020A4")]
			[Address(RVA = "0x24A6F90", Offset = "0x24A6F90", VA = "0x7BBCCA6F90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138C74", Offset = "0x1138C74")]
			set
			{
			}
		}

		// Token: 0x04001859 RID: 6233
		[Token(Token = "0x4001859")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103BA4", Offset = "0x1103BA4")]
		private ulong <room_id>k__BackingField;

		// Token: 0x0400185A RID: 6234
		[Token(Token = "0x400185A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103BB4", Offset = "0x1103BB4")]
		private ulong <account_id>k__BackingField;

		// Token: 0x0400185B RID: 6235
		[Token(Token = "0x400185B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103BC4", Offset = "0x1103BC4")]
		private ERoom.PlayerRole <to_role>k__BackingField;

		// Token: 0x0400185C RID: 6236
		[Token(Token = "0x400185C")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103BD4", Offset = "0x1103BD4")]
		private uint <to_room_pos>k__BackingField;

		// Token: 0x0400185D RID: 6237
		[Token(Token = "0x400185D")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103BE4", Offset = "0x1103BE4")]
		private uint <to_group_pos>k__BackingField;

		// Token: 0x0400185E RID: 6238
		[Token(Token = "0x400185E")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103BF4", Offset = "0x1103BF4")]
		private ERoom.Type <room_type>k__BackingField;
	}
}
