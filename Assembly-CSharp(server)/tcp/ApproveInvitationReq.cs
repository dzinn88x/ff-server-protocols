using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000472 RID: 1138
	[Token(Token = "0x2000472")]
	[ProtoContract]
	public class ApproveInvitationReq
	{
		// Token: 0x06001CB7 RID: 7351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB7")]
		[Address(RVA = "0x24A261C", Offset = "0x24A261C", VA = "0x7BBCCA261C")]
		public ApproveInvitationReq()
		{
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x0000C378 File Offset: 0x0000A578
		// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000388")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154EF4", Offset = "0x1154EF4")]
		public ulong invitee_id
		{
			[Token(Token = "0x6001CB8")]
			[Address(RVA = "0x24A2624", Offset = "0x24A2624", VA = "0x7BBCCA2624")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11354E4", Offset = "0x11354E4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001CB9")]
			[Address(RVA = "0x24A262C", Offset = "0x24A262C", VA = "0x7BBCCA262C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11354F4", Offset = "0x11354F4")]
			set
			{
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001CBA RID: 7354 RVA: 0x0000C390 File Offset: 0x0000A590
		// (set) Token: 0x06001CBB RID: 7355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000389")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154F08", Offset = "0x1154F08")]
		public ulong clan_id
		{
			[Token(Token = "0x6001CBA")]
			[Address(RVA = "0x24A2634", Offset = "0x24A2634", VA = "0x7BBCCA2634")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135504", Offset = "0x1135504")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001CBB")]
			[Address(RVA = "0x24A263C", Offset = "0x24A263C", VA = "0x7BBCCA263C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135514", Offset = "0x1135514")]
			set
			{
			}
		}

		// Token: 0x04001503 RID: 5379
		[Token(Token = "0x4001503")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102034", Offset = "0x1102034")]
		private ulong <invitee_id>k__BackingField;

		// Token: 0x04001504 RID: 5380
		[Token(Token = "0x4001504")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102044", Offset = "0x1102044")]
		private ulong <clan_id>k__BackingField;
	}
}
