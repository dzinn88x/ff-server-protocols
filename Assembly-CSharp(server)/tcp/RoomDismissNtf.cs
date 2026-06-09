using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000510 RID: 1296
	[Token(Token = "0x2000510")]
	[ProtoContract]
	public class RoomDismissNtf
	{
		// Token: 0x0600205C RID: 8284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600205C")]
		[Address(RVA = "0x24A6328", Offset = "0x24A6328", VA = "0x7BBCCA6328")]
		public RoomDismissNtf()
		{
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x0600205D RID: 8285 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		// (set) Token: 0x0600205E RID: 8286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000524")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11580F4", Offset = "0x11580F4")]
		public ulong leaver_id
		{
			[Token(Token = "0x600205D")]
			[Address(RVA = "0x24A6330", Offset = "0x24A6330", VA = "0x7BBCCA6330")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138864", Offset = "0x1138864")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x600205E")]
			[Address(RVA = "0x24A6338", Offset = "0x24A6338", VA = "0x7BBCCA6338")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138874", Offset = "0x1138874")]
			set
			{
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x0600205F RID: 8287 RVA: 0x0000DE00 File Offset: 0x0000C000
		// (set) Token: 0x06002060 RID: 8288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000525")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158108", Offset = "0x1158108")]
		public ulong room_id
		{
			[Token(Token = "0x600205F")]
			[Address(RVA = "0x24A6340", Offset = "0x24A6340", VA = "0x7BBCCA6340")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138884", Offset = "0x1138884")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6002060")]
			[Address(RVA = "0x24A6348", Offset = "0x24A6348", VA = "0x7BBCCA6348")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138894", Offset = "0x1138894")]
			set
			{
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06002061 RID: 8289 RVA: 0x0000DE18 File Offset: 0x0000C018
		// (set) Token: 0x06002062 RID: 8290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000526")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115811C", Offset = "0x115811C")]
		public ERoom.DismissReason reason
		{
			[Token(Token = "0x6002061")]
			[Address(RVA = "0x24A6350", Offset = "0x24A6350", VA = "0x7BBCCA6350")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11388A4", Offset = "0x11388A4")]
			get
			{
				return ERoom.DismissReason.DismissReason_NONE;
			}
			[Token(Token = "0x6002062")]
			[Address(RVA = "0x24A6358", Offset = "0x24A6358", VA = "0x7BBCCA6358")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11388B4", Offset = "0x11388B4")]
			set
			{
			}
		}

		// Token: 0x0400183E RID: 6206
		[Token(Token = "0x400183E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11039F4", Offset = "0x11039F4")]
		private ulong <leaver_id>k__BackingField;

		// Token: 0x0400183F RID: 6207
		[Token(Token = "0x400183F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103A04", Offset = "0x1103A04")]
		private ulong <room_id>k__BackingField;

		// Token: 0x04001840 RID: 6208
		[Token(Token = "0x4001840")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103A14", Offset = "0x1103A14")]
		private ERoom.DismissReason <reason>k__BackingField;
	}
}
