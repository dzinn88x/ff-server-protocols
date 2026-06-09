using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x02000524 RID: 1316
	[Token(Token = "0x2000524")]
	[ProtoContract]
	public class EmulatorCheckPlayersNtf
	{
		// Token: 0x0600216E RID: 8558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600216E")]
		[Address(RVA = "0x24A2E00", Offset = "0x24A2E00", VA = "0x7BBCCA2E00")]
		public EmulatorCheckPlayersNtf()
		{
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x0600216F RID: 8559 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002170 RID: 8560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A3")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158D38", Offset = "0x1158D38")]
		public ulong[] account_ids
		{
			[Token(Token = "0x600216F")]
			[Address(RVA = "0x24A2E08", Offset = "0x24A2E08", VA = "0x7BBCCA2E08")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139844", Offset = "0x1139844")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002170")]
			[Address(RVA = "0x24A2E10", Offset = "0x24A2E10", VA = "0x7BBCCA2E10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139854", Offset = "0x1139854")]
			set
			{
			}
		}

		// Token: 0x040018BD RID: 6333
		[Token(Token = "0x40018BD")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11041E4", Offset = "0x11041E4")]
		private ulong[] <account_ids>k__BackingField;
	}
}
