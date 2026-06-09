using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200045A RID: 1114
	[Token(Token = "0x200045A")]
	[ProtoContract]
	public class ApproveChampionshipTeamInvitationReq
	{
		// Token: 0x06001C54 RID: 7252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C54")]
		[Address(RVA = "0x24A25F4", Offset = "0x24A25F4", VA = "0x7BBCCA25F4")]
		public ApproveChampionshipTeamInvitationReq()
		{
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x0000C078 File Offset: 0x0000A278
		// (set) Token: 0x06001C56 RID: 7254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035E")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154990", Offset = "0x1154990")]
		public ulong invitee_id
		{
			[Token(Token = "0x6001C55")]
			[Address(RVA = "0x24A25FC", Offset = "0x24A25FC", VA = "0x7BBCCA25FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134FA4", Offset = "0x1134FA4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001C56")]
			[Address(RVA = "0x24A2604", Offset = "0x24A2604", VA = "0x7BBCCA2604")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134FB4", Offset = "0x1134FB4")]
			set
			{
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x0000C090 File Offset: 0x0000A290
		// (set) Token: 0x06001C58 RID: 7256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035F")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11549A4", Offset = "0x11549A4")]
		public ulong team_id
		{
			[Token(Token = "0x6001C57")]
			[Address(RVA = "0x24A260C", Offset = "0x24A260C", VA = "0x7BBCCA260C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134FC4", Offset = "0x1134FC4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001C58")]
			[Address(RVA = "0x24A2614", Offset = "0x24A2614", VA = "0x7BBCCA2614")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134FD4", Offset = "0x1134FD4")]
			set
			{
			}
		}

		// Token: 0x040014A1 RID: 5281
		[Token(Token = "0x40014A1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101D94", Offset = "0x1101D94")]
		private ulong <invitee_id>k__BackingField;

		// Token: 0x040014A2 RID: 5282
		[Token(Token = "0x40014A2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101DA4", Offset = "0x1101DA4")]
		private ulong <team_id>k__BackingField;
	}
}
