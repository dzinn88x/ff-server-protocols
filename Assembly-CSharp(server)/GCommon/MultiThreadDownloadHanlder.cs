using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace GCommon
{
	// Token: 0x02000FD0 RID: 4048
	[Token(Token = "0x2000FD0")]
	public class MultiThreadDownloadHanlder : DownloadHandlerScript
	{
		// Token: 0x06003B53 RID: 15187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B53")]
		[Address(RVA = "0x245D5CC", Offset = "0x245D5CC", VA = "0x7BBCC5D5CC")]
		public MultiThreadDownloadHanlder(Action<byte[], uint, int> complete_callback, int download_type, uint index, bool should_reusememorydata, long cell_size)
		{
		}

		// Token: 0x06003B54 RID: 15188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B54")]
		[Address(RVA = "0x245D770", Offset = "0x245D770", VA = "0x7BBCC5D770")]
		private MemoryStream GetMemoryData()
		{
			return null;
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B55")]
		[Address(RVA = "0x245D78C", Offset = "0x245D78C", VA = "0x7BBCC5D78C")]
		private void ClearMemoryData()
		{
		}

		// Token: 0x06003B56 RID: 15190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B56")]
		[Address(RVA = "0x245D7D8", Offset = "0x245D7D8", VA = "0x7BBCC5D7D8", Slot = "5")]
		protected override byte[] GetData()
		{
			return null;
		}

		// Token: 0x06003B57 RID: 15191 RVA: 0x000127E0 File Offset: 0x000109E0
		[Token(Token = "0x6003B57")]
		[Address(RVA = "0x245D824", Offset = "0x245D824", VA = "0x7BBCC5D824", Slot = "7")]
		protected override bool ReceiveData(byte[] remote_data, int dataLength)
		{
			return default(bool);
		}

		// Token: 0x06003B58 RID: 15192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B58")]
		[Address(RVA = "0x245D954", Offset = "0x245D954", VA = "0x7BBCC5D954", Slot = "8")]
		protected override void CompleteContent()
		{
		}

		// Token: 0x04004CC7 RID: 19655
		[Token(Token = "0x4004CC7")]
		[FieldOffset(Offset = "0x18")]
		private Action<byte[], uint, int> m_OnComplete;

		// Token: 0x04004CC8 RID: 19656
		[Token(Token = "0x4004CC8")]
		[FieldOffset(Offset = "0x20")]
		public uint DataIndex;

		// Token: 0x04004CC9 RID: 19657
		[Token(Token = "0x4004CC9")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, MemoryStream> REUSED_MEM_MAP;

		// Token: 0x04004CCA RID: 19658
		[Token(Token = "0x4004CCA")]
		[FieldOffset(Offset = "0x28")]
		private MemoryStream reused_download_data;

		// Token: 0x04004CCB RID: 19659
		[Token(Token = "0x4004CCB")]
		[FieldOffset(Offset = "0x30")]
		private MemoryStream download_data;

		// Token: 0x04004CCC RID: 19660
		[Token(Token = "0x4004CCC")]
		[FieldOffset(Offset = "0x38")]
		private int download_size;

		// Token: 0x04004CCD RID: 19661
		[Token(Token = "0x4004CCD")]
		[FieldOffset(Offset = "0x3C")]
		private bool should_reused_mem;

		// Token: 0x04004CCE RID: 19662
		[Token(Token = "0x4004CCE")]
		[FieldOffset(Offset = "0x40")]
		private long m_CellSize;
	}
}
