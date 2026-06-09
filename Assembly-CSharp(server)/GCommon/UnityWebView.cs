using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000F5F RID: 3935
	[Token(Token = "0x2000F5F")]
	public static class UnityWebView
	{
		// Token: 0x06003903 RID: 14595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003903")]
		[Address(RVA = "0x223D678", Offset = "0x223D678", VA = "0x7BBCA3D678")]
		public static void Init()
		{
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06003904 RID: 14596 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003905 RID: 14597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D9")]
		public static string JavaScriptName
		{
			[Token(Token = "0x6003904")]
			[Address(RVA = "0x223D80C", Offset = "0x223D80C", VA = "0x7BBCA3D80C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BAD0", Offset = "0x113BAD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003905")]
			[Address(RVA = "0x223D874", Offset = "0x223D874", VA = "0x7BBCA3D874")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BAE0", Offset = "0x113BAE0")]
			private set
			{
			}
		}

		// Token: 0x06003906 RID: 14598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003906")]
		[Address(RVA = "0x223D8E0", Offset = "0x223D8E0", VA = "0x7BBCA3D8E0")]
		public static void SetLogCallbacks(Action<string> onLog, Action<string> onLogError)
		{
		}

		// Token: 0x06003907 RID: 14599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003907")]
		[Address(RVA = "0x223D960", Offset = "0x223D960", VA = "0x7BBCA3D960")]
		internal static void Log(string log)
		{
		}

		// Token: 0x06003908 RID: 14600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003908")]
		[Address(RVA = "0x223DA20", Offset = "0x223DA20", VA = "0x7BBCA3DA20")]
		internal static void LogError(string logError)
		{
		}

		// Token: 0x06003909 RID: 14601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003909")]
		[Address(RVA = "0x223DAE0", Offset = "0x223DAE0", VA = "0x7BBCA3DAE0")]
		public static void ExtraLog(bool enable)
		{
		}

		// Token: 0x0600390A RID: 14602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600390A")]
		[Address(RVA = "0x223DBF0", Offset = "0x223DBF0", VA = "0x7BBCA3DBF0")]
		public static void SetUnitySendMessageGameObjectName(string gameObjectName)
		{
		}

		// Token: 0x0600390B RID: 14603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600390B")]
		[Address(RVA = "0x223DCD8", Offset = "0x223DCD8", VA = "0x7BBCA3DCD8")]
		public static void SetSendConsoleMessagesToUnity(bool send)
		{
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x0600390C RID: 14604 RVA: 0x00011B38 File Offset: 0x0000FD38
		// (set) Token: 0x0600390D RID: 14605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006DA")]
		public static bool UseJavaScriptInjection
		{
			[Token(Token = "0x600390C")]
			[Address(RVA = "0x223DDE8", Offset = "0x223DDE8", VA = "0x7BBCA3DDE8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BAF0", Offset = "0x113BAF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600390D")]
			[Address(RVA = "0x223DE50", Offset = "0x223DE50", VA = "0x7BBCA3DE50")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BB00", Offset = "0x113BB00")]
			set
			{
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x0600390E RID: 14606 RVA: 0x00011B50 File Offset: 0x0000FD50
		// (set) Token: 0x0600390F RID: 14607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006DB")]
		public static bool UseMediaManipulationOnHideAndShowByJavaScript
		{
			[Token(Token = "0x600390E")]
			[Address(RVA = "0x223DEC0", Offset = "0x223DEC0", VA = "0x7BBCA3DEC0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BB10", Offset = "0x113BB10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600390F")]
			[Address(RVA = "0x223DF28", Offset = "0x223DF28", VA = "0x7BBCA3DF28")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x113BB20", Offset = "0x113BB20")]
			set
			{
			}
		}

		// Token: 0x06003910 RID: 14608 RVA: 0x00011B68 File Offset: 0x0000FD68
		[Token(Token = "0x6003910")]
		[Address(RVA = "0x223DF98", Offset = "0x223DF98", VA = "0x7BBCA3DF98")]
		public static int Open(string url, float x, float y, float width, float height, UnityWebView.WebViewParameters parameters)
		{
			return 0;
		}

		// Token: 0x06003911 RID: 14609 RVA: 0x00011B80 File Offset: 0x0000FD80
		[Token(Token = "0x6003911")]
		[Address(RVA = "0x223E6EC", Offset = "0x223E6EC", VA = "0x7BBCA3E6EC")]
		public static bool Test()
		{
			return default(bool);
		}

		// Token: 0x06003912 RID: 14610 RVA: 0x00011B98 File Offset: 0x0000FD98
		[Token(Token = "0x6003912")]
		[Address(RVA = "0x223E778", Offset = "0x223E778", VA = "0x7BBCA3E778")]
		public static bool CanFix()
		{
			return default(bool);
		}

		// Token: 0x06003913 RID: 14611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003913")]
		[Address(RVA = "0x223E780", Offset = "0x223E780", VA = "0x7BBCA3E780")]
		public static void Fix()
		{
		}

		// Token: 0x06003914 RID: 14612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003914")]
		[Address(RVA = "0x223E7CC", Offset = "0x223E7CC", VA = "0x7BBCA3E7CC")]
		public static void Close(int webViewId)
		{
		}

		// Token: 0x06003915 RID: 14613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003915")]
		[Address(RVA = "0x223EBB0", Offset = "0x223EBB0", VA = "0x7BBCA3EBB0")]
		public static void CloseAll()
		{
		}

		// Token: 0x06003916 RID: 14614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003916")]
		[Address(RVA = "0x223EF50", Offset = "0x223EF50", VA = "0x7BBCA3EF50")]
		public static void Reload(int webViewId)
		{
		}

		// Token: 0x06003917 RID: 14615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003917")]
		[Address(RVA = "0x223F05C", Offset = "0x223F05C", VA = "0x7BBCA3F05C")]
		internal static void OnGetUserAgentString(int webViewId, string userAgentString)
		{
		}

		// Token: 0x06003918 RID: 14616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003918")]
		[Address(RVA = "0x223F180", Offset = "0x223F180", VA = "0x7BBCA3F180")]
		public static void GetUserAgentString(int webViewId, Action<int, string> callback)
		{
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003919")]
		[Address(RVA = "0x223F32C", Offset = "0x223F32C", VA = "0x7BBCA3F32C")]
		public static void SetUserAgentString(int webViewId, string userAgentString)
		{
		}

		// Token: 0x0600391A RID: 14618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600391A")]
		[Address(RVA = "0x223F48C", Offset = "0x223F48C", VA = "0x7BBCA3F48C")]
		internal static void OnCanGoBackward(int webViewId, bool result)
		{
		}

		// Token: 0x0600391B RID: 14619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600391B")]
		[Address(RVA = "0x223F5B0", Offset = "0x223F5B0", VA = "0x7BBCA3F5B0")]
		public static void CanGoBackward(int webViewId, Action<int, bool> callback)
		{
		}

		// Token: 0x0600391C RID: 14620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600391C")]
		[Address(RVA = "0x223F768", Offset = "0x223F768", VA = "0x7BBCA3F768")]
		internal static void OnCanGoForward(int webViewId, bool result)
		{
		}

		// Token: 0x0600391D RID: 14621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600391D")]
		[Address(RVA = "0x223F88C", Offset = "0x223F88C", VA = "0x7BBCA3F88C")]
		public static void CanGoForward(int webViewId, Action<int, bool> callback)
		{
		}

		// Token: 0x0600391E RID: 14622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600391E")]
		[Address(RVA = "0x223FA44", Offset = "0x223FA44", VA = "0x7BBCA3FA44")]
		public static void GoBackward(int webViewId)
		{
		}

		// Token: 0x0600391F RID: 14623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600391F")]
		[Address(RVA = "0x223FB50", Offset = "0x223FB50", VA = "0x7BBCA3FB50")]
		public static void GoForward(int webViewId)
		{
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003920")]
		[Address(RVA = "0x223FC5C", Offset = "0x223FC5C", VA = "0x7BBCA3FC5C")]
		public static string GetURL(int webViewId)
		{
			return null;
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x00011BB0 File Offset: 0x0000FDB0
		[Token(Token = "0x6003921")]
		[Address(RVA = "0x223FD70", Offset = "0x223FD70", VA = "0x7BBCA3FD70")]
		public static float GetLoadingProgress(int webViewId)
		{
			return 0f;
		}

		// Token: 0x06003922 RID: 14626 RVA: 0x00011BC8 File Offset: 0x0000FDC8
		[Token(Token = "0x6003922")]
		[Address(RVA = "0x223FE88", Offset = "0x223FE88", VA = "0x7BBCA3FE88")]
		public static bool IsLoading(int webViewId)
		{
			return default(bool);
		}

		// Token: 0x06003923 RID: 14627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003923")]
		[Address(RVA = "0x223FFA0", Offset = "0x223FFA0", VA = "0x7BBCA3FFA0")]
		public static void SetNameInJavaScript(string name)
		{
		}

		// Token: 0x06003924 RID: 14628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003924")]
		[Address(RVA = "0x22400F0", Offset = "0x22400F0", VA = "0x7BBCA400F0")]
		public static void RegisterJavaScriptMessageHandler(string msg, string[] parameters, Action<string, string[], int, string> handler)
		{
		}

		// Token: 0x06003925 RID: 14629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003925")]
		[Address(RVA = "0x22402E8", Offset = "0x22402E8", VA = "0x7BBCA402E8")]
		public static void UnregisterJavaScriptMessageHandler(string msg)
		{
		}

		// Token: 0x06003926 RID: 14630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003926")]
		[Address(RVA = "0x22403E8", Offset = "0x22403E8", VA = "0x7BBCA403E8")]
		public static void MessageHandlerReturnToJavaScript(int webViewId, string promiseId, string result, bool error = false)
		{
		}

		// Token: 0x06003927 RID: 14631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003927")]
		[Address(RVA = "0x2240C1C", Offset = "0x2240C1C", VA = "0x7BBCA40C1C")]
		internal static void OnJavaScriptPostMessage(int webViewId, string msg)
		{
		}

		// Token: 0x06003928 RID: 14632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003928")]
		[Address(RVA = "0x2241584", Offset = "0x2241584", VA = "0x7BBCA41584")]
		private static string JavaScriptResultCallbackString(int webViewId, Action<int, UnityWebView.JavaScriptResult> callback)
		{
			return null;
		}

		// Token: 0x06003929 RID: 14633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003929")]
		[Address(RVA = "0x2241854", Offset = "0x2241854", VA = "0x7BBCA41854")]
		private static string SetJavaScriptCallback(int webViewId, Action<int, UnityWebView.JavaScriptResult> callback)
		{
			return null;
		}

		// Token: 0x0600392A RID: 14634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600392A")]
		[Address(RVA = "0x2241A30", Offset = "0x2241A30", VA = "0x7BBCA41A30")]
		internal static void DoJavaScriptCallback(int webViewId, UnityWebView.JavaScriptResult result)
		{
		}

		// Token: 0x0600392B RID: 14635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600392B")]
		[Address(RVA = "0x223E9E8", Offset = "0x223E9E8", VA = "0x7BBCA3E9E8")]
		private static void ClearJavaScriptCallbacks(int webViewId)
		{
		}

		// Token: 0x0600392C RID: 14636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600392C")]
		[Address(RVA = "0x223ECD4", Offset = "0x223ECD4", VA = "0x7BBCA3ECD4")]
		private static void ClearAllJavaScriptCallbacks()
		{
		}

		// Token: 0x0600392D RID: 14637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600392D")]
		[Address(RVA = "0x22409F0", Offset = "0x22409F0", VA = "0x7BBCA409F0")]
		public static string RunJavaScript(int webViewId, string jsCode, string id, Action<int, UnityWebView.JavaScriptResult> callback)
		{
			return null;
		}

		// Token: 0x0600392E RID: 14638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600392E")]
		[Address(RVA = "0x2241EB8", Offset = "0x2241EB8", VA = "0x7BBCA41EB8")]
		public static string JavaScriptEcho(int webViewId, string msg)
		{
			return null;
		}

		// Token: 0x0600392F RID: 14639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600392F")]
		[Address(RVA = "0x2242090", Offset = "0x2242090", VA = "0x7BBCA42090")]
		private static void OnJavaScriptEchoCallback(int webViewId, UnityWebView.JavaScriptResult jsr)
		{
		}

		// Token: 0x06003930 RID: 14640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003930")]
		[Address(RVA = "0x224067C", Offset = "0x224067C", VA = "0x7BBCA4067C")]
		public static string ToLiteral(string input)
		{
			return null;
		}

		// Token: 0x06003931 RID: 14641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003931")]
		[Address(RVA = "0x2242344", Offset = "0x2242344", VA = "0x7BBCA42344")]
		public static string FromLiteral(string input)
		{
			return null;
		}

		// Token: 0x06003932 RID: 14642 RVA: 0x00011BE0 File Offset: 0x0000FDE0
		[Token(Token = "0x6003932")]
		[Address(RVA = "0x22428D4", Offset = "0x22428D4", VA = "0x7BBCA428D4")]
		public static bool CanClearCookies()
		{
			return default(bool);
		}

		// Token: 0x06003933 RID: 14643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003933")]
		[Address(RVA = "0x2242960", Offset = "0x2242960", VA = "0x7BBCA42960")]
		public static void ClearCookies()
		{
		}

		// Token: 0x06003934 RID: 14644 RVA: 0x00011BF8 File Offset: 0x0000FDF8
		[Token(Token = "0x6003934")]
		[Address(RVA = "0x22429E4", Offset = "0x22429E4", VA = "0x7BBCA429E4")]
		public static bool CanClearCache()
		{
			return default(bool);
		}

		// Token: 0x06003935 RID: 14645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003935")]
		[Address(RVA = "0x2242A70", Offset = "0x2242A70", VA = "0x7BBCA42A70")]
		public static void ClearCache(Action<string> onClearCache)
		{
		}

		// Token: 0x06003936 RID: 14646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003936")]
		[Address(RVA = "0x2242B5C", Offset = "0x2242B5C", VA = "0x7BBCA42B5C")]
		internal static void OnClearCache(string msg)
		{
		}

		// Token: 0x06003937 RID: 14647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003937")]
		[Address(RVA = "0x2242C24", Offset = "0x2242C24", VA = "0x7BBCA42C24")]
		internal static void DeleteLocalStorage()
		{
		}

		// Token: 0x06003938 RID: 14648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003938")]
		[Address(RVA = "0x2242CA8", Offset = "0x2242CA8", VA = "0x7BBCA42CA8")]
		public static void ShowWebView(int webViewId)
		{
		}

		// Token: 0x06003939 RID: 14649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003939")]
		[Address(RVA = "0x2242DB4", Offset = "0x2242DB4", VA = "0x7BBCA42DB4")]
		public static void HideWebView(int webViewId)
		{
		}

		// Token: 0x0600393A RID: 14650 RVA: 0x00011C10 File Offset: 0x0000FE10
		[Token(Token = "0x600393A")]
		[Address(RVA = "0x2242EC0", Offset = "0x2242EC0", VA = "0x7BBCA42EC0")]
		public static bool SupportWebPage()
		{
			return default(bool);
		}

		// Token: 0x0600393B RID: 14651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600393B")]
		[Address(RVA = "0x2242EC8", Offset = "0x2242EC8", VA = "0x7BBCA42EC8")]
		public static void OpenWebPage(string url, bool animated, Action onClose)
		{
		}

		// Token: 0x0600393C RID: 14652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600393C")]
		[Address(RVA = "0x2242F34", Offset = "0x2242F34", VA = "0x7BBCA42F34")]
		public static void CloseWebPage(bool animated)
		{
		}

		// Token: 0x04004AD8 RID: 19160
		[Token(Token = "0x4004AD8")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E924", Offset = "0x112E924")]
		private static string <JavaScriptName>k__BackingField;

		// Token: 0x04004AD9 RID: 19161
		[Token(Token = "0x4004AD9")]
		[FieldOffset(Offset = "0x8")]
		private static Action<string> OnLog;

		// Token: 0x04004ADA RID: 19162
		[Token(Token = "0x4004ADA")]
		[FieldOffset(Offset = "0x10")]
		private static Action<string> OnLogError;

		// Token: 0x04004ADB RID: 19163
		[Token(Token = "0x4004ADB")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E934", Offset = "0x112E934")]
		private static bool <UseJavaScriptInjection>k__BackingField;

		// Token: 0x04004ADC RID: 19164
		[Token(Token = "0x4004ADC")]
		[FieldOffset(Offset = "0x19")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x112E944", Offset = "0x112E944")]
		private static bool <UseMediaManipulationOnHideAndShowByJavaScript>k__BackingField;

		// Token: 0x04004ADD RID: 19165
		[Token(Token = "0x4004ADD")]
		[FieldOffset(Offset = "0x20")]
		private static Dictionary<int, Action<int, string>> _GetUserAgentStringCallback;

		// Token: 0x04004ADE RID: 19166
		[Token(Token = "0x4004ADE")]
		[FieldOffset(Offset = "0x28")]
		private static Dictionary<int, Action<int, bool>> _CanGoBackwardCallback;

		// Token: 0x04004ADF RID: 19167
		[Token(Token = "0x4004ADF")]
		[FieldOffset(Offset = "0x30")]
		private static Dictionary<int, Action<int, bool>> _CanGoForwardCallback;

		// Token: 0x04004AE0 RID: 19168
		[Token(Token = "0x4004AE0")]
		[FieldOffset(Offset = "0x38")]
		private static Dictionary<string, UnityWebView.JavaScriptMessageHandler> _JavaScriptMessageHandlers;

		// Token: 0x04004AE1 RID: 19169
		[Token(Token = "0x4004AE1")]
		private const string PROMISE_ID_KEY = "PromiseId";

		// Token: 0x04004AE2 RID: 19170
		[Token(Token = "0x4004AE2")]
		[FieldOffset(Offset = "0x40")]
		private static Dictionary<int, Dictionary<string, Action<int, UnityWebView.JavaScriptResult>>> _JavaScriptCallbacks;

		// Token: 0x04004AE3 RID: 19171
		[Token(Token = "0x4004AE3")]
		[FieldOffset(Offset = "0x48")]
		private static int _JavaScriptEchoId;

		// Token: 0x04004AE4 RID: 19172
		[Token(Token = "0x4004AE4")]
		[FieldOffset(Offset = "0x50")]
		private static string _JavaScriptEchoMsg;

		// Token: 0x04004AE5 RID: 19173
		[Token(Token = "0x4004AE5")]
		[FieldOffset(Offset = "0x58")]
		private static Action<string> _OnClearCache;

		// Token: 0x04004AE6 RID: 19174
		[Token(Token = "0x4004AE6")]
		public const string NATIVE_TO_JAVASCRIPT_PROMISE_THEN = "nativePromiseThen";

		// Token: 0x04004AE7 RID: 19175
		[Token(Token = "0x4004AE7")]
		[FieldOffset(Offset = "0x60")]
		internal static Action _OnWebPageClose;

		// Token: 0x02000F60 RID: 3936
		[Token(Token = "0x2000F60")]
		[Serializable]
		public class WebViewParameters
		{
			// Token: 0x0600393E RID: 14654 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600393E")]
			[Address(RVA = "0x224326C", Offset = "0x224326C", VA = "0x7BBCA4326C")]
			public WebViewParameters()
			{
			}

			// Token: 0x04004AE8 RID: 19176
			[Token(Token = "0x4004AE8")]
			[FieldOffset(Offset = "0x10")]
			public string UnitySendMessageGameObjectName;

			// Token: 0x04004AE9 RID: 19177
			[Token(Token = "0x4004AE9")]
			[FieldOffset(Offset = "0x18")]
			public bool Scaling;

			// Token: 0x04004AEA RID: 19178
			[Token(Token = "0x4004AEA")]
			[FieldOffset(Offset = "0x19")]
			public bool UseCookie;

			// Token: 0x04004AEB RID: 19179
			[Token(Token = "0x4004AEB")]
			[FieldOffset(Offset = "0x1A")]
			public bool DeferredDisplay;

			// Token: 0x04004AEC RID: 19180
			[Token(Token = "0x4004AEC")]
			[FieldOffset(Offset = "0x1B")]
			public bool ExtraLog;
		}

		// Token: 0x02000F61 RID: 3937
		[Token(Token = "0x2000F61")]
		private class JavaScriptMessageHandler
		{
			// Token: 0x0600393F RID: 14655 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600393F")]
			[Address(RVA = "0x22402E0", Offset = "0x22402E0", VA = "0x7BBCA402E0")]
			public JavaScriptMessageHandler()
			{
			}

			// Token: 0x04004AED RID: 19181
			[Token(Token = "0x4004AED")]
			[FieldOffset(Offset = "0x10")]
			public string[] Parameters;

			// Token: 0x04004AEE RID: 19182
			[Token(Token = "0x4004AEE")]
			[FieldOffset(Offset = "0x18")]
			public Action<string, string[], int, string> Handler;
		}

		// Token: 0x02000F62 RID: 3938
		[Token(Token = "0x2000F62")]
		[Serializable]
		public class JavaScriptResult
		{
			// Token: 0x06003940 RID: 14656 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003940")]
			[Address(RVA = "0x2243264", Offset = "0x2243264", VA = "0x7BBCA43264")]
			public JavaScriptResult()
			{
			}

			// Token: 0x04004AEF RID: 19183
			[Token(Token = "0x4004AEF")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04004AF0 RID: 19184
			[Token(Token = "0x4004AF0")]
			[FieldOffset(Offset = "0x18")]
			public string callback;

			// Token: 0x04004AF1 RID: 19185
			[Token(Token = "0x4004AF1")]
			[FieldOffset(Offset = "0x20")]
			public string error;

			// Token: 0x04004AF2 RID: 19186
			[Token(Token = "0x4004AF2")]
			[FieldOffset(Offset = "0x28")]
			public string value;
		}

		// Token: 0x02000F63 RID: 3939
		[Token(Token = "0x2000F63")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA4B0", Offset = "0x10EA4B0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06003942 RID: 14658 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003942")]
			[Address(RVA = "0x22430D0", Offset = "0x22430D0", VA = "0x7BBCA430D0")]
			public <>c()
			{
			}

			// Token: 0x06003943 RID: 14659 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003943")]
			[Address(RVA = "0x22430D8", Offset = "0x22430D8", VA = "0x7BBCA430D8")]
			internal string <FromLiteral>b__65_0(Match match)
			{
				return null;
			}

			// Token: 0x04004AF3 RID: 19187
			[Token(Token = "0x4004AF3")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UnityWebView.<>c <>9;

			// Token: 0x04004AF4 RID: 19188
			[Token(Token = "0x4004AF4")]
			[FieldOffset(Offset = "0x8")]
			public static MatchEvaluator <>9__65_0;
		}

		// Token: 0x02000F64 RID: 3940
		[Token(Token = "0x2000F64")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA4C0", Offset = "0x10EA4C0")]
		private sealed class <>c__DisplayClass71_0
		{
			// Token: 0x06003944 RID: 14660 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003944")]
			[Address(RVA = "0x2242C1C", Offset = "0x2242C1C", VA = "0x7BBCA42C1C")]
			public <>c__DisplayClass71_0()
			{
			}

			// Token: 0x06003945 RID: 14661 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003945")]
			[Address(RVA = "0x2243198", Offset = "0x2243198", VA = "0x7BBCA43198")]
			internal void <OnClearCache>b__0()
			{
			}

			// Token: 0x04004AF5 RID: 19189
			[Token(Token = "0x4004AF5")]
			[FieldOffset(Offset = "0x10")]
			public string msg;
		}
	}
}
