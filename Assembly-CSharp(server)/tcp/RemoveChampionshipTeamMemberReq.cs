using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000458 RID: 1112
	[Token(Token = "0x2000458")]
	[ProtoContract]
	public class RemoveChampionshipTeamMemberReq
	{
		// Token: 0x06001C46 RID: 7238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C46")]
		[Address(RVA = "0x24A5B58", Offset = "0x24A5B58", VA = "0x7BBCCA5B58")]
		public RemoveChampionshipTeamMemberReq()
		{
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001C47 RID: 7239 RVA: 0x0000C018 File Offset: 0x0000A218
		// (set) Token: 0x06001C48 RID: 7240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000358")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11548A0", Offset = "0x11548A0")]
		public ulong team_id
		{
			[Token(Token = "0x6001C47")]
			[Address(RVA = "0x24A5B60", Offset = "0x24A5B60", VA = "0x7BBCCA5B60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134EE4", Offset = "0x1134EE4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001C48")]
			[Address(RVA = "0x24A5B68", Offset = "0x24A5B68", VA = "0x7BBCCA5B68")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134EF4", Offset = "0x1134EF4")]
			set
			{
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x0000C030 File Offset: 0x0000A230
		// (set) Token: 0x06001C4A RID: 7242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000359")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11548B4", Offset = "0x11548B4")]
		public ulong removee_id
		{
			[Token(Token = "0x6001C49")]
			[Address(RVA = "0x24A5B70", Offset = "0x24A5B70", VA = "0x7BBCCA5B70")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134F04", Offset = "0x1134F04")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001C4A")]
			[Address(RVA = "0x24A5B78", Offset = "0x24A5B78", VA = "0x7BBCCA5B78")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134F14", Offset = "0x1134F14")]
			set
			{
			}
		}

		// Token: 0x0400149B RID: 5275
		[Token(Token = "0x400149B")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101D34", Offset = "0x1101D34")]
		private ulong <team_id>k__BackingField;

		// Token: 0x0400149C RID: 5276
		[Token(Token = "0x400149C")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101D44", Offset = "0x1101D44")]
		private ulong <removee_id>k__BackingField;
	}
}
