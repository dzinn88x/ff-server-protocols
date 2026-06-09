using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CAF RID: 7343
	[Token(Token = "0x2001CAF")]
	public class AvatarWebData : CSVBaseData
	{
		// Token: 0x0600A03F RID: 41023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A03F")]
		[Address(RVA = "0x21C8718", Offset = "0x21C8718", VA = "0x7BBC9C8718")]
		public static AvatarWebData Get(uint avatarid, string region, string language)
		{
			return null;
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x0600A040 RID: 41024 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A041 RID: 41025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A92")]
		public string Region
		{
			[Token(Token = "0x600A040")]
			[Address(RVA = "0x21C88B0", Offset = "0x21C88B0", VA = "0x7BBC9C88B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114553C", Offset = "0x114553C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600A041")]
			[Address(RVA = "0x21C88B8", Offset = "0x21C88B8", VA = "0x7BBC9C88B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114554C", Offset = "0x114554C")]
			private set
			{
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x0600A042 RID: 41026 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A043 RID: 41027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000A93")]
		public string LanguageAbbr
		{
			[Token(Token = "0x600A042")]
			[Address(RVA = "0x21C88C0", Offset = "0x21C88C0", VA = "0x7BBC9C88C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114555C", Offset = "0x114555C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600A043")]
			[Address(RVA = "0x21C88C8", Offset = "0x21C88C8", VA = "0x7BBC9C88C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x114556C", Offset = "0x114556C")]
			private set
			{
			}
		}

		// Token: 0x0600A044 RID: 41028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A044")]
		[Address(RVA = "0x21C88D0", Offset = "0x21C88D0", VA = "0x7BBC9C88D0", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600A045 RID: 41029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A045")]
		[Address(RVA = "0x21C8954", Offset = "0x21C8954", VA = "0x7BBC9C8954", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600A046 RID: 41030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A046")]
		[Address(RVA = "0x21C8CF0", Offset = "0x21C8CF0", VA = "0x7BBC9C8CF0")]
		public AvatarWebData()
		{
		}

		// Token: 0x0400A725 RID: 42789
		[Token(Token = "0x400A725")]
		[FieldOffset(Offset = "0x10")]
		public uint AvatarID;

		// Token: 0x0400A726 RID: 42790
		[Token(Token = "0x400A726")]
		[FieldOffset(Offset = "0x18")]
		public string WebLink;

		// Token: 0x0400A727 RID: 42791
		[Token(Token = "0x400A727")]
		private const string REGION_DEFAULT = "default";

		// Token: 0x0400A728 RID: 42792
		[Token(Token = "0x400A728")]
		private const string LANGUAGE_DEFAULT = "default";

		// Token: 0x0400A729 RID: 42793
		[Token(Token = "0x400A729")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<uint, Dictionary<string, Dictionary<string, AvatarWebData>>> _Data;

		// Token: 0x0400A72A RID: 42794
		[Token(Token = "0x400A72A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FC2C", Offset = "0x112FC2C")]
		private string <Region>k__BackingField;

		// Token: 0x0400A72B RID: 42795
		[Token(Token = "0x400A72B")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112FC3C", Offset = "0x112FC3C")]
		private string <LanguageAbbr>k__BackingField;
	}
}
