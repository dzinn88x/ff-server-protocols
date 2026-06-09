using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200051A RID: 1306
	[Token(Token = "0x200051A")]
	[ProtoContract]
	public class RoomInviteNtf
	{
		// Token: 0x060020BA RID: 8378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020BA")]
		[Address(RVA = "0x24A66E4", Offset = "0x24A66E4", VA = "0x7BBCCA66E4")]
		public RoomInviteNtf()
		{
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x0000E160 File Offset: 0x0000C360
		// (set) Token: 0x060020BC RID: 8380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11584B4", Offset = "0x11584B4")]
		public ulong room_id
		{
			[Token(Token = "0x60020BB")]
			[Address(RVA = "0x24A66EC", Offset = "0x24A66EC", VA = "0x7BBCCA66EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138DA4", Offset = "0x1138DA4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60020BC")]
			[Address(RVA = "0x24A66F4", Offset = "0x24A66F4", VA = "0x7BBCCA66F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138DB4", Offset = "0x1138DB4")]
			set
			{
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060020BD RID: 8381 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060020BE RID: 8382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11584C8", Offset = "0x11584C8")]
		public RoomPlayerInfo inviter_info
		{
			[Token(Token = "0x60020BD")]
			[Address(RVA = "0x24A66FC", Offset = "0x24A66FC", VA = "0x7BBCCA66FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138DC4", Offset = "0x1138DC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60020BE")]
			[Address(RVA = "0x24A6704", Offset = "0x24A6704", VA = "0x7BBCCA6704")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138DD4", Offset = "0x1138DD4")]
			set
			{
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060020BF RID: 8383 RVA: 0x0000E178 File Offset: 0x0000C378
		// (set) Token: 0x060020C0 RID: 8384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000550")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11584DC", Offset = "0x11584DC")]
		public uint map_id
		{
			[Token(Token = "0x60020BF")]
			[Address(RVA = "0x24A670C", Offset = "0x24A670C", VA = "0x7BBCCA670C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138DE4", Offset = "0x1138DE4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020C0")]
			[Address(RVA = "0x24A6714", Offset = "0x24A6714", VA = "0x7BBCCA6714")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138DF4", Offset = "0x1138DF4")]
			set
			{
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060020C1 RID: 8385 RVA: 0x0000E190 File Offset: 0x0000C390
		// (set) Token: 0x060020C2 RID: 8386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000551")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11584F0", Offset = "0x11584F0")]
		public uint game_mode
		{
			[Token(Token = "0x60020C1")]
			[Address(RVA = "0x24A671C", Offset = "0x24A671C", VA = "0x7BBCCA671C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138E04", Offset = "0x1138E04")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020C2")]
			[Address(RVA = "0x24A6724", Offset = "0x24A6724", VA = "0x7BBCCA6724")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138E14", Offset = "0x1138E14")]
			set
			{
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060020C3 RID: 8387 RVA: 0x0000E1A8 File Offset: 0x0000C3A8
		// (set) Token: 0x060020C4 RID: 8388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000552")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158504", Offset = "0x1158504")]
		public uint group_mode
		{
			[Token(Token = "0x60020C3")]
			[Address(RVA = "0x24A672C", Offset = "0x24A672C", VA = "0x7BBCCA672C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138E24", Offset = "0x1138E24")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020C4")]
			[Address(RVA = "0x24A6734", Offset = "0x24A6734", VA = "0x7BBCCA6734")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138E34", Offset = "0x1138E34")]
			set
			{
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x060020C5 RID: 8389 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
		// (set) Token: 0x060020C6 RID: 8390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000553")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158518", Offset = "0x1158518")]
		public ulong owner_id
		{
			[Token(Token = "0x60020C5")]
			[Address(RVA = "0x24A673C", Offset = "0x24A673C", VA = "0x7BBCCA673C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138E44", Offset = "0x1138E44")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60020C6")]
			[Address(RVA = "0x24A6744", Offset = "0x24A6744", VA = "0x7BBCCA6744")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138E54", Offset = "0x1138E54")]
			set
			{
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x0000E1D8 File Offset: 0x0000C3D8
		// (set) Token: 0x060020C8 RID: 8392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000554")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115852C", Offset = "0x115852C")]
		public ERoom.Type room_type
		{
			[Token(Token = "0x60020C7")]
			[Address(RVA = "0x24A674C", Offset = "0x24A674C", VA = "0x7BBCCA674C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138E64", Offset = "0x1138E64")]
			get
			{
				return ERoom.Type.Type_NONE;
			}
			[Token(Token = "0x60020C8")]
			[Address(RVA = "0x24A6754", Offset = "0x24A6754", VA = "0x7BBCCA6754")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138E74", Offset = "0x1138E74")]
			set
			{
			}
		}

		// Token: 0x04001868 RID: 6248
		[Token(Token = "0x4001868")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103C94", Offset = "0x1103C94")]
		private ulong <room_id>k__BackingField;

		// Token: 0x04001869 RID: 6249
		[Token(Token = "0x4001869")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103CA4", Offset = "0x1103CA4")]
		private RoomPlayerInfo <inviter_info>k__BackingField;

		// Token: 0x0400186A RID: 6250
		[Token(Token = "0x400186A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103CB4", Offset = "0x1103CB4")]
		private uint <map_id>k__BackingField;

		// Token: 0x0400186B RID: 6251
		[Token(Token = "0x400186B")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103CC4", Offset = "0x1103CC4")]
		private uint <game_mode>k__BackingField;

		// Token: 0x0400186C RID: 6252
		[Token(Token = "0x400186C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103CD4", Offset = "0x1103CD4")]
		private uint <group_mode>k__BackingField;

		// Token: 0x0400186D RID: 6253
		[Token(Token = "0x400186D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103CE4", Offset = "0x1103CE4")]
		private ulong <owner_id>k__BackingField;

		// Token: 0x0400186E RID: 6254
		[Token(Token = "0x400186E")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103CF4", Offset = "0x1103CF4")]
		private ERoom.Type <room_type>k__BackingField;
	}
}
