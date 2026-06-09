using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200043C RID: 1084
	[Token(Token = "0x200043C")]
	[ProtoContract]
	public class AwardDataTCP
	{
		// Token: 0x06001BEC RID: 7148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BEC")]
		[Address(RVA = "0x24A2728", Offset = "0x24A2728", VA = "0x7BBCCA2728")]
		public AwardDataTCP()
		{
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BEE RID: 7150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000334")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11544A4", Offset = "0x11544A4")]
		public List<ItemTCP> items
		{
			[Token(Token = "0x6001BED")]
			[Address(RVA = "0x24A27A4", Offset = "0x24A27A4", VA = "0x7BBCCA27A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134A64", Offset = "0x1134A64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BEE")]
			[Address(RVA = "0x24A279C", Offset = "0x24A279C", VA = "0x7BBCCA279C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1134A74", Offset = "0x1134A74")]
			private set
			{
			}
		}

		// Token: 0x04001453 RID: 5203
		[Token(Token = "0x4001453")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1101AF4", Offset = "0x1101AF4")]
		private List<ItemTCP> <items>k__BackingField;
	}
}
