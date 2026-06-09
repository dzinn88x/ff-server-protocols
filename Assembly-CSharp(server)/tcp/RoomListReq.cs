using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000506 RID: 1286
	[Token(Token = "0x2000506")]
	[ProtoContract]
	public class RoomListReq
	{
		// Token: 0x06001FD4 RID: 8148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FD4")]
		[Address(RVA = "0x24A6A0C", Offset = "0x24A6A0C", VA = "0x7BBCCA6A0C")]
		public RoomListReq()
		{
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x0000DA40 File Offset: 0x0000BC40
		// (set) Token: 0x06001FD6 RID: 8150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E5")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115799C", Offset = "0x115799C")]
		public ulong room_id
		{
			[Token(Token = "0x6001FD5")]
			[Address(RVA = "0x24A6A88", Offset = "0x24A6A88", VA = "0x7BBCCA6A88")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138084", Offset = "0x1138084")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001FD6")]
			[Address(RVA = "0x24A6A90", Offset = "0x24A6A90", VA = "0x7BBCCA6A90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138094", Offset = "0x1138094")]
			set
			{
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x0000DA58 File Offset: 0x0000BC58
		// (set) Token: 0x06001FD8 RID: 8152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E6")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11579B0", Offset = "0x11579B0")]
		public ERoom.Type room_type
		{
			[Token(Token = "0x6001FD7")]
			[Address(RVA = "0x24A6A98", Offset = "0x24A6A98", VA = "0x7BBCCA6A98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11380A4", Offset = "0x11380A4")]
			get
			{
				return ERoom.Type.Type_NONE;
			}
			[Token(Token = "0x6001FD8")]
			[Address(RVA = "0x24A6AA0", Offset = "0x24A6AA0", VA = "0x7BBCCA6AA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11380B4", Offset = "0x11380B4")]
			set
			{
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001FDA RID: 8154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E7")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11579C4", Offset = "0x11579C4")]
		public List<EMatch.GameMode> game_modes
		{
			[Token(Token = "0x6001FD9")]
			[Address(RVA = "0x24A6AA8", Offset = "0x24A6AA8", VA = "0x7BBCCA6AA8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11380C4", Offset = "0x11380C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FDA")]
			[Address(RVA = "0x24A6A80", Offset = "0x24A6A80", VA = "0x7BBCCA6A80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11380D4", Offset = "0x11380D4")]
			private set
			{
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x0000DA70 File Offset: 0x0000BC70
		// (set) Token: 0x06001FDC RID: 8156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004E8")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157A00", Offset = "0x1157A00")]
		public ERoom.TabType room_tab_type
		{
			[Token(Token = "0x6001FDB")]
			[Address(RVA = "0x24A6AB0", Offset = "0x24A6AB0", VA = "0x7BBCCA6AB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11380E4", Offset = "0x11380E4")]
			get
			{
				return ERoom.TabType.TabType_NONE;
			}
			[Token(Token = "0x6001FDC")]
			[Address(RVA = "0x24A6AB8", Offset = "0x24A6AB8", VA = "0x7BBCCA6AB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11380F4", Offset = "0x11380F4")]
			set
			{
			}
		}

		// Token: 0x040017FF RID: 6143
		[Token(Token = "0x40017FF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103604", Offset = "0x1103604")]
		private ulong <room_id>k__BackingField;

		// Token: 0x04001800 RID: 6144
		[Token(Token = "0x4001800")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103614", Offset = "0x1103614")]
		private ERoom.Type <room_type>k__BackingField;

		// Token: 0x04001801 RID: 6145
		[Token(Token = "0x4001801")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103624", Offset = "0x1103624")]
		private List<EMatch.GameMode> <game_modes>k__BackingField;

		// Token: 0x04001802 RID: 6146
		[Token(Token = "0x4001802")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103634", Offset = "0x1103634")]
		private ERoom.TabType <room_tab_type>k__BackingField;
	}
}
