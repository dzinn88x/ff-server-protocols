using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000457 RID: 1111
	[Token(Token = "0x2000457")]
	[ProtoContract]
	public class ConfirmAddChampionshipTeamReq
	{
		// Token: 0x06001C41 RID: 7233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C41")]
		[Address(RVA = "0x24A2AE0", Offset = "0x24A2AE0", VA = "0x7BBCCA2AE0")]
		public ConfirmAddChampionshipTeamReq()
		{
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		// (set) Token: 0x06001C43 RID: 7235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000356")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154878", Offset = "0x1154878")]
		public ulong team_id
		{
			[Token(Token = "0x6001C42")]
			[Address(RVA = "0x24A2AE8", Offset = "0x24A2AE8", VA = "0x7BBCCA2AE8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134EA4", Offset = "0x1134EA4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001C43")]
			[Address(RVA = "0x24A2AF0", Offset = "0x24A2AF0", VA = "0x7BBCCA2AF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134EB4", Offset = "0x1134EB4")]
			set
			{
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001C44 RID: 7236 RVA: 0x0000C000 File Offset: 0x0000A200
		// (set) Token: 0x06001C45 RID: 7237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000357")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x115488C", Offset = "0x115488C")]
		public ulong confirmer_id
		{
			[Token(Token = "0x6001C44")]
			[Address(RVA = "0x24A2AF8", Offset = "0x24A2AF8", VA = "0x7BBCCA2AF8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134EC4", Offset = "0x1134EC4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001C45")]
			[Address(RVA = "0x24A2B00", Offset = "0x24A2B00", VA = "0x7BBCCA2B00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134ED4", Offset = "0x1134ED4")]
			set
			{
			}
		}

		// Token: 0x04001499 RID: 5273
		[Token(Token = "0x4001499")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101D14", Offset = "0x1101D14")]
		private ulong <team_id>k__BackingField;

		// Token: 0x0400149A RID: 5274
		[Token(Token = "0x400149A")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101D24", Offset = "0x1101D24")]
		private ulong <confirmer_id>k__BackingField;
	}
}
