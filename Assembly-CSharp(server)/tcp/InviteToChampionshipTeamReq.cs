using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000459 RID: 1113
	[Token(Token = "0x2000459")]
	[ProtoContract]
	public class InviteToChampionshipTeamReq
	{
		// Token: 0x06001C4B RID: 7243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4B")]
		[Address(RVA = "0x24A43CC", Offset = "0x24A43CC", VA = "0x7BBCCA43CC")]
		public InviteToChampionshipTeamReq()
		{
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x0000C048 File Offset: 0x0000A248
		// (set) Token: 0x06001C4D RID: 7245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035A")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11548C8", Offset = "0x11548C8")]
		public ulong inviter_id
		{
			[Token(Token = "0x6001C4C")]
			[Address(RVA = "0x24A443C", Offset = "0x24A443C", VA = "0x7BBCCA443C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134F24", Offset = "0x1134F24")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001C4D")]
			[Address(RVA = "0x24A4444", Offset = "0x24A4444", VA = "0x7BBCCA4444")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134F34", Offset = "0x1134F34")]
			set
			{
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C4F RID: 7247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11548DC", Offset = "0x11548DC")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11548DC", Offset = "0x11548DC")]
		public string inviter_name
		{
			[Token(Token = "0x6001C4E")]
			[Address(RVA = "0x24A444C", Offset = "0x24A444C", VA = "0x7BBCCA444C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134F44", Offset = "0x1134F44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C4F")]
			[Address(RVA = "0x24A442C", Offset = "0x24A442C", VA = "0x7BBCCA442C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134F54", Offset = "0x1134F54")]
			set
			{
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x0000C060 File Offset: 0x0000A260
		// (set) Token: 0x06001C51 RID: 7249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035C")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115492C", Offset = "0x115492C")]
		public ulong team_id
		{
			[Token(Token = "0x6001C50")]
			[Address(RVA = "0x24A4454", Offset = "0x24A4454", VA = "0x7BBCCA4454")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134F64", Offset = "0x1134F64")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001C51")]
			[Address(RVA = "0x24A445C", Offset = "0x24A445C", VA = "0x7BBCCA445C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134F74", Offset = "0x1134F74")]
			set
			{
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C53 RID: 7251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035D")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1154940", Offset = "0x1154940")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154940", Offset = "0x1154940")]
		public string team_name
		{
			[Token(Token = "0x6001C52")]
			[Address(RVA = "0x24A4464", Offset = "0x24A4464", VA = "0x7BBCCA4464")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134F84", Offset = "0x1134F84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C53")]
			[Address(RVA = "0x24A4434", Offset = "0x24A4434", VA = "0x7BBCCA4434")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134F94", Offset = "0x1134F94")]
			set
			{
			}
		}

		// Token: 0x0400149D RID: 5277
		[Token(Token = "0x400149D")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101D54", Offset = "0x1101D54")]
		private ulong <inviter_id>k__BackingField;

		// Token: 0x0400149E RID: 5278
		[Token(Token = "0x400149E")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101D64", Offset = "0x1101D64")]
		private string <inviter_name>k__BackingField;

		// Token: 0x0400149F RID: 5279
		[Token(Token = "0x400149F")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101D74", Offset = "0x1101D74")]
		private ulong <team_id>k__BackingField;

		// Token: 0x040014A0 RID: 5280
		[Token(Token = "0x40014A0")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101D84", Offset = "0x1101D84")]
		private string <team_name>k__BackingField;
	}
}
