using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x02001CB5 RID: 7349
	[Token(Token = "0x2001CB5")]
	public class BillboardLocalizationDataManager : SingletonModule<BillboardLocalizationDataManager>
	{
		// Token: 0x0600A054 RID: 41044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A054")]
		[Address(RVA = "0x14E3E30", Offset = "0x14E3E30", VA = "0x7BBBCE3E30", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600A055 RID: 41045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A055")]
		[Address(RVA = "0x14E4090", Offset = "0x14E4090", VA = "0x7BBBCE4090", Slot = "7")]
		protected override void OnCleanup()
		{
		}

		// Token: 0x0600A056 RID: 41046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A056")]
		[Address(RVA = "0x14E40F8", Offset = "0x14E40F8", VA = "0x7BBBCE40F8")]
		public BillboardLocalizationData FindLocDataByRegion(string region)
		{
			return null;
		}

		// Token: 0x0600A057 RID: 41047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A057")]
		[Address(RVA = "0x14E41C4", Offset = "0x14E41C4", VA = "0x7BBBCE41C4")]
		public BillboardLocalizationDataManager()
		{
		}

		// Token: 0x0400A735 RID: 42805
		[Token(Token = "0x400A735")]
		[FieldOffset(Offset = "0x0")]
		public static string RegionSettingKey;

		// Token: 0x0400A736 RID: 42806
		[Token(Token = "0x400A736")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, BillboardLocalizationData> m_BillboardLocalizationDict;
	}
}
