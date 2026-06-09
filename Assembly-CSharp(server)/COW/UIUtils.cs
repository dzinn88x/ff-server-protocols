using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C9B RID: 7323
	[Token(Token = "0x2001C9B")]
	internal static class UIUtils
	{
		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06009FC4 RID: 40900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A88")]
		public static string DefaultScreenshotFilePath
		{
			[Token(Token = "0x6009FC4")]
			[Address(RVA = "0x19FF2D4", Offset = "0x19FF2D4", VA = "0x7BBC1FF2D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06009FC5 RID: 40901 RVA: 0x00029C40 File Offset: 0x00027E40
		[Token(Token = "0x17000A89")]
		private static ResourceID DEFAULT_OPT_ATLASID
		{
			[Token(Token = "0x6009FC5")]
			[Address(RVA = "0x19FF354", Offset = "0x19FF354", VA = "0x7BBC1FF354")]
			get
			{
				return default(ResourceID);
			}
		}

		// Token: 0x06009FC6 RID: 40902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009FC6")]
		[Address(RVA = "0x19FF3A4", Offset = "0x19FF3A4", VA = "0x7BBC1FF3A4")]
		public static string WrapText(UILabel label, string value)
		{
			return null;
		}

		// Token: 0x06009FC7 RID: 40903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009FC7")]
		[Address(RVA = "0x19FF4BC", Offset = "0x19FF4BC", VA = "0x7BBC1FF4BC")]
		public static string SeparateDigit(int number, string cultureCode)
		{
			return null;
		}

		// Token: 0x06009FC8 RID: 40904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FC8")]
		[Address(RVA = "0x19FF644", Offset = "0x19FF644", VA = "0x7BBC1FF644")]
		public static void ResetAnimation(Animation animation, [Optional] string clipName)
		{
		}

		// Token: 0x06009FC9 RID: 40905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FC9")]
		[Address(RVA = "0x19FF8B4", Offset = "0x19FF8B4", VA = "0x7BBC1FF8B4")]
		public static void SkipAnimation(Animation animation, [Optional] string clipName)
		{
		}

		// Token: 0x06009FCA RID: 40906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FCA")]
		[Address(RVA = "0x19FFB24", Offset = "0x19FFB24", VA = "0x7BBC1FFB24")]
		public static void ResetAllAnimation(Animation animation)
		{
		}

		// Token: 0x06009FCB RID: 40907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009FCB")]
		[Address(RVA = "0x19FFEA8", Offset = "0x19FFEA8", VA = "0x7BBC1FFEA8")]
		public static string GetPlatformIcon(PlatformType platform)
		{
			return null;
		}

		// Token: 0x06009FCC RID: 40908 RVA: 0x00029C58 File Offset: 0x00027E58
		[Token(Token = "0x6009FCC")]
		[Address(RVA = "0x1A00004", Offset = "0x1A00004", VA = "0x7BBC200004")]
		public static bool AdjustSlotSpriteSize(UISprite InSprite, Vector2 InMargin)
		{
			return default(bool);
		}

		// Token: 0x06009FCD RID: 40909 RVA: 0x00029C70 File Offset: 0x00027E70
		[Token(Token = "0x6009FCD")]
		[Address(RVA = "0x1A00328", Offset = "0x1A00328", VA = "0x7BBC200328")]
		public static Color GetGradientLerpColorByRatio(int InMax, int InValue)
		{
			return default(Color);
		}

		// Token: 0x06009FCE RID: 40910 RVA: 0x00029C88 File Offset: 0x00027E88
		[Token(Token = "0x6009FCE")]
		[Address(RVA = "0x1A004B4", Offset = "0x1A004B4", VA = "0x7BBC2004B4")]
		public static Color GetColorByItemLevel(int level)
		{
			return default(Color);
		}

		// Token: 0x06009FCF RID: 40911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FCF")]
		[Address(RVA = "0x1A004F0", Offset = "0x1A004F0", VA = "0x7BBC2004F0")]
		public static void UpdateMarkColorByTeamIndex(UISprite icon, int teamIndex)
		{
		}

		// Token: 0x06009FD0 RID: 40912 RVA: 0x00029CA0 File Offset: 0x00027EA0
		[Token(Token = "0x6009FD0")]
		[Address(RVA = "0x1A0075C", Offset = "0x1A0075C", VA = "0x7BBC20075C")]
		public static Color GetMarkColorByTeamIndex(int teamIndex)
		{
			return default(Color);
		}

		// Token: 0x06009FD1 RID: 40913 RVA: 0x00029CB8 File Offset: 0x00027EB8
		[Token(Token = "0x6009FD1")]
		[Address(RVA = "0x1A008C4", Offset = "0x1A008C4", VA = "0x7BBC2008C4")]
		public static Color GetVehicleHPColor(float ratio)
		{
			return default(Color);
		}

		// Token: 0x06009FD2 RID: 40914 RVA: 0x00029CD0 File Offset: 0x00027ED0
		[Token(Token = "0x6009FD2")]
		[Address(RVA = "0x1A009B8", Offset = "0x1A009B8", VA = "0x7BBC2009B8")]
		public static Color GetHPColor(bool isDieing, float ratio)
		{
			return default(Color);
		}

		// Token: 0x06009FD3 RID: 40915 RVA: 0x00029CE8 File Offset: 0x00027EE8
		[Token(Token = "0x6009FD3")]
		[Address(RVA = "0x1A00B04", Offset = "0x1A00B04", VA = "0x7BBC200B04")]
		public static Color GetHPColor(Player player, float ratio)
		{
			return default(Color);
		}

		// Token: 0x06009FD4 RID: 40916 RVA: 0x00029D00 File Offset: 0x00027F00
		[Token(Token = "0x6009FD4")]
		[Address(RVA = "0x1A00C0C", Offset = "0x1A00C0C", VA = "0x7BBC200C0C")]
		public static Color GetEPColor(Player player, float ratio)
		{
			return default(Color);
		}

		// Token: 0x06009FD5 RID: 40917 RVA: 0x00029D18 File Offset: 0x00027F18
		[Token(Token = "0x6009FD5")]
		[Address(RVA = "0x1A00CE4", Offset = "0x1A00CE4", VA = "0x7BBC200CE4")]
		public static Color GetElitePassColor(bool isFirePass)
		{
			return default(Color);
		}

		// Token: 0x06009FD6 RID: 40918 RVA: 0x00029D30 File Offset: 0x00027F30
		[Token(Token = "0x6009FD6")]
		[Address(RVA = "0x1A00D68", Offset = "0x1A00D68", VA = "0x7BBC200D68")]
		public static bool BindAtlasSpriteByResourceID(ResourceID InResID, UISprite InSprite)
		{
			return default(bool);
		}

		// Token: 0x06009FD7 RID: 40919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FD7")]
		[Address(RVA = "0x1A0110C", Offset = "0x1A0110C", VA = "0x7BBC20110C")]
		public static void SetActive(GameObject go, bool state)
		{
		}

		// Token: 0x06009FD8 RID: 40920 RVA: 0x00029D48 File Offset: 0x00027F48
		[Token(Token = "0x6009FD8")]
		[Address(RVA = "0x1A011D4", Offset = "0x1A011D4", VA = "0x7BBC2011D4")]
		public static bool GetAtlasSpriteByResourceID(ResourceID InResID, out string OutStrSprite, out UIAtlas OutAtlas)
		{
			return default(bool);
		}

		// Token: 0x06009FD9 RID: 40921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009FD9")]
		[Address(RVA = "0x1A01548", Offset = "0x1A01548", VA = "0x7BBC201548")]
		public static string GetLevelSprite(int EquipmentLevel)
		{
			return null;
		}

		// Token: 0x06009FDA RID: 40922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FDA")]
		[Address(RVA = "0x19FDBF0", Offset = "0x19FDBF0", VA = "0x7BBC1FDBF0")]
		public static void SetSpriteName(UISprite sprite, ResourceID resourceID, UIUtils.SpriteScaleType scaleType = UIUtils.SpriteScaleType.Fit, bool makePixelPerfect = true)
		{
		}

		// Token: 0x06009FDB RID: 40923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FDB")]
		[Address(RVA = "0x1A01648", Offset = "0x1A01648", VA = "0x7BBC201648")]
		public static void SetSpriteItemIcon(UISprite targetSprite, Vector2 maxSize, ResourceID iconRes, bool enableEnlarge = false)
		{
		}

		// Token: 0x06009FDC RID: 40924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FDC")]
		[Address(RVA = "0x1A018E0", Offset = "0x1A018E0", VA = "0x7BBC2018E0")]
		public static void GetIconValidContentPixSize(UISprite targetSprite, Vector2 maxSize, bool enableEnlarge = false)
		{
		}

		// Token: 0x06009FDD RID: 40925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FDD")]
		[Address(RVA = "0x1A01A64", Offset = "0x1A01A64", VA = "0x7BBC201A64")]
		public static void SetSpriteItemIcon(UISprite targetSprite, Vector2 maxSize, ResourceID iconRes, UISprite Bg, Vector2 BgPending, bool BgFixedHeight = true)
		{
		}

		// Token: 0x06009FDE RID: 40926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FDE")]
		[Address(RVA = "0x1A01BA4", Offset = "0x1A01BA4", VA = "0x7BBC201BA4")]
		public static void UpdateWidgetColliderWithSpecialGameObject(BoxCollider box, GameObject go, bool considerInactive)
		{
		}

		// Token: 0x06009FDF RID: 40927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FDF")]
		[Address(RVA = "0x1A01FD8", Offset = "0x1A01FD8", VA = "0x7BBC201FD8")]
		public static void MoveScrollViewToBottom(UIScrollView scrollView)
		{
		}

		// Token: 0x06009FE0 RID: 40928 RVA: 0x00029D60 File Offset: 0x00027F60
		[Token(Token = "0x6009FE0")]
		public static bool IsSameList<T>(List<T> list_a, List<T> list_b)
		{
			return default(bool);
		}

		// Token: 0x06009FE1 RID: 40929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FE1")]
		[Address(RVA = "0x1A021F0", Offset = "0x1A021F0", VA = "0x7BBC2021F0")]
		public static void SaveScreenshot(string filePath, UIUtils.OnSavedScreenshot saved, bool needRotationResultPic)
		{
		}

		// Token: 0x06009FE2 RID: 40930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009FE2")]
		[Address(RVA = "0x1A02A5C", Offset = "0x1A02A5C", VA = "0x7BBC202A5C")]
		private static Texture2D RotationTexture(Texture2D originalTexture, bool clockwise = true)
		{
			return null;
		}

		// Token: 0x06009FE3 RID: 40931 RVA: 0x00029D78 File Offset: 0x00027F78
		[Token(Token = "0x6009FE3")]
		[Address(RVA = "0x1A02C90", Offset = "0x1A02C90", VA = "0x7BBC202C90")]
		public static bool SaveImageToFile(Texture2D image, string filePath)
		{
			return default(bool);
		}

		// Token: 0x06009FE4 RID: 40932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FE4")]
		[Address(RVA = "0x1A02E2C", Offset = "0x1A02E2C", VA = "0x7BBC202E2C")]
		private static void OnRenderedScreenshot()
		{
		}

		// Token: 0x06009FE5 RID: 40933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FE5")]
		[Address(RVA = "0x1A02EE0", Offset = "0x1A02EE0", VA = "0x7BBC202EE0")]
		private static void OnCameraRenderedScreenshot(UIUtils.ScreenshotRenderHandler handler)
		{
		}

		// Token: 0x06009FE6 RID: 40934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FE6")]
		[Address(RVA = "0x1A0236C", Offset = "0x1A0236C", VA = "0x7BBC20236C")]
		public static void RenderScreenshot(RenderTexture screenshot, Action done)
		{
		}

		// Token: 0x06009FE7 RID: 40935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009FE7")]
		[Address(RVA = "0x1A02FFC", Offset = "0x1A02FFC", VA = "0x7BBC202FFC")]
		public static List<string> GenerateProbabilityString(List<RareProbability> probabilityList)
		{
			return null;
		}

		// Token: 0x06009FE8 RID: 40936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009FE8")]
		[Address(RVA = "0x1A035F4", Offset = "0x1A035F4", VA = "0x7BBC2035F4")]
		public static string ItemLimitTimeFormat(uint deltaTime)
		{
			return null;
		}

		// Token: 0x06009FE9 RID: 40937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FE9")]
		[Address(RVA = "0x1A03850", Offset = "0x1A03850", VA = "0x7BBC203850")]
		public static void CalFullScreenSize(out float width, out float height)
		{
		}

		// Token: 0x06009FEA RID: 40938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FEA")]
		[Address(RVA = "0x1A03968", Offset = "0x1A03968", VA = "0x7BBC203968")]
		public static void SetCSFactionName(bool isTeamA, UILabel label)
		{
		}

		// Token: 0x06009FEB RID: 40939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FEB")]
		[Address(RVA = "0x1A03A58", Offset = "0x1A03A58", VA = "0x7BBC203A58")]
		public static void SetCSFactionIntroduction(bool isTeamA, UILabel label)
		{
		}

		// Token: 0x06009FEC RID: 40940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FEC")]
		[Address(RVA = "0x1A03B48", Offset = "0x1A03B48", VA = "0x7BBC203B48")]
		public static void SetCSFactionIcon(bool isTeamA, UISprite sprite)
		{
		}

		// Token: 0x06009FED RID: 40941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009FED")]
		[Address(RVA = "0x1A03C0C", Offset = "0x1A03C0C", VA = "0x7BBC203C0C")]
		public static string CSFactionIcon(bool isTeamA)
		{
			return null;
		}

		// Token: 0x06009FEE RID: 40942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FEE")]
		[Address(RVA = "0x1A03C68", Offset = "0x1A03C68", VA = "0x7BBC203C68")]
		public static void SetFactionIcon(bool attack, UISprite sprite)
		{
		}

		// Token: 0x06009FEF RID: 40943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009FEF")]
		[Address(RVA = "0x1A03D2C", Offset = "0x1A03D2C", VA = "0x7BBC203D2C")]
		public static string FactionIcon(bool attack)
		{
			return null;
		}

		// Token: 0x06009FF0 RID: 40944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FF0")]
		[Address(RVA = "0x1A03D88", Offset = "0x1A03D88", VA = "0x7BBC203D88")]
		public static void SetFactionDescription(bool isAttack, UILabel label)
		{
		}

		// Token: 0x06009FF1 RID: 40945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FF1")]
		[Address(RVA = "0x1A03E78", Offset = "0x1A03E78", VA = "0x7BBC203E78")]
		public static void FilterInput(UIInput input)
		{
		}

		// Token: 0x06009FF2 RID: 40946 RVA: 0x00029D90 File Offset: 0x00027F90
		[Token(Token = "0x6009FF2")]
		[Address(RVA = "0x1A03F74", Offset = "0x1A03F74", VA = "0x7BBC203F74")]
		public static bool CheckNeedChangeIcon(CSSharedItemData itemdata, out ResourceID resid, out bool isGemOrCoin)
		{
			return default(bool);
		}

		// Token: 0x06009FF3 RID: 40947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FF3")]
		[Address(RVA = "0x1A043BC", Offset = "0x1A043BC", VA = "0x7BBC2043BC")]
		public static void ChangeIcon(UISprite boxIcon, UIAtlas atlas, string name, Vector3 pos, bool isGemOrCoin)
		{
		}

		// Token: 0x06009FF4 RID: 40948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FF4")]
		[Address(RVA = "0x1A0463C", Offset = "0x1A0463C", VA = "0x7BBC20463C")]
		private static void SetComposeIcon(UISprite boxIcon, UISprite sprite, Vector3 pos, bool isGemOrCoin)
		{
		}

		// Token: 0x06009FF5 RID: 40949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FF5")]
		[Address(RVA = "0x1A04A1C", Offset = "0x1A04A1C", VA = "0x7BBC204A1C")]
		public static void SetQualityBG(int Quality, UISprite QualityBG, UISprite QualityNameBG01)
		{
		}

		// Token: 0x06009FF6 RID: 40950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FF6")]
		[Address(RVA = "0x1A04BFC", Offset = "0x1A04BFC", VA = "0x7BBC204BFC")]
		public static void SetQualityBG2(int Quality, UISprite QualityBG, UISprite QualityNameBG01)
		{
		}

		// Token: 0x06009FF7 RID: 40951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FF7")]
		[Address(RVA = "0x1A04DDC", Offset = "0x1A04DDC", VA = "0x7BBC204DDC")]
		public static void SetWeaponQualityBG(int Quality, UISprite QualityBG, UISprite QualityNameBG01)
		{
		}

		// Token: 0x06009FF8 RID: 40952 RVA: 0x00029DA8 File Offset: 0x00027FA8
		[Token(Token = "0x6009FF8")]
		[Address(RVA = "0x1A04FBC", Offset = "0x1A04FBC", VA = "0x7BBC204FBC")]
		public static bool CheckNicknameValid(string name)
		{
			return default(bool);
		}

		// Token: 0x06009FF9 RID: 40953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009FF9")]
		[Address(RVA = "0x1A05414", Offset = "0x1A05414", VA = "0x7BBC205414")]
		public static GameObject LoadRes(ResourceID res_id)
		{
			return null;
		}

		// Token: 0x06009FFA RID: 40954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009FFA")]
		[Address(RVA = "0x1A05580", Offset = "0x1A05580", VA = "0x7BBC205580")]
		public static LoadingPictResource FindLoadingBgRes(uint mapID, uint groupMode, uint matchMode, uint GameMode)
		{
			return null;
		}

		// Token: 0x06009FFB RID: 40955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FFB")]
		[Address(RVA = "0x1A056A0", Offset = "0x1A056A0", VA = "0x7BBC2056A0")]
		public static void AdjustIPXAnchor(Transform modifiedUI)
		{
		}

		// Token: 0x06009FFC RID: 40956 RVA: 0x00029DC0 File Offset: 0x00027FC0
		[Token(Token = "0x6009FFC")]
		[Address(RVA = "0x1A05B74", Offset = "0x1A05B74", VA = "0x7BBC205B74")]
		public static int GetAdjustedAnchor(int oldAnchor, float defRatio, float ipxRatio)
		{
			return 0;
		}

		// Token: 0x06009FFD RID: 40957 RVA: 0x00029DD8 File Offset: 0x00027FD8
		[Token(Token = "0x6009FFD")]
		[Address(RVA = "0x1A05C0C", Offset = "0x1A05C0C", VA = "0x7BBC205C0C")]
		public static float GetProgressValueByNonAverageMilepostValue(List<float> Mileposts, float curValue)
		{
			return 0f;
		}

		// Token: 0x06009FFE RID: 40958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009FFE")]
		[Address(RVA = "0x1A05FB4", Offset = "0x1A05FB4", VA = "0x7BBC205FB4")]
		public static void SetSpriteByNum(int num, UISprite[] sprites, string spriteNamePrefix)
		{
		}

		// Token: 0x06009FFF RID: 40959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009FFF")]
		[Address(RVA = "0x1A061BC", Offset = "0x1A061BC", VA = "0x7BBC2061BC")]
		public static string FormatBigNum(string num, int digit = 3, string sign = ",")
		{
			return null;
		}

		// Token: 0x0600A000 RID: 40960 RVA: 0x00029DF0 File Offset: 0x00027FF0
		[Token(Token = "0x600A000")]
		[Address(RVA = "0x1A06650", Offset = "0x1A06650", VA = "0x7BBC206650")]
		public static bool IsIphoneXDevice()
		{
			return default(bool);
		}

		// Token: 0x0600A001 RID: 40961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A001")]
		[Address(RVA = "0x1A06658", Offset = "0x1A06658", VA = "0x7BBC206658")]
		public static void InitNGUINotchSetting(bool reset = false)
		{
		}

		// Token: 0x0400A67E RID: 42622
		[Token(Token = "0x400A67E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string PlatformIcon_Guest;

		// Token: 0x0400A67F RID: 42623
		[Token(Token = "0x400A67F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string PlatformIcon_HW;

		// Token: 0x0400A680 RID: 42624
		[Token(Token = "0x400A680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string PlatformIcon_VK;

		// Token: 0x0400A681 RID: 42625
		[Token(Token = "0x400A681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string PlatformIcon_FB;

		// Token: 0x0400A682 RID: 42626
		[Token(Token = "0x400A682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string PlatformIcon_Google;

		// Token: 0x0400A683 RID: 42627
		[Token(Token = "0x400A683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] LevelSpirteNameArray;

		// Token: 0x0400A684 RID: 42628
		[Token(Token = "0x400A684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] ProfileTagLevel;

		// Token: 0x0400A685 RID: 42629
		[Token(Token = "0x400A685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] ProfileActiveTime;

		// Token: 0x0400A686 RID: 42630
		[Token(Token = "0x400A686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] ProfileOnlineTime;

		// Token: 0x0400A687 RID: 42631
		[Token(Token = "0x400A687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] ProfileModePrefer;

		// Token: 0x0400A688 RID: 42632
		[Token(Token = "0x400A688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] ProfileSex;

		// Token: 0x0400A689 RID: 42633
		[Token(Token = "0x400A689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] ProfileModes;

		// Token: 0x0400A68A RID: 42634
		[Token(Token = "0x400A68A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static Rect SCREEN_MARGIN_RATIO;

		// Token: 0x0400A68B RID: 42635
		[Token(Token = "0x400A68B")]
		private const string SCREENSHOT_FILE_NAME = "Free Fire Screenshot.png";

		// Token: 0x0400A68C RID: 42636
		[Token(Token = "0x400A68C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static float MAP_WIDTH;

		// Token: 0x0400A68D RID: 42637
		[Token(Token = "0x400A68D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string CLICK_FILTER_MAP;

		// Token: 0x0400A68E RID: 42638
		[Token(Token = "0x400A68E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string CLICK_FILTER_GROUP;

		// Token: 0x0400A68F RID: 42639
		[Token(Token = "0x400A68F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string CLICK_FILTER_PVE_MAP;

		// Token: 0x0400A690 RID: 42640
		[Token(Token = "0x400A690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static string CLICK_FILTER_TEAM;

		// Token: 0x0400A691 RID: 42641
		[Token(Token = "0x400A691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static string CLICK_FILTER_GIFTRECEIVERLIST;

		// Token: 0x0400A692 RID: 42642
		[Token(Token = "0x400A692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static string CLICK_FILTER_TUTORIAL;

		// Token: 0x0400A693 RID: 42643
		[Token(Token = "0x400A693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static string CLICK_FILTER_VOUCHERLIST;

		// Token: 0x0400A694 RID: 42644
		[Token(Token = "0x400A694")]
		public const float PERFECT_PROPROTION_TO_ICONBOXWIDTH = 1f;

		// Token: 0x0400A695 RID: 42645
		[Token(Token = "0x400A695")]
		public const float PERFECT_PROPROTION_TO_ICONBOXHEIGHT = 0.5f;

		// Token: 0x0400A696 RID: 42646
		[Token(Token = "0x400A696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static string HINDI_CULTURE_CODE;

		// Token: 0x0400A697 RID: 42647
		[Token(Token = "0x400A697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static int[] HINDI_NUMBER_GROUP_SIZE;

		// Token: 0x0400A698 RID: 42648
		[Token(Token = "0x400A698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static readonly Color[] MARKCOLOR;

		// Token: 0x0400A699 RID: 42649
		[Token(Token = "0x400A699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static readonly Color HP_COLOR_NORMAL;

		// Token: 0x0400A69A RID: 42650
		[Token(Token = "0x400A69A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static readonly Color HP_COLOR_WARNING;

		// Token: 0x0400A69B RID: 42651
		[Token(Token = "0x400A69B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static readonly Color HP_COLOR_DANGER;

		// Token: 0x0400A69C RID: 42652
		[Token(Token = "0x400A69C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static readonly Color HP_COLOR_KNOCK_DOWN;

		// Token: 0x0400A69D RID: 42653
		[Token(Token = "0x400A69D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static readonly Color HP_COLOR_WARNING_VEHICLE;

		// Token: 0x0400A69E RID: 42654
		[Token(Token = "0x400A69E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static readonly Color HP_COLOR_DANGER_VEHICLE;

		// Token: 0x0400A69F RID: 42655
		[Token(Token = "0x400A69F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static readonly Color EP_COLOR_NORMAL;

		// Token: 0x0400A6A0 RID: 42656
		[Token(Token = "0x400A6A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static readonly Color EP_COLOR_DISABLE;

		// Token: 0x0400A6A1 RID: 42657
		[Token(Token = "0x400A6A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public static readonly Color ITEM_COLOR_NEW;

		// Token: 0x0400A6A2 RID: 42658
		[Token(Token = "0x400A6A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public static readonly Color ITEM_COLOR_DISCOUNT;

		// Token: 0x0400A6A3 RID: 42659
		[Token(Token = "0x400A6A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public static readonly Color ITEM_COLOR_LIMIT;

		// Token: 0x0400A6A4 RID: 42660
		[Token(Token = "0x400A6A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public static readonly Color ITEM_COLOR_HOT;

		// Token: 0x0400A6A5 RID: 42661
		[Token(Token = "0x400A6A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public static readonly Color ITEM_COLOR_EXPIRE;

		// Token: 0x0400A6A6 RID: 42662
		[Token(Token = "0x400A6A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public static readonly Color ITEM_COLOR_PREVIEW;

		// Token: 0x0400A6A7 RID: 42663
		[Token(Token = "0x400A6A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public static readonly Color ITEM_COLOR_GRENADE_CHOOSE;

		// Token: 0x0400A6A8 RID: 42664
		[Token(Token = "0x400A6A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public static readonly Color ITEM_COLOR_GRENADE_COMMON;

		// Token: 0x0400A6A9 RID: 42665
		[Token(Token = "0x400A6A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public static readonly Color ITEM_COLOR_LOADOUT_CHARGE;

		// Token: 0x0400A6AA RID: 42666
		[Token(Token = "0x400A6AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static Action _OnRenderedScreenshot;

		// Token: 0x0400A6AB RID: 42667
		[Token(Token = "0x400A6AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static int _ScreenshotWaitingCameras;

		// Token: 0x0400A6AC RID: 42668
		[Token(Token = "0x400A6AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public static readonly uint[] BIG_LADDER_IDS;

		// Token: 0x0400A6AD RID: 42669
		[Token(Token = "0x400A6AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public static readonly uint[] BIG_CS_LADDER_IDS;

		// Token: 0x02001C9C RID: 7324
		[Token(Token = "0x2001C9C")]
		public enum SpriteScaleType
		{
			// Token: 0x0400A6AF RID: 42671
			[Token(Token = "0x400A6AF")]
			WidthFixed,
			// Token: 0x0400A6B0 RID: 42672
			[Token(Token = "0x400A6B0")]
			HeightFixed,
			// Token: 0x0400A6B1 RID: 42673
			[Token(Token = "0x400A6B1")]
			Fit,
			// Token: 0x0400A6B2 RID: 42674
			[Token(Token = "0x400A6B2")]
			BestFillBoarder
		}

		// Token: 0x02001C9D RID: 7325
		[Token(Token = "0x2001C9D")]
		public enum ScreenshotType
		{
			// Token: 0x0400A6B4 RID: 42676
			[Token(Token = "0x400A6B4")]
			None,
			// Token: 0x0400A6B5 RID: 42677
			[Token(Token = "0x400A6B5")]
			PlayerProfile,
			// Token: 0x0400A6B6 RID: 42678
			[Token(Token = "0x400A6B6")]
			GameHistory,
			// Token: 0x0400A6B7 RID: 42679
			[Token(Token = "0x400A6B7")]
			GachaReward,
			// Token: 0x0400A6B8 RID: 42680
			[Token(Token = "0x400A6B8")]
			GachaLuckyBag,
			// Token: 0x0400A6B9 RID: 42681
			[Token(Token = "0x400A6B9")]
			GainItem,
			// Token: 0x0400A6BA RID: 42682
			[Token(Token = "0x400A6BA")]
			LeaderBoard,
			// Token: 0x0400A6BB RID: 42683
			[Token(Token = "0x400A6BB")]
			RankLobby,
			// Token: 0x0400A6BC RID: 42684
			[Token(Token = "0x400A6BC")]
			RankSeasonInfo,
			// Token: 0x0400A6BD RID: 42685
			[Token(Token = "0x400A6BD")]
			PreviewCG,
			// Token: 0x0400A6BE RID: 42686
			[Token(Token = "0x400A6BE")]
			Pet,
			// Token: 0x0400A6BF RID: 42687
			[Token(Token = "0x400A6BF")]
			IAPBundle,
			// Token: 0x0400A6C0 RID: 42688
			[Token(Token = "0x400A6C0")]
			Manual,
			// Token: 0x0400A6C1 RID: 42689
			[Token(Token = "0x400A6C1")]
			ChampionshipStats,
			// Token: 0x0400A6C2 RID: 42690
			[Token(Token = "0x400A6C2")]
			ElitePassShare,
			// Token: 0x0400A6C3 RID: 42691
			[Token(Token = "0x400A6C3")]
			RankComparison,
			// Token: 0x0400A6C4 RID: 42692
			[Token(Token = "0x400A6C4")]
			MatchResult,
			// Token: 0x0400A6C5 RID: 42693
			[Token(Token = "0x400A6C5")]
			ThreeYearFestival,
			// Token: 0x0400A6C6 RID: 42694
			[Token(Token = "0x400A6C6")]
			MysteryMall,
			// Token: 0x0400A6C7 RID: 42695
			[Token(Token = "0x400A6C7")]
			WeaponSkinMain,
			// Token: 0x0400A6C8 RID: 42696
			[Token(Token = "0x400A6C8")]
			WeaponSkinUpgrader,
			// Token: 0x0400A6C9 RID: 42697
			[Token(Token = "0x400A6C9")]
			Bounty,
			// Token: 0x0400A6CA RID: 42698
			[Token(Token = "0x400A6CA")]
			IngamePhotograph,
			// Token: 0x0400A6CB RID: 42699
			[Token(Token = "0x400A6CB")]
			PortraitCloseup,
			// Token: 0x0400A6CC RID: 42700
			[Token(Token = "0x400A6CC")]
			FriendGraph,
			// Token: 0x0400A6CD RID: 42701
			[Token(Token = "0x400A6CD")]
			HDYard,
			// Token: 0x0400A6CE RID: 42702
			[Token(Token = "0x400A6CE")]
			BR_MVP_Show,
			// Token: 0x0400A6CF RID: 42703
			[Token(Token = "0x400A6CF")]
			CS_MVP_Show,
			// Token: 0x0400A6D0 RID: 42704
			[Token(Token = "0x400A6D0")]
			SplashBannerLiveTv
		}

		// Token: 0x02001C9E RID: 7326
		[Token(Token = "0x2001C9E")]
		public enum ShareUrlType
		{
			// Token: 0x0400A6D2 RID: 42706
			[Token(Token = "0x400A6D2")]
			None = 1000,
			// Token: 0x0400A6D3 RID: 42707
			[Token(Token = "0x400A6D3")]
			InviteFriend,
			// Token: 0x0400A6D4 RID: 42708
			[Token(Token = "0x400A6D4")]
			InviteToGroup,
			// Token: 0x0400A6D5 RID: 42709
			[Token(Token = "0x400A6D5")]
			FriendCallback,
			// Token: 0x0400A6D6 RID: 42710
			[Token(Token = "0x400A6D6")]
			InviteToClan = 1005,
			// Token: 0x0400A6D7 RID: 42711
			[Token(Token = "0x400A6D7")]
			InviteToRoom,
			// Token: 0x0400A6D8 RID: 42712
			[Token(Token = "0x400A6D8")]
			GoliathInvite,
			// Token: 0x0400A6D9 RID: 42713
			[Token(Token = "0x400A6D9")]
			SuperCarInvite
		}

		// Token: 0x02001C9F RID: 7327
		[Token(Token = "0x2001C9F")]
		public enum EShareScreenType
		{
			// Token: 0x0400A6DB RID: 42715
			[Token(Token = "0x400A6DB")]
			LandScape,
			// Token: 0x0400A6DC RID: 42716
			[Token(Token = "0x400A6DC")]
			Portrait
		}

		// Token: 0x02001CA0 RID: 7328
		// (Invoke) Token: 0x0600A004 RID: 40964
		[Token(Token = "0x2001CA0")]
		public delegate void OnSavedScreenshot(bool result);

		// Token: 0x02001CA1 RID: 7329
		[Token(Token = "0x2001CA1")]
		private class ScreenshotRenderHandler : MonoBehaviour
		{
			// Token: 0x0600A007 RID: 40967 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A007")]
			[Address(RVA = "0x1A08190", Offset = "0x1A08190", VA = "0x7BBC208190")]
			private void OnPostRender()
			{
			}

			// Token: 0x0600A008 RID: 40968 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A008")]
			[Address(RVA = "0x1A08960", Offset = "0x1A08960", VA = "0x7BBC208960")]
			public ScreenshotRenderHandler()
			{
			}

			// Token: 0x0400A6DD RID: 42717
			[Token(Token = "0x400A6DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public UIUtils.ScreenshotRenderHandler.RenderedCallback OnRendered;

			// Token: 0x0400A6DE RID: 42718
			[Token(Token = "0x400A6DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool AllowHDR;

			// Token: 0x02001CA2 RID: 7330
			// (Invoke) Token: 0x0600A00A RID: 40970
			[Token(Token = "0x2001CA2")]
			public delegate void RenderedCallback(UIUtils.ScreenshotRenderHandler handler);
		}

		// Token: 0x02001CA3 RID: 7331
		[Token(Token = "0x2001CA3")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB914", Offset = "0x10FB914")]
		private sealed class <>c__DisplayClass80_0
		{
			// Token: 0x0600A00D RID: 40973 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A00D")]
			[Address(RVA = "0x1A02364", Offset = "0x1A02364", VA = "0x7BBC202364")]
			public <>c__DisplayClass80_0()
			{
			}

			// Token: 0x0600A00E RID: 40974 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A00E")]
			[Address(RVA = "0x1A079FC", Offset = "0x1A079FC", VA = "0x7BBC2079FC")]
			internal void <SaveScreenshot>b__0()
			{
			}

			// Token: 0x0400A6DF RID: 42719
			[Token(Token = "0x400A6DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RenderTexture renderTexture;

			// Token: 0x0400A6E0 RID: 42720
			[Token(Token = "0x400A6E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool needRotationResultPic;

			// Token: 0x0400A6E1 RID: 42721
			[Token(Token = "0x400A6E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string filePath;

			// Token: 0x0400A6E2 RID: 42722
			[Token(Token = "0x400A6E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UIUtils.OnSavedScreenshot saved;
		}

		// Token: 0x02001CA4 RID: 7332
		[Token(Token = "0x2001CA4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FB924", Offset = "0x10FB924")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600A010 RID: 40976 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A010")]
			[Address(RVA = "0x1A077A0", Offset = "0x1A077A0", VA = "0x7BBC2077A0")]
			public <>c()
			{
			}

			// Token: 0x0600A011 RID: 40977 RVA: 0x00029E08 File Offset: 0x00028008
			[Token(Token = "0x600A011")]
			[Address(RVA = "0x1A077A8", Offset = "0x1A077A8", VA = "0x7BBC2077A8")]
			internal bool <RenderScreenshot>b__88_0(Camera camera)
			{
				return default(bool);
			}

			// Token: 0x0600A012 RID: 40978 RVA: 0x00029E20 File Offset: 0x00028020
			[Token(Token = "0x600A012")]
			[Address(RVA = "0x1A07894", Offset = "0x1A07894", VA = "0x7BBC207894")]
			internal int <RenderScreenshot>b__88_1(Camera a, Camera b)
			{
				return 0;
			}

			// Token: 0x0600A013 RID: 40979 RVA: 0x00029E38 File Offset: 0x00028038
			[Token(Token = "0x600A013")]
			[Address(RVA = "0x1A07948", Offset = "0x1A07948", VA = "0x7BBC207948")]
			internal bool <GenerateProbabilityString>b__89_0(RareProbability item)
			{
				return default(bool);
			}

			// Token: 0x0600A014 RID: 40980 RVA: 0x00029E50 File Offset: 0x00028050
			[Token(Token = "0x600A014")]
			[Address(RVA = "0x1A0797C", Offset = "0x1A0797C", VA = "0x7BBC20797C")]
			internal int <GenerateProbabilityString>b__89_1(RareProbability itemA, RareProbability itemB)
			{
				return 0;
			}

			// Token: 0x0600A015 RID: 40981 RVA: 0x00029E68 File Offset: 0x00028068
			[Token(Token = "0x600A015")]
			[Address(RVA = "0x1A079F8", Offset = "0x1A079F8", VA = "0x7BBC2079F8")]
			internal float <GetProgressValueByNonAverageMilepostValue>b__111_0(float u)
			{
				return 0f;
			}

			// Token: 0x0400A6E3 RID: 42723
			[Token(Token = "0x400A6E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly UIUtils.<>c <>9;

			// Token: 0x0400A6E4 RID: 42724
			[Token(Token = "0x400A6E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<Camera> <>9__88_0;

			// Token: 0x0400A6E5 RID: 42725
			[Token(Token = "0x400A6E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Comparison<Camera> <>9__88_1;

			// Token: 0x0400A6E6 RID: 42726
			[Token(Token = "0x400A6E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Predicate<RareProbability> <>9__89_0;

			// Token: 0x0400A6E7 RID: 42727
			[Token(Token = "0x400A6E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Comparison<RareProbability> <>9__89_1;

			// Token: 0x0400A6E8 RID: 42728
			[Token(Token = "0x400A6E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<float, float> <>9__111_0;
		}
	}
}
