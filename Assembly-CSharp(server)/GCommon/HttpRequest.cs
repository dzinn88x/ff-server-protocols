using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon
{
	// Token: 0x02000F7B RID: 3963
	[Token(Token = "0x2000F7B")]
	public class HttpRequest
	{
		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060039AF RID: 14767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006E1")]
		public string LastErrorMessage
		{
			[Token(Token = "0x60039AF")]
			[Address(RVA = "0x211D7C4", Offset = "0x211D7C4", VA = "0x7BBC91D7C4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B0")]
		[Address(RVA = "0x211F970", Offset = "0x211F970", VA = "0x7BBC91F970")]
		public void Start(string token)
		{
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		[Token(Token = "0x60039B1")]
		[Address(RVA = "0x211E364", Offset = "0x211E364", VA = "0x7BBC91E364")]
		public bool NeedRetry()
		{
			return default(bool);
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x00011DD8 File Offset: 0x0000FFD8
		[Token(Token = "0x60039B2")]
		[Address(RVA = "0x211FAD4", Offset = "0x211FAD4", VA = "0x7BBC91FAD4")]
		public bool HasRetried()
		{
			return default(bool);
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x00011DF0 File Offset: 0x0000FFF0
		[Token(Token = "0x60039B3")]
		[Address(RVA = "0x211EB14", Offset = "0x211EB14", VA = "0x7BBC91EB14")]
		public bool IsStarted()
		{
			return default(bool);
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x00011E08 File Offset: 0x00010008
		[Token(Token = "0x60039B4")]
		[Address(RVA = "0x211E270", Offset = "0x211E270", VA = "0x7BBC91E270")]
		public bool IsFinished()
		{
			return default(bool);
		}

		// Token: 0x060039B5 RID: 14773 RVA: 0x00011E20 File Offset: 0x00010020
		[Token(Token = "0x60039B5")]
		[Address(RVA = "0x211E2E8", Offset = "0x211E2E8", VA = "0x7BBC91E2E8")]
		public bool IsUnauthorized()
		{
			return default(bool);
		}

		// Token: 0x060039B6 RID: 14774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B6")]
		[Address(RVA = "0x211E424", Offset = "0x211E424", VA = "0x7BBC91E424")]
		public void Notify()
		{
		}

		// Token: 0x060039B7 RID: 14775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B7")]
		[Address(RVA = "0x211E1D8", Offset = "0x211E1D8", VA = "0x7BBC91E1D8")]
		public void Dispose()
		{
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x00011E38 File Offset: 0x00010038
		[Token(Token = "0x60039B8")]
		[Address(RVA = "0x211FAE4", Offset = "0x211FAE4", VA = "0x7BBC91FAE4")]
		private HttpErrorCode GetResponseCode()
		{
			return HttpErrorCode.OK;
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x00011E50 File Offset: 0x00010050
		[Token(Token = "0x60039B9")]
		[Address(RVA = "0x2120180", Offset = "0x2120180", VA = "0x7BBC920180")]
		private HttpErrorCode GetDetailedExectionError()
		{
			return HttpErrorCode.OK;
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039BA")]
		[Address(RVA = "0x211FC70", Offset = "0x211FC70", VA = "0x7BBC91FC70")]
		private void InvokeFinished(HttpErrorCode errorCode, object res, string errorMsg)
		{
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039BB")]
		[Address(RVA = "0x211F05C", Offset = "0x211F05C", VA = "0x7BBC91F05C")]
		public HttpRequest()
		{
		}

		// Token: 0x04004B37 RID: 19255
		[Token(Token = "0x4004B37")]
		[FieldOffset(Offset = "0x0")]
		public static bool DelegateCheck;

		// Token: 0x04004B38 RID: 19256
		[Token(Token = "0x4004B38")]
		private const int MAX_RETRY_COUNT = 5;

		// Token: 0x04004B39 RID: 19257
		[Token(Token = "0x4004B39")]
		[FieldOffset(Offset = "0x10")]
		public string URL;

		// Token: 0x04004B3A RID: 19258
		[Token(Token = "0x4004B3A")]
		[FieldOffset(Offset = "0x18")]
		public string Cmd;

		// Token: 0x04004B3B RID: 19259
		[Token(Token = "0x4004B3B")]
		[FieldOffset(Offset = "0x20")]
		public float Timeout;

		// Token: 0x04004B3C RID: 19260
		[Token(Token = "0x4004B3C")]
		[FieldOffset(Offset = "0x28")]
		public byte[] Data;

		// Token: 0x04004B3D RID: 19261
		[Token(Token = "0x4004B3D")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, string> Headers;

		// Token: 0x04004B3E RID: 19262
		[Token(Token = "0x4004B3E")]
		[FieldOffset(Offset = "0x38")]
		public WWW www;

		// Token: 0x04004B3F RID: 19263
		[Token(Token = "0x4004B3F")]
		[FieldOffset(Offset = "0x40")]
		public Action<HttpErrorCode, object> OnFinished;

		// Token: 0x04004B40 RID: 19264
		[Token(Token = "0x4004B40")]
		[FieldOffset(Offset = "0x48")]
		public Type ResponseType;

		// Token: 0x04004B41 RID: 19265
		[Token(Token = "0x4004B41")]
		[FieldOffset(Offset = "0x50")]
		public EHttpDataType DataType;

		// Token: 0x04004B42 RID: 19266
		[Token(Token = "0x4004B42")]
		[FieldOffset(Offset = "0x54")]
		public uint HttpOption;

		// Token: 0x04004B43 RID: 19267
		[Token(Token = "0x4004B43")]
		[FieldOffset(Offset = "0x58")]
		public bool IsDone;

		// Token: 0x04004B44 RID: 19268
		[Token(Token = "0x4004B44")]
		[FieldOffset(Offset = "0x5C")]
		private int m_SendCount;

		// Token: 0x04004B45 RID: 19269
		[Token(Token = "0x4004B45")]
		[FieldOffset(Offset = "0x60")]
		private string m_LastErrorMessage;
	}
}
