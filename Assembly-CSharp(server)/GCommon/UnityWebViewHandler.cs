using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F65 RID: 3941
	[Token(Token = "0x2000F65")]
	internal class UnityWebViewHandler : MonoBehaviour
	{
		// Token: 0x06003946 RID: 14662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003946")]
		[Address(RVA = "0x223D67C", Offset = "0x223D67C", VA = "0x7BBCA3D67C")]
		public static void Init()
		{
		}

		// Token: 0x06003947 RID: 14663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003947")]
		[Address(RVA = "0x2243274", Offset = "0x2243274", VA = "0x7BBCA43274")]
		public void OnClearCache(string msg)
		{
		}

		// Token: 0x06003948 RID: 14664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003948")]
		[Address(RVA = "0x22432D8", Offset = "0x22432D8", VA = "0x7BBCA432D8")]
		public void OnWebViewMessage_Android(string msg)
		{
		}

		// Token: 0x06003949 RID: 14665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003949")]
		[Address(RVA = "0x224335C", Offset = "0x224335C", VA = "0x7BBCA4335C")]
		public UnityWebViewHandler()
		{
		}

		// Token: 0x04004AF6 RID: 19190
		[Token(Token = "0x4004AF6")]
		private const string UNITY_WEBVIEW_HANDLER = "UnityWebViewHandler";

		// Token: 0x04004AF7 RID: 19191
		[Token(Token = "0x4004AF7")]
		[FieldOffset(Offset = "0x0")]
		private static UnityWebViewHandler _I;
	}
}
