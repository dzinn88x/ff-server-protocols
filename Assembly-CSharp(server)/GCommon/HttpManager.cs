using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Il2CppDummyDll;
using TsiU;

namespace GCommon
{
	// Token: 0x02000F76 RID: 3958
	[Token(Token = "0x2000F76")]
	public class HttpManager : TSingleton<HttpManager>
	{
		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06003992 RID: 14738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006E0")]
		public string LastErrorMessage
		{
			[Token(Token = "0x6003992")]
			[Address(RVA = "0x211D690", Offset = "0x211D690", VA = "0x7BBC91D690")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003993 RID: 14739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003993")]
		[Address(RVA = "0x211D7CC", Offset = "0x211D7CC", VA = "0x7BBC91D7CC")]
		public void Init()
		{
		}

		// Token: 0x06003994 RID: 14740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003994")]
		[Address(RVA = "0x211DFBC", Offset = "0x211DFBC", VA = "0x7BBC91DFBC")]
		public void SetImpl(IHttpManagerMonitor impl)
		{
		}

		// Token: 0x06003995 RID: 14741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003995")]
		[Address(RVA = "0x211DFC4", Offset = "0x211DFC4", VA = "0x7BBC91DFC4")]
		public void UpdateTokenInfo(string token, uint ttl)
		{
		}

		// Token: 0x06003996 RID: 14742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003996")]
		[Address(RVA = "0x211E018", Offset = "0x211E018", VA = "0x7BBC91E018")]
		public string GetToken()
		{
			return null;
		}

		// Token: 0x06003997 RID: 14743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003997")]
		[Address(RVA = "0x211E044", Offset = "0x211E044", VA = "0x7BBC91E044")]
		public void Clear()
		{
		}

		// Token: 0x06003998 RID: 14744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003998")]
		[Address(RVA = "0x2116C8C", Offset = "0x2116C8C", VA = "0x7BBC916C8C")]
		public void Update(float gameTime)
		{
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003999")]
		public HttpRequest RequestPost<T>(string url, string cmd, object data, [Optional] Action<HttpErrorCode, object> onFinished, float timeout = 0f, uint http_option = 0U, EHttpDataType reqDataType = EHttpDataType.None, EHttpDataType resDataType = EHttpDataType.None, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool encrypt = true)
		{
			return null;
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600399A")]
		public void RequestGet<T>(string url, string cmd, Action<HttpErrorCode, object> onFinished, float timeout, uint http_option = 0U, EHttpDataType resDataType = EHttpDataType.None, params object[] args)
		{
		}

		// Token: 0x0600399B RID: 14747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399B")]
		[Address(RVA = "0x211EB78", Offset = "0x211EB78", VA = "0x7BBC91EB78")]
		private HttpRequest CreatePostReq(string url, string cmd, object data, EHttpDataType reqDataType = EHttpDataType.None, EHttpDataType resDataType = EHttpDataType.None)
		{
			return null;
		}

		// Token: 0x0600399C RID: 14748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399C")]
		private HttpRequest CreatePostReq<T>(string url, string cmd, object data, Action<HttpErrorCode, object> onFinished, float timeout = 0f, uint http_option = 0U, EHttpDataType reqDataType = EHttpDataType.None, EHttpDataType resDataType = EHttpDataType.None, bool encrypt = true)
		{
			return null;
		}

		// Token: 0x0600399D RID: 14749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399D")]
		[Address(RVA = "0x211F064", Offset = "0x211F064", VA = "0x7BBC91F064")]
		public byte[] Encrypt(byte[] data)
		{
			return null;
		}

		// Token: 0x0600399E RID: 14750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399E")]
		[Address(RVA = "0x211F374", Offset = "0x211F374", VA = "0x7BBC91F374")]
		public byte[] Decrypt(byte[] data)
		{
			return null;
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x00011D48 File Offset: 0x0000FF48
		[Token(Token = "0x600399F")]
		[Address(RVA = "0x211F684", Offset = "0x211F684", VA = "0x7BBC91F684")]
		public bool IsCmdInQueue(string cmd, ref HttpRequest httpReq)
		{
			return default(bool);
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039A0")]
		[Address(RVA = "0x211F810", Offset = "0x211F810", VA = "0x7BBC91F810")]
		public HttpManager()
		{
		}

		// Token: 0x04004B23 RID: 19235
		[Token(Token = "0x4004B23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly uint HTTPOPTION_DEFAULT;

		// Token: 0x04004B24 RID: 19236
		[Token(Token = "0x4004B24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly uint HTTPOPTION_SILENCE;

		// Token: 0x04004B25 RID: 19237
		[Token(Token = "0x4004B25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly uint HTTPOPTION_BLOCK;

		// Token: 0x04004B26 RID: 19238
		[Token(Token = "0x4004B26")]
		private const float DEFAULT_TIMEOUT = 10f;

		// Token: 0x04004B27 RID: 19239
		[Token(Token = "0x4004B27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<HttpManager.EHttpChannel, HttpManager.HttpChannel> m_HttpChannels;

		// Token: 0x04004B28 RID: 19240
		[Token(Token = "0x4004B28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private HttpManager.TokenInfo m_TokenInfo;

		// Token: 0x04004B29 RID: 19241
		[Token(Token = "0x4004B29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IHttpManagerMonitor m_Impl;

		// Token: 0x04004B2A RID: 19242
		[Token(Token = "0x4004B2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private EHttpDataType m_ReqDataType;

		// Token: 0x04004B2B RID: 19243
		[Token(Token = "0x4004B2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private EHttpDataType m_ResDataType;

		// Token: 0x04004B2C RID: 19244
		[Token(Token = "0x4004B2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AesManaged m_aes;

		// Token: 0x04004B2D RID: 19245
		[Token(Token = "0x4004B2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_EnableEncrypt;

		// Token: 0x02000F77 RID: 3959
		[Token(Token = "0x2000F77")]
		private class TimeoutTimer
		{
			// Token: 0x060039A2 RID: 14754 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039A2")]
			[Address(RVA = "0x211FAB8", Offset = "0x211FAB8", VA = "0x7BBC91FAB8")]
			public void Start(float gameTime, float timeout)
			{
			}

			// Token: 0x060039A3 RID: 14755 RVA: 0x00011D60 File Offset: 0x0000FF60
			[Token(Token = "0x60039A3")]
			[Address(RVA = "0x211FAC4", Offset = "0x211FAC4", VA = "0x7BBC91FAC4")]
			public bool IsExpired(float gameTime)
			{
				return default(bool);
			}

			// Token: 0x060039A4 RID: 14756 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039A4")]
			[Address(RVA = "0x211F8F8", Offset = "0x211F8F8", VA = "0x7BBC91F8F8")]
			public TimeoutTimer()
			{
			}

			// Token: 0x04004B2E RID: 19246
			[Token(Token = "0x4004B2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private float m_EndTime;
		}

		// Token: 0x02000F78 RID: 3960
		[Token(Token = "0x2000F78")]
		private class TokenInfo
		{
			// Token: 0x060039A5 RID: 14757 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039A5")]
			[Address(RVA = "0x211DF58", Offset = "0x211DF58", VA = "0x7BBC91DF58")]
			public TokenInfo()
			{
			}

			// Token: 0x04004B2F RID: 19247
			[Token(Token = "0x4004B2F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Token;

			// Token: 0x04004B30 RID: 19248
			[Token(Token = "0x4004B30")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint TTL;
		}

		// Token: 0x02000F79 RID: 3961
		[Token(Token = "0x2000F79")]
		public enum EHttpChannel
		{
			// Token: 0x04004B32 RID: 19250
			[Token(Token = "0x4004B32")]
			Main,
			// Token: 0x04004B33 RID: 19251
			[Token(Token = "0x4004B33")]
			Second
		}

		// Token: 0x02000F7A RID: 3962
		[Token(Token = "0x2000F7A")]
		public class HttpChannel
		{
			// Token: 0x060039A6 RID: 14758 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039A6")]
			[Address(RVA = "0x211DEB0", Offset = "0x211DEB0", VA = "0x7BBC91DEB0")]
			public HttpChannel(bool supportRetry = false)
			{
			}

			// Token: 0x060039A7 RID: 14759 RVA: 0x00011D78 File Offset: 0x0000FF78
			[Token(Token = "0x60039A7")]
			[Address(RVA = "0x211E35C", Offset = "0x211E35C", VA = "0x7BBC91E35C")]
			public bool SupportRetry()
			{
				return default(bool);
			}

			// Token: 0x060039A8 RID: 14760 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60039A8")]
			[Address(RVA = "0x211D72C", Offset = "0x211D72C", VA = "0x7BBC91D72C")]
			public HttpRequest GetCurrentRequest()
			{
				return null;
			}

			// Token: 0x060039A9 RID: 14761 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039A9")]
			[Address(RVA = "0x211F900", Offset = "0x211F900", VA = "0x7BBC91F900")]
			public void Append(HttpRequest req)
			{
			}

			// Token: 0x060039AA RID: 14762 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039AA")]
			[Address(RVA = "0x211EB24", Offset = "0x211EB24", VA = "0x7BBC91EB24")]
			public void StartSend(string token, float gameTime, HttpRequest req)
			{
			}

			// Token: 0x060039AB RID: 14763 RVA: 0x00011D90 File Offset: 0x0000FF90
			[Token(Token = "0x60039AB")]
			[Address(RVA = "0x211E284", Offset = "0x211E284", VA = "0x7BBC91E284")]
			public bool IsExpired(float gameTime, HttpRequest req)
			{
				return default(bool);
			}

			// Token: 0x060039AC RID: 14764 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039AC")]
			[Address(RVA = "0x211E374", Offset = "0x211E374", VA = "0x7BBC91E374")]
			public void Done(HttpRequest req)
			{
			}

			// Token: 0x060039AD RID: 14765 RVA: 0x00011DA8 File Offset: 0x0000FFA8
			[Token(Token = "0x60039AD")]
			[Address(RVA = "0x211EAB4", Offset = "0x211EAB4", VA = "0x7BBC91EAB4")]
			public int ReuqestCount()
			{
				return 0;
			}

			// Token: 0x060039AE RID: 14766 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60039AE")]
			[Address(RVA = "0x211E210", Offset = "0x211E210", VA = "0x7BBC91E210")]
			public void Clear()
			{
			}

			// Token: 0x04004B34 RID: 19252
			[Token(Token = "0x4004B34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Queue<HttpRequest> m_Requests;

			// Token: 0x04004B35 RID: 19253
			[Token(Token = "0x4004B35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private HttpManager.TimeoutTimer m_TimeoutTimer;

			// Token: 0x04004B36 RID: 19254
			[Token(Token = "0x4004B36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private bool m_SupportRetry;
		}
	}
}
