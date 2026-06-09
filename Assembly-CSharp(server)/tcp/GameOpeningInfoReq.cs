using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x020004E1 RID: 1249
	[Token(Token = "0x20004E1")]
	[ProtoContract]
	public class GameOpeningInfoReq
	{
		// Token: 0x06001F5F RID: 8031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F5F")]
		[Address(RVA = "0x24A2F88", Offset = "0x24A2F88", VA = "0x7BBCCA2F88")]
		public GameOpeningInfoReq()
		{
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001F60 RID: 8032 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F61 RID: 8033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B4")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x11573D4", Offset = "0x11573D4")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x11573D4", Offset = "0x11573D4")]
		public string region
		{
			[Token(Token = "0x6001F60")]
			[Address(RVA = "0x24A2FF4", Offset = "0x24A2FF4", VA = "0x7BBCCA2FF4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137A64", Offset = "0x1137A64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F61")]
			[Address(RVA = "0x24A2FE4", Offset = "0x24A2FE4", VA = "0x7BBCCA2FE4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137A74", Offset = "0x1137A74")]
			set
			{
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001F62 RID: 8034 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F63 RID: 8035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B5")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1157424", Offset = "0x1157424")]
		[Attribute(Name = "DefaultValueAttribute", RVA = "0x1157424", Offset = "0x1157424")]
		public string language
		{
			[Token(Token = "0x6001F62")]
			[Address(RVA = "0x24A2FFC", Offset = "0x24A2FFC", VA = "0x7BBCCA2FFC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137A84", Offset = "0x1137A84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F63")]
			[Address(RVA = "0x24A2FEC", Offset = "0x24A2FEC", VA = "0x7BBCCA2FEC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1137A94", Offset = "0x1137A94")]
			set
			{
			}
		}

		// Token: 0x04001733 RID: 5939
		[Token(Token = "0x4001733")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11032F4", Offset = "0x11032F4")]
		private string <region>k__BackingField;

		// Token: 0x04001734 RID: 5940
		[Token(Token = "0x4001734")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1103304", Offset = "0x1103304")]
		private string <language>k__BackingField;
	}
}
