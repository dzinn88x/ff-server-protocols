using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW
{
	// Token: 0x02001306 RID: 4870
	[Token(Token = "0x2001306")]
	public class SDKManager : MonoBehaviour
	{
		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06004D37 RID: 19767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700085C")]
		public static SDKManager Instance
		{
			[Token(Token = "0x6004D37")]
			[Address(RVA = "0x1B32050", Offset = "0x1B32050", VA = "0x7BBC332050")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06004D38 RID: 19768 RVA: 0x000176D0 File Offset: 0x000158D0
		// (set) Token: 0x06004D39 RID: 19769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700085D")]
		public PlatformType PlatformType
		{
			[Token(Token = "0x6004D38")]
			[Address(RVA = "0x1B320B8", Offset = "0x1B320B8", VA = "0x7BBC3320B8")]
			get
			{
				return PlatformType.Guest;
			}
			[Token(Token = "0x6004D39")]
			[Address(RVA = "0x1B320C0", Offset = "0x1B320C0", VA = "0x7BBC3320C0")]
			set
			{
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06004D3A RID: 19770 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004D3B RID: 19771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700085E")]
		public string OpenID
		{
			[Token(Token = "0x6004D3A")]
			[Address(RVA = "0x1B32140", Offset = "0x1B32140", VA = "0x7BBC332140")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D3B")]
			[Address(RVA = "0x1B321FC", Offset = "0x1B321FC", VA = "0x7BBC3321FC")]
			set
			{
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06004D3C RID: 19772 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004D3D RID: 19773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700085F")]
		public string Token
		{
			[Token(Token = "0x6004D3C")]
			[Address(RVA = "0x1B32204", Offset = "0x1B32204", VA = "0x7BBC332204")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D3D")]
			[Address(RVA = "0x1B32260", Offset = "0x1B32260", VA = "0x7BBC332260")]
			set
			{
			}
		}

		// Token: 0x06004D3E RID: 19774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D3E")]
		[Address(RVA = "0x1B32268", Offset = "0x1B32268", VA = "0x7BBC332268")]
		private void Awake()
		{
		}

		// Token: 0x06004D3F RID: 19775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D3F")]
		[Address(RVA = "0x1B32310", Offset = "0x1B32310", VA = "0x7BBC332310")]
		private void Start()
		{
		}

		// Token: 0x06004D40 RID: 19776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D40")]
		[Address(RVA = "0x1B32314", Offset = "0x1B32314", VA = "0x7BBC332314")]
		private void Update()
		{
		}

		// Token: 0x06004D41 RID: 19777 RVA: 0x000176E8 File Offset: 0x000158E8
		[Token(Token = "0x6004D41")]
		[Address(RVA = "0x1B32318", Offset = "0x1B32318", VA = "0x7BBC332318")]
		public bool IsSupported(PlatformType platform)
		{
			return default(bool);
		}

		// Token: 0x06004D42 RID: 19778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D42")]
		[Address(RVA = "0x1B32404", Offset = "0x1B32404", VA = "0x7BBC332404")]
		public void InitSDK(PlatformType platform, bool force = false)
		{
		}

		// Token: 0x06004D43 RID: 19779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D43")]
		[Address(RVA = "0x1B32650", Offset = "0x1B32650", VA = "0x7BBC332650")]
		public void PCForceInitSDK(PlatformType platform)
		{
		}

		// Token: 0x06004D44 RID: 19780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D44")]
		[Address(RVA = "0x1B32658", Offset = "0x1B32658", VA = "0x7BBC332658")]
		public void InitBindSDK(PlatformType platform)
		{
		}

		// Token: 0x06004D45 RID: 19781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D45")]
		[Address(RVA = "0x1B32810", Offset = "0x1B32810", VA = "0x7BBC332810")]
		public void LogoutSDK()
		{
		}

		// Token: 0x06004D46 RID: 19782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D46")]
		[Address(RVA = "0x1B32968", Offset = "0x1B32968", VA = "0x7BBC332968")]
		public static string AppsFlyerAccountType(PlatformType platform)
		{
			return null;
		}

		// Token: 0x06004D47 RID: 19783 RVA: 0x00017700 File Offset: 0x00015900
		[Token(Token = "0x6004D47")]
		[Address(RVA = "0x1B323E4", Offset = "0x1B323E4", VA = "0x7BBC3323E4")]
		public static SDKType GetSDKType(PlatformType platform)
		{
			return SDKType.None;
		}

		// Token: 0x06004D48 RID: 19784 RVA: 0x00017718 File Offset: 0x00015918
		[Token(Token = "0x6004D48")]
		[Address(RVA = "0x1B325D0", Offset = "0x1B325D0", VA = "0x7BBC3325D0")]
		public SDKType GetCurrentSDKType()
		{
			return SDKType.None;
		}

		// Token: 0x06004D49 RID: 19785 RVA: 0x00017730 File Offset: 0x00015930
		[Token(Token = "0x6004D49")]
		[Address(RVA = "0x1B32A24", Offset = "0x1B32A24", VA = "0x7BBC332A24")]
		public PlatformType GetCachePlatformType()
		{
			return PlatformType.Guest;
		}

		// Token: 0x06004D4A RID: 19786 RVA: 0x00017748 File Offset: 0x00015948
		[Token(Token = "0x6004D4A")]
		[Address(RVA = "0x1B32A9C", Offset = "0x1B32A9C", VA = "0x7BBC332A9C")]
		public SDKType GetCacheSDKType()
		{
			return SDKType.None;
		}

		// Token: 0x06004D4B RID: 19787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D4B")]
		[Address(RVA = "0x1B320C8", Offset = "0x1B320C8", VA = "0x7BBC3320C8")]
		private void SavePlatformType(PlatformType platformType)
		{
		}

		// Token: 0x06004D4C RID: 19788 RVA: 0x00017760 File Offset: 0x00015960
		[Token(Token = "0x6004D4C")]
		[Address(RVA = "0x1B32A28", Offset = "0x1B32A28", VA = "0x7BBC332A28")]
		private PlatformType LoadPlatformType()
		{
			return PlatformType.Guest;
		}

		// Token: 0x06004D4D RID: 19789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D4D")]
		[Address(RVA = "0x1B32B20", Offset = "0x1B32B20", VA = "0x7BBC332B20")]
		public SDKManager()
		{
		}

		// Token: 0x040074F4 RID: 29940
		[Token(Token = "0x40074F4")]
		[FieldOffset(Offset = "0x0")]
		private static SDKManager _instance;

		// Token: 0x040074F5 RID: 29941
		[Token(Token = "0x40074F5")]
		[FieldOffset(Offset = "0x18")]
		private PlatformType m_PlatformType;

		// Token: 0x040074F6 RID: 29942
		[Token(Token = "0x40074F6")]
		[FieldOffset(Offset = "0x20")]
		private string openID;

		// Token: 0x040074F7 RID: 29943
		[Token(Token = "0x40074F7")]
		[FieldOffset(Offset = "0x28")]
		private string token;

		// Token: 0x040074F8 RID: 29944
		[Token(Token = "0x40074F8")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<PlatformType, string> _AppsFlyerAccountTypes;

		// Token: 0x040074F9 RID: 29945
		[Token(Token = "0x40074F9")]
		private const string PLAYER_PREF_KEY_PLATFORM_TYPE = "SDKPlatformType";
	}
}
