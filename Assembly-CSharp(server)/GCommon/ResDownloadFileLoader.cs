using System;
using System.IO;
using System.Security.Cryptography;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace GCommon
{
	// Token: 0x02000FCD RID: 4045
	[Token(Token = "0x2000FCD")]
	public class ResDownloadFileLoader : ResWithTempFileLoader
	{
		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06003B2F RID: 15151 RVA: 0x000126D8 File Offset: 0x000108D8
		[Token(Token = "0x170006F6")]
		public override long CELL_SIZE
		{
			[Token(Token = "0x6003B2F")]
			[Address(RVA = "0x29607B0", Offset = "0x29607B0", VA = "0x7BBD1607B0", Slot = "14")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06003B30 RID: 15152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B30")]
		[Address(RVA = "0x29607B8", Offset = "0x29607B8", VA = "0x7BBD1607B8", Slot = "7")]
		protected override void OnStart(float time)
		{
		}

		// Token: 0x06003B31 RID: 15153 RVA: 0x000126F0 File Offset: 0x000108F0
		[Token(Token = "0x6003B31")]
		[Address(RVA = "0x2960C34", Offset = "0x2960C34", VA = "0x7BBD160C34", Slot = "10")]
		public override bool HasStarted()
		{
			return default(bool);
		}

		// Token: 0x06003B32 RID: 15154 RVA: 0x00012708 File Offset: 0x00010908
		[Token(Token = "0x6003B32")]
		[Address(RVA = "0x2960C54", Offset = "0x2960C54", VA = "0x7BBD160C54", Slot = "6")]
		public override bool IsFinished()
		{
			return default(bool);
		}

		// Token: 0x06003B33 RID: 15155 RVA: 0x00012720 File Offset: 0x00010920
		[Token(Token = "0x6003B33")]
		[Address(RVA = "0x2960C68", Offset = "0x2960C68", VA = "0x7BBD160C68", Slot = "4")]
		public override long GetDownloadingSize()
		{
			return 0L;
		}

		// Token: 0x06003B34 RID: 15156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B34")]
		[Address(RVA = "0x2960C70", Offset = "0x2960C70", VA = "0x7BBD160C70", Slot = "8")]
		protected override void OnDispose()
		{
		}

		// Token: 0x06003B35 RID: 15157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B35")]
		[Address(RVA = "0x2960D00", Offset = "0x2960D00", VA = "0x7BBD160D00", Slot = "9")]
		protected override void OnNotify()
		{
		}

		// Token: 0x06003B36 RID: 15158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B36")]
		[Address(RVA = "0x2960F04", Offset = "0x2960F04", VA = "0x7BBD160F04", Slot = "11")]
		protected override void OnUpdate(float time)
		{
		}

		// Token: 0x06003B37 RID: 15159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B37")]
		[Address(RVA = "0x2960B4C", Offset = "0x2960B4C", VA = "0x7BBD160B4C")]
		private void GetFileByReq()
		{
		}

		// Token: 0x06003B38 RID: 15160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B38")]
		[Address(RVA = "0x29618CC", Offset = "0x29618CC", VA = "0x7BBD1618CC", Slot = "15")]
		protected virtual void ClearFileStream()
		{
		}

		// Token: 0x06003B39 RID: 15161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B39")]
		[Address(RVA = "0x2960CCC", Offset = "0x2960CCC", VA = "0x7BBD160CCC")]
		protected void ClearHashWorker()
		{
		}

		// Token: 0x06003B3A RID: 15162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3A")]
		[Address(RVA = "0x29619D8", Offset = "0x29619D8", VA = "0x7BBD1619D8", Slot = "16")]
		protected virtual void CollectDataAndClearFileStream()
		{
		}

		// Token: 0x06003B3B RID: 15163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3B")]
		[Address(RVA = "0x2961D8C", Offset = "0x2961D8C", VA = "0x7BBD161D8C", Slot = "12")]
		public override void OnPause()
		{
		}

		// Token: 0x06003B3C RID: 15164 RVA: 0x00012738 File Offset: 0x00010938
		[Token(Token = "0x6003B3C")]
		[Address(RVA = "0x2961DE4", Offset = "0x2961DE4", VA = "0x7BBD161DE4", Slot = "13")]
		public override long NeedDownloadSize()
		{
			return 0L;
		}

		// Token: 0x06003B3D RID: 15165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B3D")]
		[Address(RVA = "0x2961DEC", Offset = "0x2961DEC", VA = "0x7BBD161DEC")]
		public ResDownloadFileLoader()
		{
		}

		// Token: 0x04004CAD RID: 19629
		[Token(Token = "0x4004CAD")]
		[FieldOffset(Offset = "0x68")]
		public UnityWebRequest HttpReq;

		// Token: 0x04004CAE RID: 19630
		[Token(Token = "0x4004CAE")]
		[FieldOffset(Offset = "0x70")]
		public ResDownloadType DownloadType;

		// Token: 0x04004CAF RID: 19631
		[Token(Token = "0x4004CAF")]
		[FieldOffset(Offset = "0x78")]
		public Action<UnityWebRequest, ResWithTempFileLoader> OnLoaded;

		// Token: 0x04004CB0 RID: 19632
		[Token(Token = "0x4004CB0")]
		[FieldOffset(Offset = "0x80")]
		private long m_DataIndex;

		// Token: 0x04004CB1 RID: 19633
		[Token(Token = "0x4004CB1")]
		[FieldOffset(Offset = "0x88")]
		protected FileStream m_TempFileStream;

		// Token: 0x04004CB2 RID: 19634
		[Token(Token = "0x4004CB2")]
		[FieldOffset(Offset = "0x90")]
		protected long m_TempFileLength;

		// Token: 0x04004CB3 RID: 19635
		[Token(Token = "0x4004CB3")]
		[FieldOffset(Offset = "0x98")]
		protected SHA1CryptoServiceProvider m_HashWorker;

		// Token: 0x04004CB4 RID: 19636
		[Token(Token = "0x4004CB4")]
		[FieldOffset(Offset = "0xA0")]
		protected byte[] m_HashBuffer;

		// Token: 0x04004CB5 RID: 19637
		[Token(Token = "0x4004CB5")]
		[FieldOffset(Offset = "0xA8")]
		protected bool m_NeedHashTemp;

		// Token: 0x04004CB6 RID: 19638
		[Token(Token = "0x4004CB6")]
		protected const int GETDATA_TIKECOUNT = 5;

		// Token: 0x04004CB7 RID: 19639
		[Token(Token = "0x4004CB7")]
		[FieldOffset(Offset = "0xAC")]
		private int m_curTick;
	}
}
