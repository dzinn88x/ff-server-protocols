using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000517 RID: 1303
	[Token(Token = "0x2000517")]
	[ProtoContract]
	public class RoomOwnerSwitchGroupReq
	{
		// Token: 0x060020A5 RID: 8357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A5")]
		[Address(RVA = "0x24A6B44", Offset = "0x24A6B44", VA = "0x7BBCCA6B44")]
		public RoomOwnerSwitchGroupReq()
		{
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x060020A6 RID: 8358 RVA: 0x0000E088 File Offset: 0x0000C288
		// (set) Token: 0x060020A7 RID: 8359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000545")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158400", Offset = "0x1158400")]
		public ulong room_id
		{
			[Token(Token = "0x60020A6")]
			[Address(RVA = "0x24A6B4C", Offset = "0x24A6B4C", VA = "0x7BBCCA6B4C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138C84", Offset = "0x1138C84")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60020A7")]
			[Address(RVA = "0x24A6B54", Offset = "0x24A6B54", VA = "0x7BBCCA6B54")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138C94", Offset = "0x1138C94")]
			set
			{
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060020A8 RID: 8360 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
		// (set) Token: 0x060020A9 RID: 8361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000546")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158414", Offset = "0x1158414")]
		public uint from_group_pos
		{
			[Token(Token = "0x60020A8")]
			[Address(RVA = "0x24A6B5C", Offset = "0x24A6B5C", VA = "0x7BBCCA6B5C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138CA4", Offset = "0x1138CA4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020A9")]
			[Address(RVA = "0x24A6B64", Offset = "0x24A6B64", VA = "0x7BBCCA6B64")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138CB4", Offset = "0x1138CB4")]
			set
			{
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x060020AA RID: 8362 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		// (set) Token: 0x060020AB RID: 8363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000547")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158428", Offset = "0x1158428")]
		public ulong from_group_id
		{
			[Token(Token = "0x60020AA")]
			[Address(RVA = "0x24A6B6C", Offset = "0x24A6B6C", VA = "0x7BBCCA6B6C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138CC4", Offset = "0x1138CC4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60020AB")]
			[Address(RVA = "0x24A6B74", Offset = "0x24A6B74", VA = "0x7BBCCA6B74")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138CD4", Offset = "0x1138CD4")]
			set
			{
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x060020AC RID: 8364 RVA: 0x0000E0D0 File Offset: 0x0000C2D0
		// (set) Token: 0x060020AD RID: 8365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000548")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115843C", Offset = "0x115843C")]
		public uint to_group_pos
		{
			[Token(Token = "0x60020AC")]
			[Address(RVA = "0x24A6B7C", Offset = "0x24A6B7C", VA = "0x7BBCCA6B7C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138CE4", Offset = "0x1138CE4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020AD")]
			[Address(RVA = "0x24A6B84", Offset = "0x24A6B84", VA = "0x7BBCCA6B84")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138CF4", Offset = "0x1138CF4")]
			set
			{
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x060020AE RID: 8366 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
		// (set) Token: 0x060020AF RID: 8367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000549")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158450", Offset = "0x1158450")]
		public ulong to_group_id
		{
			[Token(Token = "0x60020AE")]
			[Address(RVA = "0x24A6B8C", Offset = "0x24A6B8C", VA = "0x7BBCCA6B8C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138D04", Offset = "0x1138D04")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60020AF")]
			[Address(RVA = "0x24A6B94", Offset = "0x24A6B94", VA = "0x7BBCCA6B94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138D14", Offset = "0x1138D14")]
			set
			{
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060020B0 RID: 8368 RVA: 0x0000E100 File Offset: 0x0000C300
		// (set) Token: 0x060020B1 RID: 8369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158464", Offset = "0x1158464")]
		public ERoom.Type room_type
		{
			[Token(Token = "0x60020B0")]
			[Address(RVA = "0x24A6B9C", Offset = "0x24A6B9C", VA = "0x7BBCCA6B9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138D24", Offset = "0x1138D24")]
			get
			{
				return ERoom.Type.Type_NONE;
			}
			[Token(Token = "0x60020B1")]
			[Address(RVA = "0x24A6BA4", Offset = "0x24A6BA4", VA = "0x7BBCCA6BA4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138D34", Offset = "0x1138D34")]
			set
			{
			}
		}

		// Token: 0x0400185F RID: 6239
		[Token(Token = "0x400185F")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103C04", Offset = "0x1103C04")]
		private ulong <room_id>k__BackingField;

		// Token: 0x04001860 RID: 6240
		[Token(Token = "0x4001860")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103C14", Offset = "0x1103C14")]
		private uint <from_group_pos>k__BackingField;

		// Token: 0x04001861 RID: 6241
		[Token(Token = "0x4001861")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103C24", Offset = "0x1103C24")]
		private ulong <from_group_id>k__BackingField;

		// Token: 0x04001862 RID: 6242
		[Token(Token = "0x4001862")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103C34", Offset = "0x1103C34")]
		private uint <to_group_pos>k__BackingField;

		// Token: 0x04001863 RID: 6243
		[Token(Token = "0x4001863")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103C44", Offset = "0x1103C44")]
		private ulong <to_group_id>k__BackingField;

		// Token: 0x04001864 RID: 6244
		[Token(Token = "0x4001864")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103C54", Offset = "0x1103C54")]
		private ERoom.Type <room_type>k__BackingField;
	}
}
