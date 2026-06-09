using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW
{
	// Token: 0x02001D23 RID: 7459
	[Token(Token = "0x2001D23")]
	public class UIDataModelGacha
	{
		// Token: 0x0600A280 RID: 41600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A280")]
		[Address(RVA = "0x1BAD9D8", Offset = "0x1BAD9D8", VA = "0x7BBC3AD9D8")]
		public UIDataModelGacha()
		{
		}

		// Token: 0x0600A281 RID: 41601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A281")]
		[Address(RVA = "0x1BADB34", Offset = "0x1BADB34", VA = "0x7BBC3ADB34")]
		public void ClearInfoData()
		{
		}

		// Token: 0x0600A282 RID: 41602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A282")]
		[Address(RVA = "0x1BADC00", Offset = "0x1BADC00", VA = "0x7BBC3ADC00")]
		public void ProcessSpecialDesc(ChestSpecialExchangeDesc desc)
		{
		}

		// Token: 0x0600A283 RID: 41603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A283")]
		[Address(RVA = "0x1BADD58", Offset = "0x1BADD58", VA = "0x7BBC3ADD58")]
		public void CacheGachaResult(uint chestID, UIModelGacha.GachaDrawType drawType, uint jackpotID, CSLotteryRes gachaResult)
		{
		}

		// Token: 0x0600A284 RID: 41604 RVA: 0x0002AA20 File Offset: 0x00028C20
		[Token(Token = "0x600A284")]
		[Address(RVA = "0x1BAE048", Offset = "0x1BAE048", VA = "0x7BBC3AE048")]
		public ELottery.Type GetGachaTypeByID(uint gachaID)
		{
			return ELottery.Type.Type_NORMAL;
		}

		// Token: 0x0600A285 RID: 41605 RVA: 0x0002AA38 File Offset: 0x00028C38
		[Token(Token = "0x600A285")]
		[Address(RVA = "0x1BAE0C8", Offset = "0x1BAE0C8", VA = "0x7BBC3AE0C8")]
		public bool IsEnergyGacha(uint gachaID)
		{
			return default(bool);
		}

		// Token: 0x0600A286 RID: 41606 RVA: 0x0002AA50 File Offset: 0x00028C50
		[Token(Token = "0x600A286")]
		[Address(RVA = "0x1BAE0E4", Offset = "0x1BAE0E4", VA = "0x7BBC3AE0E4")]
		public bool IsSpecialGachaData(ELottery.Type chestType)
		{
			return default(bool);
		}

		// Token: 0x0600A287 RID: 41607 RVA: 0x0002AA68 File Offset: 0x00028C68
		[Token(Token = "0x600A287")]
		[Address(RVA = "0x1BAE158", Offset = "0x1BAE158", VA = "0x7BBC3AE158")]
		public bool HasGachaDesc(uint gachaID)
		{
			return default(bool);
		}

		// Token: 0x0600A288 RID: 41608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A288")]
		[Address(RVA = "0x1BAE208", Offset = "0x1BAE208", VA = "0x7BBC3AE208")]
		public void ProcessGachaDescInfo(GachaDesc descInfo)
		{
		}

		// Token: 0x0600A289 RID: 41609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A289")]
		[Address(RVA = "0x1BADFC0", Offset = "0x1BADFC0", VA = "0x7BBC3ADFC0")]
		public GachaInfoDataBase GetGachaInfoByID(uint gachaID)
		{
			return null;
		}

		// Token: 0x0600A28A RID: 41610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A28A")]
		[Address(RVA = "0x1BAE474", Offset = "0x1BAE474", VA = "0x7BBC3AE474")]
		public void MarkGachaGachaType(uint gachaID, ELottery.Type gachaType)
		{
		}

		// Token: 0x0600A28B RID: 41611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A28B")]
		[Address(RVA = "0x1BAE4EC", Offset = "0x1BAE4EC", VA = "0x7BBC3AE4EC")]
		public ClientChestType GetClientChestTypeByID(uint gachaID)
		{
			return null;
		}

		// Token: 0x0400A8B4 RID: 43188
		[Token(Token = "0x400A8B4")]
		[FieldOffset(Offset = "0x0")]
		public static uint GACHA_MODEL_IDTYPE_MASK;

		// Token: 0x0400A8B5 RID: 43189
		[Token(Token = "0x400A8B5")]
		[FieldOffset(Offset = "0x10")]
		public GachaCDNAdData GachaCDNInfo;

		// Token: 0x0400A8B6 RID: 43190
		[Token(Token = "0x400A8B6")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<uint, GachaInfoDataBase> GachaAllInfoDic;

		// Token: 0x0400A8B7 RID: 43191
		[Token(Token = "0x400A8B7")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<uint, GachaPackageInfoData> GachaPackageInfoDic;

		// Token: 0x0400A8B8 RID: 43192
		[Token(Token = "0x400A8B8")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<uint, GachaSpecialInfoData> SpecialGachaInfoDic;

		// Token: 0x0400A8B9 RID: 43193
		[Token(Token = "0x400A8B9")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<uint, GachaSpDescData> GachaSpDescDic;

		// Token: 0x0400A8BA RID: 43194
		[Token(Token = "0x400A8BA")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<uint, GachaResultInfo> GachaResultInfoDic;

		// Token: 0x0400A8BB RID: 43195
		[Token(Token = "0x400A8BB")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<uint, ELottery.Type> m_AllGachaChestTypeDic;
	}
}
