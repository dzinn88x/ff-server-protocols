using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004B7 RID: 1207
	[Token(Token = "0x20004B7")]
	[ProtoContract]
	public class CSRankingBanNtf
	{
		// Token: 0x06001E91 RID: 7825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E91")]
		[Address(RVA = "0x24A2868", Offset = "0x24A2868", VA = "0x7BBCCA2868")]
		public CSRankingBanNtf()
		{
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E93 RID: 7827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700045B")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1156934", Offset = "0x1156934")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1156934", Offset = "0x1156934")]
		public string nickname
		{
			[Token(Token = "0x6001E92")]
			[Address(RVA = "0x24A28CC", Offset = "0x24A28CC", VA = "0x7BBCCA28CC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136F44", Offset = "0x1136F44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E93")]
			[Address(RVA = "0x24A28C4", Offset = "0x24A28C4", VA = "0x7BBCCA28C4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1136F54", Offset = "0x1136F54")]
			set
			{
			}
		}

		// Token: 0x04001680 RID: 5760
		[Token(Token = "0x4001680")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1102D64", Offset = "0x1102D64")]
		private string <nickname>k__BackingField;
	}
}
