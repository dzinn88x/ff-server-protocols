using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004A1 RID: 1185
	[Token(Token = "0x20004A1")]
	[ProtoContract]
	public class GroupLeaveNtf
	{
		// Token: 0x06001DC5 RID: 7621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC5")]
		[Address(RVA = "0x24A3CD8", Offset = "0x24A3CD8", VA = "0x7BBCCA3CD8")]
		public GroupLeaveNtf()
		{
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x0000CB28 File Offset: 0x0000AD28
		// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000400")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155DCC", Offset = "0x1155DCC")]
		public ulong leaver_id
		{
			[Token(Token = "0x6001DC6")]
			[Address(RVA = "0x24A3CE0", Offset = "0x24A3CE0", VA = "0x7BBCCA3CE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11363E4", Offset = "0x11363E4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001DC7")]
			[Address(RVA = "0x24A3CE8", Offset = "0x24A3CE8", VA = "0x7BBCCA3CE8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11363F4", Offset = "0x11363F4")]
			set
			{
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x0000CB40 File Offset: 0x0000AD40
		// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000401")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155DE0", Offset = "0x1155DE0")]
		public EGroup.LeaveReason reason
		{
			[Token(Token = "0x6001DC8")]
			[Address(RVA = "0x24A3CF0", Offset = "0x24A3CF0", VA = "0x7BBCCA3CF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136404", Offset = "0x1136404")]
			get
			{
				return EGroup.LeaveReason.LeaveReason_NORMAL;
			}
			[Token(Token = "0x6001DC9")]
			[Address(RVA = "0x24A3CF8", Offset = "0x24A3CF8", VA = "0x7BBCCA3CF8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136414", Offset = "0x1136414")]
			set
			{
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001DCB RID: 7627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000402")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155DF4", Offset = "0x1155DF4")]
		public GroupInfo group_info
		{
			[Token(Token = "0x6001DCA")]
			[Address(RVA = "0x24A3D00", Offset = "0x24A3D00", VA = "0x7BBCCA3D00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136424", Offset = "0x1136424")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DCB")]
			[Address(RVA = "0x24A3D08", Offset = "0x24A3D08", VA = "0x7BBCCA3D08")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136434", Offset = "0x1136434")]
			set
			{
			}
		}

		// Token: 0x04001625 RID: 5669
		[Token(Token = "0x4001625")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11027B4", Offset = "0x11027B4")]
		private ulong <leaver_id>k__BackingField;

		// Token: 0x04001626 RID: 5670
		[Token(Token = "0x4001626")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11027C4", Offset = "0x11027C4")]
		private EGroup.LeaveReason <reason>k__BackingField;

		// Token: 0x04001627 RID: 5671
		[Token(Token = "0x4001627")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11027D4", Offset = "0x11027D4")]
		private GroupInfo <group_info>k__BackingField;
	}
}
