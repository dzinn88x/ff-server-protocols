using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200119A RID: 4506
	[Token(Token = "0x200119A")]
	public class TutorialURLData : CSVBaseData
	{
		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x0600461B RID: 17947 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600461C RID: 17948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000820")]
		public string Language
		{
			[Token(Token = "0x600461B")]
			[Address(RVA = "0x1A346B0", Offset = "0x1A346B0", VA = "0x7BBC2346B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D9B8", Offset = "0x113D9B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600461C")]
			[Address(RVA = "0x1A346B8", Offset = "0x1A346B8", VA = "0x7BBC2346B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D9C8", Offset = "0x113D9C8")]
			private set
			{
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x0600461D RID: 17949 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600461E RID: 17950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000821")]
		public string TutorialURL
		{
			[Token(Token = "0x600461D")]
			[Address(RVA = "0x1A346C0", Offset = "0x1A346C0", VA = "0x7BBC2346C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D9D8", Offset = "0x113D9D8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600461E")]
			[Address(RVA = "0x1A346C8", Offset = "0x1A346C8", VA = "0x7BBC2346C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D9E8", Offset = "0x113D9E8")]
			private set
			{
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x0600461F RID: 17951 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004620 RID: 17952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000822")]
		public string VideoURL
		{
			[Token(Token = "0x600461F")]
			[Address(RVA = "0x1A346D0", Offset = "0x1A346D0", VA = "0x7BBC2346D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D9F8", Offset = "0x113D9F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004620")]
			[Address(RVA = "0x1A346D8", Offset = "0x1A346D8", VA = "0x7BBC2346D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DA08", Offset = "0x113DA08")]
			private set
			{
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06004621 RID: 17953 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004622 RID: 17954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000823")]
		public string Region
		{
			[Token(Token = "0x6004621")]
			[Address(RVA = "0x1A346E0", Offset = "0x1A346E0", VA = "0x7BBC2346E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DA18", Offset = "0x113DA18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004622")]
			[Address(RVA = "0x1A346E8", Offset = "0x1A346E8", VA = "0x7BBC2346E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113DA28", Offset = "0x113DA28")]
			private set
			{
			}
		}

		// Token: 0x06004623 RID: 17955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004623")]
		[Address(RVA = "0x1A346F0", Offset = "0x1A346F0", VA = "0x7BBC2346F0", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004624 RID: 17956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004624")]
		[Address(RVA = "0x1A347C4", Offset = "0x1A347C4", VA = "0x7BBC2347C4", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x06004625 RID: 17957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004625")]
		[Address(RVA = "0x1A34760", Offset = "0x1A34760", VA = "0x7BBC234760")]
		public static string FormatPrimaryKey(string region, string language)
		{
			return null;
		}

		// Token: 0x06004626 RID: 17958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004626")]
		[Address(RVA = "0x1A34A38", Offset = "0x1A34A38", VA = "0x7BBC234A38")]
		public static TutorialURLData Get(string region, string language)
		{
			return null;
		}

		// Token: 0x06004627 RID: 17959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004627")]
		[Address(RVA = "0x1A34B00", Offset = "0x1A34B00", VA = "0x7BBC234B00")]
		private static Dictionary<string, TutorialURLData> Get(string region)
		{
			return null;
		}

		// Token: 0x06004628 RID: 17960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004628")]
		[Address(RVA = "0x1A34C70", Offset = "0x1A34C70", VA = "0x7BBC234C70")]
		private static TutorialURLData Get(string language, Dictionary<string, TutorialURLData> data)
		{
			return null;
		}

		// Token: 0x06004629 RID: 17961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004629")]
		[Address(RVA = "0x1A34D24", Offset = "0x1A34D24", VA = "0x7BBC234D24")]
		public TutorialURLData()
		{
		}

		// Token: 0x0400574E RID: 22350
		[Token(Token = "0x400574E")]
		private const string DEFAULT_LANG_REGION = "default";

		// Token: 0x0400574F RID: 22351
		[Token(Token = "0x400574F")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, Dictionary<string, TutorialURLData>> _Data;

		// Token: 0x04005750 RID: 22352
		[Token(Token = "0x4005750")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F5EC", Offset = "0x112F5EC")]
		private string <Language>k__BackingField;

		// Token: 0x04005751 RID: 22353
		[Token(Token = "0x4005751")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F5FC", Offset = "0x112F5FC")]
		private string <TutorialURL>k__BackingField;

		// Token: 0x04005752 RID: 22354
		[Token(Token = "0x4005752")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F60C", Offset = "0x112F60C")]
		private string <VideoURL>k__BackingField;

		// Token: 0x04005753 RID: 22355
		[Token(Token = "0x4005753")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F61C", Offset = "0x112F61C")]
		private string <Region>k__BackingField;
	}
}
