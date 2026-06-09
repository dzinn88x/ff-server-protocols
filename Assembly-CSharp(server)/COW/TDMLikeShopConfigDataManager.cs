using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x02001191 RID: 4497
	[Token(Token = "0x2001191")]
	internal class TDMLikeShopConfigDataManager
	{
		// Token: 0x060045FE RID: 17918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045FE")]
		[Address(RVA = "0x1B41E90", Offset = "0x1B41E90", VA = "0x7BBC341E90")]
		public void LoadTDMLikeShopData()
		{
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045FF")]
		[Address(RVA = "0x1B422A0", Offset = "0x1B422A0", VA = "0x7BBC3422A0")]
		public void OnServerSyncTDMLikeShop(List<cRW{y\u0082B> tdmShopItems)
		{
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004600")]
		[Address(RVA = "0x1B42788", Offset = "0x1B42788", VA = "0x7BBC342788")]
		public List<uint> GetTDMShopFilterList()
		{
			return null;
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004601")]
		[Address(RVA = "0x1B42820", Offset = "0x1B42820", VA = "0x7BBC342820")]
		public TDMLikeShopConfigData GetTDMShopDataByIndex(uint index)
		{
			return null;
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x00015318 File Offset: 0x00013518
		[Token(Token = "0x6004602")]
		[Address(RVA = "0x1B428A0", Offset = "0x1B428A0", VA = "0x7BBC3428A0")]
		public uint GetMainItemDataIDByIndexId(uint indexId)
		{
			return 0U;
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004603")]
		[Address(RVA = "0x1B42B34", Offset = "0x1B42B34", VA = "0x7BBC342B34")]
		public List<TDMLikeShopConfigData> GetTDMShopItemListByFilter(uint filter)
		{
			return null;
		}

		// Token: 0x06004604 RID: 17924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004604")]
		[Address(RVA = "0x1B42BB4", Offset = "0x1B42BB4", VA = "0x7BBC342BB4")]
		public void OnCleanUp()
		{
		}

		// Token: 0x06004605 RID: 17925 RVA: 0x00015330 File Offset: 0x00013530
		[Token(Token = "0x6004605")]
		[Address(RVA = "0x1B42230", Offset = "0x1B42230", VA = "0x7BBC342230")]
		private ResourceID GetShopConfigRes()
		{
			return default(ResourceID);
		}

		// Token: 0x06004606 RID: 17926 RVA: 0x00015348 File Offset: 0x00013548
		[Token(Token = "0x6004606")]
		[Address(RVA = "0x1B42C14", Offset = "0x1B42C14", VA = "0x7BBC342C14")]
		public ResourceID GetTDMLikeConfigName(uint map_id, uint mode_id)
		{
			return default(ResourceID);
		}

		// Token: 0x06004607 RID: 17927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004607")]
		[Address(RVA = "0x1B42DD0", Offset = "0x1B42DD0", VA = "0x7BBC342DD0")]
		public TDMLikeShopConfigDataManager()
		{
		}

		// Token: 0x0400571B RID: 22299
		[Token(Token = "0x400571B")]
		[FieldOffset(Offset = "0x10")]
		private bool hasSyncWithServer;

		// Token: 0x0400571C RID: 22300
		[Token(Token = "0x400571C")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<uint, List<TDMLikeShopConfigData>> m_TDMLikeShopDataDic;

		// Token: 0x0400571D RID: 22301
		[Token(Token = "0x400571D")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<uint, TDMLikeShopConfigData> m_TDMLikeShopDataExpandDic;
	}
}
