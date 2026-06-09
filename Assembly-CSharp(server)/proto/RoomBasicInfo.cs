using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace proto
{
	// Token: 0x02000682 RID: 1666
	[Token(Token = "0x2000682")]
	[ProtoContract]
	public class RoomBasicInfo
	{
		// Token: 0x060023C3 RID: 9155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C3")]
		[Address(RVA = "0x24A0278", Offset = "0x24A0278", VA = "0x7BBCCA0278")]
		public RoomBasicInfo()
		{
		}

		// Token: 0x040020CF RID: 8399
		[Token(Token = "0x40020CF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108804", Offset = "0x1108804")]
		public ulong id;

		// Token: 0x040020D0 RID: 8400
		[Token(Token = "0x40020D0")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108818", Offset = "0x1108818")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1108818", Offset = "0x1108818")]
		public string name;

		// Token: 0x040020D1 RID: 8401
		[Token(Token = "0x40020D1")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108868", Offset = "0x1108868")]
		public uint map_id;

		// Token: 0x040020D2 RID: 8402
		[Token(Token = "0x40020D2")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110887C", Offset = "0x110887C")]
		public uint game_mode;

		// Token: 0x040020D3 RID: 8403
		[Token(Token = "0x40020D3")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108890", Offset = "0x1108890")]
		public uint group_mode;

		// Token: 0x040020D4 RID: 8404
		[Token(Token = "0x40020D4")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11088A4", Offset = "0x11088A4")]
		public uint cur_member_num;

		// Token: 0x040020D5 RID: 8405
		[Token(Token = "0x40020D5")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11088B8", Offset = "0x11088B8")]
		public uint max_member_num;

		// Token: 0x040020D6 RID: 8406
		[Token(Token = "0x40020D6")]
		[FieldOffset(Offset = "0x34")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11088CC", Offset = "0x11088CC")]
		public uint cur_spectator_num;

		// Token: 0x040020D7 RID: 8407
		[Token(Token = "0x40020D7")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11088E0", Offset = "0x11088E0")]
		public uint max_spectator_num;

		// Token: 0x040020D8 RID: 8408
		[Token(Token = "0x40020D8")]
		[FieldOffset(Offset = "0x3C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11088F4", Offset = "0x11088F4")]
		public uint state;

		// Token: 0x040020D9 RID: 8409
		[Token(Token = "0x40020D9")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108908", Offset = "0x1108908")]
		public bool need_code;

		// Token: 0x040020DA RID: 8410
		[Token(Token = "0x40020DA")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110891C", Offset = "0x110891C")]
		public uint banner;

		// Token: 0x040020DB RID: 8411
		[Token(Token = "0x40020DB")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108930", Offset = "0x1108930")]
		public uint color;

		// Token: 0x040020DC RID: 8412
		[Token(Token = "0x40020DC")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108944", Offset = "0x1108944")]
		public uint icon;

		// Token: 0x040020DD RID: 8413
		[Token(Token = "0x40020DD")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108958", Offset = "0x1108958")]
		public uint room_type;

		// Token: 0x040020DE RID: 8414
		[Token(Token = "0x40020DE")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x110896C", Offset = "0x110896C")]
		public uint level_visual_style;

		// Token: 0x040020DF RID: 8415
		[Token(Token = "0x40020DF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1108980", Offset = "0x1108980")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1108980", Offset = "0x1108980")]
		public string code;

		// Token: 0x040020E0 RID: 8416
		[Token(Token = "0x40020E0")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11089D0", Offset = "0x11089D0")]
		public bool enable_emulator_check;
	}
}
