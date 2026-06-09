using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW
{
	// Token: 0x020025C8 RID: 9672
	[Token(Token = "0x20025C8")]
	public class WebView
	{
		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x0600C6C9 RID: 50889 RVA: 0x000354F0 File Offset: 0x000336F0
		[Token(Token = "0x17000CD1")]
		public static bool PromptFaulty
		{
			[Token(Token = "0x600C6C9")]
			[Address(RVA = "0x17A21D4", Offset = "0x17A21D4", VA = "0x7BBBFA21D4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x0600C6CA RID: 50890 RVA: 0x00035508 File Offset: 0x00033708
		[Token(Token = "0x17000CD2")]
		public static bool FallbackToBrowser
		{
			[Token(Token = "0x600C6CA")]
			[Address(RVA = "0x17A2290", Offset = "0x17A2290", VA = "0x7BBBFA2290")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x0600C6CB RID: 50891 RVA: 0x00035520 File Offset: 0x00033720
		[Token(Token = "0x17000CD3")]
		public static bool Faulty
		{
			[Token(Token = "0x600C6CB")]
			[Address(RVA = "0x17A234C", Offset = "0x17A234C", VA = "0x7BBBFA234C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x0600C6CC RID: 50892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CD4")]
		public static string NameInJavaScript
		{
			[Token(Token = "0x600C6CC")]
			[Address(RVA = "0x17A23EC", Offset = "0x17A23EC", VA = "0x7BBBFA23EC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x0600C6CD RID: 50893 RVA: 0x00035538 File Offset: 0x00033738
		[Token(Token = "0x17000CD5")]
		public static bool RunJavaScriptAllowed
		{
			[Token(Token = "0x600C6CD")]
			[Address(RVA = "0x17A24A8", Offset = "0x17A24A8", VA = "0x7BBBFA24A8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x0600C6CE RID: 50894 RVA: 0x00035550 File Offset: 0x00033750
		[Token(Token = "0x17000CD6")]
		public static bool DeferredDisplay
		{
			[Token(Token = "0x600C6CE")]
			[Address(RVA = "0x17A2564", Offset = "0x17A2564", VA = "0x7BBBFA2564")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x0600C6CF RID: 50895 RVA: 0x00035568 File Offset: 0x00033768
		[Token(Token = "0x17000CD7")]
		public static bool DisableJavaScriptInjection
		{
			[Token(Token = "0x600C6CF")]
			[Address(RVA = "0x17A2620", Offset = "0x17A2620", VA = "0x7BBBFA2620")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x0600C6D0 RID: 50896 RVA: 0x00035580 File Offset: 0x00033780
		[Token(Token = "0x17000CD8")]
		public static bool DisableMediaManipulationOnHideAndShow
		{
			[Token(Token = "0x600C6D0")]
			[Address(RVA = "0x17A26DC", Offset = "0x17A26DC", VA = "0x7BBBFA26DC")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600C6D1 RID: 50897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6D1")]
		[Address(RVA = "0x17A2798", Offset = "0x17A2798", VA = "0x7BBBFA2798")]
		public static void Check(string text, Action onContinue)
		{
		}

		// Token: 0x0600C6D2 RID: 50898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6D2")]
		[Address(RVA = "0x17A2B0C", Offset = "0x17A2B0C", VA = "0x7BBBFA2B0C")]
		private static void OnDeepLink(string deepLinkUrl, string[] parameters, int webViewId, string promiseId)
		{
		}

		// Token: 0x0600C6D3 RID: 50899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6D3")]
		[Address(RVA = "0x17A2D2C", Offset = "0x17A2D2C", VA = "0x7BBBFA2D2C")]
		private void ApplyAndroidWebViewUserAgentStringModifications(int webViewId, string url)
		{
		}

		// Token: 0x0600C6D4 RID: 50900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6D4")]
		[Address(RVA = "0x17A2DD8", Offset = "0x17A2DD8", VA = "0x7BBBFA2DD8")]
		private void OnGetAndroidWebViewUserAgentStringForModifications(int webViewId, string userAgentString)
		{
		}

		// Token: 0x0600C6D5 RID: 50901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6D5")]
		[Address(RVA = "0x1785E00", Offset = "0x1785E00", VA = "0x7BBBF85E00")]
		public void Open(string url, WebView.Rect rect, [Optional] bool? scaling, [Optional] bool? cookie, bool needCheck = true)
		{
		}

		// Token: 0x0600C6D6 RID: 50902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6D6")]
		[Address(RVA = "0x17869D0", Offset = "0x17869D0", VA = "0x7BBBF869D0")]
		public void ShowWebView()
		{
		}

		// Token: 0x0600C6D7 RID: 50903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6D7")]
		[Address(RVA = "0x17865F8", Offset = "0x17865F8", VA = "0x7BBBF865F8")]
		public void HideWebView()
		{
		}

		// Token: 0x0600C6D8 RID: 50904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C6D8")]
		[Address(RVA = "0x17A33D4", Offset = "0x17A33D4", VA = "0x7BBBFA33D4")]
		public string RunJavaScript(string jsCode, string id, Action<int, UnityWebView.JavaScriptResult> callback)
		{
			return null;
		}

		// Token: 0x0600C6D9 RID: 50905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6D9")]
		[Address(RVA = "0x17868A0", Offset = "0x17868A0", VA = "0x7BBBF868A0")]
		public void Close()
		{
		}

		// Token: 0x0600C6DA RID: 50906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6DA")]
		[Address(RVA = "0x17A34E0", Offset = "0x17A34E0", VA = "0x7BBBFA34E0")]
		public static void CloseAll()
		{
		}

		// Token: 0x0600C6DB RID: 50907 RVA: 0x00035598 File Offset: 0x00033798
		[Token(Token = "0x600C6DB")]
		[Address(RVA = "0x17A3540", Offset = "0x17A3540", VA = "0x7BBBFA3540")]
		public bool IsOpen()
		{
			return default(bool);
		}

		// Token: 0x0600C6DC RID: 50908 RVA: 0x000355B0 File Offset: 0x000337B0
		[Token(Token = "0x600C6DC")]
		[Address(RVA = "0x1787CC4", Offset = "0x1787CC4", VA = "0x7BBBF87CC4")]
		public bool IsLoading()
		{
			return default(bool);
		}

		// Token: 0x0600C6DD RID: 50909 RVA: 0x000355C8 File Offset: 0x000337C8
		[Token(Token = "0x600C6DD")]
		[Address(RVA = "0x1787D30", Offset = "0x1787D30", VA = "0x7BBBF87D30")]
		public float GetLoadingProgress()
		{
			return 0f;
		}

		// Token: 0x0600C6DE RID: 50910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6DE")]
		[Address(RVA = "0x178766C", Offset = "0x178766C", VA = "0x7BBBF8766C")]
		public void Reload()
		{
		}

		// Token: 0x0600C6DF RID: 50911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C6DF")]
		[Address(RVA = "0x17877C8", Offset = "0x17877C8", VA = "0x7BBBF877C8")]
		public string GetURL()
		{
			return null;
		}

		// Token: 0x0600C6E0 RID: 50912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6E0")]
		[Address(RVA = "0x17A3550", Offset = "0x17A3550", VA = "0x7BBBFA3550")]
		public void GoBackward()
		{
		}

		// Token: 0x0600C6E1 RID: 50913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6E1")]
		[Address(RVA = "0x17A35BC", Offset = "0x17A35BC", VA = "0x7BBBFA35BC")]
		public void GoForward()
		{
		}

		// Token: 0x0600C6E2 RID: 50914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6E2")]
		[Address(RVA = "0x17A3628", Offset = "0x17A3628", VA = "0x7BBBFA3628")]
		private static void OnGetAudioVolume(string channel, string[] parameters, int webViewId, string promiseId)
		{
		}

		// Token: 0x0600C6E3 RID: 50915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6E3")]
		[Address(RVA = "0x17A3770", Offset = "0x17A3770", VA = "0x7BBBFA3770")]
		private static void OnGetUserAgent(string param, string[] parameters, int webViewId, string promiseId)
		{
		}

		// Token: 0x0600C6E4 RID: 50916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6E4")]
		[Address(RVA = "0x17A3848", Offset = "0x17A3848", VA = "0x7BBBFA3848")]
		private static void OnGetNetworkType(string param, string[] parameters, int webViewId, string promiseId)
		{
		}

		// Token: 0x0600C6E5 RID: 50917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6E5")]
		[Address(RVA = "0x17A38D8", Offset = "0x17A38D8", VA = "0x7BBBFA38D8")]
		private static void OnGetQuality(string param, string[] parameters, int webViewId, string promiseId)
		{
		}

		// Token: 0x0600C6E6 RID: 50918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6E6")]
		[Address(RVA = "0x17A3B38", Offset = "0x17A3B38", VA = "0x7BBBFA3B38")]
		private static void OnGetLiveTvEsportsReserve(string param, string[] parameters, int webViewId, string promiseId)
		{
		}

		// Token: 0x0600C6E7 RID: 50919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6E7")]
		[Address(RVA = "0x17A3EBC", Offset = "0x17A3EBC", VA = "0x7BBBFA3EBC")]
		private static void OnGoToInternalBrowser(string param, string[] parameters, int webViewId, string promiseId)
		{
		}

		// Token: 0x0600C6E8 RID: 50920 RVA: 0x000355E0 File Offset: 0x000337E0
		[Token(Token = "0x600C6E8")]
		[Address(RVA = "0x17A408C", Offset = "0x17A408C", VA = "0x7BBBFA408C")]
		public static bool CanClearCookies()
		{
			return default(bool);
		}

		// Token: 0x0600C6E9 RID: 50921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6E9")]
		[Address(RVA = "0x17A415C", Offset = "0x17A415C", VA = "0x7BBBFA415C")]
		public static void ClearCookies()
		{
		}

		// Token: 0x0600C6EA RID: 50922 RVA: 0x000355F8 File Offset: 0x000337F8
		[Token(Token = "0x600C6EA")]
		[Address(RVA = "0x17A41F0", Offset = "0x17A41F0", VA = "0x7BBBFA41F0")]
		public static bool CanClearCache()
		{
			return default(bool);
		}

		// Token: 0x0600C6EB RID: 50923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6EB")]
		[Address(RVA = "0x17A42C0", Offset = "0x17A42C0", VA = "0x7BBBFA42C0")]
		public static void ClearCache()
		{
		}

		// Token: 0x0600C6EC RID: 50924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6EC")]
		[Address(RVA = "0x17A438C", Offset = "0x17A438C", VA = "0x7BBBFA438C")]
		private static void OnClearCache(string msg)
		{
		}

		// Token: 0x0600C6ED RID: 50925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6ED")]
		[Address(RVA = "0x17A4390", Offset = "0x17A4390", VA = "0x7BBBFA4390")]
		public static void DeleteLocalStorage()
		{
		}

		// Token: 0x0600C6EE RID: 50926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C6EE")]
		[Address(RVA = "0x1786B90", Offset = "0x1786B90", VA = "0x7BBBF86B90")]
		public WebView()
		{
		}

		// Token: 0x0400F94C RID: 63820
		[Token(Token = "0x400F94C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int m_Handler;

		// Token: 0x0400F94D RID: 63821
		[Token(Token = "0x400F94D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool promptedFaulty;

		// Token: 0x0400F94E RID: 63822
		[Token(Token = "0x400F94E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly WebView.AndroidWebViewUserAgentStringModification[] _AndroidWebViewUserAgentStringModifications;

		// Token: 0x0400F94F RID: 63823
		[Token(Token = "0x400F94F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _Url;

		// Token: 0x020025C9 RID: 9673
		[Token(Token = "0x20025C9")]
		public class Rect
		{
			// Token: 0x0600C6F0 RID: 50928 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C6F0")]
			[Address(RVA = "0x23DED2C", Offset = "0x23DED2C", VA = "0x7BBCBDED2C")]
			public Rect()
			{
			}

			// Token: 0x0600C6F1 RID: 50929 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C6F1")]
			[Address(RVA = "0x23DED34", Offset = "0x23DED34", VA = "0x7BBCBDED34")]
			public Rect(UIWidget widget)
			{
			}

			// Token: 0x0400F950 RID: 63824
			[Token(Token = "0x400F950")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float x;

			// Token: 0x0400F951 RID: 63825
			[Token(Token = "0x400F951")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float y;

			// Token: 0x0400F952 RID: 63826
			[Token(Token = "0x400F952")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float width;

			// Token: 0x0400F953 RID: 63827
			[Token(Token = "0x400F953")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float height;
		}

		// Token: 0x020025CA RID: 9674
		[Token(Token = "0x20025CA")]
		private class AndroidWebViewUserAgentStringModification
		{
			// Token: 0x0600C6F2 RID: 50930 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C6F2")]
			[Address(RVA = "0x23DED1C", Offset = "0x23DED1C", VA = "0x7BBCBDED1C")]
			public AndroidWebViewUserAgentStringModification()
			{
			}

			// Token: 0x0400F954 RID: 63828
			[Token(Token = "0x400F954")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string[] Patterns;

			// Token: 0x0400F955 RID: 63829
			[Token(Token = "0x400F955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<string, string> Mod;
		}

		// Token: 0x020025CB RID: 9675
		[Token(Token = "0x20025CB")]
		[Serializable]
		private class QualityLevel
		{
			// Token: 0x0600C6F3 RID: 50931 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C6F3")]
			[Address(RVA = "0x23DED24", Offset = "0x23DED24", VA = "0x7BBCBDED24")]
			public QualityLevel()
			{
			}

			// Token: 0x0400F956 RID: 63830
			[Token(Token = "0x400F956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int level;

			// Token: 0x0400F957 RID: 63831
			[Token(Token = "0x400F957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;
		}

		// Token: 0x020025CC RID: 9676
		[Token(Token = "0x20025CC")]
		public static class WebPage
		{
			// Token: 0x17000CD9 RID: 3289
			// (get) Token: 0x0600C6F4 RID: 50932 RVA: 0x00035610 File Offset: 0x00033810
			[Token(Token = "0x17000CD9")]
			public static bool AnimateOpenClose
			{
				[Token(Token = "0x600C6F4")]
				[Address(RVA = "0x23DEFB4", Offset = "0x23DEFB4", VA = "0x7BBCBDEFB4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600C6F5 RID: 50933 RVA: 0x00035628 File Offset: 0x00033828
			[Token(Token = "0x600C6F5")]
			[Address(RVA = "0x23DEFBC", Offset = "0x23DEFBC", VA = "0x7BBCBDEFBC")]
			public static bool IsSupported()
			{
				return default(bool);
			}

			// Token: 0x0600C6F6 RID: 50934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C6F6")]
			[Address(RVA = "0x23DF01C", Offset = "0x23DF01C", VA = "0x7BBCBDF01C")]
			public static void OpenWebPage(string url)
			{
			}

			// Token: 0x0600C6F7 RID: 50935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C6F7")]
			[Address(RVA = "0x23DF0B8", Offset = "0x23DF0B8", VA = "0x7BBCBDF0B8")]
			public static void CloseWebPage()
			{
			}

			// Token: 0x0600C6F8 RID: 50936 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C6F8")]
			[Address(RVA = "0x23DF11C", Offset = "0x23DF11C", VA = "0x7BBCBDF11C")]
			private static void OnWebPageClose()
			{
			}
		}

		// Token: 0x020025CD RID: 9677
		[Token(Token = "0x20025CD")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDE44", Offset = "0x10FDE44")]
		private sealed class <>c__DisplayClass40_0
		{
			// Token: 0x0600C6F9 RID: 50937 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C6F9")]
			[Address(RVA = "0x23DEC8C", Offset = "0x23DEC8C", VA = "0x7BBCBDEC8C")]
			public <>c__DisplayClass40_0()
			{
			}

			// Token: 0x0600C6FA RID: 50938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C6FA")]
			[Address(RVA = "0x23DEC94", Offset = "0x23DEC94", VA = "0x7BBCBDEC94")]
			internal void <OnGetUserAgent>b__0(int _webViewId, string userAgent)
			{
			}

			// Token: 0x0400F958 RID: 63832
			[Token(Token = "0x400F958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string promiseId;
		}

		// Token: 0x020025CE RID: 9678
		[Token(Token = "0x20025CE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10FDE54", Offset = "0x10FDE54")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x0600C6FC RID: 50940 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C6FC")]
			[Address(RVA = "0x23DEC0C", Offset = "0x23DEC0C", VA = "0x7BBCBDEC0C")]
			public <>c()
			{
			}

			// Token: 0x0600C6FD RID: 50941 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600C6FD")]
			[Address(RVA = "0x23DEC14", Offset = "0x23DEC14", VA = "0x7BBCBDEC14")]
			internal string <.cctor>b__54_0(string userAgentString)
			{
				return null;
			}

			// Token: 0x0400F959 RID: 63833
			[Token(Token = "0x400F959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly WebView.<>c <>9;
		}
	}
}
