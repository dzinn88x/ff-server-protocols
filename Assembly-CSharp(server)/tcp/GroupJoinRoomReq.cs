using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004A9 RID: 1193
	[Token(Token = "0x20004A9")]
	[ProtoContract]
	public class GroupJoinRoomReq
	{
		// Token: 0x06001DF9 RID: 7673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF9")]
		[Address(RVA = "0x24A3C00", Offset = "0x24A3C00", VA = "0x7BBCCA3C00")]
		public GroupJoinRoomReq()
		{
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001DFA RID: 7674 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		// (set) Token: 0x06001DFB RID: 7675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000416")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155FE8", Offset = "0x1155FE8")]
		public ulong room_id
		{
			[Token(Token = "0x6001DFA")]
			[Address(RVA = "0x24A3C7C", Offset = "0x24A3C7C", VA = "0x7BBCCA3C7C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11366A4", Offset = "0x11366A4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001DFB")]
			[Address(RVA = "0x24A3C84", Offset = "0x24A3C84", VA = "0x7BBCCA3C84")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11366B4", Offset = "0x11366B4")]
			set
			{
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001DFC RID: 7676 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DFD RID: 7677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000417")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155FFC", Offset = "0x1155FFC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1155FFC", Offset = "0x1155FFC")]
		public string code
		{
			[Token(Token = "0x6001DFC")]
			[Address(RVA = "0x24A3C8C", Offset = "0x24A3C8C", VA = "0x7BBCCA3C8C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11366C4", Offset = "0x11366C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DFD")]
			[Address(RVA = "0x24A3C64", Offset = "0x24A3C64", VA = "0x7BBCCA3C64")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11366D4", Offset = "0x11366D4")]
			set
			{
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001DFE RID: 7678 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		// (set) Token: 0x06001DFF RID: 7679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000418")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115604C", Offset = "0x115604C")]
		public ulong group_id
		{
			[Token(Token = "0x6001DFE")]
			[Address(RVA = "0x24A3C94", Offset = "0x24A3C94", VA = "0x7BBCCA3C94")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11366E4", Offset = "0x11366E4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001DFF")]
			[Address(RVA = "0x24A3C9C", Offset = "0x24A3C9C", VA = "0x7BBCCA3C9C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11366F4", Offset = "0x11366F4")]
			set
			{
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001E00 RID: 7680 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
		// (set) Token: 0x06001E01 RID: 7681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000419")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156060", Offset = "0x1156060")]
		public bool is_solo
		{
			[Token(Token = "0x6001E00")]
			[Address(RVA = "0x24A3CA4", Offset = "0x24A3CA4", VA = "0x7BBCCA3CA4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136704", Offset = "0x1136704")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001E01")]
			[Address(RVA = "0x24A3CAC", Offset = "0x24A3CAC", VA = "0x7BBCCA3CAC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136714", Offset = "0x1136714")]
			set
			{
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001E02 RID: 7682 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E03 RID: 7683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700041A")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1156074", Offset = "0x1156074")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156074", Offset = "0x1156074")]
		public string group_name
		{
			[Token(Token = "0x6001E02")]
			[Address(RVA = "0x24A3CB8", Offset = "0x24A3CB8", VA = "0x7BBCCA3CB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136724", Offset = "0x1136724")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E03")]
			[Address(RVA = "0x24A3C6C", Offset = "0x24A3C6C", VA = "0x7BBCCA3C6C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136734", Offset = "0x1136734")]
			set
			{
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001E04 RID: 7684 RVA: 0x0000CD08 File Offset: 0x0000AF08
		// (set) Token: 0x06001E05 RID: 7685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700041B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11560C4", Offset = "0x11560C4")]
		public EGroup.RoomType room_type
		{
			[Token(Token = "0x6001E04")]
			[Address(RVA = "0x24A3CC0", Offset = "0x24A3CC0", VA = "0x7BBCCA3CC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136744", Offset = "0x1136744")]
			get
			{
				return EGroup.RoomType.Type_NONE;
			}
			[Token(Token = "0x6001E05")]
			[Address(RVA = "0x24A3CC8", Offset = "0x24A3CC8", VA = "0x7BBCCA3CC8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136754", Offset = "0x1136754")]
			set
			{
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E07 RID: 7687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700041C")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11560D8", Offset = "0x11560D8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11560D8", Offset = "0x11560D8")]
		public string group_abbr_name
		{
			[Token(Token = "0x6001E06")]
			[Address(RVA = "0x24A3CD0", Offset = "0x24A3CD0", VA = "0x7BBCCA3CD0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136764", Offset = "0x1136764")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E07")]
			[Address(RVA = "0x24A3C74", Offset = "0x24A3C74", VA = "0x7BBCCA3C74")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136774", Offset = "0x1136774")]
			set
			{
			}
		}

		// Token: 0x0400163B RID: 5691
		[Token(Token = "0x400163B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102914", Offset = "0x1102914")]
		private ulong <room_id>k__BackingField;

		// Token: 0x0400163C RID: 5692
		[Token(Token = "0x400163C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102924", Offset = "0x1102924")]
		private string <code>k__BackingField;

		// Token: 0x0400163D RID: 5693
		[Token(Token = "0x400163D")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102934", Offset = "0x1102934")]
		private ulong <group_id>k__BackingField;

		// Token: 0x0400163E RID: 5694
		[Token(Token = "0x400163E")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102944", Offset = "0x1102944")]
		private bool <is_solo>k__BackingField;

		// Token: 0x0400163F RID: 5695
		[Token(Token = "0x400163F")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102954", Offset = "0x1102954")]
		private string <group_name>k__BackingField;

		// Token: 0x04001640 RID: 5696
		[Token(Token = "0x4001640")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102964", Offset = "0x1102964")]
		private EGroup.RoomType <room_type>k__BackingField;

		// Token: 0x04001641 RID: 5697
		[Token(Token = "0x4001641")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102974", Offset = "0x1102974")]
		private string <group_abbr_name>k__BackingField;
	}
}
