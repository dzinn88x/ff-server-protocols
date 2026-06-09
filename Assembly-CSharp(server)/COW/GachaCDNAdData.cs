using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001D1B RID: 7451
	[Token(Token = "0x2001D1B")]
	public class GachaCDNAdData
	{
		// Token: 0x0600A221 RID: 41505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A221")]
		[Address(RVA = "0x1868478", Offset = "0x1868478", VA = "0x7BBC068478")]
		public void ResetData()
		{
		}

		// Token: 0x0600A222 RID: 41506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A222")]
		[Address(RVA = "0x1868574", Offset = "0x1868574", VA = "0x7BBC068574")]
		public void GetGachaAdRes()
		{
		}

		// Token: 0x0600A223 RID: 41507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A223")]
		[Address(RVA = "0x1868DDC", Offset = "0x1868DDC", VA = "0x7BBC068DDC")]
		public List<AdvertDesc> GetCurAdList(uint chestID)
		{
			return null;
		}

		// Token: 0x0600A224 RID: 41508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A224")]
		[Address(RVA = "0x1868E5C", Offset = "0x1868E5C", VA = "0x7BBC068E5C")]
		public AdvertDesc GetTabRes(uint chestID)
		{
			return null;
		}

		// Token: 0x0600A225 RID: 41509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A225")]
		[Address(RVA = "0x1868EDC", Offset = "0x1868EDC", VA = "0x7BBC068EDC")]
		public AdvertDesc GetTurntableCDNRes(uint chestID)
		{
			return null;
		}

		// Token: 0x0600A226 RID: 41510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A226")]
		[Address(RVA = "0x1868F5C", Offset = "0x1868F5C", VA = "0x7BBC068F5C")]
		public AdvertDesc GetGachaCDNBgCDNRes(uint chestID)
		{
			return null;
		}

		// Token: 0x0600A227 RID: 41511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A227")]
		[Address(RVA = "0x1868FDC", Offset = "0x1868FDC", VA = "0x7BBC068FDC")]
		public AdvertDesc GetGachaTitleCDNBgRes(uint chestID)
		{
			return null;
		}

		// Token: 0x0600A228 RID: 41512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A228")]
		[Address(RVA = "0x186908C", Offset = "0x186908C", VA = "0x7BBC06908C")]
		public AdvertDesc GetLuckBagCDNRes(uint chestID)
		{
			return null;
		}

		// Token: 0x0600A229 RID: 41513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A229")]
		[Address(RVA = "0x1868780", Offset = "0x1868780", VA = "0x7BBC068780")]
		public void ProcessData(List<AdvertDesc> adList)
		{
		}

		// Token: 0x0600A22A RID: 41514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A22A")]
		[Address(RVA = "0x186910C", Offset = "0x186910C", VA = "0x7BBC06910C")]
		public GachaCDNAdData()
		{
		}

		// Token: 0x0400A895 RID: 43157
		[Token(Token = "0x400A895")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<uint, List<AdvertDesc>> m_GachaAdsDescDict;

		// Token: 0x0400A896 RID: 43158
		[Token(Token = "0x400A896")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, AdvertDesc> m_GachaTabADDict;

		// Token: 0x0400A897 RID: 43159
		[Token(Token = "0x400A897")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<uint, AdvertDesc> m_TurntableCDNDict;

		// Token: 0x0400A898 RID: 43160
		[Token(Token = "0x400A898")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<uint, AdvertDesc> m_LuckyBagCDNDict;

		// Token: 0x0400A899 RID: 43161
		[Token(Token = "0x400A899")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<uint, AdvertDesc> m_GachaCDNBgCDNDict;

		// Token: 0x0400A89A RID: 43162
		[Token(Token = "0x400A89A")]
		[FieldOffset(Offset = "0x38")]
		private Dictionary<uint, AdvertDesc> m_GachaTitleCDNDict;

		// Token: 0x02001D1C RID: 7452
		[Token(Token = "0x2001D1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FBB34", Offset = "0x10FBB34")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A22C RID: 41516 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A22C")]
			[Address(RVA = "0x1869270", Offset = "0x1869270", VA = "0x7BBC069270")]
			public <>c()
			{
			}

			// Token: 0x0600A22D RID: 41517 RVA: 0x0002A900 File Offset: 0x00028B00
			[Token(Token = "0x600A22D")]
			[Address(RVA = "0x1869278", Offset = "0x1869278", VA = "0x7BBC069278")]
			internal int <ProcessData>b__14_0(AdvertDesc a, AdvertDesc b)
			{
				return 0;
			}

			// Token: 0x0400A89B RID: 43163
			[Token(Token = "0x400A89B")]
			[FieldOffset(Offset = "0x0")]
			public static readonly GachaCDNAdData.<>c <>9;

			// Token: 0x0400A89C RID: 43164
			[Token(Token = "0x400A89C")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<AdvertDesc> <>9__14_0;
		}
	}
}
