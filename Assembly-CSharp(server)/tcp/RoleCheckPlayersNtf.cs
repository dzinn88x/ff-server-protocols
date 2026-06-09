using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000525 RID: 1317
	[Token(Token = "0x2000525")]
	[ProtoContract]
	public class RoleCheckPlayersNtf
	{
		// Token: 0x06002171 RID: 8561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002171")]
		[Address(RVA = "0x24A5CBC", Offset = "0x24A5CBC", VA = "0x7BBCCA5CBC")]
		public RoleCheckPlayersNtf()
		{
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06002172 RID: 8562 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002173 RID: 8563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158D74", Offset = "0x1158D74")]
		public ulong[] account_ids
		{
			[Token(Token = "0x6002172")]
			[Address(RVA = "0x24A5CC4", Offset = "0x24A5CC4", VA = "0x7BBCCA5CC4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139864", Offset = "0x1139864")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002173")]
			[Address(RVA = "0x24A5CCC", Offset = "0x24A5CCC", VA = "0x7BBCCA5CCC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139874", Offset = "0x1139874")]
			set
			{
			}
		}

		// Token: 0x040018BE RID: 6334
		[Token(Token = "0x40018BE")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11041F4", Offset = "0x11041F4")]
		private ulong[] <account_ids>k__BackingField;
	}
}
