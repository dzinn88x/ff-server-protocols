using System;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW
{
	// Token: 0x020012D8 RID: 4824
	[Token(Token = "0x20012D8")]
	internal class HttpRequestMonitor : IHttpManagerMonitor
	{
		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06004C05 RID: 19461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000854")]
		public static HttpRequestMonitor Instance
		{
			[Token(Token = "0x6004C05")]
			[Address(RVA = "0x18590D0", Offset = "0x18590D0", VA = "0x7BBC0590D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004C06 RID: 19462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C06")]
		[Address(RVA = "0x1859158", Offset = "0x1859158", VA = "0x7BBC059158", Slot = "4")]
		public void OnStartRequest(HttpManager.EHttpChannel channel, HttpRequest curHttpReq)
		{
		}

		// Token: 0x06004C07 RID: 19463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C07")]
		[Address(RVA = "0x1859314", Offset = "0x1859314", VA = "0x7BBC059314", Slot = "5")]
		public void OnEndRequest(HttpManager.EHttpChannel channel, string cmd, bool hasNext)
		{
		}

		// Token: 0x06004C08 RID: 19464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C08")]
		[Address(RVA = "0x18593DC", Offset = "0x18593DC", VA = "0x7BBC0593DC", Slot = "6")]
		public void OnUnauthorized(HttpManager.EHttpChannel channel)
		{
		}

		// Token: 0x06004C09 RID: 19465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C09")]
		[Address(RVA = "0x18593E0", Offset = "0x18593E0", VA = "0x7BBC0593E0", Slot = "7")]
		public void OnRetryFailed(HttpManager.EHttpChannel channel, HttpRequest curHttpReq)
		{
		}

		// Token: 0x06004C0A RID: 19466 RVA: 0x00016CB0 File Offset: 0x00014EB0
		[Token(Token = "0x6004C0A")]
		[Address(RVA = "0x18596C8", Offset = "0x18596C8", VA = "0x7BBC0596C8")]
		public bool IsQueueningHttpMessageType(ServiceMessageTypeHTTP httpMessgeType, ref HttpRequest httpReq)
		{
			return default(bool);
		}

		// Token: 0x06004C0B RID: 19467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C0B")]
		[Address(RVA = "0x1859150", Offset = "0x1859150", VA = "0x7BBC059150")]
		public HttpRequestMonitor()
		{
		}

		// Token: 0x040073EA RID: 29674
		[Token(Token = "0x40073EA")]
		[FieldOffset(Offset = "0x0")]
		private static HttpRequestMonitor instance;

		// Token: 0x020012D9 RID: 4825
		[Token(Token = "0x20012D9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x10EB0D8", Offset = "0x10EB0D8")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004C0D RID: 19469 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C0D")]
			[Address(RVA = "0x185982C", Offset = "0x185982C", VA = "0x7BBC05982C")]
			public <>c()
			{
			}

			// Token: 0x06004C0E RID: 19470 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004C0E")]
			[Address(RVA = "0x1859834", Offset = "0x1859834", VA = "0x7BBC059834")]
			internal void <OnRetryFailed>b__6_0()
			{
			}

			// Token: 0x040073EB RID: 29675
			[Token(Token = "0x40073EB")]
			[FieldOffset(Offset = "0x0")]
			public static readonly HttpRequestMonitor.<>c <>9;

			// Token: 0x040073EC RID: 29676
			[Token(Token = "0x40073EC")]
			[FieldOffset(Offset = "0x8")]
			public static Action <>9__6_0;
		}
	}
}
