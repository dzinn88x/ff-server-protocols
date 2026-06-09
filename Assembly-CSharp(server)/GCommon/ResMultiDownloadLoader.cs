using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace GCommon
{
	// Token: 0x02000FD1 RID: 4049
	[Token(Token = "0x2000FD1")]
	public class ResMultiDownloadLoader : ResWithTempFileLoader
	{
		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06003B5A RID: 15194 RVA: 0x000127F8 File Offset: 0x000109F8
		[Token(Token = "0x170006F7")]
		public override long CELL_SIZE
		{
			[Token(Token = "0x6003B5A")]
			[Address(RVA = "0x297017C", Offset = "0x297017C", VA = "0x7BBD17017C", Slot = "14")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B5B")]
		[Address(RVA = "0x2967338", Offset = "0x2967338", VA = "0x7BBD167338")]
		public ResMultiDownloadLoader(int mex_req_count, bool should_reuse_mem = false, bool should_override_with_full = false, int gc_index = 0)
		{
		}

		// Token: 0x06003B5C RID: 15196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B5C")]
		[Address(RVA = "0x2970184", Offset = "0x2970184", VA = "0x7BBD170184", Slot = "7")]
		protected override void OnStart(float time)
		{
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B5D")]
		[Address(RVA = "0x2970A78", Offset = "0x2970A78", VA = "0x7BBD170A78")]
		private void GetFileWithIndex(float time, uint cell_index)
		{
		}

		// Token: 0x06003B5E RID: 15198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B5E")]
		[Address(RVA = "0x2970F08", Offset = "0x2970F08", VA = "0x7BBD170F08")]
		private void PrepareHashAndTempIndex()
		{
		}

		// Token: 0x06003B5F RID: 15199 RVA: 0x00012810 File Offset: 0x00010A10
		[Token(Token = "0x6003B5F")]
		[Address(RVA = "0x29710F8", Offset = "0x29710F8", VA = "0x7BBD1710F8", Slot = "10")]
		public override bool HasStarted()
		{
			return default(bool);
		}

		// Token: 0x06003B60 RID: 15200 RVA: 0x00012828 File Offset: 0x00010A28
		[Token(Token = "0x6003B60")]
		[Address(RVA = "0x2971100", Offset = "0x2971100", VA = "0x7BBD171100", Slot = "6")]
		public override bool IsFinished()
		{
			return default(bool);
		}

		// Token: 0x06003B61 RID: 15201 RVA: 0x00012840 File Offset: 0x00010A40
		[Token(Token = "0x6003B61")]
		[Address(RVA = "0x2971128", Offset = "0x2971128", VA = "0x7BBD171128", Slot = "4")]
		public override long GetDownloadingSize()
		{
			return 0L;
		}

		// Token: 0x06003B62 RID: 15202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B62")]
		[Address(RVA = "0x2971134", Offset = "0x2971134", VA = "0x7BBD171134", Slot = "8")]
		protected override void OnDispose()
		{
		}

		// Token: 0x06003B63 RID: 15203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B63")]
		[Address(RVA = "0x2971694", Offset = "0x2971694", VA = "0x7BBD171694", Slot = "11")]
		protected override void OnUpdate(float time)
		{
		}

		// Token: 0x06003B64 RID: 15204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B64")]
		[Address(RVA = "0x29720CC", Offset = "0x29720CC", VA = "0x7BBD1720CC")]
		private void SaveFlagFile()
		{
		}

		// Token: 0x06003B65 RID: 15205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B65")]
		[Address(RVA = "0x2972184", Offset = "0x2972184", VA = "0x7BBD172184")]
		private void OnRequestComplete(byte[] buffer, uint index, int download_size)
		{
		}

		// Token: 0x06003B66 RID: 15206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B66")]
		[Address(RVA = "0x2972AB4", Offset = "0x2972AB4", VA = "0x7BBD172AB4")]
		protected void CollectDataAndClearFileStream()
		{
		}

		// Token: 0x06003B67 RID: 15207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B67")]
		[Address(RVA = "0x2971448", Offset = "0x2971448", VA = "0x7BBD171448")]
		protected void ClearFileStream()
		{
		}

		// Token: 0x06003B68 RID: 15208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B68")]
		[Address(RVA = "0x2971660", Offset = "0x2971660", VA = "0x7BBD171660")]
		protected void ClearHashWorker()
		{
		}

		// Token: 0x06003B69 RID: 15209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B69")]
		[Address(RVA = "0x2972D30", Offset = "0x2972D30", VA = "0x7BBD172D30")]
		protected void ClearFlagFile()
		{
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B6A")]
		[Address(RVA = "0x2972E5C", Offset = "0x2972E5C", VA = "0x7BBD172E5C", Slot = "9")]
		protected override void OnNotify()
		{
		}

		// Token: 0x06003B6B RID: 15211 RVA: 0x00012858 File Offset: 0x00010A58
		[Token(Token = "0x6003B6B")]
		[Address(RVA = "0x2972F24", Offset = "0x2972F24", VA = "0x7BBD172F24", Slot = "13")]
		public override long NeedDownloadSize()
		{
			return 0L;
		}

		// Token: 0x06003B6C RID: 15212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B6C")]
		[Address(RVA = "0x2972F2C", Offset = "0x2972F2C", VA = "0x7BBD172F2C", Slot = "12")]
		public override void OnPause()
		{
		}

		// Token: 0x04004CCF RID: 19663
		[Token(Token = "0x4004CCF")]
		[FieldOffset(Offset = "0x68")]
		public ResDownloadType DownloadType;

		// Token: 0x04004CD0 RID: 19664
		[Token(Token = "0x4004CD0")]
		[FieldOffset(Offset = "0x70")]
		public Action<UnityWebRequest, ResWithTempFileLoader> OnLoaded;

		// Token: 0x04004CD1 RID: 19665
		[Token(Token = "0x4004CD1")]
		[FieldOffset(Offset = "0x78")]
		public bool NeedInitFileLength;

		// Token: 0x04004CD2 RID: 19666
		[Token(Token = "0x4004CD2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string ERR_CELL_DOWNLOAD_FAILED;

		// Token: 0x04004CD3 RID: 19667
		[Token(Token = "0x4004CD3")]
		[FieldOffset(Offset = "0x80")]
		protected FileStream m_TempFileStream;

		// Token: 0x04004CD4 RID: 19668
		[Token(Token = "0x4004CD4")]
		[FieldOffset(Offset = "0x88")]
		protected long m_TempFileLength;

		// Token: 0x04004CD5 RID: 19669
		[Token(Token = "0x4004CD5")]
		[FieldOffset(Offset = "0x90")]
		protected long m_DownloadingSize;

		// Token: 0x04004CD6 RID: 19670
		[Token(Token = "0x4004CD6")]
		[FieldOffset(Offset = "0x98")]
		protected long m_LastDownloadedSize;

		// Token: 0x04004CD7 RID: 19671
		[Token(Token = "0x4004CD7")]
		[FieldOffset(Offset = "0xA0")]
		protected SHA1CryptoServiceProvider m_HashWorker;

		// Token: 0x04004CD8 RID: 19672
		[Token(Token = "0x4004CD8")]
		[FieldOffset(Offset = "0xA8")]
		protected byte[] m_HashBuffer;

		// Token: 0x04004CD9 RID: 19673
		[Token(Token = "0x4004CD9")]
		[FieldOffset(Offset = "0xB0")]
		protected bool m_NeedHashTemp;

		// Token: 0x04004CDA RID: 19674
		[Token(Token = "0x4004CDA")]
		[FieldOffset(Offset = "0xB8")]
		private FileStream m_FlagStream;

		// Token: 0x04004CDB RID: 19675
		[Token(Token = "0x4004CDB")]
		[FieldOffset(Offset = "0xC0")]
		private BitArrayRich m_TempFlag;

		// Token: 0x04004CDC RID: 19676
		[Token(Token = "0x4004CDC")]
		[FieldOffset(Offset = "0xC8")]
		private BitArrayRich m_RunningFlag;

		// Token: 0x04004CDD RID: 19677
		[Token(Token = "0x4004CDD")]
		[FieldOffset(Offset = "0xD0")]
		private int m_MaxReqCount;

		// Token: 0x04004CDE RID: 19678
		[Token(Token = "0x4004CDE")]
		[FieldOffset(Offset = "0xD4")]
		private uint m_CellCount;

		// Token: 0x04004CDF RID: 19679
		[Token(Token = "0x4004CDF")]
		[FieldOffset(Offset = "0xD8")]
		private int m_CellDownloadRetryCount;

		// Token: 0x04004CE0 RID: 19680
		[Token(Token = "0x4004CE0")]
		[FieldOffset(Offset = "0xE0")]
		private List<UnityWebRequest> m_RunningReq;

		// Token: 0x04004CE1 RID: 19681
		[Token(Token = "0x4004CE1")]
		[FieldOffset(Offset = "0xE8")]
		private List<UnityWebRequest> m_FinishedReq;

		// Token: 0x04004CE2 RID: 19682
		[Token(Token = "0x4004CE2")]
		[FieldOffset(Offset = "0xF0")]
		private uint m_NextDownloadIndex;

		// Token: 0x04004CE3 RID: 19683
		[Token(Token = "0x4004CE3")]
		[FieldOffset(Offset = "0xF4")]
		private bool m_Started;

		// Token: 0x04004CE4 RID: 19684
		[Token(Token = "0x4004CE4")]
		private const float REQ_TIMEOUT_SECOUNDS = 60f;

		// Token: 0x04004CE5 RID: 19685
		[Token(Token = "0x4004CE5")]
		private const float TIMEOUT_SECOUNDS = 90f;

		// Token: 0x04004CE6 RID: 19686
		[Token(Token = "0x4004CE6")]
		[FieldOffset(Offset = "0xF8")]
		private float m_GCIndex;

		// Token: 0x04004CE7 RID: 19687
		[Token(Token = "0x4004CE7")]
		[FieldOffset(Offset = "0x8")]
		public static int Loader_Count;

		// Token: 0x04004CE8 RID: 19688
		[Token(Token = "0x4004CE8")]
		[FieldOffset(Offset = "0xFC")]
		private bool m_ShouldReuseMemory;

		// Token: 0x04004CE9 RID: 19689
		[Token(Token = "0x4004CE9")]
		[FieldOffset(Offset = "0xFD")]
		private bool m_ShouldOverrideWithFull;
	}
}
