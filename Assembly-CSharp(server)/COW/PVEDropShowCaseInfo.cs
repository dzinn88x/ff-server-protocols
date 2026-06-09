using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CFA RID: 7418
	[Token(Token = "0x2001CFA")]
	public class PVEDropShowCaseInfo
	{
		// Token: 0x0600A1C1 RID: 41409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A1C1")]
		[Address(RVA = "0x203C348", Offset = "0x203C348", VA = "0x7BBC83C348")]
		public PVEDropShowCaseInfo()
		{
		}

		// Token: 0x0400A822 RID: 43042
		[Token(Token = "0x400A822")]
		[FieldOffset(Offset = "0x10")]
		public uint MapConfigID;

		// Token: 0x0400A823 RID: 43043
		[Token(Token = "0x400A823")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<int, PVEDropShowCaseInfo.DifficultyMapInfo> DifficultyMap;

		// Token: 0x02001CFB RID: 7419
		[Token(Token = "0x2001CFB")]
		public class ItemInfo
		{
			// Token: 0x0600A1C2 RID: 41410 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A1C2")]
			[Address(RVA = "0x203C428", Offset = "0x203C428", VA = "0x7BBC83C428")]
			public ItemInfo(PVEDropShowcaseData data)
			{
			}

			// Token: 0x0400A824 RID: 43044
			[Token(Token = "0x400A824")]
			[FieldOffset(Offset = "0x10")]
			public uint ID;

			// Token: 0x0400A825 RID: 43045
			[Token(Token = "0x400A825")]
			[FieldOffset(Offset = "0x14")]
			public uint GoPos;

			// Token: 0x0400A826 RID: 43046
			[Token(Token = "0x400A826")]
			[FieldOffset(Offset = "0x18")]
			public string SubGoPos;
		}

		// Token: 0x02001CFC RID: 7420
		[Token(Token = "0x2001CFC")]
		public class DifficultyMapInfo
		{
			// Token: 0x0600A1C3 RID: 41411 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A1C3")]
			[Address(RVA = "0x203C3B8", Offset = "0x203C3B8", VA = "0x7BBC83C3B8")]
			public DifficultyMapInfo()
			{
			}

			// Token: 0x0400A827 RID: 43047
			[Token(Token = "0x400A827")]
			[FieldOffset(Offset = "0x10")]
			public List<PVEDropShowCaseInfo.ItemInfo> Items;

			// Token: 0x0400A828 RID: 43048
			[Token(Token = "0x400A828")]
			[FieldOffset(Offset = "0x18")]
			public PVEDropShowCaseInfo.ItemInfo MainDropItem;

			// Token: 0x0400A829 RID: 43049
			[Token(Token = "0x400A829")]
			[FieldOffset(Offset = "0x20")]
			public uint RedeemProps;
		}
	}
}
