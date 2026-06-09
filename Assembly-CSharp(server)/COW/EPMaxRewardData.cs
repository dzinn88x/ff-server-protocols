using System;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020010EB RID: 4331
	[Token(Token = "0x20010EB")]
	public class EPMaxRewardData : CSVBaseData
	{
		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06004392 RID: 17298 RVA: 0x00014BB0 File Offset: 0x00012DB0
		// (set) Token: 0x06004393 RID: 17299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007EF")]
		public uint EPEventID
		{
			[Token(Token = "0x6004392")]
			[Address(RVA = "0x160F590", Offset = "0x160F590", VA = "0x7BBBE0F590")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D478", Offset = "0x113D478")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6004393")]
			[Address(RVA = "0x160F598", Offset = "0x160F598", VA = "0x7BBBE0F598")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D488", Offset = "0x113D488")]
			private set
			{
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06004394 RID: 17300 RVA: 0x00014BC8 File Offset: 0x00012DC8
		// (set) Token: 0x06004395 RID: 17301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007F0")]
		public uint BadgeNum
		{
			[Token(Token = "0x6004394")]
			[Address(RVA = "0x160F5A0", Offset = "0x160F5A0", VA = "0x7BBBE0F5A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D498", Offset = "0x113D498")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6004395")]
			[Address(RVA = "0x160F5A8", Offset = "0x160F5A8", VA = "0x7BBBE0F5A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D4A8", Offset = "0x113D4A8")]
			private set
			{
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06004396 RID: 17302 RVA: 0x00014BE0 File Offset: 0x00012DE0
		// (set) Token: 0x06004397 RID: 17303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007F1")]
		public uint RewardId
		{
			[Token(Token = "0x6004396")]
			[Address(RVA = "0x160F5B0", Offset = "0x160F5B0", VA = "0x7BBBE0F5B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D4B8", Offset = "0x113D4B8")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6004397")]
			[Address(RVA = "0x160F5B8", Offset = "0x160F5B8", VA = "0x7BBBE0F5B8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113D4C8", Offset = "0x113D4C8")]
			private set
			{
			}
		}

		// Token: 0x06004398 RID: 17304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004398")]
		[Address(RVA = "0x160F5C0", Offset = "0x160F5C0", VA = "0x7BBBE0F5C0", Slot = "5")]
		public override string GetPrimaryKey()
		{
			return null;
		}

		// Token: 0x06004399 RID: 17305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004399")]
		[Address(RVA = "0x160F5EC", Offset = "0x160F5EC", VA = "0x7BBBE0F5EC", Slot = "4")]
		public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
		{
		}

		// Token: 0x0600439A RID: 17306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600439A")]
		[Address(RVA = "0x160F6C8", Offset = "0x160F6C8", VA = "0x7BBBE0F6C8")]
		public EPMaxRewardData()
		{
		}

		// Token: 0x04005374 RID: 21364
		[Token(Token = "0x4005374")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F34C", Offset = "0x112F34C")]
		private uint <EPEventID>k__BackingField;

		// Token: 0x04005375 RID: 21365
		[Token(Token = "0x4005375")]
		[FieldOffset(Offset = "0x14")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F35C", Offset = "0x112F35C")]
		private uint <BadgeNum>k__BackingField;

		// Token: 0x04005376 RID: 21366
		[Token(Token = "0x4005376")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112F36C", Offset = "0x112F36C")]
		private uint <RewardId>k__BackingField;
	}
}
