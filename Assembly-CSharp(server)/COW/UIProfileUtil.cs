using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using UnityEngine;

namespace COW
{
	// Token: 0x02001C64 RID: 7268
	[Token(Token = "0x2001C64")]
	public static class UIProfileUtil
	{
		// Token: 0x06009E61 RID: 40545 RVA: 0x000296B8 File Offset: 0x000278B8
		[Token(Token = "0x6009E61")]
		[Address(RVA = "0x1FF38E4", Offset = "0x1FF38E4", VA = "0x7BBC7F38E4")]
		public static int ComparePresence(EPresence.AccountPresence a, EPresence.AccountPresence b)
		{
			return 0;
		}

		// Token: 0x06009E62 RID: 40546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009E62")]
		[Address(RVA = "0x1FF3A60", Offset = "0x1FF3A60", VA = "0x7BBC7F3A60")]
		public static string GetPlatformIconByType(AccountExternalPlatform platform)
		{
			return null;
		}

		// Token: 0x06009E63 RID: 40547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009E63")]
		[Address(RVA = "0x1FF3AF0", Offset = "0x1FF3AF0", VA = "0x7BBC7F3AF0")]
		public static string GetGenderSprite(bool isFemale)
		{
			return null;
		}

		// Token: 0x06009E64 RID: 40548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E64")]
		[Address(RVA = "0x1FE33D0", Offset = "0x1FE33D0", VA = "0x7BBC7E33D0")]
		public static void SetHeadPic(UISprite m_HeadIcon, uint iid)
		{
		}

		// Token: 0x06009E65 RID: 40549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E65")]
		[Address(RVA = "0x1FF3B40", Offset = "0x1FF3B40", VA = "0x7BBC7F3B40")]
		public static void SetHeadPic(UISprite m_HeadIcon, HeadPicData data)
		{
		}

		// Token: 0x06009E66 RID: 40550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E66")]
		[Address(RVA = "0x1FF3D74", Offset = "0x1FF3D74", VA = "0x7BBC7F3D74")]
		public static void SetPinPic(UISprite pinIcon, uint pinId, bool isBigIcon)
		{
		}

		// Token: 0x06009E67 RID: 40551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E67")]
		[Address(RVA = "0x1FE3498", Offset = "0x1FE3498", VA = "0x7BBC7E3498")]
		public static void SetBannerWithResourceID(UISprite m_Banner, BannerData data, bool isBrief = false)
		{
		}

		// Token: 0x06009E68 RID: 40552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E68")]
		[Address(RVA = "0x1FF3E70", Offset = "0x1FF3E70", VA = "0x7BBC7F3E70")]
		public static void SetBanner(UISprite m_Banner, uint bannerId, bool isBrief = false)
		{
		}

		// Token: 0x06009E69 RID: 40553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009E69")]
		[Address(RVA = "0x1FF3F40", Offset = "0x1FF3F40", VA = "0x7BBC7F3F40")]
		public static void UpdateHeadPicOrPortraitUrl(UISprite headIcon, UINetworkTexture headTexture, BaseProfileInfo data, [Optional] GameObject fakeImage)
		{
		}

		// Token: 0x0400A4A0 RID: 42144
		[Token(Token = "0x400A4A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Color Online_Color;

		// Token: 0x0400A4A1 RID: 42145
		[Token(Token = "0x400A4A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Color Offline_Color;

		// Token: 0x0400A4A2 RID: 42146
		[Token(Token = "0x400A4A2")]
		public const uint BTN_COLOR_YELLOW = 4256628991U;

		// Token: 0x0400A4A3 RID: 42147
		[Token(Token = "0x400A4A3")]
		public const uint BTN_COLOR_GRAY = 2189591295U;

		// Token: 0x0400A4A4 RID: 42148
		[Token(Token = "0x400A4A4")]
		public const uint BG_COLOR_GRAY = 1448630527U;

		// Token: 0x0400A4A5 RID: 42149
		[Token(Token = "0x400A4A5")]
		public const uint UI_HideClanName = 1U;

		// Token: 0x0400A4A6 RID: 42150
		[Token(Token = "0x400A4A6")]
		public const uint UI_HideLevel = 2U;

		// Token: 0x0400A4A7 RID: 42151
		[Token(Token = "0x400A4A7")]
		public const uint UI_ShowRank = 4U;

		// Token: 0x0400A4A8 RID: 42152
		[Token(Token = "0x400A4A8")]
		public const uint UI_ShowOnline = 8U;

		// Token: 0x0400A4A9 RID: 42153
		[Token(Token = "0x400A4A9")]
		public const uint UI_GrayOffline = 16U;

		// Token: 0x0400A4AA RID: 42154
		[Token(Token = "0x400A4AA")]
		public const uint UI_ShowPlatformIcon = 32U;

		// Token: 0x0400A4AB RID: 42155
		[Token(Token = "0x400A4AB")]
		public const uint UI_ShowElitePass = 64U;

		// Token: 0x0400A4AC RID: 42156
		[Token(Token = "0x400A4AC")]
		public const uint UI_ShowCSRank = 128U;

		// Token: 0x0400A4AD RID: 42157
		[Token(Token = "0x400A4AD")]
		public const uint UI_ShowBtnPinIcon = 256U;

		// Token: 0x0400A4AE RID: 42158
		[Token(Token = "0x400A4AE")]
		public const uint UI_ForceShowBRRank = 512U;

		// Token: 0x0400A4AF RID: 42159
		[Token(Token = "0x400A4AF")]
		public const string DEFAULT_HEADICON = "Icon_face_normal";

		// Token: 0x0400A4B0 RID: 42160
		[Token(Token = "0x400A4B0")]
		public const string DEFAULT_BRIEF_BANNER = "Icon_callsign_briefbg_default";

		// Token: 0x0400A4B1 RID: 42161
		[Token(Token = "0x400A4B1")]
		public const string DEFAULT_BANNER = "Icon_callsign_basebg_default";

		// Token: 0x0400A4B2 RID: 42162
		[Token(Token = "0x400A4B2")]
		public const int MAX_EMOTESLOT_CNT = 8;

		// Token: 0x0400A4B3 RID: 42163
		[Token(Token = "0x400A4B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly Dictionary<EPresence.AccountPresence, int> AccountPresenceSortOrder;
	}
}
