using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using proto;
using tcp;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C47 RID: 7239
	[Token(Token = "0x2001C47")]
	public static class ItemUtil
	{
		// Token: 0x06009D5C RID: 40284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D5C")]
		[Address(RVA = "0x13F47F8", Offset = "0x13F47F8", VA = "0x7BBBBF47F8")]
		public static void SetQuantityString(UILabel m_Label, BaseItemInfo data, bool ShowExpireDayOnly = false)
		{
		}

		// Token: 0x06009D5D RID: 40285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009D5D")]
		[Address(RVA = "0x13F50A4", Offset = "0x13F50A4", VA = "0x7BBBBF50A4")]
		public static void SetQuantityString(UILabel time, UILabel num, BaseItemInfo data, bool ignoreOne = true)
		{
		}

		// Token: 0x06009D5E RID: 40286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D5E")]
		[Address(RVA = "0x13F4BCC", Offset = "0x13F4BCC", VA = "0x7BBBBF4BCC")]
		public static string GetExpireTimeString(uint expireTime, bool showExpireDayOnly = true, bool needAddOneDay = false)
		{
			return null;
		}

		// Token: 0x06009D5F RID: 40287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D5F")]
		[Address(RVA = "0x13F5708", Offset = "0x13F5708", VA = "0x7BBBBF5708")]
		public static string GetItemAvalibleTime(uint expireTime)
		{
			return null;
		}

		// Token: 0x06009D60 RID: 40288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D60")]
		[Address(RVA = "0x13F5B30", Offset = "0x13F5B30", VA = "0x7BBBBF5B30")]
		public static List<BaseItemInfo> GetBaseItemInfoListByTcpAward(AwardDataTCP award)
		{
			return null;
		}

		// Token: 0x06009D61 RID: 40289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D61")]
		[Address(RVA = "0x13F5D5C", Offset = "0x13F5D5C", VA = "0x7BBBBF5D5C")]
		public static List<BaseItemInfo> GetBaseItemInfoListByAward(AwardData a)
		{
			return null;
		}

		// Token: 0x06009D62 RID: 40290 RVA: 0x000292E0 File Offset: 0x000274E0
		[Token(Token = "0x6009D62")]
		[Address(RVA = "0x13F5FB4", Offset = "0x13F5FB4", VA = "0x7BBBBF5FB4")]
		public static bool IsBigAwardshow(uint itemid, bool isBundleItem = false)
		{
			return default(bool);
		}

		// Token: 0x06009D63 RID: 40291 RVA: 0x000292F8 File Offset: 0x000274F8
		[Token(Token = "0x6009D63")]
		[Address(RVA = "0x13F63DC", Offset = "0x13F63DC", VA = "0x7BBBBF63DC")]
		public static bool IsCommonFeatureShowItem(uint itemid)
		{
			return default(bool);
		}

		// Token: 0x06009D64 RID: 40292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D64")]
		[Address(RVA = "0x13F6624", Offset = "0x13F6624", VA = "0x7BBBBF6624")]
		public static List<CommonRewardItemInfo> MergeSameItemInfo(List<CommonRewardItemInfo> list)
		{
			return null;
		}

		// Token: 0x06009D65 RID: 40293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D65")]
		[Address(RVA = "0x13F6C24", Offset = "0x13F6C24", VA = "0x7BBBBF6C24")]
		public static string GetLabelColor(int type)
		{
			return null;
		}

		// Token: 0x06009D66 RID: 40294 RVA: 0x00029310 File Offset: 0x00027510
		[Token(Token = "0x6009D66")]
		[Address(RVA = "0x13F6C9C", Offset = "0x13F6C9C", VA = "0x7BBBBF6C9C")]
		public static Color GetColorByQuality(int q)
		{
			return default(Color);
		}

		// Token: 0x06009D67 RID: 40295 RVA: 0x00029328 File Offset: 0x00027528
		[Token(Token = "0x6009D67")]
		[Address(RVA = "0x13F6CA4", Offset = "0x13F6CA4", VA = "0x7BBBBF6CA4")]
		public static bool IsSightingTelescope(int itemID)
		{
			return default(bool);
		}

		// Token: 0x06009D68 RID: 40296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D68")]
		[Address(RVA = "0x13F6CC8", Offset = "0x13F6CC8", VA = "0x7BBBBF6CC8")]
		public static string GetItemDescription(proto.EInventory.AwardType awardType, uint itemID)
		{
			return null;
		}

		// Token: 0x06009D69 RID: 40297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009D69")]
		[Address(RVA = "0x13F6DC8", Offset = "0x13F6DC8", VA = "0x7BBBBF6DC8")]
		public static string SightScopeDisplayName(int itemID)
		{
			return null;
		}

		// Token: 0x06009D6A RID: 40298 RVA: 0x00029340 File Offset: 0x00027540
		[Token(Token = "0x6009D6A")]
		[Address(RVA = "0x13F4F8C", Offset = "0x13F4F8C", VA = "0x7BBBBF4F8C")]
		public static bool IsStackItem(BaseItemInfo data)
		{
			return default(bool);
		}

		// Token: 0x06009D6B RID: 40299 RVA: 0x00029358 File Offset: 0x00027558
		[Token(Token = "0x6009D6B")]
		[Address(RVA = "0x13F4A24", Offset = "0x13F4A24", VA = "0x7BBBBF4A24")]
		public static bool IsOnlyShowNumItem(BaseItemInfo data)
		{
			return default(bool);
		}

		// Token: 0x06009D6C RID: 40300 RVA: 0x00029370 File Offset: 0x00027570
		[Token(Token = "0x6009D6C")]
		[Address(RVA = "0x13F4AE8", Offset = "0x13F4AE8", VA = "0x7BBBBF4AE8")]
		public static bool IsShowNumAndHideTimeItem(BaseItemInfo data)
		{
			return default(bool);
		}

		// Token: 0x06009D6D RID: 40301 RVA: 0x00029388 File Offset: 0x00027588
		[Token(Token = "0x6009D6D")]
		[Address(RVA = "0x13F6E38", Offset = "0x13F6E38", VA = "0x7BBBBF6E38")]
		public static Color GetInGameShopItemRareColor(uint rare)
		{
			return default(Color);
		}

		// Token: 0x0400A36A RID: 41834
		[Token(Token = "0x400A36A")]
		public const int INVALID = 0;

		// Token: 0x0400A36B RID: 41835
		[Token(Token = "0x400A36B")]
		public const string GOLDRES = "Icon_Signin_Gold";

		// Token: 0x0400A36C RID: 41836
		[Token(Token = "0x400A36C")]
		public const string GOLDBIGRES = "Icon_Signin_Gold_big";

		// Token: 0x0400A36D RID: 41837
		[Token(Token = "0x400A36D")]
		public const string DIAMOND_RES = "Icon_Signin_Diamond";

		// Token: 0x0400A36E RID: 41838
		[Token(Token = "0x400A36E")]
		public const string DIAMOND_BIGRES = "Icon_Signin_Diamond_big";

		// Token: 0x0400A36F RID: 41839
		[Token(Token = "0x400A36F")]
		public const string SPECIAL_RES = "Icon_Signin_CBelite";

		// Token: 0x0400A370 RID: 41840
		[Token(Token = "0x400A370")]
		public const string SPECIAL_BIGRES = "Icon_Signin_CBelite_big";

		// Token: 0x0400A371 RID: 41841
		[Token(Token = "0x400A371")]
		public const string EXP_RES = "Icon_Exp";

		// Token: 0x0400A372 RID: 41842
		[Token(Token = "0x400A372")]
		public const string EXP_BIGRES = "Icon_Exp_big";

		// Token: 0x0400A373 RID: 41843
		[Token(Token = "0x400A373")]
		public const string GOLD_NAME = "TXT_CURRENCY_GOLD_TITLE";

		// Token: 0x0400A374 RID: 41844
		[Token(Token = "0x400A374")]
		public const string DIAMOND_NAME = "TXT_CURRENCY_DIAMOND_TITLE";

		// Token: 0x0400A375 RID: 41845
		[Token(Token = "0x400A375")]
		public const string SPECIAL_NAME = "TXT_ANNOUCEMENT_REWARD_SPECIAL";

		// Token: 0x0400A376 RID: 41846
		[Token(Token = "0x400A376")]
		public const string EXP_NAME = "TXT_EXP_TITLE";

		// Token: 0x0400A377 RID: 41847
		[Token(Token = "0x400A377")]
		public const string DIAMOND_DESC = "TXT_OB7_GXQ_CURRENCY_DIAMOND_DESC";

		// Token: 0x0400A378 RID: 41848
		[Token(Token = "0x400A378")]
		public const string GOLD_DESC = "TXT_OB7_GXQ_CURRENCY_GOLD_DESC";

		// Token: 0x0400A379 RID: 41849
		[Token(Token = "0x400A379")]
		public const string EXP_DESC = "TXT_OB7_GXQ_EXP_DESC";

		// Token: 0x0400A37A RID: 41850
		[Token(Token = "0x400A37A")]
		public const int SIGHT_HOLOGRAPHIC_ID = 533;

		// Token: 0x0400A37B RID: 41851
		[Token(Token = "0x400A37B")]
		public const int SIGHT_RED_DOT_ID = 532;

		// Token: 0x0400A37C RID: 41852
		[Token(Token = "0x400A37C")]
		public const int SIGHT_2_ID = 534;

		// Token: 0x0400A37D RID: 41853
		[Token(Token = "0x400A37D")]
		public const int SIGHT_4_ID = 535;

		// Token: 0x0400A37E RID: 41854
		[Token(Token = "0x400A37E")]
		public const int SIGHT_8_ID = 536;

		// Token: 0x02001C48 RID: 7240
		[Token(Token = "0x2001C48")]
		public enum ItemQualityType
		{
			// Token: 0x0400A380 RID: 41856
			[Token(Token = "0x400A380")]
			Grey = 1,
			// Token: 0x0400A381 RID: 41857
			[Token(Token = "0x400A381")]
			Green,
			// Token: 0x0400A382 RID: 41858
			[Token(Token = "0x400A382")]
			Blue,
			// Token: 0x0400A383 RID: 41859
			[Token(Token = "0x400A383")]
			Purple,
			// Token: 0x0400A384 RID: 41860
			[Token(Token = "0x400A384")]
			Orange,
			// Token: 0x0400A385 RID: 41861
			[Token(Token = "0x400A385")]
			Red = 7
		}
	}
}
