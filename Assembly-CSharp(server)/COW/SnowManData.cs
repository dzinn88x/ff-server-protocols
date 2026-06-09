using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001188 RID: 4488
	[Token(Token = "0x2001188")]
	public class SnowManData : CSVBaseData
	{
		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x060045E1 RID: 17889 RVA: 0x000152E8 File Offset: 0x000134E8
		// (set) Token: 0x060045E2 RID: 17890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700081E")]
		public uint Level
		{
			[Token(Token = "0x60045E1")]
			[Address(RVA = "0x1B39D34", Offset = "0x1B39D34", VA = "0x7BBC339D34")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D978", Offset = "0x113D978")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60045E2")]
			[Address(RVA = "0x1B39D3C", Offset = "0x1B39D3C", VA = "0x7BBC339D3C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D988", Offset = "0x113D988")]
			set
			{
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x060045E3 RID: 17891 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060045E4 RID: 17892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700081F")]
		public uint[] ClothIDs
		{
			[Token(Token = "0x60045E3")]
			[Address(RVA = "0x1B39D44", Offset = "0x1B39D44", VA = "0x7BBC339D44")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D998", Offset = "0x113D998")]
			get
			{
				return null;
			}
			[Token(Token = "0x60045E4")]
			[Address(RVA = "0x1B39D4C", Offset = "0x1B39D4C", VA = "0x7BBC339D4C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D9A8", Offset = "0x113D9A8")]
			set
			{
			}
		}

		// Token: 0x060045E5 RID: 17893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60045E5")]
		[Address(RVA = "0x1B39D54", Offset = "0x1B39D54", VA = "0x7BBC339D54", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x060045E6 RID: 17894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E6")]
		[Address(RVA = "0x1B39D80", Offset = "0x1B39D80", VA = "0x7BBC339D80", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x060045E7 RID: 17895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045E7")]
		[Address(RVA = "0x1B39F50", Offset = "0x1B39F50", VA = "0x7BBC339F50")]
		public SnowManData()
		{
		}

		// Token: 0x040056F2 RID: 22258
		[Token(Token = "0x40056F2")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F5CC", Offset = "0x112F5CC")]
		private uint <Level>k__BackingField;

		// Token: 0x040056F3 RID: 22259
		[Token(Token = "0x40056F3")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F5DC", Offset = "0x112F5DC")]
		private uint[] <ClothIDs>k__BackingField;
	}
}
