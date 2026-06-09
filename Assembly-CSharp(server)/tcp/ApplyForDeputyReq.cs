using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000477 RID: 1143
	[Token(Token = "0x2000477")]
	[ProtoContract]
	public class ApplyForDeputyReq
	{
		// Token: 0x06001CD8 RID: 7384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CD8")]
		[Address(RVA = "0x24A25DC", Offset = "0x24A25DC", VA = "0x7BBCCA25DC")]
		public ApplyForDeputyReq()
		{
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06001CD9 RID: 7385 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
		// (set) Token: 0x06001CDA RID: 7386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000396")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1155048", Offset = "0x1155048")]
		public ulong clan_id
		{
			[Token(Token = "0x6001CD9")]
			[Address(RVA = "0x24A25E4", Offset = "0x24A25E4", VA = "0x7BBCCA25E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11356A4", Offset = "0x11356A4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001CDA")]
			[Address(RVA = "0x24A25EC", Offset = "0x24A25EC", VA = "0x7BBCCA25EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11356B4", Offset = "0x11356B4")]
			set
			{
			}
		}

		// Token: 0x04001511 RID: 5393
		[Token(Token = "0x4001511")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102114", Offset = "0x1102114")]
		private ulong <clan_id>k__BackingField;
	}
}
