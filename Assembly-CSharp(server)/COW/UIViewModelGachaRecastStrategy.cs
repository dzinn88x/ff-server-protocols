using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x0200181B RID: 6171
	[Token(Token = "0x200181B")]
	public class UIViewModelGachaRecastStrategy
	{
		// Token: 0x06007853 RID: 30803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007853")]
		[Address(RVA = "0x1683B78", Offset = "0x1683B78", VA = "0x7BBBE83B78")]
		public List<GachaPackageRewardInfo> GetPackageItemList()
		{
			return null;
		}

		// Token: 0x06007854 RID: 30804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007854")]
		[Address(RVA = "0x1683B80", Offset = "0x1683B80", VA = "0x7BBBE83B80")]
		public void UpdatePackageItemList()
		{
		}

		// Token: 0x06007855 RID: 30805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007855")]
		[Address(RVA = "0x1683B84", Offset = "0x1683B84", VA = "0x7BBBE83B84")]
		public void ClearPackageItemList()
		{
		}

		// Token: 0x06007856 RID: 30806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007856")]
		[Address(RVA = "0x1683BE4", Offset = "0x1683BE4", VA = "0x7BBBE83BE4")]
		private void SortPackageItemList()
		{
		}

		// Token: 0x06007857 RID: 30807 RVA: 0x00021300 File Offset: 0x0001F500
		[Token(Token = "0x6007857")]
		[Address(RVA = "0x1683BE8", Offset = "0x1683BE8", VA = "0x7BBBE83BE8")]
		private int CompareRewardLevel(GachaTokenRewardInfo a, GachaTokenRewardInfo b)
		{
			return 0;
		}

		// Token: 0x06007858 RID: 30808 RVA: 0x00021318 File Offset: 0x0001F518
		[Token(Token = "0x6007858")]
		[Address(RVA = "0x1683BF0", Offset = "0x1683BF0", VA = "0x7BBBE83BF0")]
		public uint GetCurrentTokensCount()
		{
			return 0U;
		}

		// Token: 0x06007859 RID: 30809 RVA: 0x00021330 File Offset: 0x0001F530
		[Token(Token = "0x6007859")]
		[Address(RVA = "0x1683BF8", Offset = "0x1683BF8", VA = "0x7BBBE83BF8")]
		public uint GetAllTokensCount()
		{
			return 0U;
		}

		// Token: 0x0600785A RID: 30810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600785A")]
		[Address(RVA = "0x1683C00", Offset = "0x1683C00", VA = "0x7BBBE83C00")]
		public List<GachaTokenRewardInfo> GetGachaTokenRewardInfos()
		{
			return null;
		}

		// Token: 0x0600785B RID: 30811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600785B")]
		[Address(RVA = "0x1683C64", Offset = "0x1683C64", VA = "0x7BBBE83C64")]
		public void UseItemsToPurchase(List<uint> items)
		{
		}

		// Token: 0x0600785C RID: 30812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600785C")]
		[Address(RVA = "0x1683C68", Offset = "0x1683C68", VA = "0x7BBBE83C68")]
		public List<uint> GetAllCanUseToPurchaseItems()
		{
			return null;
		}

		// Token: 0x0600785D RID: 30813 RVA: 0x00021348 File Offset: 0x0001F548
		[Token(Token = "0x600785D")]
		[Address(RVA = "0x1683CCC", Offset = "0x1683CCC", VA = "0x7BBBE83CCC")]
		public bool CheckTokenRewardState(uint rewardID)
		{
			return default(bool);
		}

		// Token: 0x0600785E RID: 30814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600785E")]
		[Address(RVA = "0x1683CD4", Offset = "0x1683CD4", VA = "0x7BBBE83CD4")]
		public UIViewModelGachaRecastStrategy()
		{
		}

		// Token: 0x04008E3F RID: 36415
		[Token(Token = "0x4008E3F")]
		[FieldOffset(Offset = "0x10")]
		private List<GachaPackageRewardInfo> m_GachaPackageRewardList;
	}
}
