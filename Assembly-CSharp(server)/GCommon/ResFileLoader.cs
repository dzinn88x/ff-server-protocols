using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon
{
	// Token: 0x02000FC8 RID: 4040
	[Token(Token = "0x2000FC8")]
	public class ResFileLoader
	{
		// Token: 0x06003B08 RID: 15112 RVA: 0x00012558 File Offset: 0x00010758
		[Token(Token = "0x6003B08")]
		[Address(RVA = "0x29622E8", Offset = "0x29622E8", VA = "0x7BBD1622E8")]
		public static ResErrorCode MapToErrorCode(string error)
		{
			return ResErrorCode.OK;
		}

		// Token: 0x06003B09 RID: 15113 RVA: 0x00012570 File Offset: 0x00010770
		[Token(Token = "0x6003B09")]
		[Address(RVA = "0x2960EE8", Offset = "0x2960EE8", VA = "0x7BBD160EE8")]
		public static bool CheckHttpResposeCode(long response_code)
		{
			return default(bool);
		}

		// Token: 0x06003B0A RID: 15114 RVA: 0x00012588 File Offset: 0x00010788
		[Token(Token = "0x6003B0A")]
		[Address(RVA = "0x2961848", Offset = "0x2961848", VA = "0x7BBD161848")]
		public static bool IsDiskFull(ResFileLoader loader)
		{
			return default(bool);
		}

		// Token: 0x06003B0B RID: 15115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B0B")]
		[Address(RVA = "0x29623B0", Offset = "0x29623B0", VA = "0x7BBD1623B0")]
		public ResFileLoader()
		{
		}

		// Token: 0x06003B0C RID: 15116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B0C")]
		[Address(RVA = "0x29623D8", Offset = "0x29623D8", VA = "0x7BBD1623D8")]
		public void Start(float time)
		{
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B0D")]
		[Address(RVA = "0x2962494", Offset = "0x2962494", VA = "0x7BBD162494")]
		public void Notify()
		{
		}

		// Token: 0x06003B0E RID: 15118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B0E")]
		[Address(RVA = "0x2961DD8", Offset = "0x2961DD8", VA = "0x7BBD161DD8")]
		public void Dispose()
		{
		}

		// Token: 0x06003B0F RID: 15119 RVA: 0x000125A0 File Offset: 0x000107A0
		[Token(Token = "0x6003B0F")]
		[Address(RVA = "0x29624A0", Offset = "0x29624A0", VA = "0x7BBD1624A0")]
		public float UpdateProgress(float time)
		{
			return 0f;
		}

		// Token: 0x06003B10 RID: 15120 RVA: 0x000125B8 File Offset: 0x000107B8
		[Token(Token = "0x6003B10")]
		[Address(RVA = "0x2962504", Offset = "0x2962504", VA = "0x7BBD162504", Slot = "4")]
		public virtual long GetDownloadingSize()
		{
			return 0L;
		}

		// Token: 0x06003B11 RID: 15121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B11")]
		[Address(RVA = "0x2960EE0", Offset = "0x2960EE0", VA = "0x7BBD160EE0")]
		protected void SetRequestError(string error)
		{
		}

		// Token: 0x06003B12 RID: 15122 RVA: 0x000125D0 File Offset: 0x000107D0
		[Token(Token = "0x6003B12")]
		[Address(RVA = "0x2961D68", Offset = "0x2961D68", VA = "0x7BBD161D68")]
		public bool HaveError()
		{
			return default(bool);
		}

		// Token: 0x06003B13 RID: 15123 RVA: 0x000125E8 File Offset: 0x000107E8
		[Token(Token = "0x6003B13")]
		[Address(RVA = "0x296251C", Offset = "0x296251C", VA = "0x7BBD16251C", Slot = "5")]
		public virtual bool IsTimeout(float time)
		{
			return default(bool);
		}

		// Token: 0x06003B14 RID: 15124 RVA: 0x00012600 File Offset: 0x00010800
		[Token(Token = "0x6003B14")]
		[Address(RVA = "0x2962524", Offset = "0x2962524", VA = "0x7BBD162524", Slot = "6")]
		public virtual bool IsFinished()
		{
			return default(bool);
		}

		// Token: 0x06003B15 RID: 15125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B15")]
		[Address(RVA = "0x296252C", Offset = "0x296252C", VA = "0x7BBD16252C", Slot = "7")]
		protected virtual void OnStart(float time)
		{
		}

		// Token: 0x06003B16 RID: 15126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B16")]
		[Address(RVA = "0x2960CC8", Offset = "0x2960CC8", VA = "0x7BBD160CC8", Slot = "8")]
		protected virtual void OnDispose()
		{
		}

		// Token: 0x06003B17 RID: 15127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B17")]
		[Address(RVA = "0x2962530", Offset = "0x2962530", VA = "0x7BBD162530", Slot = "9")]
		protected virtual void OnNotify()
		{
		}

		// Token: 0x06003B18 RID: 15128 RVA: 0x00012618 File Offset: 0x00010818
		[Token(Token = "0x6003B18")]
		[Address(RVA = "0x2962534", Offset = "0x2962534", VA = "0x7BBD162534", Slot = "10")]
		public virtual bool HasStarted()
		{
			return default(bool);
		}

		// Token: 0x06003B19 RID: 15129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B19")]
		[Address(RVA = "0x296253C", Offset = "0x296253C", VA = "0x7BBD16253C", Slot = "11")]
		protected virtual void OnUpdate(float time)
		{
		}

		// Token: 0x06003B1A RID: 15130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B1A")]
		[Address(RVA = "0x2961DD4", Offset = "0x2961DD4", VA = "0x7BBD161DD4", Slot = "12")]
		public virtual void OnPause()
		{
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x00012630 File Offset: 0x00010830
		[Token(Token = "0x6003B1B")]
		[Address(RVA = "0x2962540", Offset = "0x2962540", VA = "0x7BBD162540", Slot = "13")]
		public virtual long NeedDownloadSize()
		{
			return 0L;
		}

		// Token: 0x04004C93 RID: 19603
		[Token(Token = "0x4004C93")]
		protected const long HTTP_OK = 200L;

		// Token: 0x04004C94 RID: 19604
		[Token(Token = "0x4004C94")]
		protected const long HTTP_PartialOK = 206L;

		// Token: 0x04004C95 RID: 19605
		[Token(Token = "0x4004C95")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string ERR_OK;

		// Token: 0x04004C96 RID: 19606
		[Token(Token = "0x4004C96")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string ERR_SAVE_TEMP_FAILED;

		// Token: 0x04004C97 RID: 19607
		[Token(Token = "0x4004C97")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string ERR_TIME_OUT;

		// Token: 0x04004C98 RID: 19608
		[Token(Token = "0x4004C98")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string ERR_READ_FAILED;

		// Token: 0x04004C99 RID: 19609
		[Token(Token = "0x4004C99")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string ERR_UNZIP_FAILED;

		// Token: 0x04004C9A RID: 19610
		[Token(Token = "0x4004C9A")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string ERR_INSUFFICIENT_STORAGE;

		// Token: 0x04004C9B RID: 19611
		[Token(Token = "0x4004C9B")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string ERR_MULTIDOWNLOAD_NOTEMPFILECONFIG;

		// Token: 0x04004C9C RID: 19612
		[Token(Token = "0x4004C9C")]
		[FieldOffset(Offset = "0x38")]
		private static readonly Dictionary<string, ResErrorCode> ErrorMapping;

		// Token: 0x04004C9D RID: 19613
		[Token(Token = "0x4004C9D")]
		[FieldOffset(Offset = "0x10")]
		public string FullPath;

		// Token: 0x04004C9E RID: 19614
		[Token(Token = "0x4004C9E")]
		[FieldOffset(Offset = "0x18")]
		public string RelativePath;

		// Token: 0x04004C9F RID: 19615
		[Token(Token = "0x4004C9F")]
		[FieldOffset(Offset = "0x20")]
		public int RetryCount;

		// Token: 0x04004CA0 RID: 19616
		[Token(Token = "0x4004CA0")]
		[FieldOffset(Offset = "0x28")]
		public long TotalSize;

		// Token: 0x04004CA1 RID: 19617
		[Token(Token = "0x4004CA1")]
		[FieldOffset(Offset = "0x30")]
		public string RequestError;

		// Token: 0x04004CA2 RID: 19618
		[Token(Token = "0x4004CA2")]
		[FieldOffset(Offset = "0x38")]
		public ResVersionInfo.FileInfo FileInfo;

		// Token: 0x04004CA3 RID: 19619
		[Token(Token = "0x4004CA3")]
		[FieldOffset(Offset = "0x40")]
		protected float m_LastProgress;
	}
}
