using System;
using Il2CppDummyDll;
using ProtoBuf;

namespace tcp
{
	// Token: 0x0200053B RID: 1339
	[Token(Token = "0x200053B")]
	[ProtoContract]
	public class MMRInfo
	{
		// Token: 0x06002192 RID: 8594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002192")]
		[Address(RVA = "0x24A47F0", Offset = "0x24A47F0", VA = "0x7BBCCA47F0")]
		public MMRInfo()
		{
		}

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06002193 RID: 8595 RVA: 0x0000E898 File Offset: 0x0000CA98
		// (set) Token: 0x06002194 RID: 8596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AF")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158E78", Offset = "0x1158E78")]
		public EMatch.GameMode game_mode
		{
			[Token(Token = "0x6002193")]
			[Address(RVA = "0x24A47F8", Offset = "0x24A47F8", VA = "0x7BBCCA47F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11399C4", Offset = "0x11399C4")]
			get
			{
				return EMatch.GameMode.GameMode_NONE;
			}
			[Token(Token = "0x6002194")]
			[Address(RVA = "0x24A4800", Offset = "0x24A4800", VA = "0x7BBCCA4800")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11399D4", Offset = "0x11399D4")]
			set
			{
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x0000E8B0 File Offset: 0x0000CAB0
		// (set) Token: 0x06002196 RID: 8598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B0")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158E8C", Offset = "0x1158E8C")]
		public uint mmr
		{
			[Token(Token = "0x6002195")]
			[Address(RVA = "0x24A4808", Offset = "0x24A4808", VA = "0x7BBCCA4808")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11399E4", Offset = "0x11399E4")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002196")]
			[Address(RVA = "0x24A4810", Offset = "0x24A4810", VA = "0x7BBCCA4810")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11399F4", Offset = "0x11399F4")]
			set
			{
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06002197 RID: 8599 RVA: 0x0000E8C8 File Offset: 0x0000CAC8
		// (set) Token: 0x06002198 RID: 8600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B1")]
		[Attribute(Name = "ProtoMemberAttribute", RVA = "0x1158EA0", Offset = "0x1158EA0")]
		public uint bot_point
		{
			[Token(Token = "0x6002197")]
			[Address(RVA = "0x24A4818", Offset = "0x24A4818", VA = "0x7BBCCA4818")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139A04", Offset = "0x1139A04")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002198")]
			[Address(RVA = "0x24A4820", Offset = "0x24A4820", VA = "0x7BBCCA4820")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1139A14", Offset = "0x1139A14")]
			set
			{
			}
		}

		// Token: 0x04001934 RID: 6452
		[Token(Token = "0x4001934")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11042A4", Offset = "0x11042A4")]
		private EMatch.GameMode <game_mode>k__BackingField;

		// Token: 0x04001935 RID: 6453
		[Token(Token = "0x4001935")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11042B4", Offset = "0x11042B4")]
		private uint <mmr>k__BackingField;

		// Token: 0x04001936 RID: 6454
		[Token(Token = "0x4001936")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x11042C4", Offset = "0x11042C4")]
		private uint <bot_point>k__BackingField;
	}
}
