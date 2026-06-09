using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001102 RID: 4354
	[Token(Token = "0x2001102")]
	internal class GameFunctionSwitchData : CSVBaseData
	{
		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06004404 RID: 17412 RVA: 0x00014DF0 File Offset: 0x00012FF0
		// (set) Token: 0x06004405 RID: 17413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007FC")]
		public FunctionType FunctionType
		{
			[Token(Token = "0x6004404")]
			[Address(RVA = "0x187D9E0", Offset = "0x187D9E0", VA = "0x7BBC07D9E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D618", Offset = "0x113D618")]
			get
			{
				return (FunctionType)0;
			}
			[Token(Token = "0x6004405")]
			[Address(RVA = "0x187D9E8", Offset = "0x187D9E8", VA = "0x7BBC07D9E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D628", Offset = "0x113D628")]
			private set
			{
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06004406 RID: 17414 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004407 RID: 17415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007FD")]
		public string FunctionName
		{
			[Token(Token = "0x6004406")]
			[Address(RVA = "0x187D9F0", Offset = "0x187D9F0", VA = "0x7BBC07D9F0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D638", Offset = "0x113D638")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004407")]
			[Address(RVA = "0x187D9F8", Offset = "0x187D9F8", VA = "0x7BBC07D9F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D648", Offset = "0x113D648")]
			private set
			{
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06004408 RID: 17416 RVA: 0x00014E08 File Offset: 0x00013008
		// (set) Token: 0x06004409 RID: 17417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007FE")]
		public int LevelLimit
		{
			[Token(Token = "0x6004408")]
			[Address(RVA = "0x187DA00", Offset = "0x187DA00", VA = "0x7BBC07DA00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D658", Offset = "0x113D658")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004409")]
			[Address(RVA = "0x187DA08", Offset = "0x187DA08", VA = "0x7BBC07DA08")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D668", Offset = "0x113D668")]
			set
			{
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x0600440A RID: 17418 RVA: 0x00014E20 File Offset: 0x00013020
		// (set) Token: 0x0600440B RID: 17419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007FF")]
		public bool IsOpen
		{
			[Token(Token = "0x600440A")]
			[Address(RVA = "0x187DA10", Offset = "0x187DA10", VA = "0x7BBC07DA10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D678", Offset = "0x113D678")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600440B")]
			[Address(RVA = "0x187DA18", Offset = "0x187DA18", VA = "0x7BBC07DA18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D688", Offset = "0x113D688")]
			private set
			{
			}
		}

		// Token: 0x0600440C RID: 17420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600440C")]
		[Address(RVA = "0x187DA24", Offset = "0x187DA24", VA = "0x7BBC07DA24", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x0600440D RID: 17421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600440D")]
		[Address(RVA = "0x187DAC0", Offset = "0x187DAC0", VA = "0x7BBC07DAC0", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600440E RID: 17422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600440E")]
		[Address(RVA = "0x187DD78", Offset = "0x187DD78", VA = "0x7BBC07DD78")]
		public GameFunctionSwitchData()
		{
		}

		// Token: 0x04005407 RID: 21511
		[Token(Token = "0x4005407")]
		[FieldOffset(Offset = "0x10")]
		private FunctionType m_FunctionType;

		// Token: 0x04005408 RID: 21512
		[Token(Token = "0x4005408")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F41C", Offset = "0x112F41C")]
		private FunctionType <FunctionType>k__BackingField;

		// Token: 0x04005409 RID: 21513
		[Token(Token = "0x4005409")]
		[FieldOffset(Offset = "0x18")]
		private string m_FunctionName;

		// Token: 0x0400540A RID: 21514
		[Token(Token = "0x400540A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F42C", Offset = "0x112F42C")]
		private string <FunctionName>k__BackingField;

		// Token: 0x0400540B RID: 21515
		[Token(Token = "0x400540B")]
		[FieldOffset(Offset = "0x28")]
		private int m_LevelLimit;

		// Token: 0x0400540C RID: 21516
		[Token(Token = "0x400540C")]
		[FieldOffset(Offset = "0x2C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F43C", Offset = "0x112F43C")]
		private int <LevelLimit>k__BackingField;

		// Token: 0x0400540D RID: 21517
		[Token(Token = "0x400540D")]
		[FieldOffset(Offset = "0x30")]
		private bool m_IsOpen;

		// Token: 0x0400540E RID: 21518
		[Token(Token = "0x400540E")]
		[FieldOffset(Offset = "0x31")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F44C", Offset = "0x112F44C")]
		private bool <IsOpen>k__BackingField;
	}
}
