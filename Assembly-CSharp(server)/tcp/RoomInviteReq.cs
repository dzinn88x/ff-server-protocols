using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000519 RID: 1305
	[Token(Token = "0x2000519")]
	[ProtoContract]
	public class RoomInviteReq
	{
		// Token: 0x060020B7 RID: 8375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020B7")]
		[Address(RVA = "0x24A675C", Offset = "0x24A675C", VA = "0x7BBCCA675C")]
		public RoomInviteReq()
		{
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x060020B8 RID: 8376 RVA: 0x0000E148 File Offset: 0x0000C348
		// (set) Token: 0x060020B9 RID: 8377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700054D")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11584A0", Offset = "0x11584A0")]
		public ulong invitee_id
		{
			[Token(Token = "0x60020B8")]
			[Address(RVA = "0x24A6764", Offset = "0x24A6764", VA = "0x7BBCCA6764")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138D84", Offset = "0x1138D84")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60020B9")]
			[Address(RVA = "0x24A676C", Offset = "0x24A676C", VA = "0x7BBCCA676C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1138D94", Offset = "0x1138D94")]
			set
			{
			}
		}

		// Token: 0x04001867 RID: 6247
		[Token(Token = "0x4001867")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103C84", Offset = "0x1103C84")]
		private ulong <invitee_id>k__BackingField;
	}
}
