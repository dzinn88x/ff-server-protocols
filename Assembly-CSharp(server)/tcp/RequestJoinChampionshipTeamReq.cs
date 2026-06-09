using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000456 RID: 1110
	[Token(Token = "0x2000456")]
	[ProtoContract]
	public class RequestJoinChampionshipTeamReq
	{
		// Token: 0x06001C3E RID: 7230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3E")]
		[Address(RVA = "0x24A5C34", Offset = "0x24A5C34", VA = "0x7BBCCA5C34")]
		public RequestJoinChampionshipTeamReq()
		{
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		// (set) Token: 0x06001C40 RID: 7232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000355")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154864", Offset = "0x1154864")]
		public ulong applicant_id
		{
			[Token(Token = "0x6001C3F")]
			[Address(RVA = "0x24A5C3C", Offset = "0x24A5C3C", VA = "0x7BBCCA5C3C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134E84", Offset = "0x1134E84")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001C40")]
			[Address(RVA = "0x24A5C44", Offset = "0x24A5C44", VA = "0x7BBCCA5C44")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134E94", Offset = "0x1134E94")]
			set
			{
			}
		}

		// Token: 0x04001498 RID: 5272
		[Token(Token = "0x4001498")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101D04", Offset = "0x1101D04")]
		private ulong <applicant_id>k__BackingField;
	}
}
