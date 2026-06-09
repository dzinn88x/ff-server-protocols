using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001139 RID: 4409
	[Token(Token = "0x2001139")]
	public class LongDigitSeparationDataManager : SingletonModule<LongDigitSeparationDataManager>
	{
		// Token: 0x060044DF RID: 17631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044DF")]
		[Address(RVA = "0x1A5499C", Offset = "0x1A5499C", VA = "0x7BBC25499C", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x060044E0 RID: 17632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E0")]
		[Address(RVA = "0x1A54CDC", Offset = "0x1A54CDC", VA = "0x7BBC254CDC", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x060044E1 RID: 17633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044E1")]
		[Address(RVA = "0x1A54CE4", Offset = "0x1A54CE4", VA = "0x7BBC254CE4")]
		public LongDigitSeparationData GetLongDigitSeparationDataByLanguage(string language)
		{
			return null;
		}

		// Token: 0x060044E2 RID: 17634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E2")]
		[Address(RVA = "0x1A54EBC", Offset = "0x1A54EBC", VA = "0x7BBC254EBC")]
		public LongDigitSeparationDataManager()
		{
		}

		// Token: 0x04005502 RID: 21762
		[Token(Token = "0x4005502")]
		public const string DEFAULT_LANGUAGE_SPLIT = "default";

		// Token: 0x04005503 RID: 21763
		[Token(Token = "0x4005503")]
		[FieldOffset(Offset = "0x18")]
		public string CurrentCultureCode;

		// Token: 0x04005504 RID: 21764
		[Token(Token = "0x4005504")]
		[FieldOffset(Offset = "0x20")]
		private List<FormatCultureInfoData> m_FormateCultureInfoData;

		// Token: 0x04005505 RID: 21765
		[Token(Token = "0x4005505")]
		[FieldOffset(Offset = "0x28")]
		public List<LongDigitSeparationData> m_LongDigitSeparationDataList;

		// Token: 0x0200113A RID: 4410
		[Token(Token = "0x200113A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EAC94", Offset = "0x10EAC94")]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x060044E3 RID: 17635 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60044E3")]
			[Address(RVA = "0x1A54EB4", Offset = "0x1A54EB4", VA = "0x7BBC254EB4")]
			public <>c__DisplayClass6_0()
			{
			}

			// Token: 0x060044E4 RID: 17636 RVA: 0x00015138 File Offset: 0x00013338
			[Token(Token = "0x60044E4")]
			[Address(RVA = "0x1A55038", Offset = "0x1A55038", VA = "0x7BBC255038")]
			internal bool <GetLongDigitSeparationDataByLanguage>b__0(LongDigitSeparationData x)
			{
				return default(bool);
			}

			// Token: 0x04005506 RID: 21766
			[Token(Token = "0x4005506")]
			[FieldOffset(Offset = "0x10")]
			public string language;
		}

		// Token: 0x0200113B RID: 4411
		[Token(Token = "0x200113B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EACA4", Offset = "0x10EACA4")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060044E6 RID: 17638 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60044E6")]
			[Address(RVA = "0x1A54FD0", Offset = "0x1A54FD0", VA = "0x7BBC254FD0")]
			public <>c()
			{
			}

			// Token: 0x060044E7 RID: 17639 RVA: 0x00015150 File Offset: 0x00013350
			[Token(Token = "0x60044E7")]
			[Address(RVA = "0x1A54FD8", Offset = "0x1A54FD8", VA = "0x7BBC254FD8")]
			internal bool <GetLongDigitSeparationDataByLanguage>b__6_1(LongDigitSeparationData x)
			{
				return default(bool);
			}

			// Token: 0x04005507 RID: 21767
			[Token(Token = "0x4005507")]
			[FieldOffset(Offset = "0x0")]
			public static readonly LongDigitSeparationDataManager.<>c <>9;

			// Token: 0x04005508 RID: 21768
			[Token(Token = "0x4005508")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<LongDigitSeparationData> <>9__6_1;
		}
	}
}
