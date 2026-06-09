using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200045C RID: 1116
	[Token(Token = "0x200045C")]
	[ProtoContract]
	public class DeclineChampionshipTeamInvitationReq
	{
		// Token: 0x06001C60 RID: 7264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C60")]
		[Address(RVA = "0x24A2B88", Offset = "0x24A2B88", VA = "0x7BBCCA2B88")]
		public DeclineChampionshipTeamInvitationReq()
		{
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
		// (set) Token: 0x06001C62 RID: 7266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000363")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154A30", Offset = "0x1154A30")]
		public ulong invitee_id
		{
			[Token(Token = "0x6001C61")]
			[Address(RVA = "0x24A2B90", Offset = "0x24A2B90", VA = "0x7BBCCA2B90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135044", Offset = "0x1135044")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001C62")]
			[Address(RVA = "0x24A2B98", Offset = "0x24A2B98", VA = "0x7BBCCA2B98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1135054", Offset = "0x1135054")]
			set
			{
			}
		}

		// Token: 0x040014A6 RID: 5286
		[Token(Token = "0x40014A6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101DE4", Offset = "0x1101DE4")]
		private ulong <invitee_id>k__BackingField;
	}
}
