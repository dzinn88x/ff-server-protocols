using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000471 RID: 1137
	[Token(Token = "0x2000471")]
	[ProtoContract]
	public class ConfirmAddReq
	{
		// Token: 0x06001CB2 RID: 7346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CB2")]
		[Address(RVA = "0x24A2B08", Offset = "0x24A2B08", VA = "0x7BBCCA2B08")]
		public ConfirmAddReq()
		{
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06001CB3 RID: 7347 RVA: 0x0000C348 File Offset: 0x0000A548
		// (set) Token: 0x06001CB4 RID: 7348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000386")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154ECC", Offset = "0x1154ECC")]
		public ulong clan_id
		{
			[Token(Token = "0x6001CB3")]
			[Address(RVA = "0x24A2B10", Offset = "0x24A2B10", VA = "0x7BBCCA2B10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11354A4", Offset = "0x11354A4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001CB4")]
			[Address(RVA = "0x24A2B18", Offset = "0x24A2B18", VA = "0x7BBCCA2B18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11354B4", Offset = "0x11354B4")]
			set
			{
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001CB5 RID: 7349 RVA: 0x0000C360 File Offset: 0x0000A560
		// (set) Token: 0x06001CB6 RID: 7350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000387")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1154EE0", Offset = "0x1154EE0")]
		public ulong confirmer_id
		{
			[Token(Token = "0x6001CB5")]
			[Address(RVA = "0x24A2B20", Offset = "0x24A2B20", VA = "0x7BBCCA2B20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11354C4", Offset = "0x11354C4")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x6001CB6")]
			[Address(RVA = "0x24A2B28", Offset = "0x24A2B28", VA = "0x7BBCCA2B28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11354D4", Offset = "0x11354D4")]
			set
			{
			}
		}

		// Token: 0x04001501 RID: 5377
		[Token(Token = "0x4001501")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102014", Offset = "0x1102014")]
		private ulong <clan_id>k__BackingField;

		// Token: 0x04001502 RID: 5378
		[Token(Token = "0x4001502")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102024", Offset = "0x1102024")]
		private ulong <confirmer_id>k__BackingField;
	}
}
