using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F66 RID: 3942
	[Token(Token = "0x2000F66")]
	internal class UnityWebViewInstanceHandler : MonoBehaviour
	{
		// Token: 0x0600394A RID: 14666 RVA: 0x00011C28 File Offset: 0x0000FE28
		[Token(Token = "0x600394A")]
		[Address(RVA = "0x2243364", Offset = "0x2243364", VA = "0x7BBCA43364")]
		private static int NewInstanceId()
		{
			return 0;
		}

		// Token: 0x0600394B RID: 14667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600394B")]
		[Address(RVA = "0x223E1FC", Offset = "0x223E1FC", VA = "0x7BBCA3E1FC")]
		public static UnityWebViewInstanceHandler Create()
		{
			return null;
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600394C")]
		[Address(RVA = "0x223E640", Offset = "0x223E640", VA = "0x7BBCA3E640")]
		public static void Bind(int webViewId, UnityWebViewInstanceHandler handler)
		{
		}

		// Token: 0x0600394D RID: 14669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600394D")]
		[Address(RVA = "0x223EA74", Offset = "0x223EA74", VA = "0x7BBCA3EA74")]
		public static void Destroy(int webViewId)
		{
		}

		// Token: 0x0600394E RID: 14670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600394E")]
		[Address(RVA = "0x223ED58", Offset = "0x223ED58", VA = "0x7BBCA3ED58")]
		public static void DestroyAll()
		{
		}

		// Token: 0x0600394F RID: 14671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600394F")]
		[Address(RVA = "0x22433D4", Offset = "0x22433D4", VA = "0x7BBCA433D4")]
		public void CanGoBackwardResult(string result)
		{
		}

		// Token: 0x06003950 RID: 14672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003950")]
		[Address(RVA = "0x2243578", Offset = "0x2243578", VA = "0x7BBCA43578")]
		public void CanGoForwardResult(string result)
		{
		}

		// Token: 0x06003951 RID: 14673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003951")]
		[Address(RVA = "0x224371C", Offset = "0x224371C", VA = "0x7BBCA4371C")]
		public void OnJavaScriptPostMessage(string data)
		{
		}

		// Token: 0x06003952 RID: 14674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003952")]
		[Address(RVA = "0x2243808", Offset = "0x2243808", VA = "0x7BBCA43808")]
		public void OnJavaScriptResult(string javaScriptResultString)
		{
		}

		// Token: 0x06003953 RID: 14675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003953")]
		[Address(RVA = "0x22438F4", Offset = "0x22438F4", VA = "0x7BBCA438F4")]
		public void OnWebViewMessage_Android(string msg)
		{
		}

		// Token: 0x06003954 RID: 14676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003954")]
		[Address(RVA = "0x22439AC", Offset = "0x22439AC", VA = "0x7BBCA439AC")]
		public void OnConsoleMessage_Android(string consoleMessage)
		{
		}

		// Token: 0x06003955 RID: 14677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003955")]
		[Address(RVA = "0x2243CA4", Offset = "0x2243CA4", VA = "0x7BBCA43CA4")]
		public void OnGetUserAgentString(string userAgent)
		{
		}

		// Token: 0x06003956 RID: 14678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003956")]
		[Address(RVA = "0x2243D90", Offset = "0x2243D90", VA = "0x7BBCA43D90")]
		public UnityWebViewInstanceHandler()
		{
		}

		// Token: 0x04004AF8 RID: 19192
		[Token(Token = "0x4004AF8")]
		private const string UNITY_WEBVIEW_INSTANCE_HANDLER_TEMPLATE = "UnityWebViewInstanceHandler_{0}";

		// Token: 0x04004AF9 RID: 19193
		[Token(Token = "0x4004AF9")]
		[FieldOffset(Offset = "0x0")]
		private static int _NextInstanceId;

		// Token: 0x04004AFA RID: 19194
		[Token(Token = "0x4004AFA")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<int, UnityWebViewInstanceHandler> _Handlers;

		// Token: 0x04004AFB RID: 19195
		[Token(Token = "0x4004AFB")]
		[FieldOffset(Offset = "0x18")]
		private int _WebViewId;

		// Token: 0x02000F67 RID: 3943
		[Token(Token = "0x2000F67")]
		[Serializable]
		private struct ConsoleMessage_Android
		{
			// Token: 0x04004AFC RID: 19196
			[Token(Token = "0x4004AFC")]
			[FieldOffset(Offset = "0x0")]
			public string messageLevel;

			// Token: 0x04004AFD RID: 19197
			[Token(Token = "0x4004AFD")]
			[FieldOffset(Offset = "0x8")]
			public int lineNumber;

			// Token: 0x04004AFE RID: 19198
			[Token(Token = "0x4004AFE")]
			[FieldOffset(Offset = "0x10")]
			public string message;

			// Token: 0x04004AFF RID: 19199
			[Token(Token = "0x4004AFF")]
			[FieldOffset(Offset = "0x18")]
			public string sourceId;
		}

		// Token: 0x02000F68 RID: 3944
		[Token(Token = "0x2000F68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA4D0", Offset = "0x10EA4D0")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06003958 RID: 14680 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003958")]
			[Address(RVA = "0x2243570", Offset = "0x2243570", VA = "0x7BBCA43570")]
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x06003959 RID: 14681 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003959")]
			[Address(RVA = "0x2244298", Offset = "0x2244298", VA = "0x7BBCA44298")]
			internal void <CanGoBackwardResult>b__0()
			{
			}

			// Token: 0x04004B00 RID: 19200
			[Token(Token = "0x4004B00")]
			[FieldOffset(Offset = "0x10")]
			public UnityWebViewInstanceHandler <>4__this;

			// Token: 0x04004B01 RID: 19201
			[Token(Token = "0x4004B01")]
			[FieldOffset(Offset = "0x18")]
			public bool canGoBackward;
		}

		// Token: 0x02000F69 RID: 3945
		[Token(Token = "0x2000F69")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA4E0", Offset = "0x10EA4E0")]
		private sealed class <>c__DisplayClass10_0
		{
			// Token: 0x0600395A RID: 14682 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600395A")]
			[Address(RVA = "0x2243714", Offset = "0x2243714", VA = "0x7BBCA43714")]
			public <>c__DisplayClass10_0()
			{
			}

			// Token: 0x0600395B RID: 14683 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600395B")]
			[Address(RVA = "0x2243E18", Offset = "0x2243E18", VA = "0x7BBCA43E18")]
			internal void <CanGoForwardResult>b__0()
			{
			}

			// Token: 0x04004B02 RID: 19202
			[Token(Token = "0x4004B02")]
			[FieldOffset(Offset = "0x10")]
			public UnityWebViewInstanceHandler <>4__this;

			// Token: 0x04004B03 RID: 19203
			[Token(Token = "0x4004B03")]
			[FieldOffset(Offset = "0x18")]
			public bool canGoForward;
		}

		// Token: 0x02000F6A RID: 3946
		[Token(Token = "0x2000F6A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA4F0", Offset = "0x10EA4F0")]
		private sealed class <>c__DisplayClass11_0
		{
			// Token: 0x0600395C RID: 14684 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600395C")]
			[Address(RVA = "0x2243800", Offset = "0x2243800", VA = "0x7BBCA43800")]
			public <>c__DisplayClass11_0()
			{
			}

			// Token: 0x0600395D RID: 14685 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600395D")]
			[Address(RVA = "0x2243E9C", Offset = "0x2243E9C", VA = "0x7BBCA43E9C")]
			internal void <OnJavaScriptPostMessage>b__0()
			{
			}

			// Token: 0x04004B04 RID: 19204
			[Token(Token = "0x4004B04")]
			[FieldOffset(Offset = "0x10")]
			public UnityWebViewInstanceHandler <>4__this;

			// Token: 0x04004B05 RID: 19205
			[Token(Token = "0x4004B05")]
			[FieldOffset(Offset = "0x18")]
			public string data;
		}

		// Token: 0x02000F6B RID: 3947
		[Token(Token = "0x2000F6B")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA500", Offset = "0x10EA500")]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x0600395E RID: 14686 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600395E")]
			[Address(RVA = "0x22438EC", Offset = "0x22438EC", VA = "0x7BBCA438EC")]
			public <>c__DisplayClass12_0()
			{
			}

			// Token: 0x0600395F RID: 14687 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600395F")]
			[Address(RVA = "0x2243F7C", Offset = "0x2243F7C", VA = "0x7BBCA43F7C")]
			internal void <OnJavaScriptResult>b__0()
			{
			}

			// Token: 0x04004B06 RID: 19206
			[Token(Token = "0x4004B06")]
			[FieldOffset(Offset = "0x10")]
			public UnityWebViewInstanceHandler <>4__this;

			// Token: 0x04004B07 RID: 19207
			[Token(Token = "0x4004B07")]
			[FieldOffset(Offset = "0x18")]
			public string javaScriptResultString;
		}

		// Token: 0x02000F6C RID: 3948
		[Token(Token = "0x2000F6C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EA510", Offset = "0x10EA510")]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06003960 RID: 14688 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003960")]
			[Address(RVA = "0x2243D88", Offset = "0x2243D88", VA = "0x7BBCA43D88")]
			public <>c__DisplayClass16_0()
			{
			}

			// Token: 0x06003961 RID: 14689 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003961")]
			[Address(RVA = "0x2244218", Offset = "0x2244218", VA = "0x7BBCA44218")]
			internal void <OnGetUserAgentString>b__0()
			{
			}

			// Token: 0x04004B08 RID: 19208
			[Token(Token = "0x4004B08")]
			[FieldOffset(Offset = "0x10")]
			public UnityWebViewInstanceHandler <>4__this;

			// Token: 0x04004B09 RID: 19209
			[Token(Token = "0x4004B09")]
			[FieldOffset(Offset = "0x18")]
			public string userAgent;
		}
	}
}
