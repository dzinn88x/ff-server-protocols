using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F6D RID: 3949
	[Token(Token = "0x2000F6D")]
	public static class UnityWebView_Android
	{
		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06003962 RID: 14690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006DC")]
		private static AndroidJavaClass WebViewManager
		{
			[Token(Token = "0x6003962")]
			[Address(RVA = "0x224431C", Offset = "0x224431C", VA = "0x7BBCA4431C")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003963 RID: 14691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003963")]
		[Address(RVA = "0x223DAE8", Offset = "0x223DAE8", VA = "0x7BBCA3DAE8")]
		public static void ExtraLog(bool enable)
		{
		}

		// Token: 0x06003964 RID: 14692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003964")]
		[Address(RVA = "0x223DBF4", Offset = "0x223DBF4", VA = "0x7BBCA3DBF4")]
		public static void SetUnitySendMessageGameObjectName(string name)
		{
		}

		// Token: 0x06003965 RID: 14693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003965")]
		[Address(RVA = "0x223DCE0", Offset = "0x223DCE0", VA = "0x7BBCA3DCE0")]
		public static void SetSendConsoleMessagesToUnity(bool send)
		{
		}

		// Token: 0x06003966 RID: 14694 RVA: 0x00011C40 File Offset: 0x0000FE40
		[Token(Token = "0x6003966")]
		[Address(RVA = "0x223E330", Offset = "0x223E330", VA = "0x7BBCA3E330")]
		public static int Open(string url, float x, float y, float width, float height, UnityWebView.WebViewParameters parameters)
		{
			return 0;
		}

		// Token: 0x06003967 RID: 14695 RVA: 0x00011C58 File Offset: 0x0000FE58
		[Token(Token = "0x6003967")]
		[Address(RVA = "0x223E6F0", Offset = "0x223E6F0", VA = "0x7BBCA3E6F0")]
		public static bool Test()
		{
			return default(bool);
		}

		// Token: 0x06003968 RID: 14696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003968")]
		[Address(RVA = "0x223E8E0", Offset = "0x223E8E0", VA = "0x7BBCA3E8E0")]
		public static void Close(int webViewId)
		{
		}

		// Token: 0x06003969 RID: 14697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003969")]
		[Address(RVA = "0x223EC54", Offset = "0x223EC54", VA = "0x7BBCA3EC54")]
		public static void CloseAll()
		{
		}

		// Token: 0x0600396A RID: 14698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600396A")]
		[Address(RVA = "0x223EF54", Offset = "0x223EF54", VA = "0x7BBCA3EF54")]
		public static void Reload(int webViewId)
		{
		}

		// Token: 0x0600396B RID: 14699 RVA: 0x00011C70 File Offset: 0x0000FE70
		[Token(Token = "0x600396B")]
		[Address(RVA = "0x223F654", Offset = "0x223F654", VA = "0x7BBCA3F654")]
		public static bool CanGoBackward(int webViewId)
		{
			return default(bool);
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x00011C88 File Offset: 0x0000FE88
		[Token(Token = "0x600396C")]
		[Address(RVA = "0x223F930", Offset = "0x223F930", VA = "0x7BBCA3F930")]
		public static bool CanGoForward(int webViewId)
		{
			return default(bool);
		}

		// Token: 0x0600396D RID: 14701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600396D")]
		[Address(RVA = "0x223FA48", Offset = "0x223FA48", VA = "0x7BBCA3FA48")]
		public static void GoBackward(int webViewId)
		{
		}

		// Token: 0x0600396E RID: 14702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600396E")]
		[Address(RVA = "0x223FB54", Offset = "0x223FB54", VA = "0x7BBCA3FB54")]
		public static void GoForward(int webViewId)
		{
		}

		// Token: 0x0600396F RID: 14703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600396F")]
		[Address(RVA = "0x223FC60", Offset = "0x223FC60", VA = "0x7BBCA3FC60")]
		public static string GetURL(int webViewId)
		{
			return null;
		}

		// Token: 0x06003970 RID: 14704 RVA: 0x00011CA0 File Offset: 0x0000FEA0
		[Token(Token = "0x6003970")]
		[Address(RVA = "0x223FD74", Offset = "0x223FD74", VA = "0x7BBCA3FD74")]
		public static float GetLoadingProgress(int webViewId)
		{
			return 0f;
		}

		// Token: 0x06003971 RID: 14705 RVA: 0x00011CB8 File Offset: 0x0000FEB8
		[Token(Token = "0x6003971")]
		[Address(RVA = "0x223FE8C", Offset = "0x223FE8C", VA = "0x7BBCA3FE8C")]
		public static bool IsLoading(int webViewId)
		{
			return default(bool);
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003972")]
		[Address(RVA = "0x224000C", Offset = "0x224000C", VA = "0x7BBCA4000C")]
		public static void SetNameInJavaScript(string name)
		{
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003973")]
		[Address(RVA = "0x2241CB4", Offset = "0x2241CB4", VA = "0x7BBCA41CB4")]
		public static string RunJavaScript(int webViewId, string jsCode, string callback, string id)
		{
			return null;
		}

		// Token: 0x06003974 RID: 14708 RVA: 0x00011CD0 File Offset: 0x0000FED0
		[Token(Token = "0x6003974")]
		[Address(RVA = "0x22428D8", Offset = "0x22428D8", VA = "0x7BBCA428D8")]
		public static bool CanClearCookies()
		{
			return default(bool);
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003975")]
		[Address(RVA = "0x2242964", Offset = "0x2242964", VA = "0x7BBCA42964")]
		public static void ClearCookies()
		{
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x00011CE8 File Offset: 0x0000FEE8
		[Token(Token = "0x6003976")]
		[Address(RVA = "0x22429E8", Offset = "0x22429E8", VA = "0x7BBCA429E8")]
		public static bool CanClearCache()
		{
			return default(bool);
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003977")]
		[Address(RVA = "0x2242ADC", Offset = "0x2242ADC", VA = "0x7BBCA42ADC")]
		public static void ClearCache()
		{
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003978")]
		[Address(RVA = "0x2242C28", Offset = "0x2242C28", VA = "0x7BBCA42C28")]
		public static void DeleteLocalStorage()
		{
		}

		// Token: 0x06003979 RID: 14713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003979")]
		[Address(RVA = "0x2242CAC", Offset = "0x2242CAC", VA = "0x7BBCA42CAC")]
		public static void Show(int webViewId)
		{
		}

		// Token: 0x0600397A RID: 14714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397A")]
		[Address(RVA = "0x2242DB8", Offset = "0x2242DB8", VA = "0x7BBCA42DB8")]
		public static void Hide(int webViewId)
		{
		}

		// Token: 0x0600397B RID: 14715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397B")]
		[Address(RVA = "0x223F224", Offset = "0x223F224", VA = "0x7BBCA3F224")]
		public static void GetUserAgentString(int webViewId)
		{
		}

		// Token: 0x0600397C RID: 14716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397C")]
		[Address(RVA = "0x223F330", Offset = "0x223F330", VA = "0x7BBCA3F330")]
		public static void SetUserAgentString(int webViewId, string userAgentString)
		{
		}

		// Token: 0x04004B0A RID: 19210
		[Token(Token = "0x4004B0A")]
		[FieldOffset(Offset = "0x0")]
		private static AndroidJavaClass _WebViewManager;
	}
}
