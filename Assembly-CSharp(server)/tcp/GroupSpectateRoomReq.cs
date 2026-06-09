using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004AA RID: 1194
	[Token(Token = "0x20004AA")]
	[ProtoContract]
	public class GroupSpectateRoomReq
	{
		// Token: 0x06001E08 RID: 7688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E08")]
		[Address(RVA = "0x24A401C", Offset = "0x24A401C", VA = "0x7BBCCA401C")]
		public GroupSpectateRoomReq()
		{
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x0000CD20 File Offset: 0x0000AF20
		// (set) Token: 0x06001E0A RID: 7690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700041D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156128", Offset = "0x1156128")]
		public ulong room_id
		{
			[Token(Token = "0x6001E09")]
			[Address(RVA = "0x24A4080", Offset = "0x24A4080", VA = "0x7BBCCA4080")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136784", Offset = "0x1136784")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001E0A")]
			[Address(RVA = "0x24A4088", Offset = "0x24A4088", VA = "0x7BBCCA4088")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136794", Offset = "0x1136794")]
			set
			{
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E0C RID: 7692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700041E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115613C", Offset = "0x115613C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x115613C", Offset = "0x115613C")]
		public string code
		{
			[Token(Token = "0x6001E0B")]
			[Address(RVA = "0x24A4090", Offset = "0x24A4090", VA = "0x7BBCCA4090")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11367A4", Offset = "0x11367A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E0C")]
			[Address(RVA = "0x24A4078", Offset = "0x24A4078", VA = "0x7BBCCA4078")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11367B4", Offset = "0x11367B4")]
			set
			{
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001E0D RID: 7693 RVA: 0x0000CD38 File Offset: 0x0000AF38
		// (set) Token: 0x06001E0E RID: 7694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700041F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115618C", Offset = "0x115618C")]
		public ulong group_id
		{
			[Token(Token = "0x6001E0D")]
			[Address(RVA = "0x24A4098", Offset = "0x24A4098", VA = "0x7BBCCA4098")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11367C4", Offset = "0x11367C4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001E0E")]
			[Address(RVA = "0x24A40A0", Offset = "0x24A40A0", VA = "0x7BBCCA40A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11367D4", Offset = "0x11367D4")]
			set
			{
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001E0F RID: 7695 RVA: 0x0000CD50 File Offset: 0x0000AF50
		// (set) Token: 0x06001E10 RID: 7696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000420")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11561A0", Offset = "0x11561A0")]
		public bool is_solo
		{
			[Token(Token = "0x6001E0F")]
			[Address(RVA = "0x24A40A8", Offset = "0x24A40A8", VA = "0x7BBCCA40A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11367E4", Offset = "0x11367E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001E10")]
			[Address(RVA = "0x24A40B0", Offset = "0x24A40B0", VA = "0x7BBCCA40B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11367F4", Offset = "0x11367F4")]
			set
			{
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001E11 RID: 7697 RVA: 0x0000CD68 File Offset: 0x0000AF68
		// (set) Token: 0x06001E12 RID: 7698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000421")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11561B4", Offset = "0x11561B4")]
		public EGroup.RoomType room_type
		{
			[Token(Token = "0x6001E11")]
			[Address(RVA = "0x24A40BC", Offset = "0x24A40BC", VA = "0x7BBCCA40BC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136804", Offset = "0x1136804")]
			get
			{
				return EGroup.RoomType.Type_NONE;
			}
			[Token(Token = "0x6001E12")]
			[Address(RVA = "0x24A40C4", Offset = "0x24A40C4", VA = "0x7BBCCA40C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136814", Offset = "0x1136814")]
			set
			{
			}
		}

		// Token: 0x04001642 RID: 5698
		[Token(Token = "0x4001642")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102984", Offset = "0x1102984")]
		private ulong <room_id>k__BackingField;

		// Token: 0x04001643 RID: 5699
		[Token(Token = "0x4001643")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102994", Offset = "0x1102994")]
		private string <code>k__BackingField;

		// Token: 0x04001644 RID: 5700
		[Token(Token = "0x4001644")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11029A4", Offset = "0x11029A4")]
		private ulong <group_id>k__BackingField;

		// Token: 0x04001645 RID: 5701
		[Token(Token = "0x4001645")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11029B4", Offset = "0x11029B4")]
		private bool <is_solo>k__BackingField;

		// Token: 0x04001646 RID: 5702
		[Token(Token = "0x4001646")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11029C4", Offset = "0x11029C4")]
		private EGroup.RoomType <room_type>k__BackingField;
	}
}
