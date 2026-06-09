using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001093 RID: 4243
	[Token(Token = "0x2001093")]
	public class AnniversyWebsite : CSVBaseData
	{
		// Token: 0x06004158 RID: 16728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004158")]
		[Address(RVA = "0x154C9BC", Offset = "0x154C9BC", VA = "0x7BBBD4C9BC")]
		public static AnniversyWebsite Get(string region, string language, AnniversyWebsite.Type type = AnniversyWebsite.Type.Main)
		{
			return null;
		}

		// Token: 0x06004159 RID: 16729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004159")]
		[Address(RVA = "0x154CA9C", Offset = "0x154CA9C", VA = "0x7BBBD4CA9C")]
		private static Dictionary<string, Dictionary<int, AnniversyWebsite>> Get(string region)
		{
			return null;
		}

		// Token: 0x0600415A RID: 16730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600415A")]
		[Address(RVA = "0x154CC64", Offset = "0x154CC64", VA = "0x7BBBD4CC64")]
		private static Dictionary<int, AnniversyWebsite> Get(string language, Dictionary<string, Dictionary<int, AnniversyWebsite>> data)
		{
			return null;
		}

		// Token: 0x0600415B RID: 16731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600415B")]
		[Address(RVA = "0x154CD44", Offset = "0x154CD44", VA = "0x7BBBD4CD44")]
		private static AnniversyWebsite Get(int type, Dictionary<int, AnniversyWebsite> data)
		{
			return null;
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x0600415C RID: 16732 RVA: 0x000140D0 File Offset: 0x000122D0
		// (set) Token: 0x0600415D RID: 16733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700077E")]
		public int ID
		{
			[Token(Token = "0x600415C")]
			[Address(RVA = "0x154CE10", Offset = "0x154CE10", VA = "0x7BBBD4CE10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C6F8", Offset = "0x113C6F8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600415D")]
			[Address(RVA = "0x154CE18", Offset = "0x154CE18", VA = "0x7BBBD4CE18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C708", Offset = "0x113C708")]
			private set
			{
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x0600415E RID: 16734 RVA: 0x000140E8 File Offset: 0x000122E8
		// (set) Token: 0x0600415F RID: 16735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700077F")]
		public int TitleType
		{
			[Token(Token = "0x600415E")]
			[Address(RVA = "0x154CE20", Offset = "0x154CE20", VA = "0x7BBBD4CE20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C718", Offset = "0x113C718")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600415F")]
			[Address(RVA = "0x154CE28", Offset = "0x154CE28", VA = "0x7BBBD4CE28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C728", Offset = "0x113C728")]
			private set
			{
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06004160 RID: 16736 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004161 RID: 16737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000780")]
		public string Region
		{
			[Token(Token = "0x6004160")]
			[Address(RVA = "0x154CE30", Offset = "0x154CE30", VA = "0x7BBBD4CE30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C738", Offset = "0x113C738")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004161")]
			[Address(RVA = "0x154CE38", Offset = "0x154CE38", VA = "0x7BBBD4CE38")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C748", Offset = "0x113C748")]
			private set
			{
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06004162 RID: 16738 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004163 RID: 16739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000781")]
		public string LanguageAbbr
		{
			[Token(Token = "0x6004162")]
			[Address(RVA = "0x154CE40", Offset = "0x154CE40", VA = "0x7BBBD4CE40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C758", Offset = "0x113C758")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004163")]
			[Address(RVA = "0x154CE48", Offset = "0x154CE48", VA = "0x7BBBD4CE48")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C768", Offset = "0x113C768")]
			private set
			{
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06004164 RID: 16740 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004165 RID: 16741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000782")]
		public string WebUrl
		{
			[Token(Token = "0x6004164")]
			[Address(RVA = "0x154CE50", Offset = "0x154CE50", VA = "0x7BBBD4CE50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C778", Offset = "0x113C778")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004165")]
			[Address(RVA = "0x154CE58", Offset = "0x154CE58", VA = "0x7BBBD4CE58")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113C788", Offset = "0x113C788")]
			private set
			{
			}
		}

		// Token: 0x06004166 RID: 16742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004166")]
		[Address(RVA = "0x154CE60", Offset = "0x154CE60", VA = "0x7BBBD4CE60", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004167 RID: 16743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004167")]
		[Address(RVA = "0x154CE8C", Offset = "0x154CE8C", VA = "0x7BBBD4CE8C", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004168 RID: 16744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004168")]
		[Address(RVA = "0x154D228", Offset = "0x154D228", VA = "0x7BBBD4D228")]
		public AnniversyWebsite()
		{
		}

		// Token: 0x040050B2 RID: 20658
		[Token(Token = "0x40050B2")]
		private const string REGION_DEFAULT = "default";

		// Token: 0x040050B3 RID: 20659
		[Token(Token = "0x40050B3")]
		private const string LANGUAGE_DEFAULT = "default";

		// Token: 0x040050B4 RID: 20660
		[Token(Token = "0x40050B4")]
		private const int TYPE_DEFAULT = 1;

		// Token: 0x040050B5 RID: 20661
		[Token(Token = "0x40050B5")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, Dictionary<string, Dictionary<int, AnniversyWebsite>>> _Data;

		// Token: 0x040050B6 RID: 20662
		[Token(Token = "0x40050B6")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EC8C", Offset = "0x112EC8C")]
		private int <ID>k__BackingField;

		// Token: 0x040050B7 RID: 20663
		[Token(Token = "0x40050B7")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112EC9C", Offset = "0x112EC9C")]
		private int <TitleType>k__BackingField;

		// Token: 0x040050B8 RID: 20664
		[Token(Token = "0x40050B8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112ECAC", Offset = "0x112ECAC")]
		private string <Region>k__BackingField;

		// Token: 0x040050B9 RID: 20665
		[Token(Token = "0x40050B9")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112ECBC", Offset = "0x112ECBC")]
		private string <LanguageAbbr>k__BackingField;

		// Token: 0x040050BA RID: 20666
		[Token(Token = "0x40050BA")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112ECCC", Offset = "0x112ECCC")]
		private string <WebUrl>k__BackingField;

		// Token: 0x02001094 RID: 4244
		[Token(Token = "0x2001094")]
		public enum Type
		{
			// Token: 0x040050BC RID: 20668
			[Token(Token = "0x40050BC")]
			None,
			// Token: 0x040050BD RID: 20669
			[Token(Token = "0x40050BD")]
			Main,
			// Token: 0x040050BE RID: 20670
			[Token(Token = "0x40050BE")]
			Invitation
		}
	}
}
